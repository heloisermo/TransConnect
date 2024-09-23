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
    internal partial class FormAdmin : Form
    {
        private Salarie salarie;
        public FormAdmin(Salarie s)
        {
            this.salarie = s;
            InitializeComponent();
        }


        /// <summary>
        /// Fonction qui va charger le form et afficher l'arbre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            if (salarie != null)
            {
                AjouterSalarieATreeView(treeView1.Nodes, salarie);

                treeView1.ExpandAll();

                RemplirCbxSubordonnes();
                txtNom.Visible = false;
                txtPrenom.Visible = false;
                txtNss.Visible = false;
                txtMail.Visible = false;
                txtRue.Visible = false;
                txtNumeroRue.Visible = false;
                txtCodePostal.Visible = false;
                txtVille.Visible = false;
                txtTel.Visible = false;
                txtMdp.Visible = false;
                txtPoste.Visible = false;
                dateTimePicker1.Visible = false;
                lblVille.Visible = false;
                lblMdp.Visible = false;
                lblCodePostal.Visible = false;
                lblTel.Visible = false;
                lblRue.Visible = false;
                lblNRue.Visible = false;
                lblMail.Visible = false;
                lblNss.Visible = false;
                lblPrenom.Visible = false;
                lblNom.Visible = false;
                lblAnniv.Visible = false;
                lblPoste.Visible = false;
                btnConfirmer.Visible = false;
                btnLicensier.Visible = false;
                btnRecruter.Visible = false;
                cbxSalaries.Visible = false;
                btnStatistiques.Visible = false;
                agendaView.Visible = false;
                lblNombreLivraisons.Visible = false;
                cbxChoixDate.Visible = false;
                btnLivree.Visible = false;
                btnConge.Visible = false;
                dateTimePicker2.Visible = false;
                monthCalendar1.Visible = false;
                lblAgenda.Visible = false;
                lblCommandes.Visible = false;

                if (salarie is Chauffeur chauffeur)
                {
                    agendaView.Visible = true;
                    lblNombreLivraisons.Visible = true;
                    cbxChoixDate.Visible = true;
                    btnLivree.Visible = true;
                    btnConge.Visible = true;
                    dateTimePicker2.Visible=true;
                    monthCalendar1.Visible = false;
                    lblAgenda.Visible = false;
                    lblCommandes.Visible = true;

                    foreach (DateTime date in chauffeur.Agenda)
                    {
                        // Ajouter la date à mettre en surbrillance
                        monthCalendar1.AddBoldedDate(date);

                    }

                    foreach (Livraison livraison in chauffeur.Livraisons)
                    {
                        cbxChoixDate.Items.Add(livraison.Date_de_livraion.ToString("yyyy-MM-dd"));
                    }
                    lblNombreLivraisons.Text = "Nombre de livraisons : " + chauffeur.Livraisons.Count.ToString();
                    agendaView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    agendaView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Date",
                        Name = "DateColumn"
                    });

                    agendaView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Chemin",
                        Name = "CheminColumn"
                    });

                    foreach (Livraison livraison in chauffeur.Livraisons)
                    {
                        string chemin = string.Join(" -> ", livraison.Trajet.Villes);
                        agendaView.Rows.Add(livraison.Date_de_livraion, chemin);
                    }


                }



                else
                {
                    btnLicensier.Visible = true;
                    btnRecruter.Visible = true;
                    cbxSalaries.Visible = true;

                    if (this.salarie.Poste == "Directeur Général")
                    {
                        btnStatistiques.Visible = true;
                    }
                }
            }


        }


        /// <summary>
        /// Fonction récursive qui permet d'ajouter les salariés à l'arbre sur notre windows form
        /// </summary>
        /// <param name="noeuds"></param>L'ensemble de nos salariés
        /// <param name="salarie"></param>Le salarié que l'on souhaite ajouter
        private void AjouterSalarieATreeView(TreeNodeCollection noeuds, Salarie salarie)
        {
            // On crée un noeud qui prend la valeur Prenom/Nom du salarié
            TreeNode noeud = new TreeNode(salarie.Prenom + " " + salarie.Nom);

            // On l'ajoute à nos noeuds
            noeuds.Add(noeud);

            noeud.Expand();

            //Pour tous les subordonnés de ce salarié, on refait la fonction
            foreach (var subordonne in salarie.Subordonnes)
            {
                AjouterSalarieATreeView(noeud.Nodes, subordonne);
            }
        }


        /// <summary>
        /// Fonction qui remplit le combobox de la personne connectée avec ses propres subordonnés
        /// </summary>
        private void RemplirCbxSubordonnes()
        {
            List<Salarie> salaries = JsonSerialisation.Charger<List<Salarie>>("Salaries.json");
            cbxSalaries.Items.Clear();

            foreach (Salarie subordonne in this.salarie.Subordonnes)
            {
                cbxSalaries.Items.Add(subordonne.Nom + " " + subordonne.Prenom);
            }

        }


        /// <summary>
        /// Fonction qui licencie une personne sélectionnée dans le combobox en appuyant sur le bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLicencier_Click(object sender, EventArgs e)
        {
            List<Salarie> salaries = JsonSerialisation.Charger<List<Salarie>>("salaries.json");
            Salarie a_licencier = null;
            foreach (Salarie s in this.salarie.Subordonnes)
            {
                if (cbxSalaries.Text == s.Nom + " " + s.Prenom)
                {
                    a_licencier = s;
                    this.salarie.Licencier(a_licencier, salaries);
                    MessageBox.Show("Vous avez licensié " + a_licencier.Nom);
                    break;
                }

            }

            JsonSerialisation.Sauvegarder<List<Salarie>>("salaries.json", salaries);
            RemplirCbxSubordonnes();
            MettreAJourArbre();
        }


        /// <summary>
        /// Fonction qui ajoute un salarié à la liste des salariés lorsqu'on le recrute
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecruter_Click(object sender, EventArgs e)
        {
            txtNom.Visible = true;
            txtPrenom.Visible = true;
            txtNss.Visible = true;
            txtMail.Visible = true;
            txtRue.Visible = true;
            txtNumeroRue.Visible = true;
            txtCodePostal.Visible = true;
            txtVille.Visible = true;
            txtTel.Visible = true;
            txtMdp.Visible = true;
            txtPoste.Visible = true;
            dateTimePicker1.Visible = true;
            lblVille.Visible = true;
            lblMdp.Visible = true;
            lblCodePostal.Visible = true;
            lblTel.Visible = true;
            lblRue.Visible = true;
            lblNRue.Visible = true;
            lblMail.Visible = true;
            lblNss.Visible = true;
            lblPrenom.Visible = true;
            lblNom.Visible = true;
            lblAnniv.Visible = true;
            lblPoste.Visible = true;
            btnConfirmer.Visible = true;



        }


        /// <summary>
        /// Fonction pour valider un recrutement lorsqu'on appuie sur le bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            // Créer un nouvel objet Salarie à partir des valeurs saisies dans les TextBox
            Salarie a_embaucher = new Salarie(
                txtNom.Text,
                txtPrenom.Text,
                dateTimePicker1.Value,
                Convert.ToInt32(txtNss.Text),
                new Adresse(Convert.ToInt32(txtNumeroRue.Text), txtRue.Text, txtVille.Text, Convert.ToInt32(txtCodePostal.Text)),
                txtMail.Text,
                txtTel.Text,
                txtMdp.Text,
                txtPoste.Text,
                1100
            );

            List<Salarie> salaries = JsonSerialisation.Charger<List<Salarie>>("salaries.json");
            salaries = this.salarie.Embaucher(a_embaucher, salaries);
            MessageBox.Show("Vous avez Embauché " + a_embaucher.Prenom + " " + a_embaucher.Nom);

            JsonSerialisation.Sauvegarder<List<Salarie>>("salaries.json", salaries);
            RemplirCbxSubordonnes();
            MettreAJourArbre();
        }


        /// <summary>
        /// Fonction qui permet de mettrz à jour l'arbre en fonction de si l'on a recruté ou licencié quelqu'un
        /// </summary>
        private void MettreAJourArbre()
        {
            treeView1.Nodes.Clear();
            List<Salarie> salaries = JsonSerialisation.Charger<List<Salarie>>("salaries.json");

            if (salaries != null)
            {
                Salarie directeur = salaries.FirstOrDefault(s => s.Poste == this.salarie.Poste);
                if (directeur != null)
                {
                    AjouterSalarieATreeView(treeView1.Nodes, directeur);
                }
            }
            treeView1.ExpandAll();
        }


        /// <summary>
        /// Fonction qui affiche les statistiques lorsque l'on appuie sur le bouton concerné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStatistiques_Click(object sender, EventArgs e)
        {
            FormStatistiques formulaire = new FormStatistiques();
            formulaire.Show();

        }

        private void btnLivree_Click(object sender, EventArgs e)
        {
            if (salarie is Chauffeur chauffeur)
            {
                if (cbxChoixDate.SelectedItem != null)
                {
                    foreach (Livraison livraison in chauffeur.Livraisons)
                    {
                        if (livraison.Date_de_livraion.ToString("yyyy-MM-dd") == cbxChoixDate.SelectedItem.ToString())
                        {
                            List<Commande> commandes = JsonSerialisation.ChargerCommandes();
                            foreach (Commande commande in commandes)
                            {
                                if (commande.Livraison.Date_de_livraion == livraison.Date_de_livraion && chauffeur.Mail == commande.Chauffeur.Mail)
                                {
                                    commande.Livree();
                                    JsonSerialisation.SauvegarderCommandes(commandes);
                                    MessageBox.Show(commande.Etat);
                                    break;
                                }
                            }

                        }
                    }
                }
            }
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            FormSeConnecter formulaire = new FormSeConnecter();
            formulaire.Show();
            this.Hide();
        }


        /// <summary>
        /// Fonction qui met à jour l'agenda du chauffeur s'il veut poser un congé un jour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConge_Click(object sender, EventArgs e)
        {
            if (salarie is Chauffeur chauffeur)
            {
                if (chauffeur.Disponible(dateTimePicker2.Value) == true)
                {
                    chauffeur.MiseAJourAgenda(dateTimePicker2.Value);
                    MessageBox.Show("Vous avez bien posé un congé le " + dateTimePicker2.Value.ToString());
                }
                else
                {
                    MessageBox.Show("Vous ne pouvez pas poser de congé le " + dateTimePicker2.Value.ToString());
                }

            }

        }
    }
}
