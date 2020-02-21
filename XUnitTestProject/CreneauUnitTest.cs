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
            var etr = new Entretien(DateTime.Parse("Jan 1, 2019"), 3, "jean Bono", "Java", 4);
            crn = etr.Creneau;
        }

        [Fact]
        public void TestWrongDate()
        {
            Creneau Crn = new Creneau(DateTime.Parse("Jan 2, 2019"), 3);

            var result = crn.Equals(Crn);

            Assert.False(result, "Different date");
        }

        [Fact]
        public void TestWrongDuration()
        {
            Creneau Crn = new Creneau(DateTime.Parse("Jan 1, 2019"), 1);

            var result = (crn == Crn);

            Assert.False(result, "Different duration");
        }

        [Fact]
        public void TestIdentical()
        {
            Creneau Crn = new Creneau(DateTime.Parse("Jan 1, 2019"), 3);

            var result = crn.Equals(Crn);

            Assert.True(result, "Is Good");
        }

        [Fact]
        public void TestHashcodeTrue()
        {
            Creneau Crn = new Creneau(DateTime.Parse("Jan 1, 2019"), 3);

            Assert.Equal(crn.GetHashCode(), Crn.GetHashCode());
        }

        [Fact]
        public void TestHashcodeFalse()
        {
            Creneau Crn = new Creneau(DateTime.Parse("Jan 1, 2019"), 1);

            Assert.NotEqual(crn.GetHashCode(), Crn.GetHashCode());
        }

        [Fact]
        public void TestWrongObject()
        {
            var result = crn.Equals(DateTime.Parse("Jan 1, 2019"));

            Assert.False(result, "Is False");
        }

        [Fact]
        public void TestDifferent()
        {
            Creneau Crn = new Creneau(DateTime.Parse("Jan 1, 2019"), 10);

            var result = crn != Crn;

            Assert.True(result, "Is False");
        }

        [Fact]
        public void TestNegatifDuration()
        {
            Assert.Throws<ArgumentException>(() => new Creneau(DateTime.Parse("Jan 1, 2019"), -10));
        }

        [Fact]
        public void TestWeekend()
        {
            Assert.Throws<ArgumentException>(() => new Creneau(DateTime.Parse("Jan 5, 2020"), 10));
        }
    }
}
