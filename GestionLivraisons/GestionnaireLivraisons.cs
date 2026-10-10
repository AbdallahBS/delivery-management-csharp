using System;
using System.Collections.Generic;
using System.Text;

namespace GestionLivraisons
{
    public class GestionnaireLivraisons
    {
        private List<Livraison> livraisons;

        public GestionnaireLivraisons()
        {
            livraisons = new List<Livraison>();
        }

        public void AjouterLivraison(Livraison livraison)
        {
            livraisons.Add(livraison);
        }

        public void AfficherToutesLesLivraisons()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("          LISTE DE TOUTES LES LIVRAISONS          ");
            Console.WriteLine("==================================================");
            foreach (var livraison in livraisons)
            {
                livraison.AfficherDetails();
            }
        }

        public double CalculerPrixTotal()
        {
            double prixTotal = 0;
            // Polymorphisme : pas de test 'if (livraison is ...)'
            foreach (var livraison in livraisons)
            {
                prixTotal += livraison.CalculerPrix();
            }
            return prixTotal;
        }

        public List<Livraison> ObtenirLivraisons()
        {
            return livraisons;
        }
    }
}
