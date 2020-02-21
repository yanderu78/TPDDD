using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject.Common.DTO
{
    public class RecruteurDTO
    {
        public string Nom;

        public string Specialite;

        public DateTime Disponibilite;

        public int Experiance;

        public RecruteurDTO(string nom, string spec, DateTime disp, int exp)
        {
            this.Nom = nom;
            this.Specialite = spec;
            this.Disponibilite = disp;
            this.Experiance = exp;
        }
    }
}
