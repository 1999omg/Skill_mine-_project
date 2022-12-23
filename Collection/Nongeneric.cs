using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;




namespace Skill_mine__project.Collection
{
    class Nongeneric
    {
    }
    public class Emp
    {
        int id;
        string name;
        string dept;

       // Employeee() { }

        Emp (int id, string name, string dept)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
        }

        static void MMain(string[] args)
        {
            // Employeee <int> obj1 = new Employeee <int>();

            ArrayList ar = new ArrayList();

            // ArrayList<int> al = new ArrayList<int>();


            List<int> all = new List<int>();
            all.Add(10);
            all.Add(10001);




            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            foreach (var item in myStack)
            {
                Console.Write(item + ","); //prints 4,3,2,1, 
            }

            //   ArrayList<int> ar = new ArrayList<int>();
            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(3, "Three");
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(4, null);
            numberNames.Add(10, "Ten");
            numberNames.Add(5, "Five");



            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            foreach (var id in callerIds)
                Console.Write(id); 


        }
    }

    internal class MyGeneric<T>
    {
        public MyGeneric()
        {
            MyGeneric<Emp> obj2 = new MyGeneric<Emp>();
          //  Emp.Add(10, "hgf", "kjdfhgg");

            MyGeneric<int> obj1 = new MyGeneric<int>();
          
        }
    }
}
