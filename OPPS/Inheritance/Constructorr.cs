using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Skill_mine__project.OPPS.Inheritance
{
   public  class Constructorr
    {
    }
    public class Employee {
      public  int id;
        public long sallery;
        public string name;
        public string dept;

       public Employee (int id , long sallery, string name, string dept)
        {
            this.id = id;
            this.sallery = sallery;
            this.name = name;
            this.dept = dept;

        }
        public override string ToString()
        {
            return id + "" + name + "" + sallery + "" + dept;
            
        }

        
    }

    /* public class Hr : Employee
     {
       public  Hr (int id, long sallery, string name, string dept)
         {
             this.id = id;
             this.sallery = sallery;
             this.name = name;
             this.dept = dept;

         } 

     }*/
}
