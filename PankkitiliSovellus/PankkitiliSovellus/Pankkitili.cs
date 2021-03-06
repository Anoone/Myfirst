﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PankkitiliSovellus
{
    public class Pankkitili
    {
        public Pankkitili(int alkusaldo)
        {
            Saldo = alkusaldo;
        }

        public int Saldo { get; set; }

        public void Talleta(int amount)
        {
            //Saldo = Saldo + amount
            Saldo += amount;
        }
        public void Nosta(int amount)
        {
            if(Saldo - amount < 0)
            {
                throw new ArgumentException("Tilillä ei ole tarpeeksi nostovaraa.");
            }
            //Saldo = Saldo + amount
            Saldo -= amount;
        }
    }
}
