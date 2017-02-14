using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAPSTaskExecutor
{
    class TaskExecutorTest
    {
        public static void Main(String[] args)
        {
            TaskExecutor te = TaskExecutor.NewTask("C:\\tmp\\echoadsfsadfsadf.bat", new[] {"hello,", "Greg! ", "This", "is", "a", "test"});
            bool foo;
            Console.WriteLine(te.Execute(out foo));
            Console.ReadKey();
        }
    }
}
