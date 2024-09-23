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
    internal partial class FormModifClient : Form
    {
        private Client client;
        public FormModifClient(Client client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void FormModifClient_Load(object sender, EventArgs e)
        {
            txtPrenom.Text = this.client.Prenom;
            txtNom.Text = this.client.Nom;
            txtEmail.Text = this.client.Mail;
            txtTelephone.Text = this.client.Tel;
            Adresse adresse = this.client.Adresse;
            txtNumero.Text = adresse.Numero.ToString();
            txtRue.Text = adresse.Rue;
            txtVille.Text = adresse.Ville;
            txtCodePostal.Text = adresse.Code_Postal.ToString();
            txtNSS.Text = this.client.N_ss.ToString();
            dtpDateNaissance.Value = this.client.Naissance;
            txtMdp.Text = this.client.Mdp;

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Clients clients = JsonSerialisation.Charger<Clients>("clients.json");
            List<Client> clientsAModif = clients.nos_Clients;
            for (int i = 0; i < clientsAModif.Count; i++)
            {
                if (clientsAModif[i].N_ss == this.client.N_ss)
                {
                    Adresse adresse = new Adresse(int.Parse(txtNumero.Text), txtRue.Text, txtVille.Text, int.Parse(txtCodePostal.Text));
                    this.client.ModifierClient(txtNom.Text, txtPrenom.Text, dtpDateNaissance.Value, int.Parse(txtNSS.Text), adresse, txtEmail.Text, txtTelephone.Text, txtMdp.Text);
                    clientsAModif[i].Nom = txtNom.Text;
                    clientsAModif[i].Prenom = txtPrenom.Text;
                    clientsAModif[i].Mail = txtEmail.Text;
                    clientsAModif[i].Tel = txtTelephone.Text;
                    clientsAModif[i].Adresse.Numero = int.Parse(txtNumero.Text);
                    clientsAModif[i].Adresse.Rue = txtRue.Text;
                    clientsAModif[i].Adresse.Ville = txtVille.Text;
                    clientsAModif[i].Adresse.Code_Postal = int.Parse(txtCodePostal.Text);
                    clientsAModif[i].N_ss = int.Parse(txtNSS.Text);
                    clientsAModif[i].Naissance = dtpDateNaissance.Value;
                    clientsAModif[i].Mdp = txtMdp.Text;
                    clients.nos_Clients = clientsAModif;
                    clients = new Clients(clientsAModif);
                    JsonSerialisation.Sauvegarder("clients.json", clients);
                    break;
                }
            }
            new FormProfilClient(this.client).Show();
            this.Hide();
        }
    }
}
