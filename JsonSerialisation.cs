using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Newtonsoft.Json.Linq;
using Microsoft.VisualBasic;
using System.ComponentModel.Design;

namespace TransConnect_Stone_Romeo
{
    internal class JsonSerialisation
    {

        /// <summary>
        /// Fonction qui permet de connecter un utilisateur à la plateforme en fonction de son mail et son mot de passe
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="mail"></param>
        /// <param name="motDePasse"></param>
        /// <returns></returns>
        public static T ConnecterUtilisateur<T>(string mail, string motDePasse) where T : class, IUtilisateur
        {

            List<Salarie> salaries = ChargerSalaries();

            // Charger la liste des clients depuis le fichier JSON
            Clients clientsObj = Charger<Clients>("clients.json");
            List<Client> clients = clientsObj.nos_Clients;

            // Vérifier si les informations de connexion correspondent à un salarié
            foreach (Salarie salarie in salaries)
            {
                if (salarie.Mail == mail && salarie.Mdp == motDePasse)
                {
                    // L'utilisateur est un salarié connecté avec succès
                    T utilisateur = salarie as T;
                    if (utilisateur != null)
                    {
                        // Afficher le prénom de l'utilisateur connecté en utilisant la propriété Prenom de l'interface IUtilisateur
                        Console.WriteLine($"Connexion réussie pour l'utilisateur {utilisateur.Prenom}");
                        return utilisateur;
                    }
                }
            }

            // Vérifier si les informations de connexion correspondent à un client
            foreach (Client client in clients)
            {
                if (client.Mail == mail && client.Mdp == motDePasse)
                {
                    // L'utilisateur est un client connecté avec succès
                    T utilisateur = client as T;
                    if (utilisateur != null)
                    {
                        // Afficher le prénom de l'utilisateur connecté en utilisant la propriété Prenom de l'interface IUtilisateur
                        Console.WriteLine($"Connexion réussie pour l'utilisateur {utilisateur.Prenom}");
                        return utilisateur;
                    }
                }
            }

            // Si aucun utilisateur ne correspond aux informations de connexion, retourner null
            return null;
        }

        /// <summary>
        /// Fonction qui permet de charger notre fichier (de n'importe quel type)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cheminFichier"></param>
        /// <returns></returns>
        public static T Charger<T>(string cheminFichier)
        {
            if (!File.Exists(cheminFichier))
            {
                File.Create(cheminFichier).Dispose();
                return default(T);
            }
            string chemin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, cheminFichier);
            string json = File.ReadAllText(chemin);

            return JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// Fonction pour mettre à jour un fichier
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cheminFichier"></param>
        /// <param name="objets"></param>
        public static void Sauvegarder<T>(string cheminFichier, T objets)
        {

            string json = JsonConvert.SerializeObject(objets, Formatting.Indented);
            string chemin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, cheminFichier);
            File.WriteAllText(chemin, json);

        }

        /// <summary>
        /// Fonction qui met à jour un fichier de salaries (fonction différente car les salraries peuvent être chauffeur et la sérialisation est différente)
        /// </summary>
        /// <param name="salaries"></param>
        public static void SauvegarderSalaries(List<Salarie> salaries)
        {
            var json = JsonConvert.SerializeObject(salaries, Formatting.Indented,
            new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

            File.WriteAllText("salaries.json", json);
        }

        /// <summary>
        /// Fonction qui met à jour un chauffeur dans une liste de salariés
        /// </summary>
        /// <param name="chauffeur"></param>
        public static void MAJChauffeurs(Chauffeur chauffeur)
        {
            List<Salarie> salaries = ChargerSalaries();
            for(int i = 0; i < salaries.Count; i++)
            {
                if (salaries[i].Mail == chauffeur.Mail)
                {
                    salaries[i] = chauffeur;
                    break;
                }
            }
            SauvegarderSalaries(salaries);
        }

        /// <summary>
        /// Fonction qui charge les salaries en prenant en compte les objets
        /// </summary>
        /// <returns></returns>
        public static List<Salarie> ChargerSalaries()
        {
            string cheminFichier = "salaries.json";
            if (!File.Exists(cheminFichier))
            {
                File.Create(cheminFichier).Dispose();
                return default(List<Salarie>);
            }
            string chemin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, cheminFichier);

            var readJson = File.ReadAllText(cheminFichier);
            var deserializedSalaries = JsonConvert.DeserializeObject<List<Salarie>>(readJson, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            return deserializedSalaries;
        }

        /*public static void AjouterSalarie(Salarie salarie)
        {
            List<Salarie> salaries = ChargerSalaries();
            if (salaries == null)
            {
                salaries = new List<Salarie>();
            }
            salaries.Add(salarie);
            SauvegarderSalaries(salaries);

        }*/
        public static List<Chauffeur> ChargerChauffeurs()
        {
            List<Salarie> salaries = ChargerSalaries();
            List<Chauffeur> chauffeurs = new List<Chauffeur>();

            foreach (Salarie salarie in salaries)
            {
                if (salarie is Chauffeur chauffeur)
                {
                    chauffeurs.Add(chauffeur);
                }
            }
            return chauffeurs;
        }

        /// <summary>
        /// Fonction qui charge les commandes à partir du fichier de commandes
        /// </summary>
        /// <returns></returns>
        public static List<Commande> ChargerCommandes()
        {
            string cheminFichier = "commandes.json";
            if (!File.Exists(cheminFichier))
            {
                File.Create(cheminFichier).Dispose();
                return default(List<Commande>);
            }
            string chemin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, cheminFichier);

            var readJson = File.ReadAllText(cheminFichier);
            var deserializedCommandes = JsonConvert.DeserializeObject<List<Commande>>(readJson, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            return deserializedCommandes;
        }

        /// <summary>
        /// Fonction qui permet de sauvegarder des commandes a partir de la liste des commandes
        /// </summary>
        /// <param name="commandes"></param>
        public static void SauvegarderCommandes(List<Commande> commandes)
        {
            var json = JsonConvert.SerializeObject(commandes, Formatting.Indented,
            new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

            File.WriteAllText("commandes.json", json);
        }

        /// <summary>
        ///  Fonction qui permet de mettre à jour une commande et la modifier dans notre fichier de commandes
        /// </summary>
        /// <param name="commande"></param>
        public static void MAJCommandes(Commande commande)
        {
            List<Commande> commandes = ChargerCommandes();
            if (commandes == null)
            {
                commandes = new List<Commande>();
            }
            commandes.Add(commande);
            SauvegarderCommandes(commandes);

        }

        /// <summary>
        /// Fonction qui charge les commandes d'un client 
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static List<Commande> ChargerCommandes(Client client)
        {
            List<Commande> commandes = ChargerCommandes();
            List<Commande> commandesClient = new List<Commande>();
            if(commandes == null)
            {
                return commandesClient;
            }
            foreach (Commande commande in commandes)
            {
                if (commande.Client.Mail == client.Mail)
                {
                    commandesClient.Add(commande);
                }
            }
            return commandesClient; 
        }

    }

}

