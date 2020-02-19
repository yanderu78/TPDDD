﻿using System;
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
            string nameCand, string specialtyCand, int experiance)
        {
            this.creneau = new Creneau(date, duree);
            this.candidat = new Candidat(nameCand, specialtyCand, experiance);
            statut = Statut.Planifie;
            guid = Guid.NewGuid();
        }

        // Methods

        public void AjouterRecruteur(string nameRecr, string specialtyRecr)
        {
            this.recruteur = new Recruteur(nameRecr, specialtyRecr);
        }

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
