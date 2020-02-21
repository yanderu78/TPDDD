using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject.Common.DTO
{
    public class SalleDTO
    {
        private string localisation;

        private int capacite;

        private DateTime disponibilite;

        public string Localisation
        {
            get
            {
                return localisation;
            }
        }

        public int Capacite
        {
            get
            {
                return capacite;
            }
        }

        public DateTime Disponibilite
        {
            get
            {
                return disponibilite;
            }
        }

        public SalleDTO(string loc, int cap, DateTime disp)
        {
            localisation = loc;
            capacite = cap;
            disponibilite = disp;
        }
    }
}
