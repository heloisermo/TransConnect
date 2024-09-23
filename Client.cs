using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnect_Stone_Romeo
{
    internal class Client : Personne, IUtilisateur
    {
        public Client(string nom, string prenom, DateTime naissance,
        int nss, Adresse adresse, string mail, string tel,string mdp) : base(nom, prenom, naissance, nss, adresse, mail, tel,mdp)
        {
        }
        public List<Commande> Commandes()
        {
            return JsonSerialisation.ChargerCommandes(this);
        }

        /// <summary>
        /// Fonction qui renvoie le montant total des achats d'un client
        /// </summary>
        /// <returns></returns>
        public float MontantAchats()
        {
            float montant = 0;
            List<Commande> commandes = this.Commandes();
            foreach (Commande commande in commandes)
            {
                montant += commande.Prix;
            }
            return  montant;
        }

        /// <summary>
        /// Fonction qui calcule la fidelité d'un client en fonction du montant des achats d'un client
        /// </summary>
        /// <returns></returns>
        public string Fidelite()
        {
            if (this.MontantAchats() < 100)
            {
                return "carton";
            }else
            if (this.MontantAchats() >= 100)
            {
                return "bronze";
            }else
            if (this.MontantAchats() >= 200)
            {
                return "argent";
            }
            else
            {
                return "or";
            }
        }


        public void ModifierClient(string nom, string prenom, DateTime naissance, int nss, Adresse adresse, string mail, string tel, string mdp)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Naissance = naissance;
            this.N_ss = nss;
            this.Adresse = adresse;
            this.Mail = mail;
            this.Tel = tel;
            this.Mdp = mdp;
        }

    }
}

