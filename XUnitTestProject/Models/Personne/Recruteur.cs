using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject.Models
{
    public class Recruteur
    {
        private string nom;

        private string specialite;

        private DateTime disponibilite;

        public string Nom
        {
            get
            {
                return nom;
            }
        }

        public string Specialite
        {
            get
            {
                return specialite;
            }
        }

        public DateTime Disponibilite
        {
            get
            {
                return disponibilite;
            }
        }

        public Recruteur(string nom, string spec, DateTime disp)
        {
            this.nom = nom;
            this.specialite = spec;
            this.disponibilite = disp;
        }
    }
}
