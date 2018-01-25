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

        public Pankkitili tili1 = null;
        //TearDown
        [SetUp]
        public void TestienAlustaja()
        {
            this.tili1 = new Pankkitili(100);
        }

        [Test]
        public void Luotili()
        {

            //testataan olion luokan tyyppi
            Assert.IsInstanceOf<Pankkitili>(tili1);
        }

        [Test]
        public void Alkusaldo()
        {
            //testataan arvon yhtäsuuruutta
            Assert.That(100, Is.EqualTo(tili1.Saldo));
        }

        [Test]
        public void Talletus()
        {
            // tallennetaan rahaa tilille
            tili1.Talleta(550);
            //testataan arvon yhtäsuuruutta
            Assert.That(650, Is.EqualTo(tili1.Saldo));
        }

        [Test]
        public void Nosto()
        {
            // nostetaan rahaa tilille
            tili1.Nosta(50);
            //testataan arvon yhtäsuuruutta
            Assert.That(50, Is.EqualTo(tili1.Saldo));
        }

        [Test]
        public void EiMiinukselle()
        {

            //testataan antaako ohjelma halutun virhetyypin
            Assert.Throws<ArgumentException>(() => tili1.Nosta(200));
            //vaikka virhe sattuu niin rahoja ei menetä
            //Loppusaldon pitäisi pysyä samana
            Assert.That(100, Is.EqualTo(tili1.Saldo));



        }
    }
}
