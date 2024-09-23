namespace TransConnect_Stone_Romeo
{
    partial class FormMenuPrincipal
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
            BtnSeConnecter = new Button();
            BtnSInscrire = new Button();
            lblBienvenue = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // BtnSeConnecter
            // 
            BtnSeConnecter.Location = new Point(326, 251);
            BtnSeConnecter.Margin = new Padding(2);
            BtnSeConnecter.Name = "BtnSeConnecter";
            BtnSeConnecter.Size = new Size(168, 34);
            BtnSeConnecter.TabIndex = 0;
            BtnSeConnecter.Text = "Se connecter";
            BtnSeConnecter.UseVisualStyleBackColor = true;
            BtnSeConnecter.Click += button1_Click;
            // 
            // BtnSInscrire
            // 
            BtnSInscrire.Location = new Point(326, 301);
            BtnSInscrire.Margin = new Padding(2);
            BtnSInscrire.Name = "BtnSInscrire";
            BtnSInscrire.Size = new Size(168, 34);
            BtnSInscrire.TabIndex = 1;
            BtnSInscrire.Text = "S'inscrire";
            BtnSInscrire.UseVisualStyleBackColor = true;
            BtnSInscrire.Click += button2_Click;
            // 
            // lblBienvenue
            // 
            lblBienvenue.AutoSize = true;
            lblBienvenue.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenue.Location = new Point(219, 75);
            lblBienvenue.Margin = new Padding(2, 0, 2, 0);
            lblBienvenue.Name = "lblBienvenue";
            lblBienvenue.Size = new Size(384, 64);
            lblBienvenue.TabIndex = 2;
            lblBienvenue.Text = "Bienvenue sur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(242, 139);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(332, 65);
            label2.TabIndex = 3;
            label2.Text = "TransConnect";
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(lblBienvenue);
            Controls.Add(BtnSInscrire);
            Controls.Add(BtnSeConnecter);
            Margin = new Padding(2);
            Name = "FormMenuPrincipal";
            Text = "MenuPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSeConnecter;
        private Button BtnSInscrire;
        private Label lblBienvenue;
        private Label label2;
    }
}