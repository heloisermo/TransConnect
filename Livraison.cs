using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnect_Stone_Romeo
{

    internal class Livraison
    {
        string ville_depart;
        string ville_arrivee;
        DateTime date_de_livraion;
        string etat;

        Trajet trajet;

        public Livraison(string ville_depart, string ville_arrivee, DateTime date_de_livraion)
        {
            this.ville_depart = ville_depart;
            this.ville_arrivee = ville_arrivee;
            this.date_de_livraion = date_de_livraion;
            Graphe graphe = new Graphe("Distances.csv");
            this.trajet = new Trajet(graphe.Dijkstra(ville_depart, ville_arrivee).chemin, graphe.Dijkstra(ville_depart, ville_arrivee).distance);


        }
        public string Ville_depart
        {
            get { return this.ville_depart; }
        }
        public string Ville_arrivee
        {
            get { return this.ville_arrivee; }
        }
        public DateTime Date_de_livraion
        {
            get { return this.date_de_livraion; }
        }
        public Trajet Trajet
        {
            get { return this.trajet; }
        }


    }
    internal class Trajet
    {
        LinkedList<string> villes;
        int distance;

        float duree;
        public Trajet(LinkedList<string> villes, int distance)
        {
            this.villes = villes;
            this.distance = distance;
            this.duree = CalculerDuree(villes);
        }

        /// <summary>
        /// Fonction qui va chercher la durée de trajet entre deux villes à partir de sa valeur dans le fichier Distances.csv
        /// </summary>
        /// <returns>Un dictionnaire composé d'une liste de deux villes et de la durée pour relier les deux</returns>
        public static Dictionary<List<string>, TimeSpan> GetDurees()
        {
            Dictionary<List<string>, TimeSpan> durees = new Dictionary<List<string>, TimeSpan>();

            using (StreamReader sr = new StreamReader("Distances.csv"))
            {
                string ligne;
                while ((ligne = sr.ReadLine()) != null)
                {
                    string[] parties = ligne.Split(';');
                    if (parties.Length == 4)
                    {
                        string villeDepart = parties[0].Trim();
                        string villeArrivee = parties[1].Trim();
                        TimeSpan duree = ParseDuree(parties[3]);
                        List<string> villes = new List<string> { villeDepart, villeArrivee };

                        durees[villes] = duree;
                    }
                }
            }

            return durees;
        }

        /// <summary>
        /// Transforme la colonne durée du fichier csv en un TimeSpan
        /// </summary>
        /// <param name="dureeStr"></param>
        /// <returns>La durée au format TimeSpan</returns>
        public static TimeSpan ParseDuree(string dureeStr)
        {
            string[] parties = dureeStr.Split('h');
            int heures = int.Parse(parties[0]);
            int minutes = 0;
            if (parties.Length > 1)
            {
                minutes = int.Parse(parties[1].Replace("mn", "").Trim());
            }
            return new TimeSpan(heures, minutes, 0);
        }

        /// <summary>
        /// Cette fonction parcourt les villes d'un trajet et additionne les durées entre chaque ville pour obtenir la durée totale du trajet
        /// </summary>
        /// <param name="villes"></param>
        /// <returns>La durée d'un trajet</returns>
        public float CalculerDuree(LinkedList<string> villes)
        {
            float duree = 0;
            Dictionary<List<string>, TimeSpan> durees = GetDurees();
            for (int i = 0; i < villes.Count - 1; i++)
            {
                List<string> villesTrajet = new List<string> { villes.ElementAt(i), villes.ElementAt(i + 1) };
                foreach(List<string> villesDuree in durees.Keys)
                {
                    if (villesDuree.SequenceEqual(villesTrajet))
                    {
                        duree += (float)durees[villesDuree].TotalMinutes;
                    }
                }
            }

            return duree / 60;
        }
        public LinkedList<string> Villes
        {
            get { return this.villes; }
        }

        public int Distance
        {
            get { return this.distance; }
        }
        public float Duree
        {
            get { return CalculerDuree(Villes); }
        }
    }

}
