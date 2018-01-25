using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle2
{
    public class SimpCircle
    { 
        private double radius;

        public SimpCircle()
        {
            this.radius = 1.0;
        }

        public SimpCircle(double radius)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return radius;
        }

        public void setRadius(double newRadius)
        {
            radius = newRadius; // radius setter
        }

        public double getArea()
        {
            return radius * radius * Math.PI;
        }

        public double getCircumference()
        {
            return 2 * Math.PI * radius;
        }

        public String toString()
        {
            return "Circle[radius=" + radius + "]";
        }
    }
}
