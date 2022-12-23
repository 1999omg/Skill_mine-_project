using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.OPPS.Abstract
{
   public abstract class Sallery
    {
        public abstract double calculateSallery();
      public  static double hra = 0.10;
       public static double dra = 0.05;
    }

    public class Hr : Sallery
    {
        public override double   calculateSallery ()
        {
            double sallery = 50000;
            sallery = sallery * hra;
            sallery = sallery * dra;

            return sallery;
           // [arameter should same
           // return type should same
             
        }

    }

    public class Manager :Sallery
    {
        public override double calculateSallery()
        {
            double sallery = 70000;
            sallery = sallery * hra;
            sallery = sallery * dra;
            return sallery;

        }
    }
    class Employee : Sallery
    {
        public override double calculateSallery()
        {
            double sallery =30000 ;
            sallery = sallery * hra;
            sallery = sallery * dra;
            return sallery;

        }
    }
    public class Calculate
    {
        static void MMain (string[] args)
        {
            Employee e = new Employee();
            e.calculateSallery();

            Console.WriteLine(e.calculateSallery());


        }
    }
}
