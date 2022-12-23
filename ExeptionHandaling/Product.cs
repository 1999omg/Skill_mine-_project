using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.Collection
{
    public class Product
    {
        public int id;
        public int price;
        public string name;

       public Product(int id , int price,string name)
        {
            this.id = id;
            this.price = price;
            this.name = name;

        }

    }
    public class Shoroom
    {
        static void Main(string[] args)
        {
            Product pr1 = new Product(1,5000," key board  ");
            Product pr2 = new Product(2, 500, " mouse  ");
            Product pr3 = new Product(3, 2500, " speaker  ");
            Product pr4 = new Product(4, 3000, " screem gard ");

            List<Product> p = new List<Product>();
            p.Add(pr1);
            p.Add(pr2);
            p.Add(pr3);
            p.Add(pr4);

            for (int i = 0; i < p.Count; i++)
            {
                if (p[i].price > 2000)
                {
                    Console.WriteLine(p[i].name);
                }
            }
            Console.WriteLine();

            

        }
    }
}
