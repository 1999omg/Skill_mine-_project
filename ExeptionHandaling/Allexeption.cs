using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.ExeptionHandaling
{
    class Allexeption
    {
        public void divideByZero()
        {
            // arethamatic exeption 
            Console.WriteLine(" enter any number ");
            int num = int.Parse(Console.ReadLine());
            int div = 0;
            int division = num / div;
            Console.WriteLine(division);
        }

        public void IndexOutOfRangeException(int range)
        {
           
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 7, 8, 9, 8, };

            for (int i = 0; i < arr.Length+2 ; i++)
            {
                Console.WriteLine(arr[i]);
            }

           

        }





        static void mMain(string[] args)
        {
            Allexeption exep = new Allexeption();


           // print n pattern 





            

            try
            {
                exep.divideByZero();

               

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                exep.IndexOutOfRangeException(11);
            }
           catch (IndexOutOfRangeException id)
            {
                Console.WriteLine(id.Message  +" this type of exeption occur ");
            }
        }
    }
}
