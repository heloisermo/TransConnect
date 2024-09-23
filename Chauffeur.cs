using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnect_Stone_Romeo
{
    internal class Chauffeur : Salarie
    {
        private List<DateTime> agenda;
        private string anciennete;
        private string ville_actuelle;

        private List<Livraison> livraisons;
        [JsonConstructor]
        public Chauffeur(string nom, string prenom, DateTime naissance, int nss, Adresse adresse, string mail, string tel,
            string mdp, string poste, double salaire) : base(nom, prenom, naissance,
                nss, adresse, mail, tel, mdp, poste, salaire)
        {
            this.agenda = new List<DateTime>();
            this.anciennete = this.CalculAnciennete();
            this.ville_actuelle = "Paris";
            this.livraisons = new List<Livraison>();
        }
        public List<DateTime> Agenda
        {
            get { return this.agenda; }
            set { this.agenda = value; }
        }
        public string Anciennete
        {
            get { return this.anciennete; }
            set { this.anciennete = value; }
        }

        public string Ville_actuelle
        {
            get { return this.ville_actuelle; }
            set { this.ville_actuelle = value; }
        }
        public List<Livraison> Livraisons
        {
            get { return this.livraisons; }
            set { this.livraisons = value; }
        }

        public void MiseAJourAgenda(DateTime date)
        {
            if (Agenda.All(d => date.Date != d.Date))
            {
                Agenda.Add(date);
            }
        }

        /// <summary>
        /// Fonction qui renvoie si un chauffeur est disponible ou non à une date donnée
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public bool Disponible(DateTime date)
        {
            return Agenda.All(d => date.Date != d.Date);
        }

        /// <summary>
        /// Fonction qui selectionne un chauffeur pour une livraison en fonction de sa disponibilité; elle met à jour l'agenda du chauffeur et ajoute la livraison à sa liste de livraisons
        /// </summary>
        /// <param name="chauffeurs"></param>
        /// <param name="livraison"></param>
        /// <returns></returns>
        public static Chauffeur SelectionnerChauffeur(List<Chauffeur> chauffeurs, Livraison livraison)
        {
            Chauffeur chauffeur = null;
            foreach (Chauffeur c in chauffeurs)
            {
                if (c.Disponible(livraison.Date_de_livraion))
                {
                    if (chauffeur == null)
                    {
                        chauffeur = c;
                    }
                    else
                    {
                        Graphe graphe = new Graphe("Distances.csv");
                        if (graphe.Dijkstra(c.Ville_actuelle, livraison.Ville_depart).distance < graphe.Dijkstra(chauffeur.Ville_actuelle, livraison.Ville_depart).distance)
                        {
                            chauffeur = c;
                        }
                    }
                }
            }
            if (chauffeur == null)
            {
                MessageBox.Show("Aucun chauffeur disponible pour cette date");
            }
            else
            {
                chauffeur.MiseAJourAgenda(livraison.Date_de_livraion);
                chauffeur.Livraisons.Add(livraison);
            }


            return chauffeur;
        }
 

        /// <summary>
        /// fonction qui calcule le tarif d'un chauffeur en fonction de son ancienneté
        /// </summary>
        /// <returns></returns>
        public int Tarif()
        {
            switch (this.anciennete)
            {
                case "Junior":
                    return 10;
                case "Senior":
                    return 15;
                case "Expert":
                    return 20;
                default:
                    return 10;
            }
        }

        /// <summary>
        /// Fonction qui calcule l'ancienneté d'un chauffeur en fonction du temps depuis lequel il travaille dans l'entreprise
        /// </summary>
        /// <returns></returns>
        public string CalculAnciennete()
        {
            if (DateTime.Now.Year - this.Entree.Year <= 1)
            {
                return "junior";
            }
            if (DateTime.Now.Year - this.Entree.Year <= 5)
            {
                return "senior";
            }
            else
            {
                return "expert";
            }
        }

    }
}
