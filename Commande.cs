using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnect_Stone_Romeo
{

    internal class Commande
    {
        private Client client;
        private Livraison livraison;
        private float prix;
        private Vehicule vehicule;
        private Chauffeur chauffeur;
        private DateTime date;

        private string etat;
        public Commande(Client client, Livraison livraison, Vehicule vehicule, Chauffeur chauffeur, DateTime date, string etat)

        {
            this.client = client;
            this.livraison = livraison;
            this.vehicule = vehicule;
            this.chauffeur = chauffeur;
            this.date = DateTime.Now;
            this.etat = etat;

        }

        public Client Client
        {
            get { return this.client; }
            set { this.client = value; }
        }
        public Livraison Livraison
        {
            get { return this.livraison; }
            set { this.livraison = value; }
        }
        public float Prix
        {
            get { return this.CalculerPrix(); }
            set { this.prix = value; }
        }
        public Vehicule Vehicule
        {
            get { return this.vehicule; }
            set { this.vehicule = value; }
        }
        public Chauffeur Chauffeur
        {
            get { return this.chauffeur; }
            set { this.chauffeur = value; }
        }
        public DateTime Date
        {
            get { return this.date; }
        }
        public string Etat
        {get 
            { return this.etat;}
            set { this.etat = value; }
        }

        public void ModifierCommande(Client client, Livraison livraison, int prix, Vehicule vehicule, Chauffeur chauffeur, string etat)
        {
            this.Client = client;
            this.Livraison = livraison;
            this.Prix = prix;
            this.Vehicule = vehicule;
            this.Chauffeur = chauffeur;
            this.Etat = etat;
        }

        public void Payee()
        {
            this.Etat = "payée";

        }
        public void EnLivraison()
        {
            this.Etat = "en livraison";
        }
        public void Livree()
        {
            this.Etat = "livrée";

        }


        /// <summary>
        /// Fonction qui calcule le prix d'une commande en fonction du chauffeur, de la durée, du véhicule, de la distance
        /// </summary>
        /// <returns></returns>
        public float CalculerPrix()
        {
            return this.livraison.Trajet.Distance * this.vehicule.Prix_100km + this.chauffeur.Tarif() * this.livraison.Trajet.Duree;
        }


        /// <summary>
        /// Fonction qui renvoie une liste de commandes ayant lieu sur une periode donnée
        /// </summary>
        /// <param name="debut"></param>
        /// <param name="fin"></param>
        /// <param name="commandes"></param>
        /// <returns></returns>
        public static List<Commande> CommandesEntreDeuxDates(DateTime debut, DateTime fin, List<Commande>commandes)
        {
            List<Commande> commandesEntreDeuxDates = new List<Commande>();
            foreach (Commande commande in commandes)
            {
                if (commande.Date >= debut && commande.Date <= fin)
                {
                    commandesEntreDeuxDates.Add(commande);
                }
            }
            return commandesEntreDeuxDates;
        }


        /// <summary>
        /// Fonction qui calcule le montant moyen d'un client
        /// </summary>
        /// <param name="commandes"></param>
        /// <returns></returns>
        public static float MontantMoyenCompteClient(List<Commande> commandes)
        {
            float total = 0;
            List<Client> clients = new List<Client>();
            foreach (Commande commande in commandes)
            {
                if (!clients.Contains(commande.Client))
                {
                    clients.Add(commande.Client);
                    total += commande.Client.MontantAchats();
                }
            }
            return (int)total / clients.Count;
        }


        /// <summary>
        /// Fonction qui permet de calculer le prix moyen d'une commande
        /// </summary>
        /// <param name="commandes"></param>
        /// <returns></returns>
        public static float MoyenneMontantCommandes(List<Commande>commandes)
        {
            float total = 0;
            foreach (Commande commande in commandes)
            {
                total += commande.Prix;
            }
            return total / commandes.Count;
        }
    }
}
