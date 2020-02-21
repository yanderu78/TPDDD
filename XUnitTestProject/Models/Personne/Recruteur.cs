using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XUnitTestProject.Common.DTO;
using XUnitTestProject.infrastructure;

namespace XUnitTestProject.Models
{
    public class Recruteur
    {
        private string nom;

        private string specialite;

        private DateTime disponibilite;

        private int experiance;

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

        public int Experiance
        {
            get
            {
                return experiance;
            }
        }

        public Recruteur(string nom, string spec, DateTime disp, int exp)
        {
            this.nom = nom;
            this.specialite = spec;
            this.disponibilite = disp;
            this.experiance = exp;
        }

        public Recruteur(string spec, DateTime disp, int exp)
        {
            List<RecruteurDTO> lstRe = AccessDB.AllRecruteurs;
            lstRe = lstRe.FindAll(x => x.Specialite == spec);
            if (lstRe.Count == 0)
                throw new Exception("aucun recruteur ne correspond a la specialité");
            lstRe = lstRe.FindAll(x => x.Disponibilite == disp);
            if (lstRe.Count == 0)
                throw new Exception("aucun recruteur n'est disponible pour l'entretien");
            RecruteurDTO dto = lstRe.FirstOrDefault(x => x.Experiance > exp);
            if (dto == null)
                throw new Exception("aucun recruteur n'est assez experimenter");
            this.nom = dto.Nom;
            this.specialite = dto.Specialite;
            this.disponibilite = dto.Disponibilite;
            this.experiance = dto.Experiance;
        }

        public Recruteur(RecruteurDTO dto)
        {
            this.nom = dto.Nom;
            this.specialite = dto.Specialite;
            this.disponibilite = dto.Disponibilite;
            this.experiance = dto.Experiance;
        }
    }
}
