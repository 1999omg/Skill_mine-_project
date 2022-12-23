using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.Collection
{
    public class Employee : IComparable
    {

        public int ID;
        public string EmployeeName;

        
        public Employee(int id, string employeename)
        {
            this.ID = id;
            this.EmployeeName = employeename;
        }
               
        public int CompareTo(object incomingobject)
        {

            Employee incomingemployee = incomingobject as Employee;

            return this.ID.CompareTo(incomingemployee.ID);
        }
    }

    class Test 
    {

        
        static public void mMain()
        {

                    
            Employee[] employees = new Employee[]
            {
        new Employee(1, "Susmita"),
        new Employee(5, "Soniya"),
        new Employee(3, "Rohit"),
        new Employee(2, "Mohit"),
        new Employee(4, "Pihu")
            };      



            Console.WriteLine("Before sorting employees array");
            foreach (var emp in employees)
            {
                Console.WriteLine("ID - {0}, Employee Name - {1}",
                                  emp.ID, emp.EmployeeName);
            }

         
            Array.Sort(employees);

            Console.WriteLine();

          
            Console.WriteLine("After sorting employees array");
            foreach (var emp in employees)
            {
                Console.WriteLine("ID - {0}, Employee Name - {1}",
                                  emp.ID, emp.EmployeeName);
            }
        }
    }
}
                