using System;
using System.Collections.Generic;
using System.Text;
using XUnitTestProject.infrastructure;
using XUnitTestProject.Models;

namespace XUnitTestProject.use_case
{
    public static class PlanifierEntretien
    {
        public static void PlanifEntretien(DateTime date, int duree,
            string nomCand, string specialiteCand, int experiance)
        {
            Entretien etr = new Entretien(date, duree, nomCand, specialiteCand, experiance);
            AccessDB.etr = etr;
        }
    }
}
