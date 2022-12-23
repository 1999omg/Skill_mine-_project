using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.Collection
{
    public enum ProductType { furniture, mobile, mensshirt }
    public class Product2
    {
        public string Company { set; get; }


        public ProductType ProductType;
        public List<DetailsProduct> dlist = new List<DetailsProduct>();
    }
    public class DetailsProduct
    {
        public string Name { set; get; }
        public string Colour { set; get; }
        public int Price { set; get; }

    }
    
    public class Showroomm
    {
        static void Main(string[] args)
        {
            List<Product2> p = new List<Product2>()
            {
                new Product2
                {
                   // name=" chair",

                }
            };
        }
    }

}
