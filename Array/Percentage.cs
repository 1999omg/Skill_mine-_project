using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.Array
{
    class Percentage
    {

       public void find_percentage()
        {
            // for single student 
            int[] mark = new int[3];
            int sum = 0;
            for (int i = 0; i < mark.Length; i++)
            {
                mark[i] = int.Parse(Console.ReadLine());
                sum = sum + mark[i];
            }
            double per = (double)sum * 3 / 10;
        }

    }
}
