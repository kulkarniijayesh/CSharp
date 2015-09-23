using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace MultiThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //int count = 0;
            //Program pr = new Program();
            //ThreadStart TestThreadStart = new ThreadStart(pr.testThread1);
            //ThreadStart TestThreadStart2 = new ThreadStart(pr.testThread2);

            //Thread[] testThread = new Thread[2] { new Thread(TestThreadStart), new Thread(TestThreadStart2) };
            //foreach (var item in testThread)
            //{
            //    item.Start();
            //}
            //while (count++ < 10)
            //{
            //    Console.WriteLine("Main thread executed" + count + " times");
            //    Thread.Sleep(500);
            //}
            #endregion
            ThreadPool.QueueUserWorkItem(new Program().testThread1);
            ThreadPool.QueueUserWorkItem(new Program().testThread2);
            Console.WriteLine("UI is still responsive, try entering a string..");
            var read = Console.ReadLine();
            Console.WriteLine("You entered: {0}", read);

            Console.ReadLine();

        }
        public void testThread2(object ThreadContext)
        {
            int count = 0;
            while (count++ < 10)
            {
                
                Thread.Sleep(500);
            }
            Console.WriteLine("Thread 2 is executed " + count + " times");
        }

        public void testThread1(object ThreadContext)
        {
            int count = 0;
            while (count++ <10)
            {
                
                Thread.Sleep(500);
            }
            Console.WriteLine("Thread 1 is executed " + count + " times");
        }
    }
}
