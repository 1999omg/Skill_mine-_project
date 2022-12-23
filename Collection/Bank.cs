using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.Collection
{
    class Bank
    {
        int id;
        string name;
        int acno;
        string actype;



        public Bank (int id , string name, int acno,string actype)
        {
            this.id = id;
            this.name = name;
            this.acno = acno;
            this.actype = actype;
        } 

        int Id
        {
            set { this.id = id; }
            get { return id; }
        }

        string Name
        {
            get { return name; }
            set { this.name = name; }
        }

        int Acno
        {
            set { this.acno = acno; }
            get { return acno; }
        }
        
    }

    public class SavingAC
    {
        static void Main(string[] args)
        {
            Bank b1 = new Bank(1," mr raghav ",545457,"saving account ");
            Bank b2 = new Bank(1, " mr raghav ", 545457, "saving account ");
            Bank b3 = new Bank(1, " mr raghav ", 545457, "saving account ");
            Bank b4 = new Bank(1, " mr raghav ", 545457, "saving account ");

            List<Bank> sb = new List<Bank>();

            sb.Add(b1);


        }
    }
}
