using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multithreadingdemo
{
    public class Multithreadingd
    {
        public void Run()
        {
            Thread t=Thread.CurrentThread;
            Console.WriteLine(t.Name);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                //Thread.Sleep(2000);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Multithreadingd mt = new Multithreadingd();
            Thread t1 = new Thread(new ThreadStart(mt.Run));
            Thread t2 = new Thread(new ThreadStart(mt.Run));
            Thread t3 = new Thread(new ThreadStart(mt.Run));
            t1.Name = "t1 thread";
            t2.Name = "t2 thread";
            t3.Name = "t3 thread";
            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.AboveNormal;
            t3.Priority = ThreadPriority.Highest;
            t1.Start();
            t1.Join();//block other thread and excute t1 complete it's task
            t2.Start();
            t3.Start();
            Console.ReadLine();
        }
    }
}
