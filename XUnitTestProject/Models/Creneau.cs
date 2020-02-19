using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject.Models
{
    public class Creneau
    {
        private DateTime date;

        private DateTime start;

        private DateTime end;

        public DateTime Start
        {
            get
            {
                return this.start;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
        }

        public DateTime End
        {
            get
            {
                return this.end;
            }
        }

        public Creneau(DateTime date, int duree)
        {
            if (duree <= 0)
                throw new ArgumentException("can't go back in time or have a instant meeting");

            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                throw new ArgumentException("we're closed on weekends");

            this.date = date;
            this.start = date;
            this.end = date.AddHours(duree);
        }

        //Operator overload

        public static bool operator ==(Creneau a, Creneau b)
        {
            return (a.start == b.start && a.end == b.end) ? true: false;
        }

        public static bool operator !=(Creneau a, Creneau b)
        {
            return (a.start != b.start || a.end != b.end) ? true : false;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Creneau))
                return false;

            return Equals((Creneau)obj);
        }

        public bool Equals(Creneau other)
        {
            if (start != other.Start)
                return false;

            return end == other.End;
        }

        public override int GetHashCode()
        {
            return start.GetHashCode() + end.GetHashCode();
        }
    }
}
