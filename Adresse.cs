using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnect_Stone_Romeo
{
    internal class Adresse
    {
        private int numero;
        private string rue;
        private string ville;
        private int code_postal;

        public Adresse(int numero, string rue, string ville, int code_postal)
        {
            this.numero = numero;
            this.rue = rue;
            this.ville = ville;
            this.code_postal = code_postal;
        }

        public int Numero 
        { 
            get{ return this.numero; }
            set{ this.numero = value; }
        }
        public string Rue
        {
            get { return this.rue; }
            set { this.rue = value; }
        }

        public string Ville
        {   get { return this.ville;}
            set{ this.ville=value;}
        }

        public int Code_Postal
        {
            get { return this.code_postal; }
            set { this.code_postal = value; }
        }
    }
}
