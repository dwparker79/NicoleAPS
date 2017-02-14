using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NAPSTaskManager
{
    using NAPSTaskExecutor;

    #region Task Scheduler

    public enum ScheduleType
    {
        Daily,
        Weekly,
        Biweekly,
        Monthly
    }

    public enum ScheduleStatus
    {
        Waiting,
        Running,
        Error
    }

    public class TaskSchedule
    {
        public TaskExecutor Task { get; private set; }
        public string LogPath { get; private set; }
        public ScheduleType SType { get; set; }
        public ScheduleStatus SStatus { get; protected set; }
        public string StatusMessage { get; protected set; }
        private TimeSpan LAST_TIME
        {
            get
            {
                switch (SType)
                {
                    case ScheduleType.Daily:
                        return new TimeSpan(1, 0, 0, 0);
                    case ScheduleType.Weekly:
                        return new TimeSpan(7, 0, 0, 0);
                    case ScheduleType.Biweekly:
                        return new TimeSpan(14, 0, 0, 0);
                    case ScheduleType.Monthly:
                    default:
                        return new TimeSpan(DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month), 0, 0, 0);
                }
            }
        }

        public List<TimeSpan> Times { get; private set; }
        protected DateTime LastExecuted;
        private int currentCheckIndex;
        private TimeSpan lastCheckedTime;
        private DateTime currentCycleStart;

        public TaskSchedule(TaskExecutor task, string log, ScheduleType type)
            : this(task, log, type, DateTime.Now)
        { }

        public TaskSchedule(TaskExecutor task, string log, ScheduleType type, DateTime cycleStart)
        {
            this.Task = task;
            this.LogPath = log;
            this.SType = type;


            LastExecuted = DateTime.MinValue;
            currentCheckIndex = 0;
            currentCycleStart = cycleStart;
            lastCheckedTime = DateTime.Now - currentCycleStart;

            Times = new List<TimeSpan>();
            SStatus = File.Exists(Task.TaskPath) ? ScheduleStatus.Waiting : ScheduleStatus.Error;
            UpdateStatusMessage();
        }

        private void UpdateStatusMessage(string errMessage = "")
        {
            StatusMessage = File.Exists(Task.TaskPath) ? "" : "WARNING: File path does not exist.\r\n";
            if (errMessage.Length > 0)
                StatusMessage += errMessage;
            else
            {
                string prevRun = "Last run: ";
                if (LastExecuted > DateTime.MinValue)
                    prevRun += LastExecuted.ToString("f");
                else
                    prevRun += "never.";

                StatusMessage += prevRun;
            }
            StatusMessage += "\r\nNext run time: ";

            if (Times.Count == 0)
                StatusMessage += "never.";
            else
            {
                if (currentCheckIndex >= Times.Count)
                    StatusMessage += (currentCycleStart + LAST_TIME + Times[0]).ToString("f");
                else
                    StatusMessage += (currentCycleStart + Times[currentCheckIndex]).ToString("f");
            }
        }

        public void AddTime(TimeSpan item)
        {
            int index = 0;
            while (index < Times.Count && Times[index] < item)
                index++;
            Times.Insert(index, item);
            if (item < lastCheckedTime)
                currentCheckIndex = index + 1;

            UpdateStatusMessage();
        }

        public bool RemoveTime(TimeSpan item)
        {
            bool retval = false;
            for (int i = 0; i < Times.Count && Times[i] <= item; i++)
            {
                if (Times[i] == item)
                {
                    Times.RemoveAt(i);
                    retval = false;
                    break; // technically unnecessary, since duplicate entries won't happen, but good practice.
                }
            }

            UpdateStatusMessage();
            return retval;
        }

        public void ClearTimes()
        {
            Times.Clear();
            UpdateStatusMessage();
        }

        private static byte[] Convert(char[] arr)
        {
            byte[] retval = new byte[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                retval[i] = (byte)arr[i];
            return retval;
        }
        public bool GetExecutionThread(out Thread exe)
        {
            exe = null;
            if (Times.Count > 0)
            {
                bool retval = false;
                lastCheckedTime = DateTime.Now - currentCycleStart;
                
                // if we're at the end of the cycles, start it over and check again
                if (lastCheckedTime >= LAST_TIME)
                {
                    currentCheckIndex = 0;
                    currentCycleStart += LAST_TIME;
                    lastCheckedTime = DateTime.Now - currentCycleStart;
                }
                if (currentCheckIndex < Times.Count && lastCheckedTime > Times[currentCheckIndex])
                {
                    exe = new Thread(() =>
                    {
                        SStatus = ScheduleStatus.Running;
                        StatusMessage = "Currently executing task...";
                        string newLog = "";
                        FileStream fs = null;
                        try
                        {
                            bool wasSuccessful;
                            newLog = Task.Execute(out wasSuccessful);
                            fs = new FileStream(LogPath, FileMode.Create);
                            fs.Write(Convert(newLog.ToCharArray()), 0, newLog.Length);

                            if (!wasSuccessful)
                                throw new Exception("An error occurred during execution.  Check the log file for details.");
                        }
                        catch (Exception e) 
                        {
                            SStatus = ScheduleStatus.Error;
                            UpdateStatusMessage(e.Message);
                        }
                        finally
                        {
                            if (fs != null)
                                fs.Close();
                            if (SStatus == ScheduleStatus.Running)
                            {
                                SStatus = ScheduleStatus.Waiting;
                                UpdateStatusMessage();
                            }
                        }
                    });
                    exe.Name = Task.TaskPath + "|" + LogPath + "|Y";
                    exe.Start();
                    retval = true;
                    while (currentCheckIndex < Times.Count && lastCheckedTime > Times[currentCheckIndex])
                        currentCheckIndex++;
                    LastExecuted = DateTime.Now;
                }

                return retval;
            }
            else
            {
                return false;
            }
        }
    }

    #endregion

    public struct ThreadTableInfo
    {
        private string location;
        private string log;
        private string startTime;
        private bool wasScheduled;

        public string Location
        {
            get
            {
                return location;
            }
        }
        public string Log
        {
            get
            {
                return log;
            }
        }
        public string StartTime
        {
            get
            {
                return startTime;
            }
        }
        public string WasScheduled
        {
            get
            {
                if (wasScheduled)
                    return "Yes";
                else
                    return "No";
            }
        }

        public ThreadTableInfo(string loc, string log, string start, bool scheduled)
        {
            location = "";
            this.log = "";
            startTime = "";
            wasScheduled = scheduled;
        }

        public string[] TableInfo
        {
            get
            {
                return new[] { location, log, startTime, WasScheduled };
            }
        }
    }

    public class TaskManager
    {
        private static bool isErrorPathValid;
        public static string ErrorPath { get; protected set; }

        static TaskManager()
        {
            SetErrorPath(AppDomain.CurrentDomain.BaseDirectory + "\\err\\NAPS_Error_log.log");
        }

        public static bool SetErrorPath(string path)
        {
            if (!File.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                    File.Create(path);
                }
                catch (Exception)
                {
                    return isErrorPathValid = false;
                }
            }

            ErrorPath = path;
            return isErrorPathValid = true;
        }

        private Timer scheduleTimer;

        //private const int MAX_TASKS = 5;
        public List<TaskSchedule> CurrentSchedules { get; private set; }
        private List<Thread> CurrentThreads;
        private List<DateTime> CurrentStartTimes;
        /*
        private Queue<uint> NextTaskIDs;
        private Queue<Action<TaskExecutor, string>> NextTasks;
        private Queue<KeyValuePair<TaskExecutor, string>> NextExecutors;
        */

        public bool CurrentlyWorking
        {
            get
            {
                return CurrentThreads.Any(t => t.IsAlive);
            }
        }

        public List<ThreadTableInfo> CurrentThreadInfo
        {
            get
            {
                CleanupTasks();
                List<ThreadTableInfo> retval = new List<ThreadTableInfo>();
                lock (CurrentThreads)
                lock (CurrentStartTimes)
                {
                    for (int i = 0; i < CurrentThreads.Count; i++)
                    {
                        string[] str = CurrentThreads[i].Name.Split('|');
                        retval.Add(new ThreadTableInfo(str[0], str[1], CurrentStartTimes[i].ToString("yyyy/MM/dd hh:mm tt"), str[2] == "Y"));
                    }
                }
                return retval;
            }
        }
        public List<TaskSchedule> CurrentScheduleInfo
        {
            get
            {
                List<TaskSchedule> retval = new List<TaskSchedule>();
                foreach (TaskSchedule ts in CurrentSchedules)
                    retval.Add(ts);
                return retval;
            }
        }

        public List<string> CurrentThreadNames
        {
            get
            {
                CleanupTasks();
                List<string> retval = new List<string>();
                lock (CurrentThreads)
                {
                    foreach (Thread t in CurrentThreads)
                    {
                        retval.Add(t.Name.Split('|')[0]);
                    }
                }
                return retval;
            }
        }
        public List<string> CurrentThreadLogs
        {
            get
            {
                CleanupTasks();
                List<string> retval = new List<string>();
                lock (CurrentThreads)
                {
                    foreach (Thread t in CurrentThreads)
                    {
                        retval.Add(t.Name.Split('|')[1]);
                    }
                }
                return retval;
            }
        }
        public List<DateTime> CurrentThreadStartTimes
        {
            get
            {
                CleanupTasks();
                return CurrentStartTimes;
            }
        }
        public TaskManager()
        {
            CurrentThreads = new List<Thread>();
            CurrentStartTimes = new List<DateTime>();
            CurrentSchedules = new List<TaskSchedule>();

            DateTime timerDelay = DateTime.Now.AddMinutes(1);
            timerDelay = timerDelay.AddSeconds(-timerDelay.Second)
                .AddMilliseconds(-timerDelay.Millisecond);
            scheduleTimer = new Timer(new TimerCallback(ScheduleTimer_Callback), null,
                timerDelay - DateTime.Now, new TimeSpan(0, 1, 0));
        }

        private void ScheduleTimer_Callback(Object state)
        {
            foreach (TaskSchedule ts in CurrentSchedules)
            {
                Thread maybeAdd;
                if (ts.GetExecutionThread(out maybeAdd))
                {
                    CurrentStartTimes.Add(DateTime.Now);
                    CurrentThreads.Add(maybeAdd);
                }
            }
        }

        private static byte[] Convert(char[] arr)
        {
            byte[] retval = new byte[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                retval[i] = (byte)arr[i];
            return retval;
        }

        private void CleanupTasks()
        {
            for (int i = 0; i < CurrentThreads.Count; i++)
            {
                if (CurrentThreads[i].ThreadState == ThreadState.Aborted ||
                    CurrentThreads[i].ThreadState == ThreadState.Stopped)
                {
                    CurrentThreads.RemoveAt(i);
                    CurrentStartTimes.RemoveAt(i);
                    i--;
                }
            }
        }

        public void AddTask(string taskPath, string taskExtension, string logPath, params string[] taskParameters)
        {
            // upon adding a new task, we should see if any other tasks have finished.
            CleanupTasks();
            
            Thread newThr = new Thread(() =>
            {
                FileStream logWriter = null;
                try
                {
                    //Console.WriteLine(logPath + " starting.");
                    string log = "Error: could not interpret file extension " + taskExtension;
                    bool wasSuccessful = true;
                    switch (taskExtension)
                    {
                        case ".bat":
                            log = (TaskExecutor.NewTask(taskPath, taskParameters)).Execute(out wasSuccessful);
                            break;
                        case ".ps1":
                            log = (PowershellTaskExecutor.NewTask(taskPath, taskParameters)).Execute(out wasSuccessful);
                            break;
                    }
                    //Console.WriteLine(logPath + "'s contents: " + log);
                    logWriter = new FileStream(logPath, FileMode.Create, FileAccess.Write, FileShare.None);
                    logWriter.Write(Convert(log.ToCharArray()), 0, log.Length);

                    if (!wasSuccessful)
                        throw new Exception("An error occurred during execution.  Check the log file for details.");
                }
                catch (Exception e)
                {
                    if (isErrorPathValid)
                    {
                        string errMessage = DateTime.Now.ToString("@yyyy-MM-dd hh:mm") + " Error executing task " + taskPath + taskExtension + ": " + e.Message;
                        logWriter = new FileStream(ErrorPath, FileMode.Append);
                        logWriter.Write(Convert(errMessage.ToCharArray()), 0, errMessage.Length);
                    }
                }
                finally
                {
                    if (logWriter != null)
                        logWriter.Close();
                }
            });
            newThr.Name = taskPath + taskExtension + "|" + logPath + "|N";
            CurrentThreads.Add(newThr);
            CurrentStartTimes.Add(DateTime.Now);
            newThr.Start();
        }

        public void AddSchedule(TaskExecutor executor, string logPath, ScheduleType type, params TimeSpan[] times)
        {
            DateTime schedStart = DateTime.Now.Date;
            switch (type)
            {
                case ScheduleType.Monthly:
                    schedStart = schedStart.AddDays(1 - schedStart.Day);
                    break;
                case ScheduleType.Biweekly:
                case ScheduleType.Weekly:
                    switch (schedStart.DayOfWeek)
                    {
                        case DayOfWeek.Sunday:
                            schedStart = schedStart.AddDays(-6);
                            break;
                        case DayOfWeek.Saturday:
                            schedStart = schedStart.AddDays(-5);
                            break;
                        case DayOfWeek.Friday:
                            schedStart = schedStart.AddDays(-4);
                            break;
                        case DayOfWeek.Thursday:
                            schedStart = schedStart.AddDays(-3);
                            break;
                        case DayOfWeek.Wednesday:
                            schedStart = schedStart.AddDays(-2);
                            break;
                        case DayOfWeek.Tuesday:
                            schedStart = schedStart.AddDays(-1);
                            break;
                        case DayOfWeek.Monday:
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            TaskSchedule newSched = new TaskSchedule(executor, logPath, type, schedStart);
            foreach (TimeSpan ts in times)
            {
                newSched.AddTime(ts);
            }
            CurrentSchedules.Add(newSched);
        }

        public void KillAll()
        {
            lock(CurrentThreads)
            {
                foreach (Thread t in CurrentThreads)
                {
                    t.Abort();
                }
                CurrentThreads.Clear();
            }
        }

        ~TaskManager()
        {
            KillAll();
            scheduleTimer.Dispose();
        }
    }
}