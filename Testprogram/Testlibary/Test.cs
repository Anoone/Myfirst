using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testlibary
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void test1()
        {
            Assert.That(1, Is.EqualTo(1));
        }
    }
}
