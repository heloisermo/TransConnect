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
    public partial class FormStatistiques : Form
    {
        public FormStatistiques()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            commandesView.Columns.Clear();
            List<Commande> commandes = JsonSerialisation.ChargerCommandes();
            List<Commande> aAfficher = Commande.CommandesEntreDeuxDates(dateTimePicker1.Value, dateTimePicker2.Value, commandes);

            commandesView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            commandesView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Client",
                Name = "ClientColumn"
            });
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
            if (aAfficher.Count != 0)
            {
                foreach (Commande commande in aAfficher)
                {
                    commandesView.Rows.Add(commande.Client.Nom, commande.Vehicule.GetType().Name, commande.Livraison.Ville_depart, commande.Livraison.Ville_arrivee, commande.Livraison.Date_de_livraion, commande.Prix, commande.Etat);
                }
            }
        }

        private void FormStatistiques_Load(object sender, EventArgs e)
        {
            List<Commande> commandes = JsonSerialisation.ChargerCommandes();
            lblPrixMoyen.Text = "Le prix moyen par commande est de " + Commande.MoyenneMontantCommandes(commandes).ToString() + " euros";
            lblPrixMoyen.AutoSize = true;

            lblCompteCLientMoyen.Text = "Un compte client moyen compte " + Commande.MontantMoyenCompteClient(commandes).ToString() + " euros";
            cbxTri.Items.Add("Alphabétique");
            cbxTri.Items.Add("Ville");
            cbxTri.Items.Add("TotalAchats");
            clientsView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nom",
                Name = "NomColumn"
            });
            clientsView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Prénom",
                Name = "PrenomColumn"
            });
            clientsView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Ville",
                Name = "VilleColumn"
            });

            clientsView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total Achats",
                Name = "TotalAchatsColumn"
            });
        }

        private void btnAfficheClient_Click(object sender, EventArgs e)
        {
            clientsView.Rows.Clear();
            Clients clientsTri = JsonSerialisation.Charger<Clients>("clients.json");
            switch (cbxTri.SelectedItem)
            {
                case "Alphabétique":
                    
                    clientsTri.TriAlphabetique();
                    break;

                case "Ville":
                    clientsTri.TriVille();
                    break;
                case "TotalAchats":
                    clientsTri.TriAchat();
                    break;
                default:
                    clientsTri.TriSimultane();
                    break;
            }
            foreach(Client client in clientsTri.nos_Clients)
            {
                clientsView.Rows.Add(client.Nom, client.Prenom, client.Adresse.Ville, client.MontantAchats());
            }
        }
    }
}
