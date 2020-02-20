using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject.Models
{
    public class Creneau
    {
        private DateTime date;

        private DateTime debut;

        private DateTime fin;

        public DateTime Debut
        {
            get
            {
                return this.debut;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
        }

        public DateTime Fin
        {
            get
            {
                return this.fin;
            }
        }

        public Creneau(DateTime date, int duree)
        {
            if (duree <= 0)
                throw new ArgumentException("Impossible d'avoir une durée negative");

            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                throw new ArgumentException("Fermé pendant les week ends");

            this.date = date;
            this.debut = date;
            this.fin = date.AddHours(duree);
        }

        //Operator overload

        public static bool operator ==(Creneau a, Creneau b)
        {
            return (a.debut == b.debut && a.fin == b.fin) ? true: false;
        }

        public static bool operator !=(Creneau a, Creneau b)
        {
            return (a.debut != b.debut || a.fin != b.fin) ? true : false;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Creneau))
                return false;

            return Equals((Creneau)obj);
        }

        public bool Equals(Creneau autre)
        {
            if (debut != autre.Debut)
                return false;

            return fin == autre.Fin;
        }

        public override int GetHashCode()
        {
            return debut.GetHashCode() + fin.GetHashCode();
        }
    }
}
