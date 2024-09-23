using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TransConnect_Stone_Romeo
{
    public partial class FormSInscrire : Form
    {
        public FormSInscrire()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            Clients clients = JsonSerialisation.Charger<Clients>("clients.json");

            if (clients == null)
            {
                clients = new Clients(new List<Client>()); // Créez un nouvel objet Clients avec une liste de clients vide si celui chargé est null
            }

            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtPrenom.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTelephone.Text) ||
                string.IsNullOrWhiteSpace(txtRue.Text) ||
                string.IsNullOrWhiteSpace(txtVille.Text) ||
                string.IsNullOrWhiteSpace(txtCodePostal.Text) ||
                string.IsNullOrWhiteSpace(txtNSS.Text) ||
                string.IsNullOrWhiteSpace(txtMdp.Text))
            {
                MessageBox.Show("Certain.s champ.s sont incomplets");
                return;
            }

            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            DateTime dateNaissance = dtpDateNaissance.Value;
            int nss = int.Parse(txtNSS.Text);
            int num = int.Parse(txtNumero.Text);
            string rue = txtRue.Text;
            string ville = txtVille.Text;
            int codePostal = int.Parse(txtCodePostal.Text);
            string email = txtEmail.Text;
            string telephone = txtTelephone.Text;
            string mdp = txtMdp.Text;

            if (clients.EmailDejaUtilise(email))
            {
                MessageBox.Show("Cette adresse mail est déjà utilisée !");
                return;
            }
            Adresse adresse = new Adresse(num, rue, ville, codePostal);

            Client client = new Client(nom, prenom, dateNaissance, nss, adresse, email, telephone, mdp);

            clients.AjoutClient(client);

            JsonSerialisation.Sauvegarder<Clients>("clients.json", clients);

            MessageBox.Show("Inscription réussie !");

            FormSeConnecter form = new FormSeConnecter();
            form.Show();
            this.Hide();

        }

        private void dtpDateNaissance_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormSInscrire_Load(object sender, EventArgs e)
        {

        }
    }
}
