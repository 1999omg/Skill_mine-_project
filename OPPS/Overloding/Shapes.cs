using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.OPPS.Overloding
{
    class Shapes
    {
        public int area( int l , int b)
        {
            return l * b;

        }

        public float  area (float p, int r)
        {
            return 2*p*r;
        }

        public int area (int b, int h,string t)
        {
            return 1/2*b * h;
        }

       public void testa() {

            {
                Shapes obj = new Shapes();

                obj.area(10, 5, "trinagle");
                Console.WriteLine(obj.area(10, 5, "triangle"));

                obj.area(10, 5);
                Console.WriteLine(obj.area(10, 5));

            }
        }
    }
}
