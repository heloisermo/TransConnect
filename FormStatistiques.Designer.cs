namespace TransConnect_Stone_Romeo
{
    partial class FormStatistiques
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
            dateTimePicker2 = new DateTimePicker();
            lblFin = new Label();
            lblDebut = new Label();
            btnCommandes = new Button();
            lblPrixMoyen = new Label();
            lblCompteCLientMoyen = new Label();
            commandesView = new DataGridView();
            btnAfficheClient = new Button();
            clientsView = new DataGridView();
            cbxTri = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)commandesView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientsView).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(135, 54);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(241, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(135, 102);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(241, 27);
            dateTimePicker2.TabIndex = 1;
            // 
            // lblFin
            // 
            lblFin.AutoSize = true;
            lblFin.Location = new Point(20, 106);
            lblFin.Margin = new Padding(2, 0, 2, 0);
            lblFin.Name = "lblFin";
            lblFin.Size = new Size(62, 20);
            lblFin.TabIndex = 2;
            lblFin.Text = "Date fin";
            // 
            // lblDebut
            // 
            lblDebut.AutoSize = true;
            lblDebut.Location = new Point(20, 54);
            lblDebut.Margin = new Padding(2, 0, 2, 0);
            lblDebut.Name = "lblDebut";
            lblDebut.Size = new Size(88, 20);
            lblDebut.TabIndex = 3;
            lblDebut.Text = "Date  début";
            // 
            // btnCommandes
            // 
            btnCommandes.Location = new Point(402, 54);
            btnCommandes.Margin = new Padding(2);
            btnCommandes.Name = "btnCommandes";
            btnCommandes.Size = new Size(97, 74);
            btnCommandes.TabIndex = 5;
            btnCommandes.Text = "Afficher commandes";
            btnCommandes.UseVisualStyleBackColor = true;
            btnCommandes.Click += button1_Click;
            // 
            // lblPrixMoyen
            // 
            lblPrixMoyen.AutoSize = true;
            lblPrixMoyen.Location = new Point(20, 238);
            lblPrixMoyen.Margin = new Padding(2, 0, 2, 0);
            lblPrixMoyen.Name = "lblPrixMoyen";
            lblPrixMoyen.Size = new Size(50, 20);
            lblPrixMoyen.TabIndex = 6;
            lblPrixMoyen.Text = "label1";
            // 
            // lblCompteCLientMoyen
            // 
            lblCompteCLientMoyen.AutoSize = true;
            lblCompteCLientMoyen.Location = new Point(19, 289);
            lblCompteCLientMoyen.Margin = new Padding(2, 0, 2, 0);
            lblCompteCLientMoyen.Name = "lblCompteCLientMoyen";
            lblCompteCLientMoyen.Size = new Size(50, 20);
            lblCompteCLientMoyen.TabIndex = 7;
            lblCompteCLientMoyen.Text = "label1";
            // 
            // commandesView
            // 
            commandesView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            commandesView.Location = new Point(537, 54);
            commandesView.Name = "commandesView";
            commandesView.RowHeadersWidth = 51;
            commandesView.Size = new Size(406, 149);
            commandesView.TabIndex = 8;
            // 
            // btnAfficheClient
            // 
            btnAfficheClient.Location = new Point(803, 238);
            btnAfficheClient.Name = "btnAfficheClient";
            btnAfficheClient.Size = new Size(140, 29);
            btnAfficheClient.TabIndex = 9;
            btnAfficheClient.Text = "Afficher les clients";
            btnAfficheClient.UseVisualStyleBackColor = true;
            btnAfficheClient.Click += btnAfficheClient_Click;
            // 
            // clientsView
            // 
            clientsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsView.Location = new Point(402, 289);
            clientsView.Name = "clientsView";
            clientsView.RowHeadersWidth = 51;
            clientsView.Size = new Size(541, 259);
            clientsView.TabIndex = 10;
            // 
            // cbxTri
            // 
            cbxTri.FormattingEnabled = true;
            cbxTri.Location = new Point(581, 239);
            cbxTri.Name = "cbxTri";
            cbxTri.Size = new Size(204, 28);
            cbxTri.TabIndex = 11;
            // 
            // FormStatistiques
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 668);
            Controls.Add(cbxTri);
            Controls.Add(clientsView);
            Controls.Add(btnAfficheClient);
            Controls.Add(commandesView);
            Controls.Add(lblCompteCLientMoyen);
            Controls.Add(lblPrixMoyen);
            Controls.Add(btnCommandes);
            Controls.Add(lblDebut);
            Controls.Add(lblFin);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Margin = new Padding(2);
            Name = "FormStatistiques";
            Text = "Statistiques";
            Load += FormStatistiques_Load;
            ((System.ComponentModel.ISupportInitialize)commandesView).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientsView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label lblFin;
        private Label lblDebut;
        private Button btnCommandes;
        private Label lblPrixMoyen;
        private Label lblCompteCLientMoyen;
        private DataGridView commandesView;
        private Button btnAfficheClient;
        private DataGridView clientsView;
        private ComboBox cbxTri;
    }
}