using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject.Models
{
    public class Candidat
    {
        private string nom;

        private string specialite;

        private int experiance;

        public string Name
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

        public int Experiance
        {
            get
            {
                return experiance;
            }
        }

        public Candidat(string nom, string Specialite, int Experiance)
        {
            this.nom = nom;
            this.specialite = Specialite;
            this.experiance = Experiance;
        }
    }
}
