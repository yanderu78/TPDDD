using System;
using Xunit;
using XUnitTestProject.infrastructure;
using XUnitTestProject.Models;
using XUnitTestProject.use_case;

namespace XUnitTestProject
{
    public class PlanifierUnitTest
    {
        [Fact]
        public void TestPlanOK()
        {
            AccessDB.etr = null;
            PlanifierEntretien.PlanifEntretien(DateTime.Parse("Jan 1, 2019"), 3, "jean Candi", "Java", 4);
            Assert.NotNull(AccessDB.etr);
        }

        [Fact]
        public void TestPlanOKAndConfirmed()
        {
            AccessDB.etr = null;
            PlanifierEntretien.PlanifEntretien(DateTime.Parse("Jan 1, 2019"), 3, "jean Candi", "Java", 4);
            ConfirmerEntretien.ConfirmEntretien();
            Assert.Equal(Statut.Confirme, AccessDB.etr.Statut);
        }

        [Fact]
        public void TestPlanOKAndCanceled()
        {
            AccessDB.etr = null;
            PlanifierEntretien.PlanifEntretien(DateTime.Parse("Jan 1, 2019"), 3, "jean Candi", "Java", 4);
            AnnulerEntretien.AnnulEntretien("changement d'avis");
            Assert.Equal(Statut.Annule, AccessDB.etr.Statut);
        }

        [Fact]
        public void TestPlanOKAndCanceledFail()
        {
            AccessDB.etr = null;
            PlanifierEntretien.PlanifEntretien(DateTime.Parse("Jan 1, 2019"), 3, "jean Candi", "Java", 4);
            Assert.Throws<ArgumentException>(() => AnnulerEntretien.AnnulEntretien(""));
        }

        [Fact]
        public void TestFailSpecialty()
        {
            AccessDB.etr = null;
            Assert.Throws<Exception>(() => PlanifierEntretien.PlanifEntretien(
                DateTime.Parse("Jan 1, 2019"), 3, "jean Candi", "Curling", 4));
        }

        [Fact]
        public void TestFailExperiance()
        {
            AccessDB.etr = null;
            Assert.Throws<Exception>(() => PlanifierEntretien.PlanifEntretien(
                DateTime.Parse("Jan 3, 2019"), 3, "jean Candi", ".NET", 12));
        }

        [Fact]
        public void TestFailRoom()
        {
            AccessDB.etr = null;
            Assert.Throws<Exception>(() => PlanifierEntretien.PlanifEntretien(
                DateTime.Parse("Jan 4, 2019"), 3, "jean Candi", "Agile", 2));
        }
    }
}
