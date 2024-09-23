namespace TransConnect_Stone_Romeo
{
    partial class FormAdmin
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
            treeView1 = new TreeView();
            btnLicensier = new Button();
            btnRecruter = new Button();
            cbxSalaries = new ComboBox();
            txtVille = new TextBox();
            txtMdp = new TextBox();
            txtCodePostal = new TextBox();
            txtTel = new TextBox();
            txtNumeroRue = new TextBox();
            txtRue = new TextBox();
            txtMail = new TextBox();
            txtNss = new TextBox();
            txtPrenom = new TextBox();
            txtNom = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtPoste = new TextBox();
            lblVille = new Label();
            lblMdp = new Label();
            lblCodePostal = new Label();
            lblTel = new Label();
            lblRue = new Label();
            lblNRue = new Label();
            lblMail = new Label();
            lblNss = new Label();
            lblPrenom = new Label();
            lblNom = new Label();
            lblAnniv = new Label();
            lblPoste = new Label();
            btnConfirmer = new Button();
            btnStatistiques = new Button();
            agendaView = new DataGridView();
            lblNombreLivraisons = new Label();
            cbxChoixDate = new ComboBox();
            btnLivree = new Button();
            btnDeconnexion = new Button();
            btnConge = new Button();
            dateTimePicker2 = new DateTimePicker();
            monthCalendar1 = new MonthCalendar();
            lblAgenda = new Label();
            lblCommandes = new Label();
            ((System.ComponentModel.ISupportInitialize)agendaView).BeginInit();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(0, 0);
            treeView1.Margin = new Padding(2);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(436, 625);
            treeView1.TabIndex = 0;
            // 
            // btnLicensier
            // 
            btnLicensier.Location = new Point(774, -2);
            btnLicensier.Margin = new Padding(2);
            btnLicensier.Name = "btnLicensier";
            btnLicensier.Size = new Size(158, 34);
            btnLicensier.TabIndex = 1;
            btnLicensier.Text = "Licensier";
            btnLicensier.UseVisualStyleBackColor = true;
            btnLicensier.Click += btnLicencier_Click;
            // 
            // btnRecruter
            // 
            btnRecruter.Location = new Point(1016, -4);
            btnRecruter.Margin = new Padding(2);
            btnRecruter.Name = "btnRecruter";
            btnRecruter.RightToLeft = RightToLeft.Yes;
            btnRecruter.Size = new Size(158, 34);
            btnRecruter.TabIndex = 2;
            btnRecruter.Text = "Recruter";
            btnRecruter.UseVisualStyleBackColor = true;
            btnRecruter.Click += btnRecruter_Click;
            // 
            // cbxSalaries
            // 
            cbxSalaries.FormattingEnabled = true;
            cbxSalaries.Items.AddRange(new object[] { "Dupond Mr", "Fiesta Mme", "Forge Mr", "Fermi Mme", "Fetard Mr", "Royal Mr", "Romu Mr", "Romi Mme", "Roma Mr", "Prince Mme", "Rome Mme", "Rimou Mme", "Joyeuse Mme", "Couleur Mme", "ToutleMonde Mme", "GripSous Mr", "Picsou Mr", "Fournier Mme", "Gautier Mme", "GrosSous Mr" });
            cbxSalaries.Location = new Point(548, -2);
            cbxSalaries.Margin = new Padding(2);
            cbxSalaries.Name = "cbxSalaries";
            cbxSalaries.Size = new Size(228, 33);
            cbxSalaries.TabIndex = 3;
            // 
            // txtVille
            // 
            txtVille.Location = new Point(962, 430);
            txtVille.Margin = new Padding(2);
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(253, 31);
            txtVille.TabIndex = 4;
            // 
            // txtMdp
            // 
            txtMdp.Location = new Point(958, 358);
            txtMdp.Margin = new Padding(2);
            txtMdp.Name = "txtMdp";
            txtMdp.Size = new Size(258, 31);
            txtMdp.TabIndex = 5;
            // 
            // txtCodePostal
            // 
            txtCodePostal.Location = new Point(1016, 282);
            txtCodePostal.Margin = new Padding(2);
            txtCodePostal.Name = "txtCodePostal";
            txtCodePostal.Size = new Size(200, 31);
            txtCodePostal.TabIndex = 6;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(1000, 205);
            txtTel.Margin = new Padding(2);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(216, 31);
            txtTel.TabIndex = 7;
            // 
            // txtNumeroRue
            // 
            txtNumeroRue.Location = new Point(614, 362);
            txtNumeroRue.Margin = new Padding(2);
            txtNumeroRue.Name = "txtNumeroRue";
            txtNumeroRue.Size = new Size(198, 31);
            txtNumeroRue.TabIndex = 8;
            // 
            // txtRue
            // 
            txtRue.Location = new Point(950, 141);
            txtRue.Margin = new Padding(2);
            txtRue.Name = "txtRue";
            txtRue.Size = new Size(266, 31);
            txtRue.TabIndex = 9;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(581, 286);
            txtMail.Margin = new Padding(2);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(232, 31);
            txtMail.TabIndex = 10;
            // 
            // txtNss
            // 
            txtNss.Location = new Point(548, 211);
            txtNss.Margin = new Padding(2);
            txtNss.Name = "txtNss";
            txtNss.Size = new Size(264, 31);
            txtNss.TabIndex = 11;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(581, 148);
            txtPrenom.Margin = new Padding(2);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(232, 31);
            txtPrenom.TabIndex = 12;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(559, 82);
            txtNom.Margin = new Padding(2);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(253, 31);
            txtNom.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(916, 512);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 14;
            // 
            // txtPoste
            // 
            txtPoste.Location = new Point(962, 82);
            txtPoste.Margin = new Padding(2);
            txtPoste.Name = "txtPoste";
            txtPoste.Size = new Size(253, 31);
            txtPoste.TabIndex = 15;
            // 
            // lblVille
            // 
            lblVille.AutoSize = true;
            lblVille.Location = new Point(912, 436);
            lblVille.Margin = new Padding(2, 0, 2, 0);
            lblVille.Name = "lblVille";
            lblVille.Size = new Size(44, 25);
            lblVille.TabIndex = 16;
            lblVille.Text = "Ville";
            // 
            // lblMdp
            // 
            lblMdp.AutoSize = true;
            lblMdp.Location = new Point(902, 362);
            lblMdp.Margin = new Padding(2, 0, 2, 0);
            lblMdp.Name = "lblMdp";
            lblMdp.Size = new Size(50, 25);
            lblMdp.TabIndex = 17;
            lblMdp.Text = "Mdp";
            // 
            // lblCodePostal
            // 
            lblCodePostal.AutoSize = true;
            lblCodePostal.Location = new Point(902, 286);
            lblCodePostal.Margin = new Padding(2, 0, 2, 0);
            lblCodePostal.Name = "lblCodePostal";
            lblCodePostal.Size = new Size(108, 25);
            lblCodePostal.TabIndex = 18;
            lblCodePostal.Text = "Code postal";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(902, 218);
            lblTel.Margin = new Padding(2, 0, 2, 0);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(92, 25);
            lblTel.TabIndex = 19;
            lblTel.Text = "Téléphone";
            // 
            // lblRue
            // 
            lblRue.AutoSize = true;
            lblRue.Location = new Point(902, 150);
            lblRue.Margin = new Padding(2, 0, 2, 0);
            lblRue.Name = "lblRue";
            lblRue.Size = new Size(42, 25);
            lblRue.TabIndex = 20;
            lblRue.Text = "Rue";
            // 
            // lblNRue
            // 
            lblNRue.AutoSize = true;
            lblNRue.Location = new Point(501, 362);
            lblNRue.Margin = new Padding(2, 0, 2, 0);
            lblNRue.Name = "lblNRue";
            lblNRue.Size = new Size(107, 25);
            lblNRue.TabIndex = 21;
            lblNRue.Text = "Numéro rue";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(501, 286);
            lblMail.Margin = new Padding(2, 0, 2, 0);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(73, 25);
            lblMail.TabIndex = 22;
            lblMail.Text = "Courriel";
            // 
            // lblNss
            // 
            lblNss.AutoSize = true;
            lblNss.Location = new Point(501, 211);
            lblNss.Margin = new Padding(2, 0, 2, 0);
            lblNss.Name = "lblNss";
            lblNss.Size = new Size(41, 25);
            lblNss.TabIndex = 23;
            lblNss.Text = "Nss";
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(501, 148);
            lblPrenom.Margin = new Padding(2, 0, 2, 0);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(74, 25);
            lblPrenom.TabIndex = 24;
            lblPrenom.Text = "Prénom";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(501, 82);
            lblNom.Margin = new Padding(2, 0, 2, 0);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(52, 25);
            lblNom.TabIndex = 25;
            lblNom.Text = "Nom";
            // 
            // lblAnniv
            // 
            lblAnniv.AutoSize = true;
            lblAnniv.Location = new Point(721, 512);
            lblAnniv.Margin = new Padding(2, 0, 2, 0);
            lblAnniv.Name = "lblAnniv";
            lblAnniv.Size = new Size(154, 25);
            lblAnniv.TabIndex = 26;
            lblAnniv.Text = "Date de naissance";
            // 
            // lblPoste
            // 
            lblPoste.AutoSize = true;
            lblPoste.Location = new Point(902, 85);
            lblPoste.Margin = new Padding(2, 0, 2, 0);
            lblPoste.Name = "lblPoste";
            lblPoste.Size = new Size(55, 25);
            lblPoste.TabIndex = 27;
            lblPoste.Text = "Poste";
            // 
            // btnConfirmer
            // 
            btnConfirmer.Location = new Point(988, 591);
            btnConfirmer.Margin = new Padding(2);
            btnConfirmer.Name = "btnConfirmer";
            btnConfirmer.Size = new Size(228, 34);
            btnConfirmer.TabIndex = 28;
            btnConfirmer.Text = "Confirmer";
            btnConfirmer.UseVisualStyleBackColor = true;
            btnConfirmer.Click += btnConfirmer_Click;
            // 
            // btnStatistiques
            // 
            btnStatistiques.Location = new Point(774, 40);
            btnStatistiques.Margin = new Padding(2);
            btnStatistiques.Name = "btnStatistiques";
            btnStatistiques.Size = new Size(228, 34);
            btnStatistiques.TabIndex = 30;
            btnStatistiques.Text = "Afficher les statistiques";
            btnStatistiques.UseVisualStyleBackColor = true;
            btnStatistiques.Click += btnStatistiques_Click;
            // 
            // agendaView
            // 
            agendaView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            agendaView.Location = new Point(548, 111);
            agendaView.Margin = new Padding(4);
            agendaView.Name = "agendaView";
            agendaView.RowHeadersWidth = 51;
            agendaView.Size = new Size(616, 235);
            agendaView.TabIndex = 31;
            // 
            // lblNombreLivraisons
            // 
            lblNombreLivraisons.AutoSize = true;
            lblNombreLivraisons.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            lblNombreLivraisons.Location = new Point(0, 647);
            lblNombreLivraisons.Margin = new Padding(4, 0, 4, 0);
            lblNombreLivraisons.Name = "lblNombreLivraisons";
            lblNombreLivraisons.Size = new Size(59, 25);
            lblNombreLivraisons.TabIndex = 32;
            lblNombreLivraisons.Text = "label1";
            // 
            // cbxChoixDate
            // 
            cbxChoixDate.FormattingEnabled = true;
            cbxChoixDate.Location = new Point(548, 426);
            cbxChoixDate.Margin = new Padding(4);
            cbxChoixDate.Name = "cbxChoixDate";
            cbxChoixDate.Size = new Size(188, 33);
            cbxChoixDate.TabIndex = 33;
            // 
            // btnLivree
            // 
            btnLivree.Location = new Point(744, 425);
            btnLivree.Margin = new Padding(4);
            btnLivree.Name = "btnLivree";
            btnLivree.Size = new Size(118, 36);
            btnLivree.TabIndex = 34;
            btnLivree.Text = "Livrer";
            btnLivree.UseVisualStyleBackColor = true;
            btnLivree.Click += btnLivree_Click;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.Location = new Point(988, 638);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(228, 34);
            btnDeconnexion.TabIndex = 35;
            btnDeconnexion.Text = "Déconnexion";
            btnDeconnexion.UseVisualStyleBackColor = true;
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // btnConge
            // 
            btnConge.Location = new Point(916, 467);
            btnConge.Name = "btnConge";
            btnConge.Size = new Size(299, 34);
            btnConge.TabIndex = 36;
            btnConge.Text = "Poser un conger";
            btnConge.UseVisualStyleBackColor = true;
            btnConge.Click += btnConge_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(916, 424);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 37;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(550, 571);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 38;
            // 
            // lblAgenda
            // 
            lblAgenda.AutoSize = true;
            lblAgenda.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgenda.Location = new Point(633, 513);
            lblAgenda.Name = "lblAgenda";
            lblAgenda.Size = new Size(143, 30);
            lblAgenda.TabIndex = 39;
            lblAgenda.Text = "Mon agenda";
            // 
            // lblCommandes
            // 
            lblCommandes.AutoSize = true;
            lblCommandes.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCommandes.Location = new Point(774, 67);
            lblCommandes.Name = "lblCommandes";
            lblCommandes.Size = new Size(187, 30);
            lblCommandes.TabIndex = 40;
            lblCommandes.Text = "Mes commandes";
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 868);
            Controls.Add(lblCommandes);
            Controls.Add(lblAgenda);
            Controls.Add(monthCalendar1);
            Controls.Add(dateTimePicker2);
            Controls.Add(btnConge);
            Controls.Add(btnDeconnexion);
            Controls.Add(btnLivree);
            Controls.Add(cbxChoixDate);
            Controls.Add(lblNombreLivraisons);
            Controls.Add(agendaView);
            Controls.Add(btnStatistiques);
            Controls.Add(btnConfirmer);
            Controls.Add(lblPoste);
            Controls.Add(lblAnniv);
            Controls.Add(lblNom);
            Controls.Add(lblPrenom);
            Controls.Add(lblNss);
            Controls.Add(lblMail);
            Controls.Add(lblNRue);
            Controls.Add(lblRue);
            Controls.Add(lblTel);
            Controls.Add(lblCodePostal);
            Controls.Add(lblMdp);
            Controls.Add(lblVille);
            Controls.Add(txtPoste);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtNom);
            Controls.Add(txtPrenom);
            Controls.Add(txtNss);
            Controls.Add(txtMail);
            Controls.Add(txtRue);
            Controls.Add(txtNumeroRue);
            Controls.Add(txtTel);
            Controls.Add(txtCodePostal);
            Controls.Add(txtMdp);
            Controls.Add(txtVille);
            Controls.Add(cbxSalaries);
            Controls.Add(btnRecruter);
            Controls.Add(btnLicensier);
            Controls.Add(treeView1);
            Margin = new Padding(2);
            Name = "FormAdmin";
            Text = "FormAdmin";
            Load += FormAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)agendaView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private Button btnLicensier;
        private Button btnRecruter;
        private ComboBox cbxSalaries;
        private TextBox txtVille;
        private TextBox txtMdp;
        private TextBox txtCodePostal;
        private TextBox txtTel;
        private TextBox txtNumeroRue;
        private TextBox txtRue;
        private TextBox txtMail;
        private TextBox txtNss;
        private TextBox txtPrenom;
        private TextBox txtNom;
        private DateTimePicker dateTimePicker1;
        private TextBox txtPoste;
        private Label lblVille;
        private Label lblMdp;
        private Label lblCodePostal;
        private Label lblTel;
        private Label lblRue;
        private Label lblNRue;
        private Label lblMail;
        private Label lblNss;
        private Label lblPrenom;
        private Label lblNom;
        private Label lblAnniv;
        private Label lblPoste;
        private Button btnConfirmer;
        private Button btnStatistiques;
        private DataGridView agendaView;
        private Label lblNombreLivraisons;
        private ComboBox cbxChoixDate;
        private Button btnLivree;
        private Button btnDeconnexion;
        private Button btnConge;
        private DateTimePicker dateTimePicker2;
        private MonthCalendar monthCalendar1;
        private Label lblAgenda;
        private Label lblCommandes;
    }
}