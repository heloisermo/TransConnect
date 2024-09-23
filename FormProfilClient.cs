using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransConnect_Stone_Romeo
{
    internal partial class FormProfilClient : Form
    {
        private Client client;


        public Client MonClient
        {
            get { return this.client; }
            set { this.client = value; }
        }


        public FormProfilClient(Client client)
        {
            this.MonClient = client;
            InitializeComponent();
        }

        private void btnPasserCommande_Click(object sender, EventArgs e)
        {
            FormPasserCommande form = new FormPasserCommande(this.client);
            form.Show();
            this.Hide();
        }

        private void FormProfilClient_Load(object sender, EventArgs e)
        {
            lblNom.Text = this.client.Prenom+" "+this.client.Nom;
            lblFidele.Text = "Fidélité: "+this.client.Fidelite();
            List<Commande> commandes = this.client.Commandes();
            commandesView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Type de véhicule",
                Name = "TypeVehiculeColumn"
            });

            commandesView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Ville de départ",
                Name = "VilleDepartColumn"
            });

            commandesView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Ville d'arrivée",
                Name = "VilleArriveeColumn"
            });

            commandesView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Date de livraison",
                Name = "DateLivraisonColumn"
            });

            commandesView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Prix",
                Name = "PrixColumn"
            });

            commandesView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "État",
                Name = "EtatColumn"
            });
            if (commandes.Count != 0)
            {
                foreach (Commande commande in commandes)
                {
                    commandesView.Rows.Add(commande.Vehicule.GetType().Name, commande.Livraison.Ville_depart, commande.Livraison.Ville_arrivee, commande.Livraison.Date_de_livraion, commande.Prix, commande.Etat);
                }
                commandesView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormModifClient form = new FormModifClient(this.client);
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSeConnecter formSeConnecter = new FormSeConnecter();
            formSeConnecter.Show();
            this.Hide();
        }
    }
}
