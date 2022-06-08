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
            t1.Name = "t1 thread";
            t2.Name = "t2 thread";
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
    }
}
