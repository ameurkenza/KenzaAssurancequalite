using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualitelogicielUA3
{
    internal class Course
    {
        private int numeroCours;
        private string code;
        private string titre;
        private List<Student> etudiantsInscrits;

        // Constructeur
        public Course(int numeroCours, string code, string titre)
        {
            this.numeroCours = numeroCours;
            this.code = code;
            this.titre = titre;
            this.etudiantsInscrits = new List<Student>();
        }

        // Getters et setters
        public int NumeroCours
        {
            get { return numeroCours; }
            set { numeroCours = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }

        // Méthode pour afficher les informations du cours
        public void AfficherInfos()
        {
            Console.WriteLine($"Numéro du cours: {numeroCours}, Code: {code}, Titre: {titre}");
        }

        // Méthode pour ajouter un étudiant à la liste des inscrits
        public void AjouterEtudiant(Student etudiant)
        {
            etudiantsInscrits.Add(etudiant);
        }

        // Méthode pour lister tous les étudiants inscrits à ce cours
        public void ListerEtudiants()
        {
            if (etudiantsInscrits.Any())
            {
                Console.WriteLine("Étudiants inscrits au cours:");
                foreach (Student etudiant in etudiantsInscrits)
                {
                    etudiant.AfficherInfos(); // Utilise la méthode AfficherInfos de la classe Student
                }
            }
            else
            {
                Console.WriteLine("Aucun étudiant inscrit à ce cours.");
            }
        }
    }
}
