using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Skill_mine__project.Threading
{
    class SampleT
    {
        public void m1()
        {
            lock (this)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(100);
                }
            }
        }

        public void m2()
        {
            for (int i = 10; i < 21; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }

        }
    }
    public class Implement
    {
        public static void Main (string []args)
        {
            SampleT s = new SampleT();

            Thread t1 = new Thread(new ThreadStart(s.m1));
            Thread t2 = new Thread(new ThreadStart(s.m2));
            Thread t3 = new Thread(new  ThreadStart(s.m1));

            t1.Start();
            t3.Start();
            t3.Join();


            t2.Start();

            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Normal;



        }
    }
}
