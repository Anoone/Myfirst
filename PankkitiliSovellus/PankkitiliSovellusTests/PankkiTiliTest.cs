using NUnit.Framework;
using PankkitiliSovellus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PankkitiliSovellusTests
{
    [TestFixture]
    public class PankkiTiliTest
    {
        /*Pankkitilisovellus sisältää:
         * 
         * Luokka, jonka nimi on pankkitili
         * Pankkitilissä on kolme toimintoa
         * 
         * tallettaa rahaa
         * nostaa rahaa
         * siirtää rahaa pankkitilitä toiselle
         * tarkisteta ettei tili mene miinukselle
        */
        [Test]
        public void CreateBackAccount()
        {
            Pankkitili tili1 = new Pankkitili();
            Assert.IsInstanceOf<Pankkitili>(tili1);
        }

    }
}
