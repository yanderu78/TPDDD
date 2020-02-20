using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XUnitTestProject.infrastructure;
using XUnitTestProject.Models;

namespace XUnitTestProject.use_case
{
    static public class AjouterRecruteur
    {
        static public Entretien AjRecrut(Entretien etr)
        {
            List<Recruteur> lstRe = AccessDB.AllRecruteurs;
            Recruteur rec = lstRe.FirstOrDefault(x => x.Specialite == etr.Candidat.Specialite
            && x.Disponibilite == etr.Creneau.Debut);
            if (rec == null)
                throw new ArgumentException("No Recruteurs match the specialty");
            etr.AjouterRecruteur(rec.Nom, rec.Specialite, rec.Disponibilite);
            return etr;
        }
    }
}
