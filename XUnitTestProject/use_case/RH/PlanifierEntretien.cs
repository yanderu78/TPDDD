using System;
using System.Collections.Generic;
using System.Text;
using XUnitTestProject.infrastructure;
using XUnitTestProject.Models;

namespace XUnitTestProject.use_case.RH
{
    public static class PlanifierEntretien
    {
        public static void PlanifEntretien(DateTime date, int duree,
            string nomCand, string specialiteCand, int experiance)
        {
            Entretien etr = CreerEntretien.CreerEntretrien(date, duree, nomCand, specialiteCand, experiance);
            etr = AjouterSalle.AjSalle(etr);
            etr = AjouterRecruteur.AjRecrut(etr);
            AccessDB.etr = etr;
        }
    }
}
