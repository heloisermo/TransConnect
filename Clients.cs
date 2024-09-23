using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TransConnect_Stone_Romeo
{
    internal class Clients
    {
        private List<Client> clients;

        public Clients(List<Client> clients)
        {
            this.clients = clients;
        }

        public List<Client> nos_Clients
        {
            get { return this.clients; }
            set { this.clients = value; }
        }


        public static Client ConnecterClient(Clients clients, string mail, string motDePasse)
        {
            foreach (Client client in clients.nos_Clients)
            {
                if (client.Mail==mail && client.Mdp == motDePasse)
                {
                    return client;
                }
            }

            return null;
        }

        public void AjoutClient(Client c)
        {
            this.clients.Add(c);
        }

        public void EnleverClient(Client c) 
        { 
            this.clients.Remove(c);
        }
        

        public void TriAlphabetique()
        {
            //pour chaque duo de clients on va les comparer sur leur nom, et Sort répète l'opération jusqu'à ce que tout soit trié
            this.clients.Sort((client1, client2) => string.Compare(client1.Nom, client2.Nom));
        }

        public void TriVille()
        {
            this.clients.Sort((client1, client2) => string.Compare(client1.Adresse.Ville, client2.Adresse.Ville));
        }

        public void TriAchat()
        {
            this.clients.Sort((client2, client1) => client1.MontantAchats().CompareTo(client2.MontantAchats()));
        }
        

        /// <summary>
        /// Fonction qui permet d'effectuer un tri selon les 3 critères: alphabétique, ville, achat
        /// </summary>
        public void TriSimultane()
        {
            this.clients.Sort((client1, client2) => string.Compare(client1.Nom, client2.Nom));
            this.clients.Sort((client1, client2) => string.Compare(client1.Adresse.Ville, client2.Adresse.Ville));
            this.clients.Sort((client1, client2) => client2.MontantAchats().CompareTo(client1.MontantAchats()));
        }

        /// <summary>
        /// Fonction qui vérifie si l'email d'un nouveau client n'est pas déjà utilisé
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool EmailDejaUtilise(string email)
        {
            return this.clients.Any(c => c.Mail == email);
        }

    }

}

