using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.OPPS.Encapsulation
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Price}";
        }
    


    static void MMain (string[] args)
    {
        //property initializer syntax
        Product p1 = new Product();
        p1.Id = 1;
        p1.Name = "Keyboard";
        p1.Price = 499;

        // object intializer syntax
        Product p2 = new Product { Id = 2, Name = "Mouse", Price = 999 };
        Console.WriteLine(p1);
        Console.WriteLine(p2);
    }



}
}
