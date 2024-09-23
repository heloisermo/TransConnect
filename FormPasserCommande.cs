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
    internal partial class FormPasserCommande : Form
    {
        private Client client;
        public FormPasserCommande(Client client)
        {
            this.client = client;   
            InitializeComponent();
        }

        /// <summary>
        /// Il s'agit de la partie interactive du menu déroulant: en fonction de ce qu'on sélectionne dans le combobox
        /// Des éléments aparaissent sur le panel qui est lié au combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel1.AutoSize = true;

            switch (cbxTypeVehicule.SelectedItem.ToString())
            {
                case "Voiture":

                    Label lblNbPassagers = new Label();
                    lblNbPassagers.Text = "Nombre de passagers";
                    panel1.Controls.Add(lblNbPassagers);
                    lblNbPassagers.AutoSize = true;

                    for (int i = 1; i <= 5; i++)
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Text = i.ToString();
                        checkBox.CheckedChanged += new EventHandler(checkBox_CheckedChanged);

                        //D'office les checkbox se placent en haut a gauche donc on leur attribue une localisation
                        //Pour pas qu'ils soient cachés derrière le premier
                        checkBox.Location = new Point(0, 20 * i);
                        panel1.Controls.Add(checkBox);
                    }
                    break;

                case "Camionnette":

                    Label lblUsage = new Label();
                    lblUsage.Text = "Usage de la camionnette";
                    lblUsage.AutoSize = true;
                    panel1.Controls.Add(lblUsage);
                    TextBox txtUsage = new TextBox();
                    txtUsage.AutoSize = true;
                    txtUsage.Location = new Point(0, 20);
                    panel1.Controls.Add(txtUsage);

                    break;


                case "Camion":

                    Label lblTypeCamion = new Label();
                    lblTypeCamion.Text = "Type de camion désiré";
                    lblTypeCamion.AutoSize = true;
                    panel1.Controls.Add(lblTypeCamion);
                    ComboBox comboBoxTypeCamion = new ComboBox();
                    comboBoxTypeCamion.Location = new Point(0, 20);
                    comboBoxTypeCamion.Items.Add("Citerne");
                    comboBoxTypeCamion.Items.Add("Benne");
                    comboBoxTypeCamion.Items.Add("Frigorifique");
                    panel1.Controls.Add(comboBoxTypeCamion);

                    comboBoxTypeCamion.SelectedIndexChanged += new EventHandler(comboBoxTypeCamion_SelectedIndexChanged);


                    break;
            }

        }

        private void comboBoxTypeCamion_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel2.Controls.Clear(); // Videz panel2 avant d'ajouter de nouveaux contrôles

            ComboBox comboBox = (ComboBox)sender; // Récupérez le ComboBox qui a déclenché l'événement

            Label lblMatiere = new Label();
            lblMatiere.Text = "Matière transportée : ";
            lblMatiere.AutoSize = true;



            Label lblVolume = new Label();
            lblVolume.Text = "Volume requis : ";
            lblVolume.AutoSize = true;
            lblVolume.Location = new Point(140, 0);

            TextBox txtMatiere = new TextBox();
            txtMatiere.AutoSize = true;
            txtMatiere.Location = new Point(0, 20);


            TextBox txtVolume = new TextBox();
            txtVolume.AutoSize = true;
            txtVolume.Location = new Point(140, 20);


            panel2.Controls.Add(lblMatiere);
            panel2.Controls.Add(lblVolume);

            panel2.Controls.Add(txtMatiere);
            panel2.Controls.Add(txtVolume);

            switch (comboBox.SelectedItem.ToString())
            {

                case "Citerne":

                    break;
                case "Benne":

                    Label lblNbBenne = new Label();
                    lblNbBenne.Text = "Nombre de benne.s : ";
                    lblNbBenne.AutoSize = true;
                    lblNbBenne.Location = new Point(0, 50);
                    panel2.Controls.Add(lblNbBenne);
                    int k = 20;
                    for (int i = 1; i <= 3; i++)
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Text = i.ToString();
                        checkBox.CheckedChanged += new EventHandler(checkBox_CheckedChanged);

                        //D'office les checkbox se placent en haut a gauche donc on leur attribue une localisation
                        //Pour pas qu'ils soient cachés derrière le premier
                        checkBox.Location = new Point(0, 60 + k);
                        panel2.Controls.Add(checkBox);
                        k += 20;
                    }

                    Label lblGrue = new Label();
                    lblGrue.Text = "Voulez vous une grue ? ";
                    lblGrue.AutoSize = true;
                    lblGrue.Location = new Point(0, 160);
                    panel2.Controls.Add(lblGrue);

                    CheckBox checkBoxOui = new CheckBox();
                    checkBoxOui.Text = "Oui";
                    checkBoxOui.CheckedChanged += new EventHandler(checkBox_CheckedChanged);
                    checkBoxOui.Location = new Point(0, 180);
                    panel2.Controls.Add(checkBoxOui);

                    CheckBox checkBoxNon = new CheckBox();
                    checkBoxNon.Text = "Non";
                    checkBoxNon.CheckedChanged += new EventHandler(checkBox_CheckedChanged);
                    checkBoxNon.Location = new Point(0, 200);
                    panel2.Controls.Add(checkBoxNon);

                    break;

                case "Frigorifique":

                    Label lblGElec = new Label();
                    lblGElec.Text = "Groupes électrogènes : ";
                    lblGElec.AutoSize = true;
                    lblGElec.Location = new Point(0, 50);
                    panel2.Controls.Add(lblGElec);
                    int j = 20;
                    for (int i = 1; i <= 3; i++)
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Text = i.ToString();
                        checkBox.CheckedChanged += new EventHandler(checkBox_CheckedChanged);

                        //D'office les checkbox se placent en haut a gauche donc on leur attribue une localisation
                        //Pour pas qu'ils soient cachés derrière le premier
                        checkBox.Location = new Point(0, 60 + j);
                        panel2.Controls.Add(checkBox);
                        j += 20;
                    }
                    break;
            }
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                // L'utilisateur a sélectionné cette option
            }
            else
            {
                // L'utilisateur a désélectionné cette option
            }
        }

        private void btnValiderCommande_Click(object sender, EventArgs e)
        {
            DateTime dateCommande = dateTimePicker1.Value;

            string lieuDepart = cbxDepart.SelectedItem.ToString();
            string lieuArrivee = cbxArrivee.SelectedItem.ToString();
            string typeVehicule = cbxTypeVehicule.SelectedItem.ToString();

            int nbPassagers = 0;
            string usageCamionnette = "";
            string typeCamion = "";
            string matiereTransportee = "";
            int volumeRequis = 0;
            int nbBennes = 0;
            bool grue = false;
            int nbGroupesElectrogenes = 0;

            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)ctrl;
                    if (checkBox.Checked)
                    {
                        if (typeVehicule == "Voiture")
                        {
                            nbPassagers = int.Parse(checkBox.Text);
                        }
                    }
                }
                else if (ctrl is TextBox)
                {
                    TextBox textBox = (TextBox)ctrl;
                    if (typeVehicule == "Camionnette")
                    {
                        usageCamionnette = textBox.Text;
                    }
                }
                else if (ctrl is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)ctrl;
                    if (typeVehicule == "Camion")
                    {
                        typeCamion = comboBox.SelectedItem.ToString();
                    }
                }
            }

            foreach (Control ctrl in panel2.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox textBox = (TextBox)ctrl;
                    if (typeVehicule == "Camion")
                    {
                        if (textBox.Name == "txtMatiere")
                        {
                            matiereTransportee = textBox.Text;
                        }
                        else if (textBox.Name == "txtVolume")
                        {
                            volumeRequis = int.Parse(textBox.Text);
                        }
                    }
                }
                else if (ctrl is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)ctrl;
                    if (checkBox.Checked)
                    {
                        if (typeVehicule == "Camion" && checkBox.Name.StartsWith("checkBoxBenne"))
                        {
                            nbBennes += int.Parse(checkBox.Text);
                        }
                        else if (typeVehicule == "Camion" && checkBox.Text == "Oui")
                        {
                            grue = true;
                        }
                        else if (typeVehicule == "Camion" && checkBox.Name.StartsWith("checkBoxGroupeElectrogene"))
                        {
                            nbGroupesElectrogenes += int.Parse(checkBox.Text);
                        }
                    }
                }
            }
            List<Salarie> list = JsonSerialisation.ChargerSalaries();
            Livraison livraison = new Livraison(lieuDepart, lieuArrivee, dateCommande);
            List<Chauffeur> chauffeurs = JsonSerialisation.ChargerChauffeurs();
            Chauffeur chauffeur = Chauffeur.SelectionnerChauffeur(chauffeurs, livraison);
            if (chauffeur != null)
            {
                JsonSerialisation.MAJChauffeurs(chauffeur);


                switch (typeVehicule)
                {
                    case "Voiture":
                        Voiture voiture = new Voiture(nbPassagers);
                        Commande comV = new Commande(this.client, livraison, voiture, chauffeur, DateTime.Now, "payée");
                        JsonSerialisation.MAJCommandes(comV);
                        break;
                    case "Camionnette":
                        Camionnette camionnette = new Camionnette(usageCamionnette);
                        Commande comCa = new Commande(this.client, livraison, camionnette, chauffeur, DateTime.Now, "payée");
                        JsonSerialisation.MAJCommandes(comCa);
                        break;
                    case "Camion":
                        switch (typeCamion)
                        {
                            case "Citerne":
                                Citerne citerne = new Citerne(volumeRequis, matiereTransportee);
                                Commande comCi = new Commande(this.client, livraison, citerne, chauffeur, DateTime.Now, "payée");
                                JsonSerialisation.MAJCommandes(comCi);
                                break;
                            case "Benne":
                                Benne benne = new Benne(volumeRequis, matiereTransportee, nbBennes, grue);
                                Commande comB = new Commande(this.client, livraison, benne, chauffeur, DateTime.Now, "payée");
                                JsonSerialisation.MAJCommandes(comB);
                                break;
                            case "Frigorifique":
                                Frigorifique frigorifique = new Frigorifique(volumeRequis, matiereTransportee, nbGroupesElectrogenes);
                                Commande comF = new Commande(this.client, livraison, frigorifique, chauffeur, DateTime.Now, "payée");
                                JsonSerialisation.MAJCommandes(comF);
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;

                }
                MessageBox.Show("Commande validée");
                FormProfilClient form = new FormProfilClient(this.client);
                form.Show();
                this.Hide();
            }
            else
            {
                FormPasserCommande formulaire = new FormPasserCommande(this.client);
                formulaire.Show();
                this.Dispose();
            }
             

        }

        private void FormPasserCommande_Load(object sender, EventArgs e)
        {

        }
    }
}
