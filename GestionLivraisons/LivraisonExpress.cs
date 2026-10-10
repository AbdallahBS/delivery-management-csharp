using System;
using System.Collections.Generic;
using System.Text;

namespace GestionLivraisons
{
    public class LivraisonExpress : Livraison
    {
        public LivraisonExpress(int numero, string destination, double poids)
            : base(numero, destination, poids)
        {
        }

        public override double CalculerPrix()
        {
            return 10 + (2.5 * Poids);
        }
    }
}
