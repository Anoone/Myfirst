using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testprogram;

namespace Testlibary
{
    [TestFixture]
    public class MerkkiJonoTester
    {
        MerkkiJonoLaskin laskin;

        [SetUp]
        public void TestienAlustus()
        {
            laskin = new MerkkiJonoLaskin();
        }
        [Test]
        public void TyhjaMerkkiJono()
        {
            Assert.That(laskin.Summa(""), Is.EqualTo(0));
        }

        [Test]
        public void YksiAnnettuLukuPalauttaaLuvunArvon()
        {
            Assert.That(laskin.Summa("5"), Is.EqualTo(5));
        }

        [Test]
        public void KaksiLukuaPilkullaErotettunaAntaaSumman()
        {
            Assert.That(laskin.Summa("3,5"), Is.EqualTo(8));
        }

        [Test]
        public void RajatonMaaraNumeroitaPilkullaErotettunaAntaaSumman()
        {

            Assert.That(laskin.Summa("1,2,3,4,5"), Is.EqualTo(15));
        }



    }
}