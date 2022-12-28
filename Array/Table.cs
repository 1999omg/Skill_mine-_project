using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.Array
{
    class Table
    {
        // write code for print number table 
        static void Main(string[] args)
        {
            Console.WriteLine(" enter number you want table ");
            int num = int.Parse(Console.ReadLine());
            int mul = 1;
            for  (int i = 0; i < 11 ; i++)
            {
                mul = i *num ;
                Console.WriteLine(mul);

            }
        }
    }
}
