using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle2
{
    public class TestCircle
    {  
        public static void Main(String[] args)
        {

            SimpCircle c1 = new SimpCircle(5.0);
            Console.WriteLine(c1.toString());
            Console.WriteLine(" ");
            Console.WriteLine("The circle has radius of "
               + c1.getRadius() + " and area of " + c1.getArea() + " and a circumference of " + c1.getCircumference());


        }
    }
}
