using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.Array
{
    class Maximum
    {

        public void findMax (int[] ar)
        {
            int max = ar[0];
            for (int i=0;i< ar.Length; i++)
            {
                if (ar[i]>max)
                {
                    max = ar[i];

                }
            }
            Console.WriteLine(max);

        }
        static void mmMain (string []args)
        {
            int[] ar = new int[10];
        for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Maximum obj = new Maximum();
            obj.findMax(ar);
        }
    }
}
