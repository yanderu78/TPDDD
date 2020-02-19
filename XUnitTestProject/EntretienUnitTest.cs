using System;
using Xunit;
using XUnitTestProject.Models;

namespace XUnitTestProject
{
    public class EntretienUnitTest
    {
        private readonly Entretien etr;

        public EntretienUnitTest()
        {
            string dateInput = "Jan 1, 2009";
            DateTime parsedDate = DateTime.Parse(dateInput);
            etr = new Entretien(parsedDate, 3, "jean Bono", "Java", 4);
        }       

        [Fact]
        public void TestNoReason()
        {
            Assert.Throws<ArgumentException>(() => etr.Annuler(""));
        }

        [Fact]
        public void TestAnulation()
        {
            etr.Annuler("je refuse");
            Assert.Equal(Statut.Annule, etr.Statut);
        }

        [Fact]
        public void TestConfirmation()
        {
            etr.Confirmer();
            Assert.Equal(Statut.Confirme, etr.Statut);
        }

        [Fact]
        public void TestUniqueGuid()
        {
            string dateInput = "Jan 1, 2009";
            DateTime parsedDate = DateTime.Parse(dateInput);
            var Etr = new Entretien(parsedDate, 3, "jean Bono", "Java", 4);
            Assert.NotEqual(etr.guID, Etr.guID);
        }
    }
}
