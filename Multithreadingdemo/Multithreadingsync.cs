using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multithreadingdemo
{
    class Multithreadingsync
    {
        public void Run()
        {
            Thread t = Thread.CurrentThread;
            lock (this)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(t.Name);
                    Console.WriteLine(i);
                    
                }
            }
        }
    }
    public class Syncronization
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
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadLine();
        }
    }
}
