using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.ExeptionHandaling
{
    class Throws
    {
    }
    public class Student
    {
        int id;
        int roll;
        string name;
        int mark;

        Student(int id, int roll , string name,int mark)
        {
            this.id = id;
            this.roll = roll;
            this.name = name;
            this.mark = mark;
        }

        private static void MMain(Student std)
        {
            Student obj = new Student (10,20,null,74);



            if (obj.name == null)
                throw new NullReferenceException("Student object is null.");

            Console.WriteLine(obj.name);


            if (obj.id > 50)

                throw new NullReferenceException(" invalid id");


        }

       

        static void Main (string[] args)
        {
            Student s = new Student(10, 2, " ram", 74);


        }

    }
}
