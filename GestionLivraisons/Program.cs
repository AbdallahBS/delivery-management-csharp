using System;

namespace GestionLivraisons
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciation du gestionnaire
            GestionnaireLivraisons gestionnaire = new GestionnaireLivraisons();

            // Création des 3 livraisons selon la Partie 6 du sujet
            Livraison standard = new LivraisonStandard(1, "Tunis", 4);
            Livraison express = new LivraisonExpress(2, "Sousse", 2);
            Livraison refrigeree = new LivraisonRefrigeree(3, "Sfax", 5);

            // Ajout au gestionnaire
            gestionnaire.AjouterLivraison(standard);
            gestionnaire.AjouterLivraison(express);
            gestionnaire.AjouterLivraison(refrigeree);

            // 1. Affichage de toutes les livraisons
            gestionnaire.AfficherToutesLesLivraisons();

            Console.WriteLine();

            // 2. Calculer et afficher le prix total
            double total = gestionnaire.CalculerPrixTotal();
            Console.WriteLine($"PRIX TOTAL DE TOUTES LES LIVRAISONS : {total} TND");

            Console.WriteLine();

            // 3. Calculer et afficher l'assurance de la livraison réfrigérée
            Console.WriteLine("--- ASSURANCES DES LIVRAISONS ASSURABLES ---");
            foreach (var livraison in gestionnaire.ObtenirLivraisons())
            {
                if (livraison is IAssurable assurable)
                {
                    Console.WriteLine($"Livraison N°{livraison.Numero} ({livraison.Destination}) - Montant de l'assurance : {assurable.CalculerAssurance()} TND");
                }
            }

            Console.WriteLine("\nAppuyez sur une touche pour fermer la console...");
            Console.ReadKey();
        }
    }
}