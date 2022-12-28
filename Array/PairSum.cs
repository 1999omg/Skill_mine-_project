using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.Array
{
    class PairSum
    {
        //Find pair of elements in array whose number is given number.
 //      // e.g.Given array is { 4,5,7,1,2,3,0}
          // If number given is 7. Then pairs whose sum is equal to given
//        number are – (4,3) (5,2) (7,0)


        public void findPairSum()
        {
            //  6.Write a C# program to remove all occurrences of a character from string.
            int[] ar = { 1, 5, 8, 9, 6, 5, 7, 4, 8, 5, 4, 7, 4, 5,
                2, 2, 52, 2, 5, 2, 1, 4, 25, 5, 5, 2, 5, 1, 54 };

            for (int i = 0; i < ar.Length - 1; i++)
            {
                if (ar[i] + ar[i + 1] == 7)
                {
                    Console.WriteLine(ar[i] + "   " + ar[i + 1]);
                }
            }


        }

    }
}
