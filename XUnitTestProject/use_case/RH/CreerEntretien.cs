using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XUnitTestProject.infrastructure;
using XUnitTestProject.Models;

namespace XUnitTestProject.use_case
{
    static public class CreerEntretien
    {
        static public Entretien CreerEntretrien(DateTime date, int duree,
            string nomCand, string specialiteCand, int experiance)
        {
            return new Entretien(date, duree, nomCand, specialiteCand, experiance);
        }
    }
}
