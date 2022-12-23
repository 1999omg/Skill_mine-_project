using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.Collection
{
   public class Laptop
    {
        int modelNo;
        string os;
        string name;
        int price;

        public string Name   
        {
            get { return name; }   
            set { name = value; }  
        }

        public string Os
        {
            set { this.os = os; }
            get { return os; }
        }

        public int Price
        {
            set { this.price = price; }
            get { return price; }
        }
    }

    class Showroom {

        List<Laptop> l = new List<Laptop>();
       

    }

}
