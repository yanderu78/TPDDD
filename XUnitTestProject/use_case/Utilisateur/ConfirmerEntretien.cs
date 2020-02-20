using System;
using System.Collections.Generic;
using System.Text;
using XUnitTestProject.infrastructure;

namespace XUnitTestProject.use_case
{
    public static class ConfirmerEntretien
    {
        public static void ConfirmEntretien()
        {
            if (AccessDB.etr.Salle == null || AccessDB.etr.Recruteur == null)
                throw new ArgumentNullException("Salle ou recruteur non defini");
            else
                AccessDB.etr.Confirmer();
        }
    }
}
