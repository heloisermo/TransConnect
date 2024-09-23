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
    internal partial class FormSeConnecter : Form
    {
        public FormSeConnecter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMeConnecter_Click(object sender, EventArgs e)
        {
            string mail = txtMail.Text;
            string motDePasse = txtMdp.Text;

            // Vérifier si l'utilisateur est un chauffeur
            Chauffeur chauffeur = JsonSerialisation.ConnecterUtilisateur<Chauffeur>(mail, motDePasse);
            Salarie salarie = JsonSerialisation.ConnecterUtilisateur<Salarie>(mail, motDePasse);

            if (chauffeur != null)
            {
                // Handle the Chauffeur-specific logic
                FormAdmin form = new FormAdmin(chauffeur);
                form.Show();
                this.Hide();
            }
            else if (salarie != null)
            {
                FormAdmin form = new FormAdmin(salarie);
                form.Show();
                this.Hide();
            }
            else
            {
                // Vérifier si l'utilisateur est un client
                Client client = JsonSerialisation.ConnecterUtilisateur<Client>(mail, motDePasse);
                if (client != null)
                {
                    FormProfilClient form = new FormProfilClient(client);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erreur : les informations de connexion sont incorrectes.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormSeConnecter_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Les informations des différents salariés sont dans notre document pdf :\nClient : heloise.romeo@gmail.com et mdp : 1" +
                "\n Chef : mr.dupond@example.com et mdp : 123 \n Chauffeur : mr.romu@example.com et mdp :123 ");
        }
    }
}
