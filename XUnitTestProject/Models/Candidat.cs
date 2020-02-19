using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject.Models
{
    public class Candidat
    {
        private string name;

        private string specialty;

        private int experiance;

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

        public int Experiance
        {
            get
            {
                return experiance;
            }
        }

        public Candidat(string Name, string Specialty, int Experiance)
        {
            this.name = Name;
            this.specialty = Specialty;
            this.experiance = Experiance;
        }
    }
}
