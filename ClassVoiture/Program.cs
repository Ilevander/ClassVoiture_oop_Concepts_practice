using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVoiture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture[] voitures = new Voiture[5];

            // Remplir le tableau de voitures
            voitures[0] = new Voiture("Renault", "Bleu", "ABC123", 120);
            voitures[1] = new Voiture("Peugeot", "Rouge", "DEF456", 150);
            voitures[2] = new Voiture("Toyota", "Noir", "GHI789", 100);
            voitures[3] = new Voiture("Ford", "Vert", "JKL012", 130);
            voitures[4] = new Voiture("BMW", "Blanc", "MNO345", 180);

            // Afficher les informations de toutes les voitures
            Console.WriteLine("Informations des voitures avant modification :");
            AfficherInformations(voitures);

            // Augmenter le nombre de chevaux de 1 pour toutes les voitures
            AugmenterChevaux(voitures);

            // Afficher les informations de toutes les voitures après modification
            Console.WriteLine("\nInformations des voitures après modification :");
            AfficherInformations(voitures);

            // Inviter l'utilisateur à saisir une matricule et afficher les informations de la voiture correspondante
            Console.Write("\nEntrez une matricule : ");
            string matriculeRecherche = Console.ReadLine();
            ChercherEtAfficherVoiture(voitures, matriculeRecherche);
        }

        // Fonction pour afficher les informations de toutes les voitures
        static void AfficherInformations(Voiture[] voitures)
        {
            foreach (var voiture in voitures)
            {
                voiture.Presentation();
            }
        }

        // Fonction pour augmenter le nombre de chevaux de 1 pour toutes les voitures
        static void AugmenterChevaux(Voiture[] voitures)
        {
            foreach (var voiture in voitures)
            {
                voiture.NombreChevaux += 1;
            }
        }

        // Fonction pour chercher et afficher les informations d'une voiture par matricule
        static void ChercherEtAfficherVoiture(Voiture[] voitures, string matricule)
        {
            bool voitureTrouvee = false;

            foreach (var voiture in voitures)
            {
                if (voiture.Matricule == matricule)
                {
                    Console.WriteLine("\nInformations de la voiture recherchée :");
                    voiture.Presentation();
                    voitureTrouvee = true;
                    break;
                }
            }

            if (!voitureTrouvee)
            {
                Console.WriteLine("Matricule inexistante.");
            }
        }
    }
}
