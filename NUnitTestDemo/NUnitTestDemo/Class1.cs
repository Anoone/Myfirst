using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestDemo
{
    [TestFixture]
    class Testcase
    {
        [TestCase]
        public void Add()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(5,math.Add(2,3));
        }

        [TestCase]
            public void Sub()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(1,math.Sub(3,2));
        }

        [TestCase]
        public void Mul()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(20, math.Mul(4, 5));
        }

        [TestCase]
        public void Div()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(5, math.Div(25, 5));
        }


    }
}
