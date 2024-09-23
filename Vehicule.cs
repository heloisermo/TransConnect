using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TransConnect_Stone_Romeo
{
    [JsonDerivedType(typeof(Voiture))]
    [JsonDerivedType(typeof(Camionnette))]
    [JsonDerivedType(typeof(Citerne))]
    [JsonDerivedType(typeof(Benne))]
    [JsonDerivedType(typeof(Frigorifique))]
    public abstract class Vehicule
    {
        protected int prix_100km;

        public Vehicule(int prix_100km)

        {
            this.prix_100km = prix_100km;
        }
        public int Prix_100km
        {
            get { return this.prix_100km; }
        }
    }

 

    public class Voiture : Vehicule
    {
        int nb_passagers;
        public Voiture(int nb_passagers) : base(10 + nb_passagers * 2)
        {
            this.nb_passagers = nb_passagers;
        }
        public int Nb_passagers
        {
            get { return this.nb_passagers; }
        }
    }

    public class Camionnette : Vehicule
    {
        string usage;
        public Camionnette(string usage) : base(25)
        {
            this.usage = usage;
        }
        public string Usage
        {
            get { return this.usage; }
        }
    }

    public abstract class Camion : Vehicule
    {
        int volume;
        string matiere;
        public Camion(int volume, string matiere) : base(40)
        {
            this.volume = volume;
            this.matiere = matiere;
        }
        public int Volume
        {
            get { return this.volume; }
        }
        public string Matiere
        {
            get { return this.matiere; }
        }
    }

    public class Citerne : Camion
    {
        public Citerne(int volume, string matiere) : base(volume, matiere)
        {
            this.prix_100km = 40 + volume * 10;
        }
    }

    public class Benne : Camion
    {
        int nb_bennes;
        bool grue;
        public Benne(int volume, string matiere, int nb_bennes, bool grue) : base(volume, matiere)
        {
            this.nb_bennes = nb_bennes;
            this.grue = grue;
            this.prix_100km = 40 + nb_bennes * 10 + (grue ? 10 : 0);
        }
        public int Nb_bennes
        {
            get { return this.nb_bennes; }
        }
        public bool Grue
        {
            get { return this.grue; }
        }
    }

    public class Frigorifique : Camion
    {
        int nb_groupe_elec;
        public Frigorifique(int volume, string matiere, int nb_groupe_elec) : base(volume, matiere)
        {
            this.nb_groupe_elec = nb_groupe_elec;
            this.prix_100km = 40 + nb_groupe_elec * 10;
        }
        public int Nb_groupe_elec
        {
            get { return this.nb_groupe_elec; }
        }
    }

}
