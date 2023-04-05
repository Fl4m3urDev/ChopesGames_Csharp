namespace ChopesGames
{
    partial class FormCreerClient
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnCreer = new System.Windows.Forms.Button();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.tbxAdresse = new System.Windows.Forms.TextBox();
            this.tbxVille = new System.Windows.Forms.TextBox();
            this.tbxCodePostal = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblAvertissement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(31, 27);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(31, 60);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(31, 90);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblAdresse.TabIndex = 2;
            this.lblAdresse.Text = "Adresse";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(34, 121);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(26, 13);
            this.lblVille.TabIndex = 3;
            this.lblVille.Text = "Ville";
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Location = new System.Drawing.Point(34, 151);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(64, 13);
            this.lblCodePostal.TabIndex = 4;
            this.lblCodePostal.Text = "Code Postal";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(34, 184);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(247, 229);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(75, 23);
            this.btnCreer.TabIndex = 6;
            this.btnCreer.Text = "&Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // tbxNom
            // 
            this.tbxNom.ForeColor = System.Drawing.Color.Gray;
            this.tbxNom.Location = new System.Drawing.Point(126, 27);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(196, 20);
            this.tbxNom.TabIndex = 7;
            this.tbxNom.Text = "ex. : JAOUEN";
            this.tbxNom.Enter += new System.EventHandler(this.tbxNom_Enter);
            this.tbxNom.Leave += new System.EventHandler(this.tbxNom_Leave);
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.ForeColor = System.Drawing.Color.Gray;
            this.tbxPrenom.Location = new System.Drawing.Point(126, 60);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(196, 20);
            this.tbxPrenom.TabIndex = 8;
            this.tbxPrenom.Text = "ex. : Yves";
            this.tbxPrenom.Enter += new System.EventHandler(this.tbxPrenom_Enter);
            this.tbxPrenom.Leave += new System.EventHandler(this.tbxPrenom_Leave);
            // 
            // tbxAdresse
            // 
            this.tbxAdresse.ForeColor = System.Drawing.Color.Gray;
            this.tbxAdresse.Location = new System.Drawing.Point(126, 90);
            this.tbxAdresse.Name = "tbxAdresse";
            this.tbxAdresse.Size = new System.Drawing.Size(196, 20);
            this.tbxAdresse.TabIndex = 9;
            this.tbxAdresse.Text = "ex. : 1 rue de Gouédic (sans de virgule)";
            this.tbxAdresse.Enter += new System.EventHandler(this.tbxAdresse_Enter);
            this.tbxAdresse.Leave += new System.EventHandler(this.tbxAdresse_Leave);
            // 
            // tbxVille
            // 
            this.tbxVille.ForeColor = System.Drawing.Color.Gray;
            this.tbxVille.Location = new System.Drawing.Point(126, 118);
            this.tbxVille.Name = "tbxVille";
            this.tbxVille.Size = new System.Drawing.Size(196, 20);
            this.tbxVille.TabIndex = 10;
            this.tbxVille.Text = "ex. : Saint Brieuc";
            this.tbxVille.Enter += new System.EventHandler(this.tbxVille_Enter);
            this.tbxVille.Leave += new System.EventHandler(this.tbxVille_Leave);
            // 
            // tbxCodePostal
            // 
            this.tbxCodePostal.ForeColor = System.Drawing.Color.Gray;
            this.tbxCodePostal.Location = new System.Drawing.Point(126, 151);
            this.tbxCodePostal.Name = "tbxCodePostal";
            this.tbxCodePostal.Size = new System.Drawing.Size(196, 20);
            this.tbxCodePostal.TabIndex = 11;
            this.tbxCodePostal.Text = "ex. : 22000";
            this.tbxCodePostal.Enter += new System.EventHandler(this.tbxCodePostal_Enter);
            this.tbxCodePostal.Leave += new System.EventHandler(this.tbxCodePostal_Leave);
            // 
            // tbxEmail
            // 
            this.tbxEmail.ForeColor = System.Drawing.Color.Gray;
            this.tbxEmail.Location = new System.Drawing.Point(126, 184);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(196, 20);
            this.tbxEmail.TabIndex = 12;
            this.tbxEmail.Text = "ex. : yves.jaouen@rabelais.fr";
            this.tbxEmail.Enter += new System.EventHandler(this.tbxEmail_Enter);
            this.tbxEmail.Leave += new System.EventHandler(this.tbxEmail_Leave);
            // 
            // lblAvertissement
            // 
            this.lblAvertissement.AutoSize = true;
            this.lblAvertissement.Location = new System.Drawing.Point(49, 272);
            this.lblAvertissement.Name = "lblAvertissement";
            this.lblAvertissement.Size = new System.Drawing.Size(264, 13);
            this.lblAvertissement.TabIndex = 13;
            this.lblAvertissement.Text = "A l\'exception du mail, tous les champs sont obligatoires";
            // 
            // FormCreerClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 318);
            this.Controls.Add(this.lblAvertissement);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxCodePostal);
            this.Controls.Add(this.tbxVille);
            this.Controls.Add(this.tbxAdresse);
            this.Controls.Add(this.tbxPrenom);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCodePostal);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Name = "FormCreerClient";
            this.Text = "Créer un Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.TextBox tbxPrenom;
        private System.Windows.Forms.TextBox tbxAdresse;
        private System.Windows.Forms.TextBox tbxVille;
        private System.Windows.Forms.TextBox tbxCodePostal;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblAvertissement;
    }
}