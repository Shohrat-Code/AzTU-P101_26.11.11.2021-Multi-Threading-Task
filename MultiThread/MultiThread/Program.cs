using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThread
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread secondThread = new Thread(Loop);
            //Thread secondThread = new Thread(new ThreadStart(Loop));
            //secondThread.Start();
            //secondThread.IsBackground = true;
            //secondThread.Join();

            //Foreground Thread
            //Background Thread
            //Thread pool

            Task task = new Task(Loop);
            task.Start();

            Task task2 = new Task(Test);
            task2.Start();

            task.Wait();
            task2.Wait();
            //async-await

            Console.WriteLine("Main thread started");
        }

        static void Loop()
        {
            Console.WriteLine("Second thread started");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Second thread finished");
        }

        static void Test()
        {
            Console.WriteLine("Third thread started");
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
            //Console.WriteLine(sum);
            Console.WriteLine("Third thread finished");
        }
    }
}
