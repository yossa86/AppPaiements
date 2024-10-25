using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class PayPal : Paiement
    {
        public string Courriel { get; set; }
        public PayPal(double montant, string description, string email) : base(montant, description)
        {
            Montant = montant;
            Description = description;
            Courriel = email;
        }

        public override void AfficherDetails()
        {
            Console.WriteLine($"Montant:{Montant}, Description:{Description}, email:{Courriel}");
        }
    }
}

