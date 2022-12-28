using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.Array
{
    class Accurance
    {
        // 33. Count number of occurrences of a number in an array
        public void Frequency()
        {
            int[] ar = { 1, 5, 2, 8, 5, 8, 5, 4, 5, 8, 5, 2, 5, 9, 6 };
            int count = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = 0; j < ar.Length; j++)
                {
                    count = 0;
                    if (ar[i] == ar[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(ar[i] + " ||  " + count);

            }


        }
    }
}