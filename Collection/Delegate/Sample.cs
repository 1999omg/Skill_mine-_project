using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.Collection.Delegate
{
    class Sample
    {
        public delegate void Mydelet(int x, int y);
        public delegate void mydelet2(char ch);

        public int  addition (int x , int y)
        {
           // public event Mydelet();
            return x+y;
        }

        public double division (int x, int y)
        {
            return x / y;
        }

        public long multiply (int x, int y)
        {
            return x * y;
        }
    }

    public class MainMydelet
    {
        static void Main
    }
}
