using System;
using System.Collections.Generic;
using System.Text;

namespace GestionLivraisons
{
    public abstract class Livraison
    {
        // Propriétés encapsulées
        public int Numero { get; set; }
        public string Destination { get; set; }
        public double Poids { get; set; }

        // Constructeur
        public Livraison(int numero, string destination, double poids)
        {
            Numero = numero;
            Destination = destination;
            Poids = poids;
        }

        // Méthode abstraite à implémenter dans les classes filles
        public abstract double CalculerPrix();

        // Méthode virtuelle qu'on peut personnaliser
        public virtual void AfficherDetails()
        {
            Console.WriteLine($"[Livraison N°{Numero}] {GetType().Name} -> Destination: {Destination} | Poids: {Poids} kg | Prix: {CalculerPrix()} TND");
        }
    }
}
