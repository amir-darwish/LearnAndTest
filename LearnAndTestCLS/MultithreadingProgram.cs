using LearnAndTestCLS.Multithreading;
using System;
using System.Threading;

namespace LearnAndTestCLS
{
    internal class MultithreadingProgram
    {

        public static void Main(string[] args)
        {

            //void Method(int num)
            //{
            //    for (int i = 0; i < num; i++)
            //    {
            //        Console.WriteLine("Method 1 : " + i);
            //        Thread.Sleep(400);
            //    }
            //}
            //// Create thread 
            //Thread t = new Thread(() => Method(20));
            //t.Start();
            //t.IsBackground = true;

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Main 1 : " + i);
            //    Thread.Sleep(400);

            //}

            Thread t1 = new Thread(() => clsDownload.WebPage("https://github.com/"));
            t1.Start();

            Thread t2 = new Thread(() => clsDownload.WebPage("https://www.booking.com/"));
            t2.Start();


            Thread t3 = new Thread(() => clsDownload.WebPage("https://www.welcometothejungle.com/"));
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("All site downloadedd with succes");


            Console.ReadKey();
        }
    }
}
