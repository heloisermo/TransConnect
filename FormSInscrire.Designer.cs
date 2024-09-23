namespace TransConnect_Stone_Romeo
{
    partial class FormSInscrire
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
            txtTelephone = new TextBox();
            txtVille = new TextBox();
            txtNom = new TextBox();
            txtEmail = new TextBox();
            txtCodePostal = new TextBox();
            txtRue = new TextBox();
            txtNSS = new TextBox();
            txtPrenom = new TextBox();
            dtpDateNaissance = new DateTimePicker();
            btnInscription = new Button();
            txtNumero = new TextBox();
            lblNom = new Label();
            lblPrenom = new Label();
            lblNss = new Label();
            lblRue = new Label();
            lblVille = new Label();
            lblPostal = new Label();
            lblNumeroRue = new Label();
            lblCourriel = new Label();
            lblTelephone = new Label();
            lblMdp = new Label();
            txtMdp = new TextBox();
            lblNaissance = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(740, 382);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(298, 31);
            txtTelephone.TabIndex = 0;
            // 
            // txtVille
            // 
            txtVille.Location = new Point(164, 435);
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(273, 31);
            txtVille.TabIndex = 1;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(164, 183);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(273, 31);
            txtNom.TabIndex = 2;
            txtNom.TextChanged += textBox3_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(740, 313);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(298, 31);
            txtEmail.TabIndex = 3;
            // 
            // txtCodePostal
            // 
            txtCodePostal.Location = new Point(164, 503);
            txtCodePostal.Name = "txtCodePostal";
            txtCodePostal.Size = new Size(273, 31);
            txtCodePostal.TabIndex = 4;
            // 
            // txtRue
            // 
            txtRue.Location = new Point(164, 376);
            txtRue.Name = "txtRue";
            txtRue.Size = new Size(273, 31);
            txtRue.TabIndex = 5;
            // 
            // txtNSS
            // 
            txtNSS.Location = new Point(164, 310);
            txtNSS.Name = "txtNSS";
            txtNSS.Size = new Size(273, 31);
            txtNSS.TabIndex = 6;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(164, 247);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(273, 31);
            txtPrenom.TabIndex = 7;
            // 
            // dtpDateNaissance
            // 
            dtpDateNaissance.Location = new Point(740, 248);
            dtpDateNaissance.Name = "dtpDateNaissance";
            dtpDateNaissance.Size = new Size(298, 31);
            dtpDateNaissance.TabIndex = 8;
            dtpDateNaissance.ValueChanged += dtpDateNaissance_ValueChanged;
            // 
            // btnInscription
            // 
            btnInscription.Location = new Point(834, 549);
            btnInscription.Name = "btnInscription";
            btnInscription.Size = new Size(112, 34);
            btnInscription.TabIndex = 9;
            btnInscription.Text = "S'inscrire";
            btnInscription.UseVisualStyleBackColor = true;
            btnInscription.Click += btnInscription_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(740, 177);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(298, 31);
            txtNumero.TabIndex = 10;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(32, 183);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(52, 25);
            lblNom.TabIndex = 11;
            lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(32, 253);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(74, 25);
            lblPrenom.TabIndex = 12;
            lblPrenom.Text = "Prénom";
            // 
            // lblNss
            // 
            lblNss.AutoSize = true;
            lblNss.Location = new Point(32, 313);
            lblNss.Name = "lblNss";
            lblNss.Size = new Size(45, 25);
            lblNss.TabIndex = 13;
            lblNss.Text = "NSS";
            // 
            // lblRue
            // 
            lblRue.AutoSize = true;
            lblRue.Location = new Point(32, 379);
            lblRue.Name = "lblRue";
            lblRue.Size = new Size(42, 25);
            lblRue.TabIndex = 14;
            lblRue.Text = "Rue";
            // 
            // lblVille
            // 
            lblVille.AutoSize = true;
            lblVille.Location = new Point(32, 438);
            lblVille.Name = "lblVille";
            lblVille.Size = new Size(44, 25);
            lblVille.TabIndex = 15;
            lblVille.Text = "Ville";
            // 
            // lblPostal
            // 
            lblPostal.AutoSize = true;
            lblPostal.Location = new Point(32, 506);
            lblPostal.Name = "lblPostal";
            lblPostal.Size = new Size(106, 25);
            lblPostal.TabIndex = 16;
            lblPostal.Text = "Code Postal";
            // 
            // lblNumeroRue
            // 
            lblNumeroRue.AutoSize = true;
            lblNumeroRue.Location = new Point(544, 183);
            lblNumeroRue.Name = "lblNumeroRue";
            lblNumeroRue.Size = new Size(132, 25);
            lblNumeroRue.TabIndex = 17;
            lblNumeroRue.Text = "Numéro de rue";
            // 
            // lblCourriel
            // 
            lblCourriel.AutoSize = true;
            lblCourriel.Location = new Point(544, 319);
            lblCourriel.Name = "lblCourriel";
            lblCourriel.Size = new Size(73, 25);
            lblCourriel.TabIndex = 18;
            lblCourriel.Text = "Courriel";
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Location = new Point(544, 382);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(92, 25);
            lblTelephone.TabIndex = 19;
            lblTelephone.Text = "Téléphone";
            // 
            // lblMdp
            // 
            lblMdp.AutoSize = true;
            lblMdp.Location = new Point(544, 451);
            lblMdp.Name = "lblMdp";
            lblMdp.Size = new Size(120, 25);
            lblMdp.TabIndex = 20;
            lblMdp.Text = "Mot de passe";
            // 
            // txtMdp
            // 
            txtMdp.Location = new Point(740, 451);
            txtMdp.Name = "txtMdp";
            txtMdp.Size = new Size(298, 31);
            txtMdp.TabIndex = 21;
            // 
            // lblNaissance
            // 
            lblNaissance.AutoSize = true;
            lblNaissance.Location = new Point(544, 250);
            lblNaissance.Name = "lblNaissance";
            lblNaissance.Size = new Size(154, 25);
            lblNaissance.TabIndex = 22;
            lblNaissance.Text = "Date de naissance";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(440, 72);
            label1.Name = "label1";
            label1.Size = new Size(149, 45);
            label1.TabIndex = 23;
            label1.Text = "Bonjour !";
            label1.Click += label1_Click;
            // 
            // FormSInscrire
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 627);
            Controls.Add(label1);
            Controls.Add(lblNaissance);
            Controls.Add(txtMdp);
            Controls.Add(lblMdp);
            Controls.Add(lblTelephone);
            Controls.Add(lblCourriel);
            Controls.Add(lblNumeroRue);
            Controls.Add(lblPostal);
            Controls.Add(lblVille);
            Controls.Add(lblRue);
            Controls.Add(lblNss);
            Controls.Add(lblPrenom);
            Controls.Add(lblNom);
            Controls.Add(txtNumero);
            Controls.Add(btnInscription);
            Controls.Add(dtpDateNaissance);
            Controls.Add(txtPrenom);
            Controls.Add(txtNSS);
            Controls.Add(txtRue);
            Controls.Add(txtCodePostal);
            Controls.Add(txtEmail);
            Controls.Add(txtNom);
            Controls.Add(txtVille);
            Controls.Add(txtTelephone);
            Name = "FormSInscrire";
            Text = "FormSInscrire";
            Load += FormSInscrire_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTelephone;
        private TextBox txtVille;
        private TextBox txtNom;
        private TextBox txtEmail;
        private TextBox txtCodePostal;
        private TextBox txtRue;
        private TextBox txtNSS;
        private TextBox txtPrenom;
        private DateTimePicker dtpDateNaissance;
        private Button btnInscription;
        private TextBox txtNumero;
        private Label lblNom;
        private Label lblPrenom;
        private Label lblNss;
        private Label lblRue;
        private Label lblVille;
        private Label lblPostal;
        private Label lblNumeroRue;
        private Label lblCourriel;
        private Label lblTelephone;
        private Label lblMdp;
        private TextBox txtMdp;
        private Label lblNaissance;
        private Label label1;
    }
}