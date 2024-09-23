namespace TransConnect_Stone_Romeo
{
    partial class FormPasserCommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            btnValiderCommande = new Button();
            cbxTypeVehicule = new ComboBox();
            lblDepart = new Label();
            lblArrivee = new Label();
            label1 = new Label();
            lblTypeVehicule = new Label();
            panel2 = new Panel();
            cbxDepart = new ComboBox();
            cbxArrivee = new ComboBox();
            label2 = new Label();
            btnDeconnexion = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(142, 392);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(273, 31);
            dateTimePicker1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(472, 218);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 410);
            panel1.TabIndex = 6;
            // 
            // btnValiderCommande
            // 
            btnValiderCommande.Location = new Point(120, 564);
            btnValiderCommande.Margin = new Padding(2);
            btnValiderCommande.Name = "btnValiderCommande";
            btnValiderCommande.Size = new Size(219, 34);
            btnValiderCommande.TabIndex = 0;
            btnValiderCommande.Text = "Valider la commande";
            btnValiderCommande.UseVisualStyleBackColor = true;
            btnValiderCommande.Click += btnValiderCommande_Click;
            // 
            // cbxTypeVehicule
            // 
            cbxTypeVehicule.FormattingEnabled = true;
            cbxTypeVehicule.Items.AddRange(new object[] { "Voiture", "Camionnette", "Camion" });
            cbxTypeVehicule.Location = new Point(248, 486);
            cbxTypeVehicule.Margin = new Padding(2);
            cbxTypeVehicule.Name = "cbxTypeVehicule";
            cbxTypeVehicule.Size = new Size(168, 33);
            cbxTypeVehicule.TabIndex = 8;
            cbxTypeVehicule.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblDepart
            // 
            lblDepart.AutoSize = true;
            lblDepart.Location = new Point(36, 221);
            lblDepart.Margin = new Padding(2, 0, 2, 0);
            lblDepart.Name = "lblDepart";
            lblDepart.Size = new Size(125, 25);
            lblDepart.TabIndex = 9;
            lblDepart.Text = "Lieu de départ";
            // 
            // lblArrivee
            // 
            lblArrivee.AutoSize = true;
            lblArrivee.Location = new Point(36, 301);
            lblArrivee.Margin = new Padding(2, 0, 2, 0);
            lblArrivee.Name = "lblArrivee";
            lblArrivee.Size = new Size(115, 25);
            lblArrivee.TabIndex = 10;
            lblArrivee.Text = "Lieu d'arrivée";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 392);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 11;
            label1.Text = "Date";
            // 
            // lblTypeVehicule
            // 
            lblTypeVehicule.AutoSize = true;
            lblTypeVehicule.Location = new Point(36, 494);
            lblTypeVehicule.Margin = new Padding(2, 0, 2, 0);
            lblTypeVehicule.Name = "lblTypeVehicule";
            lblTypeVehicule.Size = new Size(142, 25);
            lblTypeVehicule.TabIndex = 12;
            lblTypeVehicule.Text = "Type de véhicule";
            // 
            // panel2
            // 
            panel2.Location = new Point(729, 218);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(446, 410);
            panel2.TabIndex = 13;
            // 
            // cbxDepart
            // 
            cbxDepart.FormattingEnabled = true;
            cbxDepart.Items.AddRange(new object[] { "Paris", "Rouen", "Lyon", "Angers", "La Rochelle", "Bordeaux", "Biarritz", "Toulouse", "Pau", "Nimes", "Montpellier", "Marseille", "Avignon", "Monaco", "Toulon" });
            cbxDepart.Location = new Point(248, 218);
            cbxDepart.Margin = new Padding(2);
            cbxDepart.Name = "cbxDepart";
            cbxDepart.Size = new Size(168, 33);
            cbxDepart.TabIndex = 14;
            // 
            // cbxArrivee
            // 
            cbxArrivee.FormattingEnabled = true;
            cbxArrivee.Items.AddRange(new object[] { "Paris", "Rouen", "Lyon", "Angers", "La Rochelle", "Bordeaux", "Biarritz", "Toulouse", "Pau", "Nimes", "Montpellier", "Marseille", "Avignon", "Monaco", "Toulon" });
            cbxArrivee.Location = new Point(248, 301);
            cbxArrivee.Margin = new Padding(2);
            cbxArrivee.Name = "cbxArrivee";
            cbxArrivee.Size = new Size(168, 33);
            cbxArrivee.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(309, 70);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(658, 65);
            label2.TabIndex = 16;
            label2.Text = "Merci pour votre commande !";
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.Location = new Point(0, 0);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(131, 34);
            btnDeconnexion.TabIndex = 17;
            btnDeconnexion.Text = "Déconnexion";
            btnDeconnexion.UseVisualStyleBackColor = true;
            // 
            // FormPasserCommande
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 850);
            Controls.Add(btnDeconnexion);
            Controls.Add(btnValiderCommande);
            Controls.Add(label2);
            Controls.Add(cbxArrivee);
            Controls.Add(cbxDepart);
            Controls.Add(panel2);
            Controls.Add(lblTypeVehicule);
            Controls.Add(label1);
            Controls.Add(lblArrivee);
            Controls.Add(lblDepart);
            Controls.Add(cbxTypeVehicule);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Margin = new Padding(2);
            Name = "FormPasserCommande";
            Text = "PasserCommande";
            Load += FormPasserCommande_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;

        // Créer une variable pour stocker l'élément de menu sélectionné
        private ToolStripMenuItem elementMenuSelectionne;


        private Panel panel1;
        private Button btnValiderCommande;

        
        private ComboBox cbxTypeVehicule;
        private Label lblDepart;
        private Label lblArrivee;
        private Label label1;
        private Label lblTypeVehicule;
        private Panel panel2;
        private ComboBox cbxDepart;
        private ComboBox cbxArrivee;
        private Label label2;
        private Button btnDeconnexion;
    }
}
