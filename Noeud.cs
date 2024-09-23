using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnect_Stone_Romeo
{
    public class Noeud<T>
    {
        private Noeud<T> suivant;
        private T valeur;

        public Noeud(T valeur)
        {
            this.valeur = valeur;
            this.suivant = null;
        }

        public Noeud(T valeur, Noeud<T> suivant)
        {
            this.valeur = valeur;
            this.suivant = suivant;
        }

        public Noeud<T> Suivant
        {
            get { return this.suivant; }
            set { this.suivant = value; }
        }

        public T Valeur
        {
            get { return this.valeur; }
            set { this.valeur = value; }
        }


    }

    public class Linkedist<T> where T : IComparable<T>
    {
        private Noeud<T> tete;

        public Linkedist()
        {
            this.tete = null;
        }

        public void Ajouter(T valeur)
        {
            Noeud<T> nouveau = new Noeud<T>(valeur);
            if (this.tete == null)
            {
                this.tete = nouveau;
            }
            else
            {
                Noeud<T> courant = this.tete;
                while (courant.Suivant != null)
                {
                    courant = courant.Suivant;
                }
                courant.Suivant = nouveau;
            }
        }

        public void Sort()
        {
            Noeud<T> courant = this.tete;
            while (courant != null)
            {
                Noeud<T> suivant = courant.Suivant;
                while (suivant != null)
                {
                    if (courant.Valeur.CompareTo(suivant.Valeur) > 0)
                    {
                        T temp = courant.Valeur;
                        courant.Valeur = suivant.Valeur;
                        suivant.Valeur = temp;
                    }
                    suivant = suivant.Suivant;
                }
                courant = courant.Suivant;
            }
        }

        public List<T> FindAll(Predicate<T> match)
        {
            List<T> result = new List<T>();
            Noeud<T> courant = this.tete;
            while (courant != null)
            {
                if (match(courant.Valeur))
                {
                    result.Add(courant.Valeur);
                }
                courant = courant.Suivant;
            }
            return result;
        }
    }
}
