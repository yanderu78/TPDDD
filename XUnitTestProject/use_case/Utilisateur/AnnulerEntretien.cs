using System;
using System.Collections.Generic;
using System.Text;
using XUnitTestProject.infrastructure;

namespace XUnitTestProject.use_case
{
    public static class AnnulerEntretien
    {
        public static void AnnulEntretien(string reason)
        {
            AccessDB.etr.Annuler(reason);
        }
    }
}
