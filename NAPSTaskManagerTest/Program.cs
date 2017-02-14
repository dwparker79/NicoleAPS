using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NAPSTaskExecutor;
using NAPSTaskManager;

namespace NAPSTaskManagerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating tasks...");
            TaskManager tm = new TaskManager();
            for (int i = 0; i < 200; i += 5)
            {
                tm.AddTask("C:\\tmp\\echo.bat", "C:\\tmp\\echo\\echo" + i.ToString("000") + ".log", "oiasdjfoiajsdfoijasdf", "sdlkjf", "alsdkjf", "alskdjf");
                tm.AddTask("C:\\tmp\\echo.bat", "C:\\tmp\\echo\\echo" + (i + 1).ToString("000") + ".log", "Hello,", "world!");
                tm.AddTask("C:\\tmp\\echo.bat", "C:\\tmp\\echo\\echo" + (i + 2).ToString("000") + ".log", "oiasdjfoiajsdfoijasdf", "sdlkjf", "alsdkjf", "alskdjf");
                tm.AddTask("C:\\tmp\\echo.bat", "C:\\tmp\\echo\\echo" + (i + 3).ToString("000") + ".log", "w");
                tm.AddTask("C:\\tmp\\echo.bat", "C:\\tmp\\echo\\echo" + (i + 4).ToString("000") + ".log", "oiasdjfoiajsdfoijasdf", "sdlkjf", "alsdkjf", "alskdjf");
            }
            Console.WriteLine("Tasks Created.  Waiting for TaskManager to finish...");
            DateTime waitTime = DateTime.Now.AddSeconds(1);
            while (tm.CurrentlyWorking)
            {
                if (DateTime.Now > waitTime)
                {
                    waitTime = waitTime.AddSeconds(1);
                    Console.Write('.');
                }
            }
            Console.WriteLine(" done.");
            Console.WriteLine(File.Exists("C:\\tmp\\echo\\echo001.log"));
            Console.ReadKey();
        }
    }
}
