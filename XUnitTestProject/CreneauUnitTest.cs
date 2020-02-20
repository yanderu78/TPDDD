using System;
using Xunit;
using XUnitTestProject.Models;

namespace XUnitTestProject
{
    public class CreneauUnitTest
    {
        private readonly Creneau crn;

        public CreneauUnitTest()
        {
            string dateInput = "Jan 1, 2009";
            DateTime parsedDate = DateTime.Parse(dateInput);
            var etr = new Entretien(parsedDate, 3, "jean Bono", "Java", 4);
            crn = etr.Creneau;
        }

        [Fact]
        public void TestWrongDate()
        {
            string dateInput = "Jan 2, 2009";
            DateTime parsedDate = DateTime.Parse(dateInput);
            Creneau Crn = new Creneau(parsedDate, 3);

            var result = crn.Equals(Crn);

            Assert.False(result, "Different date");
        }

        [Fact]
        public void TestWrongDuration()
        {
            string dateInput = "Jan 1, 2009";
            DateTime parsedDate = DateTime.Parse(dateInput);
            Creneau Crn = new Creneau(parsedDate, 1);

            var result = (crn == Crn);

            Assert.False(result, "Different duration");
        }

        [Fact]
        public void TestIdentical()
        {
            string dateInput = "Jan 1, 2009";
            DateTime parsedDate = DateTime.Parse(dateInput);
            Creneau Crn = new Creneau(parsedDate, 3);

            var result = crn.Equals(Crn);

            Assert.True(result, "Is Good");
        }

        [Fact]
        public void TestHashcodeTrue()
        {
            string dateInput = "Jan 1, 2009";
            DateTime parsedDate = DateTime.Parse(dateInput);
            Creneau Crn = new Creneau(parsedDate, 3);

            Assert.Equal(crn.GetHashCode(), Crn.GetHashCode());
        }

        [Fact]
        public void TestHashcodeFalse()
        {
            string dateInput = "Jan 1, 2009";
            DateTime parsedDate = DateTime.Parse(dateInput);
            Creneau Crn = new Creneau(parsedDate, 1);

            Assert.NotEqual(crn.GetHashCode(), Crn.GetHashCode());
        }

        [Fact]
        public void TestWrongObject()
        {
            string dateInput = "Jan 1, 2009";
            var parsedDate = DateTime.Parse(dateInput);

            var result = crn.Equals(parsedDate);

            Assert.False(result, "Is False");
        }

        [Fact]
        public void TestDifferent()
        {
            string dateInput = "Jan 1, 2009";
            var parsedDate = DateTime.Parse(dateInput);
            Creneau Crn = new Creneau(parsedDate, 10);

            var result = crn != Crn;

            Assert.True(result, "Is False");
        }

        [Fact]
        public void TestNegatifDuration()
        {
            string dateInput = "Jan 1, 2009";
            var parsedDate = DateTime.Parse(dateInput);

            Assert.Throws<ArgumentException>(() => new Creneau(parsedDate, -10));
        }

        [Fact]
        public void TestWeekend()
        {
            string dateInput = "Jan 5, 2020";
            var parsedDate = DateTime.Parse(dateInput);

            Assert.Throws<ArgumentException>(() => new Creneau(parsedDate, 10));
        }
    }
}
