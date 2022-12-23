using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.String
{
    class Fibonacci
    {
        static void Main (string[] args)
        {
            int n = int.Parse(Conslole.ReadLine());
            int a, b, c;
            for (int i=1;i<n; i++)
            {
                a = i;
                b = i + 1;
                c = a + b;

                Console.WriteLine(c);
            }
        }
    }
}
