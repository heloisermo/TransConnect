using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace TransConnect_Stone_Romeo
{
    internal class Salarie : Personne, IUtilisateur
    {
        private DateTime date_entree;
        private string poste;
        private double salaire;
        private List<Salarie> subordonnes;

        public Salarie(string nom, string prenom, DateTime naissance, int nss, Adresse adresse, string mail, string tel, string mdp, 
            string poste, double salaire):base(nom, prenom, naissance, nss, adresse, mail, tel, mdp)

        {
            this.date_entree = DateTime.Now;
            this.poste = poste;
            this.salaire = salaire;
            this.subordonnes = new List<Salarie>();
        }
        public DateTime Entree
        {
            get { return this.date_entree; }
        }

        public string Poste
        {
            get { return this.poste; }
            set { this.poste = value; }
        }
        public double Salaire
        {
            get { return this.salaire; }
            set { this.salaire = value; }
        }
        public List<Salarie> Subordonnes 
        {
            get { return this.subordonnes; }
            set { this.subordonnes = value; }
        }

        /// <summary>
        /// Fonction qui permet d'embaucher un salarie et de l'ajouter à la liste de l'ensemble des salariés
        /// </summary>
        /// <param name="salarie"></param>
        /// <param name="salaries"></param>
        public List<Salarie> Embaucher(Salarie salarie, List<Salarie> salaries)
        {
            this.Subordonnes.Add(salarie);
            for (int i = 0; i < salaries.Count; i++)
            {
                if (salaries[i].Mail == this.Mail)
                {
                    salaries[i].Subordonnes.Add(salarie);
                }
            }
            salaries.Add(salarie);
            return salaries;
        }


        /// <summary>
        /// Fonction qui permet de licencier un salarié et de l'enlever de la liste de l'ensemble des salariés
        /// </summary>
        /// <param name="licencie"></param>
        /// <param name="salaries"></param>
        public void Licencier(Salarie licencie, List<Salarie> salaries)
        {
            // Retirer le salarie de la liste
            salaries.RemoveAll(s => s.Mail == licencie.Mail);
            this.Subordonnes.Remove(licencie);
            // Retirer le salarie des subordonnes des salaries
            foreach (Salarie salarie in salaries)
            {
                salarie.Subordonnes.RemoveAll(s => s.Mail == licencie.Mail);
            }

            // Deplacer les salaries de la personne licenciee à son chef (json)
            foreach (Salarie salarie in salaries)
            {
                if (salarie.Mail == this.Mail)
                {
                    foreach (Salarie subordonne in licencie.Subordonnes)
                    {
                        salarie.Subordonnes.Add(subordonne);
                    }
                    break;
                }
            }

            // Deplacer les salaries de la personne licenciee à son chef (this)
            foreach (Salarie subordonne in licencie.Subordonnes)
            {
                this.Subordonnes.Add(subordonne);
            }

            licencie.Subordonnes.Clear();

            
        }

        
    }
}
