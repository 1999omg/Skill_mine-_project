using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.Array
{
    class Geometry


    {

        public double radiusOfCircle(double r)
        {
            // Accept radius of a circle. Display area of a circle


            double area = 2 * 3.14 * r;
            Console.WriteLine(area);
            return area;
        }

        int ractangle (int length)
        {
            int breadth = length / 2;
            int perimeter = 2*(length * breadth);
            return perimeter;
        }


        public void triangle()
        {
            int angle1 = int.Parse(Console.ReadLine());
            int angle2 = int.Parse(Console.ReadLine());

            int angle3 = 180 - (angle1 + angle2);
            Console.WriteLine(angle3+" third angle of triangle ");
        }

        static void mMian(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            int length = 20;
        }
    }
}
