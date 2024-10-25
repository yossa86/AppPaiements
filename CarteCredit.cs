﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class CarteCredit : Paiement
    {
        public int NumeroCarte { get; set; }
        public CarteCredit(double montant, string description, int carte) : base(montant, description)
        {
            Montant = montant;
            Description = description;
            NumeroCarte = carte;
        }
        public override void AfficherDetails()
        {
            Console.WriteLine($"Montant:{Montant}, Description:{Description}, NumeroCarte:{NumeroCarte}");
        }
    }
}

