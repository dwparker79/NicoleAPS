using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NAPSTaskExecutor
{
    using System.Management.Automation;

    internal class ThreadsafeStringBuilder
    {
        private List<char> str;

        public ThreadsafeStringBuilder()
        {
            str = new List<char>();
        }

        public void Clear()
        {
            str.Clear();
        }

        public void Append(string add)
        {
            if (add == null || add.Length == 0)
                return;

            foreach (char c in add)
                str.Add(c);
        }

        public override string ToString()
        {
            string retval = "";
            foreach (char c in str)
                retval += c;
            return retval;
        }
    }

    public class TaskExecutor
    {
        protected SecureString Password;
        protected string Username;

        public string TaskPath { get; private set; }
        public string[] TaskParameters { get; private set; }
        public int MaxTimeoutMillis { get; set; }
        protected TaskExecutor(string taskPath, string[] parameters, int maxTimeout = 60000) 
        {
            this.TaskPath = taskPath;
            this.TaskParameters = parameters;
            this.MaxTimeoutMillis = maxTimeout;
        }
        protected TaskExecutor(string taskPath, string[] parameters, string username, SecureString password, int maxTimeout = 60000)
        {
            this.TaskPath = taskPath;
            this.TaskParameters = parameters;
            this.MaxTimeoutMillis = maxTimeout;
            this.Username = username;
            this.Password = password;
            if (!this.Password.IsReadOnly())
                this.Password.MakeReadOnly();
        }

        public virtual string Execute(out bool successful)
        {
            ThreadsafeStringBuilder response = new ThreadsafeStringBuilder();
            Process prc = new Process();
            try
            {
                successful = true;
                DateTime outputChangedTime = DateTime.Now;
                if (TaskParameters.Length > 0)
                {
                    ThreadsafeStringBuilder prms = new ThreadsafeStringBuilder();
                    prms.Append(TaskParameters[0]);
                    for (int i = 1; i < TaskParameters.Length; i++)
                    {
                        prms.Append(" ");
                        prms.Append(TaskParameters[i]);
                    }
                    prc.StartInfo.Arguments = prms.ToString();
                }
                prc.StartInfo.FileName = TaskPath;
                prc.StartInfo.UseShellExecute = false;
                prc.StartInfo.RedirectStandardOutput = true;
                prc.StartInfo.CreateNoWindow = true;
                
                if (Username != null)
                {
                    prc.StartInfo.UserName = Username;
                    prc.StartInfo.Password = Password;
                }

                prc.Start();
                response.Append(prc.StandardOutput.ReadToEnd().Trim());
                prc.WaitForExit(MaxTimeoutMillis);
                if (!prc.HasExited)
                {
                    prc.Kill();
                    successful = false;
                    return "Process timed out.\r\n" + response.ToString();
                }
            }
            catch (Exception e)
            {
                successful = false;
                response.Clear();
                response.Append("An error occured during execution.\n");
                response.Append(e.GetType().ToString());
                response.Append(": ");
                response.Append(e.Message);
            }
            finally
            {
                prc.Close();
            }
            return response.ToString();
        }
        public static TaskExecutor NewTask(string taskPath, string[] parameters)
        {
            return new TaskExecutor(taskPath + ".bat", parameters);
        }
        public static TaskExecutor NewTask(string taskPath, int timeout, string[] parameters)
        {
            return new TaskExecutor(taskPath + ".bat", parameters, timeout);
        }
        public static TaskExecutor NewTask(string taskPath, string username, SecureString password, string[] parameters)
        {
            return new TaskExecutor(taskPath + ".bat", parameters, username, password);
        }
        public static TaskExecutor NewTask(string taskPath, int timeout, string username, SecureString password, string[] parameters)
        {
            return new TaskExecutor(taskPath + ".bat", parameters, username, password, timeout);
        }
    }

    public class PowershellTaskExecutor : TaskExecutor
    {
        public override string Execute(out bool successful)
        {
            ThreadsafeStringBuilder response = new ThreadsafeStringBuilder();
            Process prc = new Process();
            try
            {
                successful = true;
                DateTime outputChangedTime = DateTime.Now;

                ThreadsafeStringBuilder prms = new ThreadsafeStringBuilder();
                prms.Append("& \"");
                prms.Append(TaskPath);
                prms.Append("\"");
                if (TaskParameters.Length > 0)
                {
                    for (int i = 0; i < TaskParameters.Length; i++)
                    {
                        prms.Append(" \"");
                        prms.Append(TaskParameters[i]);
                        prms.Append("\"");
                    }
                }
                prc.StartInfo.Arguments = prms.ToString();

                prc.StartInfo.FileName = "powershell.exe";
                prc.StartInfo.UseShellExecute = false;
                prc.StartInfo.RedirectStandardOutput = true;
                prc.StartInfo.CreateNoWindow = true;

                if (Username != null)
                {
                    prc.StartInfo.UserName = Username;
                    prc.StartInfo.Password = Password;
                }

                prc.Start();
                prc.WaitForExit(MaxTimeoutMillis);
                response.Append(prc.StandardOutput.ReadToEnd().Trim());
                if (!prc.HasExited)
                {
                    prc.Kill();
                    successful = false;
                    return "Process timed out.\r\n" + response.ToString();
                }
            }
            catch (Exception e)
            {
                successful = false;
                response.Clear();
                response.Append("An error occured during execution.\n");
                response.Append(e.GetType().ToString());
                response.Append(": ");
                response.Append(e.Message);
            }
            finally
            {
                prc.Close();
            }
            return response.ToString();
        }

        protected PowershellTaskExecutor(string taskPath, string[] parameters, int timeout = 60000)
            : base(taskPath, parameters, timeout) { }
        protected PowershellTaskExecutor(string taskPath, string[] parameters, string username, SecureString password, int timeout = 60000)
            : base(taskPath, parameters, username, password, timeout) { }

        public new static PowershellTaskExecutor NewTask(string taskPath, string[] parameters)
        {
            return new PowershellTaskExecutor(taskPath + ".ps1", parameters);
        }
        public new static PowershellTaskExecutor NewTask(string taskPath, int timeout, string[] parameters)
        {
            return new PowershellTaskExecutor(taskPath + ".ps1", parameters, timeout);
        }
        public new static PowershellTaskExecutor NewTask(string taskPath, string username, SecureString password, string[] parameters)
        {
            return new PowershellTaskExecutor(taskPath + ".ps1", parameters, username, password);
        }
        public new static PowershellTaskExecutor NewTask(string taskPath, int timeout, string username, SecureString password, string[] parameters)
        {
            return new PowershellTaskExecutor(taskPath + ".ps1", parameters, username, password, timeout);
        }
    }
}