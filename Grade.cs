using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualitelogicielUA3
{
    internal class Grade
    {
        private int numeroEtudiant;
        private int numeroCours;
        private float note;

        // Constructeur
        public Grade(int numeroEtudiant, int numeroCours, float note)
        {
            this.numeroEtudiant = numeroEtudiant;
            this.numeroCours = numeroCours;
            this.note = note;
        }

        // Getters et setters pour le numéro d'étudiant
        public int NumeroEtudiant
        {
            get { return numeroEtudiant; }
            set { numeroEtudiant = value; }
        }

        // Getters et setters pour le numéro du cours
        public int NumeroCours
        {
            get { return numeroCours; }
            set { numeroCours = value; }
        }

        // Getters et setters pour la note
        public float Note
        {
            get { return note; }
            set { note = value; }
        }
    }
}
