using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject.Models
{

    public enum Statut { Annule = -1, Planifie = 0, Confirme = 1 };

    public class Entretien
    {
        // Attributes

        private Statut statut;

        private Creneau creneau;

        private Candidat candidat;

        private Recruteur recruteur;

        private Guid guid;

        public Statut Statut
        {
            get
            {
                return statut;
            }
        }

        public Guid guID
        {
            get
            {
                return guid;
            }
        }

        public Creneau Creneau
        {
            get
            {
                return creneau;
            }
            set
            {
                creneau = value;
            }
        }

        //Constructor

        public Entretien(Creneau creneau)
        {
            this.creneau = creneau;
            statut = Statut.Planifie;
            guid = Guid.NewGuid();
        }

        // Methods

        public void Confirmer()
        {
            statut = Statut.Confirme;
        }

        public void Annuler(string raison)
        {
            if (string.IsNullOrWhiteSpace(raison))
                throw new ArgumentException("Raison can't be a empty string");
            statut = Statut.Annule;
        }
    }
}
