namespace TransConnect_Stone_Romeo
{
    partial class FormProfilClient
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
            btnPasserCommande = new Button();
            lblNom = new Label();
            lblFidele = new Label();
            commandesView = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)commandesView).BeginInit();
            SuspendLayout();
            // 
            // btnPasserCommande
            // 
            btnPasserCommande.Location = new Point(241, 51);
            btnPasserCommande.Margin = new Padding(2);
            btnPasserCommande.Name = "btnPasserCommande";
            btnPasserCommande.Size = new Size(142, 27);
            btnPasserCommande.TabIndex = 0;
            btnPasserCommande.Text = "Passer commande";
            btnPasserCommande.UseVisualStyleBackColor = true;
            btnPasserCommande.Click += btnPasserCommande_Click;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(514, 9);
            lblNom.Margin = new Padding(2, 0, 2, 0);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(0, 20);
            lblNom.TabIndex = 3;
            // 
            // lblFidele
            // 
            lblFidele.AutoSize = true;
            lblFidele.Location = new Point(516, 36);
            lblFidele.Name = "lblFidele";
            lblFidele.Size = new Size(0, 20);
            lblFidele.TabIndex = 4;
            // 
            // commandesView
            // 
            commandesView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            commandesView.Location = new Point(12, 94);
            commandesView.Name = "commandesView";
            commandesView.RowHeadersWidth = 51;
            commandesView.Size = new Size(616, 254);
            commandesView.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(241, 9);
            button1.Name = "button1";
            button1.Size = new Size(142, 29);
            button1.TabIndex = 6;
            button1.Text = "Modifier infos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(108, 29);
            button2.TabIndex = 7;
            button2.Text = "Déconnexion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormProfilClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(commandesView);
            Controls.Add(lblFidele);
            Controls.Add(lblNom);
            Controls.Add(btnPasserCommande);
            Margin = new Padding(2);
            Name = "FormProfilClient";
            Text = "FormProfil";
            Load += FormProfilClient_Load;
            ((System.ComponentModel.ISupportInitialize)commandesView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPasserCommande;
        private Label lblBonjour;
        private Button BtnSuivreCommande;
        private Label lblNom;
        private Label lblFidele;
        private DataGridView commandesView;
        private Button button1;
        private Button button2;
    }
}
