using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.Array
{
    class SubArray
    {
        public void findSumSubArray()
        {
            // 6.Find a continuous sub array whose sum is equal to given number. 
            //e.g. if given array is { 12, 4, 2, 10, 5, 1 } and given number is 16 then sum of subarray { 4,2,10}
            //   and { 10, 5,1} is equal to given number



            int[] ar = { 1, 4, 5, 8, 9, 6, 3, 6, 5, 7, 8, 5, 2, 5, 7, 8 };
            int length = 0;
            int count = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                count = 0;
                for (int j = 0; j < ar.Length; j++)
                {
                    for (int k = 0; k < ar.Length; k++)
                    {
                        if (ar[i] + ar[j] + ar[k] == 16)
                        {
                            count++;
                        }
                    }
                }

            }
            int[] sub = new int[count];
            for (int i = 0; i < ar.Length; i++)
            {

                for (int j = 0; j < ar.Length; j++)
                {
                    for (int k = 0; k < ar.Length; k++)
                    {
                        if (ar[i] + ar[j] + ar[k] == 16)
                        {
                            sub[0] = ar[i];
                            sub[1] = ar[j];
                            sub[2] = ar[k];
                        }
                    }
                }


            }

            Console.WriteLine(string.Join(" ", sub));
            Console.WriteLine(string .Join("",ar));
        }
    }
}
