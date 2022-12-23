using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project
{
    class Pattern
    {
        static void MMain(string[] args)
        {

            int n = 10;

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            for (int i = n; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();



            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("__");
                }
                Console.WriteLine();

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (j == 1 || j == 9 || j == i)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write("_");

                }
                Console.WriteLine();
            }

        }
    }
}
