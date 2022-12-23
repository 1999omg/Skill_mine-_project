using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project
{
    class Constructor
    {

    }
    public class Teacher
    {
      public  string name;
      public  int exprience;
      public  int id;
      public  long sallery;
         
        public Teacher(string name, int exprience,int id, long sallery)
        {
            this.name = name;
            this.id = id;
            this.exprience=exprience;
            this.sallery = sallery;
            Console.WriteLine(" paramerise constructor ");
        }

       public  Teacher()
        {
            Console.WriteLine(" default constructor ");
        }
    }
    class PermenantTeacher
    {
        static void mMain (string[] args)
        {
            Teacher t = new Teacher();
            Teacher tt = new Teacher(" mr anikate sir ", 10, 1, 500000);
            Console.WriteLine("name is " + tt.name + "  exprience is " + tt.exprience + "  id is " + tt.id +
             "  sallery is " +tt.sallery   );
                 
        }
    }
}
