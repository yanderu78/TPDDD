using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XUnitTestProject.infrastructure;
using XUnitTestProject.Models;

namespace XUnitTestProject.use_case
{
    public static class AjouterSalle
    {
        public static Entretien AjSalle(Entretien etr)
        {
            List<Salle> lstRo = AccessDB.AllRooms;
            Salle ro = lstRo.FirstOrDefault(x => x.Disponibilite == etr.Creneau.Debut);
            if (ro == null)
                throw new ArgumentException("No rooms available");
            etr.AjouterRoom(ro);
            return etr;
        }
    }
}
