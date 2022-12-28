using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.Collection
{
    class MVC
    { }
    
        public class Student
        {
            public int id;
            public string name;

          public  Student(int id , string name)
            {
                this.id = id;
                this.name = name;
            }
        }

        public class Courses
        {
          public  int id;
         public   string name;

          public  Courses(int id, string name)
            {
                this.id = id;
                this.name = name;
            }

        }
    
    public class TQ
    {
        static void mMain(string[] args)
        {
            Student s1 = new Student (1, "ram");
            Student s2 = new Student(1, "ram");
            Student s3 = new Student(1, "ram");
            Student s4 = new Student(1, "ram");



            Courses c1 = new Courses(1, " java");
            Courses c2 = new Courses(1, " java");
            Courses c3 = new Courses(1, " java");
            Courses c4 = new Courses(1, " java");
            


            List<object> l = new List<object>();
            List<Student> ss = new List<Student>();
            ss.Add(s1);
            ss.Add(s2);
            ss.Add(s3);
            ss.Add(s4);

            
        }
    }
    











}
