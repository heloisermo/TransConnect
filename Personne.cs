using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnect_Stone_Romeo
{
    internal class Personne 
    {
        private string nom;
        private string prenom;
        private DateTime date_naissance;
        private int n_ss;
        private Adresse adresse;
        private string adresse_mail;
        private string num_telephone;
        private string mdp;

        public Personne(string nom, string prenom, DateTime date_naissance, int n_ss, Adresse adresse, string adresse_mail, string num_telephone, string mdp)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.date_naissance = date_naissance;
            this.n_ss = n_ss;
            this.adresse = adresse;
            this.adresse_mail = adresse_mail;
            this.num_telephone = num_telephone;
            this.mdp = mdp;
        }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }
        public DateTime Naissance
        {
            get { return this.date_naissance; }
            set { this.date_naissance = value; }
        }

        public int N_ss
        {
            get { return this.n_ss; }
            set { this.n_ss = value; }
        }
         
        public string Mail
        {
            get { return this.adresse_mail; }
            set { this.adresse_mail = value; }
        }

        public string Num
        {
            get { return this.num_telephone; }
            set { this.num_telephone = value; }
        }

        public Adresse Adresse
        {
            get { return this.adresse;}
            set { this.adresse = value;}
        }

        public string Mdp
        {
            get { return this.mdp; }
            set { this.mdp = value; }
        }
        public string Tel
        {
            get { return this.num_telephone; }
            set { this.num_telephone = value; }
        }

    }
}

