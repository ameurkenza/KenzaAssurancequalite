using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualitelogicielUA3
{
    internal class Student
    {
        private int numeroEtudiant;
        private string nom;
        private string prenom;
        private Dictionary<string, List<float>> notesParCours;

        // Constructeur
        public Student(int numeroEtudiant, string nom, string prenom)
        {
            this.numeroEtudiant = numeroEtudiant;
            this.nom = nom;
            this.prenom = prenom;
            this.notesParCours = new Dictionary<string, List<float>>();
        }

        // Getters et setters
        public int NumeroEtudiant
        {
            get { return numeroEtudiant; }
            set { numeroEtudiant = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        // Méthode pour afficher les informations de l'étudiant
        public void AfficherInfos()
        {
            Console.WriteLine($"Numéro d'étudiant: {numeroEtudiant}, Nom: {nom}, Prénom: {prenom}");
        }

        // Méthode pour ajouter une note à un cours spécifique
        public void AjouterNote(string cours, float note)
        {
            if (!notesParCours.ContainsKey(cours))
            {
                notesParCours[cours] = new List<float>();
            }
            notesParCours[cours].Add(note);
        }

        // Méthode pour afficher toutes les notes de l'étudiant pour chaque cours
        public void AfficherNotes()
        {
            foreach (var cours in notesParCours)
            {
                Console.Write($"Cours: {cours.Key}, Notes: ");
                cours.Value.ForEach(note => Console.Write(note + " "));
                Console.WriteLine();
            }
        }
    }
}
