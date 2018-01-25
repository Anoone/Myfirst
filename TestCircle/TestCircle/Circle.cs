using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCircle
{
    public class Circle
    {  // Save as "Circle.java"
       // private instance variable, not accessible from outside this class
        private double radius;
        private String colour;

        // The default constructor with no argument.
        // It sets the radius and color to their default value.
        public Circle()
        {
            radius = 1.0;
            colour = "green";
        }

        // 2nd constructor with given radius, but color default
        public Circle(double radius)
        {
            this.radius = radius;
            colour = "red";
        }

        // 3rd constructor to construct a new instance of Circle with the given radius and color
        public Circle(double radius, String ccolour)
        {
            this.radius = radius;
            colour = "blue";
        }

        // A public method for retrieving the radius
        public double getRadius()
        {
            return radius;
        }

        // A public method for computing the area of circle
        public double getArea()
        {
            return radius * radius * Math.PI;
        }

        // Getter for instance variable color
        public String getColour()
        {
            return colour;

        }

        // Setter for instance variable radius
        public void setRadius(double newRadius)
        {
            radius = newRadius;
        }

        // Setter for instance variable color
        public void setColour(String newColour)
        {
            colour = newColour;
        }
    }
}
