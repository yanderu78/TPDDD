using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XUnitTestProject.Common.DTO;
using XUnitTestProject.infrastructure;

namespace XUnitTestProject.Models
{
    public class Salle
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

        public Salle(string loc, int cap, DateTime disp)
        {
            localisation = loc;
            capacite = cap;
            disponibilite = disp;
        }

        public Salle(DateTime dt)
        {
            List<SalleDTO> lstRo = AccessDB.AllRooms;
            SalleDTO dto = lstRo.FirstOrDefault(x => x.Disponibilite == dt);
            if (dto == null)
                throw new Exception("Aucune salle disponible pour l'entretien");

            localisation = dto.Localisation;
            capacite = dto.Capacite;
            disponibilite = dto.Disponibilite;
        }

        public Salle(SalleDTO dto)
        {
            localisation = dto.Localisation;
            capacite = dto.Capacite;
            disponibilite = dto.Disponibilite;
        }
    }
}
