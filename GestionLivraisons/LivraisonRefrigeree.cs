using System;
using System.Collections.Generic;
using System.Text;

namespace GestionLivraisons
{
    public class LivraisonRefrigeree : Livraison, IAssurable
    {
        public LivraisonRefrigeree(int numero, string destination, double poids)
            : base(numero, destination, poids)
        {
        }

        public override double CalculerPrix()
        {
            return 15 + (3 * Poids);
        }

        public double CalculerAssurance()
        {
            return 10 + (2 * Poids);
        }

        public override void AfficherDetails()
        {
            base.AfficherDetails();
            Console.WriteLine($"   └── Assurance : {CalculerAssurance()} TND");
        }
    }
}
