using System;
using System.Collections.Generic;
using System.Text;
using XUnitTestProject.infrastructure;

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

        private Salle salle;

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

        public Salle Salle
        {
            get
            {
                return salle;
            }
            set
            {
                salle = value;
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

        public Recruteur Recruteur
        {
            get
            {
                return recruteur;
            }
            set
            {
                recruteur = value;
            }
        }

        public Candidat Candidat
        {
            get
            {
                return candidat;
            }
            set
            {
                candidat = value;
            }
        }

        //Constructor

        public Entretien(DateTime date, int duree,
            string nomCand, string specialiteCand, int experiance)
        {
            this.creneau = new Creneau(date, duree);
            this.candidat = new Candidat(nomCand, specialiteCand, experiance);
            this.recruteur = new Recruteur(specialiteCand, date, experiance);
            this.salle = new Salle(date);
            statut = Statut.Planifie;
            guid = Guid.NewGuid();
        }

        // Methods

        public void AjouterRecruteur(Recruteur rec)
        {
            this.recruteur = rec;
        }

        public void AjouterRoom(Salle salle)
        {
            this.salle = salle;
        }

        public void Confirmer()
        {
            statut = Statut.Confirme;
        }

        public void Annuler(string raison)
        {
            if (string.IsNullOrWhiteSpace(raison))
                throw new ArgumentException("La raison ne peut etre vide");
            statut = Statut.Annule;
        }
    }
}
