using System;
using System.Collections.Generic;
using System.Text;
using XUnitTestProject.Common.DTO;
using XUnitTestProject.Models;

namespace XUnitTestProject.infrastructure
{
    public static class AccessDB
    {
        public static Entretien etr;

        public static List<RecruteurDTO> AllRecruteurs = new List<RecruteurDTO>() {
            new RecruteurDTO("Jean Reno", "Java", DateTime.Parse("Jan 1, 2019"), 2),
            new RecruteurDTO("Jean Baptiste", "Java", DateTime.Parse("Jan 1, 2019"), 8),
            new RecruteurDTO("Maurice Gringan", ".NET", DateTime.Parse("Jan 3, 2019"), 5),
            new RecruteurDTO("Jeane Dupont", "Agile", DateTime.Parse("Jan 4, 2019"), 4)
        };

        public static List<SalleDTO> AllRooms = new List<SalleDTO>() {
            new SalleDTO("Paris, 8 rue bastion, salle 12", 8, DateTime.Parse("Jan 1, 2019")),
            new SalleDTO("Lyon, 4 rue jean, salle 2", 4, DateTime.Parse("Jan 2, 2019")),
            new SalleDTO("Marseille, 1 avenue sarte, salle 208", 2, DateTime.Parse("Jan 3, 2019")),
            new SalleDTO("Orleans, 2 rue baptiste, salle 4", 5, DateTime.Parse("Jan 6, 2019"))
        };
    }
}
