namespace TransConnect_Stone_Romeo
{
    partial class FormSeConnecter
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
            components = new System.ComponentModel.Container();
            txtMdp = new TextBox();
            LblMdp = new Label();
            btnMeConnecter = new Button();
            lblMail = new Label();
            txtMail = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            lblBonjour = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtMdp
            // 
            txtMdp.Location = new Point(275, 246);
            txtMdp.Name = "txtMdp";
            txtMdp.Size = new Size(324, 31);
            txtMdp.TabIndex = 1;
            // 
            // LblMdp
            // 
            LblMdp.AutoSize = true;
            LblMdp.Location = new Point(88, 252);
            LblMdp.Name = "LblMdp";
            LblMdp.Size = new Size(181, 25);
            LblMdp.TabIndex = 3;
            LblMdp.Text = "Votre mot de passe : ";
            // 
            // btnMeConnecter
            // 
            btnMeConnecter.Location = new Point(331, 342);
            btnMeConnecter.Name = "btnMeConnecter";
            btnMeConnecter.Size = new Size(145, 34);
            btnMeConnecter.TabIndex = 4;
            btnMeConnecter.Text = "Connexion";
            btnMeConnecter.UseVisualStyleBackColor = true;
            btnMeConnecter.Click += btnMeConnecter_Click;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(154, 164);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(115, 25);
            lblMail.TabIndex = 5;
            lblMail.Text = "Votre email : ";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(275, 158);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(324, 31);
            txtMail.TabIndex = 6;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblBonjour
            // 
            lblBonjour.AutoSize = true;
            lblBonjour.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBonjour.ForeColor = SystemColors.ActiveCaption;
            lblBonjour.Location = new Point(189, 62);
            lblBonjour.Name = "lblBonjour";
            lblBonjour.Size = new Size(454, 48);
            lblBonjour.TabIndex = 7;
            lblBonjour.Text = "Quel plaisir de vous revoir !";
            // 
            // FormSeConnecter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBonjour);
            Controls.Add(txtMail);
            Controls.Add(lblMail);
            Controls.Add(btnMeConnecter);
            Controls.Add(LblMdp);
            Controls.Add(txtMdp);
            Name = "FormSeConnecter";
            Text = "SeConnecter";
            Load += FormSeConnecter_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNom;
        private TextBox txtMdp;
        private Label lblNom;
        private Label LblMdp;
        private Button btnMeConnecter;
        private Label lblMail;
        private TextBox txtMail;
        private ErrorProvider errorProvider1;
        private Label lblBonjour;
    }
}