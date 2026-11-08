using System;
using System.Threading;

namespace LearnAndTestCLS
{
    internal class MultithreadingProgram
    {

        public static void Main(string[] args)
        {

            void Method(int num)
            {
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("Method 1 : " + i);
                    Thread.Sleep(400);
                }
            }
            // Create thread 
            Thread t = new Thread(() => Method(100));
            t.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main 1 : " + i);
                Thread.Sleep(400);

            }
        }
    }
}
