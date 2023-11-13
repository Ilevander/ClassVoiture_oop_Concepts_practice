using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVoiture
{
    internal class Voiture
    {
        private string marque;
        private string couleur;
        private string matricule;
        private int nombreChevaux;

        // Accesseurs et modifieurs
        public string Marque
        {
            get { return marque; }
            set { marque = value; }
        }

        public string Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }

        public string Matricule
        {
            get { return matricule; }
        }

        public int NombreChevaux
        {
            get { return nombreChevaux; }
            set { nombreChevaux = value; }
        }

        // Constructeur
        public Voiture(string marque, string couleur, string matricule, int nombreChevaux)
        {
            this.marque = marque;
            this.couleur = couleur;
            this.matricule = matricule;
            this.nombreChevaux = nombreChevaux;
        }

        // Méthode présentation
        public void Presentation()
        {
            Console.WriteLine($"Marque: {marque}, Couleur: {couleur}, Matricule: {matricule}, Chevaux: {nombreChevaux}");
        }
    }
}
