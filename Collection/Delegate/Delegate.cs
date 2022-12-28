using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project
{
    public delegate int Mydelet(int a, int b);
    public delegate string Mydelet2(string name);
    class Delegate
    {
        public int m1 (int a , int b)
        {
            return a + b;
        }

        public int m3 (int a,int b)
        {
            return a * b;
        }

        public string m2 (string name)
        {
            return name;
        }
    }
    public class User
    {
        static void mMain(string[] args)
        {
            Delegate d = new Delegate();

            Mydelet d1 = new Mydelet(d.m1);
            d1 += new Mydelet(d.m3);

          //  Mydelet2 d2 = new Mydelet2 (d.m2);

            int sr = d1.Invoke(10,20);
            Console.WriteLine(sr);
        }
    }
}
