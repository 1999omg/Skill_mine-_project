using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.Array
{
    class Sorting
    {
        
        public void sorting()
        {
            int[] arr = { 1, 5, 2, 8, 9, 6, 8, 5, 5, 2, 2, 7, 4, 1, 1 };
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    {
                        if (arr[i] < arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join("", arr));
        }

        public void halfSorting(int[] arr)
        {
            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            int temp = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length / 2; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }

                temp = arr[arr.Length / 2];
                for (int j = arr.Length / 2; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }

                }
            }
            Console.WriteLine(string.Join("", arr));
        }



    }
}
