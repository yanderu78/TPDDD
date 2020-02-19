using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject.Models
{
    public class Recruteur
    {
        private string name;

        private string specialty;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Specialty
        {
            get
            {
                return specialty;
            }
        }

        public Recruteur(string Name, string Specialty)
        {
            this.name = Name;
            this.specialty = Specialty;
        }
    }
}
