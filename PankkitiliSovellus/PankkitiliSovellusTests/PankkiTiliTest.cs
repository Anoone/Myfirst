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
        public void Luotili()
        {
            Pankkitili tili1 = new Pankkitili(100);
            //testataan olion luokan tyyppi
            Assert.IsInstanceOf<Pankkitili>(tili1);
        }

        [Test]
        public void Alkusaldo()
        {
            Pankkitili tili1 = new Pankkitili(500);

            Assert.That(500, Is.EqualTo(tili1.Saldo));
        }

    }
}
