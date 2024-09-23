using System;
using System.Collections.Generic;
using System.IO;

namespace TransConnect_Stone_Romeo
{
    public class Graphe
    {
        Dictionary<string, Dictionary<string, int>> liste_adjacence = new Dictionary<string, Dictionary<string, int>>();

        public Graphe(string fichier)
        {
            using (StreamReader reader = new StreamReader(fichier))
            {
                string ligne;
                while ((ligne = reader.ReadLine()) != null)
                {
                    string[] parties = ligne.Split(';');
                    string dep = parties[0];
                    string dest = parties[1];
                    int distance = int.Parse(parties[2]);
                    AjouteArrete(dep, dest, distance);
                }
            }
        }

        /// <summary>
        /// Ajoute une arrete contenant un depart (dep), une destination (dest) et une distance.
        /// Cette arrete est ajoutée dans les deux sens, (dep->dest) mais aussi (dest->dep).
        /// </summary>
        /// <param name="dep"></param>
        /// <param name="dest"></param>
        /// <param name="distance"></param>

        public void AjouteArrete(string dep, string dest, int distance)
        {
            if (!liste_adjacence.ContainsKey(dep))
                liste_adjacence[dep] = new Dictionary<string, int>();

            liste_adjacence[dep][dest] = distance;


            if (!liste_adjacence.ContainsKey(dest))
                liste_adjacence[dest] = new Dictionary<string, int>();

            liste_adjacence[dest][dep] = distance;
        }

        /// <summary>
        /// Cette fonction applique l'algorithme de Dijkstra pour deux villes en utilisant la liste d'adjacence
        /// </summary>
        /// <param name="dep"></param>
        /// <param name="dest"></param>
        /// <returns>Une liste chainée représentant le chemin et la distance totale du parcours.</returns>
        public (LinkedList<string> chemin, int distance) Dijkstra(string dep, string dest)
        {
            Dictionary<string, int> dist = new Dictionary<string, int>();
            Dictionary<string, string> preced = new Dictionary<string, string>();
            Dictionary<string, bool> visite = new Dictionary<string, bool>();

            foreach (string sommet in liste_adjacence.Keys)
            {
                dist[sommet] = int.MaxValue;
                preced[sommet] = null;
                visite[sommet] = false;
            }

            dist[dep] = 0;

            for (int i = 0; i < liste_adjacence.Keys.Count - 1; i++)
            {
                string u = DistanceMin(dist, visite);
                visite[u] = true;

                foreach (string v in liste_adjacence[u].Keys)
                {
                    if (!visite[v] && dist[u] != int.MaxValue && dist[u] + liste_adjacence[u][v] < dist[v])
                    {
                        dist[v] = dist[u] + liste_adjacence[u][v];
                        preced[v] = u;
                    }
                }
            }

            LinkedList<string> chemin = new LinkedList<string>();
            string courant = dest;
            while (courant != null)
            {
                chemin.AddFirst(courant);
                courant = preced[courant];
            }

            return (chemin, dist[dest]);
        }

        /// <summary>
        /// Renvoie le sommet ayant la plus petite distance parmi les sommets non visités
        /// </summary>
        /// <param name="dist"></param>
        /// <param name="visite"></param>
        /// <returns></returns>
        private string DistanceMin(Dictionary<string, int> dist, Dictionary<string, bool> visite)
        {
            string min = null;
            int valeurMin = int.MaxValue;

            foreach (string sommet in dist.Keys)
            {
                if (!visite[sommet] && dist[sommet] <= valeurMin)
                {
                    min = sommet;
                    valeurMin = dist[sommet];
                }
            }

            return min;
        }
    }

}
