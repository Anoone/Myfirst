using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCircle
{
    public class TestCircle
    {  // Save as "TestCircle.java"

        public static void Main(String[] args)
        {
            // Declare an instance of Circle class called c1.
            // Construct the instance c1 by invoking the "default" constructor
            // which sets its radius and color to their default value.
            Circle c1 = new Circle();
            Console.WriteLine(c1.toString());   // explicit call

            // Invoke public methods on instance c1, via dot operator.
            Console.WriteLine("The circle has radius of "
               + c1.getRadius() + " and area of " + c1.getArea()
                + " and color of " + c1.getColour());

            Console.WriteLine(" ");

            // Declare an instance of class circle called c2.
            // Construct the instance c2 by invoking the second constructor
            // with the given radius and default color.
            Circle c2 = new Circle(1.5);

            Console.WriteLine(c2.toString());  // explicit call
            Console.WriteLine(c2);             // println() calls toString() implicitly, same as above
            Console.WriteLine("Operator '+' invokes toString() too: " + c2);  // '+' invokes toString() too
            // Invoke public methods on instance c2, via dot operator.
            Console.WriteLine("The circle has radius of "
               + c2.getRadius() + " and area of " + c2.getArea()
               + " and color of " + c2.getColour());

            Console.WriteLine(" ");

            Circle c3 = new Circle(3.0,"blue");

            Console.WriteLine("The circle has radius of "
               + c3.getRadius() + " and area of " + c3.getArea()
               + " and color of " + c3.getColour());

            Console.WriteLine(" ");
            Circle c4 = new Circle();   // construct an instance of Circle
            c4.setRadius(5.0);          // change radius
            Console.WriteLine("radius is: " + c4.getRadius()); // Print radius via getter
            c4.setColour("purple");        // Change colour
            Console.WriteLine("color is: " + c4.getColour());   // Print color via getter


        }
    }
}
