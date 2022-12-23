using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.OPPS.Abstract
{
    public abstract class Shape
    {
        public abstract void CalculateArea();


    }
    public class Circle : Shape
    {
        private int r;
        private double area;
        public Circle(int r)
        {
            this.r = r;
        }

        public override void CalculateArea()
        {
            area = 3.14 * r * r;
        }
        public override string ToString()
        {
            return $"area of circle is {area}";
        }
    }
    public class Rectangle : Shape
    {
        // L * W
        public override void CalculateArea()
        {
            throw new NotImplementedException();
        }

    }
}

