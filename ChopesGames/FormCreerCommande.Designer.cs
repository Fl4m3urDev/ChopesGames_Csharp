namespace ChopesGames
{
    partial class FormCreerCommande
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
            this.components = new System.ComponentModel.Container();
            this.lblClient = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.gbxAjoutLigneCommande = new System.Windows.Forms.GroupBox();
            this.btnAjoutUneLigne = new System.Windows.Forms.Button();
            this.tbxQuantite = new System.Windows.Forms.TextBox();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.cmbProduit = new System.Windows.Forms.ComboBox();
            this.lblProduit = new System.Windows.Forms.Label();
            this.lvLignesCommande = new System.Windows.Forms.ListView();
            this.cmsLignesCommande = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miMiseAJourQuantite = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbxQuantite = new System.Windows.Forms.ToolStripTextBox();
            this.miValider = new System.Windows.Forms.ToolStripMenuItem();
            this.miSupprimerLigneCourante = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnReinitialiserFormulaire = new System.Windows.Forms.Button();
            this.gbxClientDate = new System.Windows.Forms.GroupBox();
            this.lblDateCourante = new System.Windows.Forms.Label();
            this.lblLibelleNombreDItems = new System.Windows.Forms.Label();
            this.lblNombreDItems = new System.Windows.Forms.Label();
            this.lblLibelleTotalHT = new System.Windows.Forms.Label();
            this.lblTotalHT = new System.Windows.Forms.Label();
            this.lblLibelleTotalTTC = new System.Windows.Forms.Label();
            this.lblTotalTTC = new System.Windows.Forms.Label();
            this.gbxAjoutLigneCommande.SuspendLayout();
            this.cmsLignesCommande.SuspendLayout();
            this.gbxClientDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(6, 27);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(33, 13);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Client";
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(45, 23);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(187, 21);
            this.cmbClient.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 67);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date : ";
            // 
            // gbxAjoutLigneCommande
            // 
            this.gbxAjoutLigneCommande.Controls.Add(this.btnAjoutUneLigne);
            this.gbxAjoutLigneCommande.Controls.Add(this.tbxQuantite);
            this.gbxAjoutLigneCommande.Controls.Add(this.lblQuantite);
            this.gbxAjoutLigneCommande.Controls.Add(this.cmbProduit);
            this.gbxAjoutLigneCommande.Controls.Add(this.lblProduit);
            this.gbxAjoutLigneCommande.Location = new System.Drawing.Point(286, 34);
            this.gbxAjoutLigneCommande.Name = "gbxAjoutLigneCommande";
            this.gbxAjoutLigneCommande.Size = new System.Drawing.Size(323, 116);
            this.gbxAjoutLigneCommande.TabIndex = 3;
            this.gbxAjoutLigneCommande.TabStop = false;
            this.gbxAjoutLigneCommande.Text = "Ajout d\'une ligne de commande";
            // 
            // btnAjoutUneLigne
            // 
            this.btnAjoutUneLigne.Location = new System.Drawing.Point(192, 74);
            this.btnAjoutUneLigne.Name = "btnAjoutUneLigne";
            this.btnAjoutUneLigne.Size = new System.Drawing.Size(107, 23);
            this.btnAjoutUneLigne.TabIndex = 4;
            this.btnAjoutUneLigne.Text = "&Ajout une ligne";
            this.btnAjoutUneLigne.UseVisualStyleBackColor = true;
            this.btnAjoutUneLigne.Click += new System.EventHandler(this.btnAjoutUneLigne_Click);
            // 
            // tbxQuantite
            // 
            this.tbxQuantite.Location = new System.Drawing.Point(72, 77);
            this.tbxQuantite.Name = "tbxQuantite";
            this.tbxQuantite.Size = new System.Drawing.Size(100, 20);
            this.tbxQuantite.TabIndex = 3;
            this.tbxQuantite.Text = "1";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(19, 81);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(47, 13);
            this.lblQuantite.TabIndex = 2;
            this.lblQuantite.Text = "Quantité";
            // 
            // cmbProduit
            // 
            this.cmbProduit.FormattingEnabled = true;
            this.cmbProduit.Location = new System.Drawing.Point(62, 33);
            this.cmbProduit.Name = "cmbProduit";
            this.cmbProduit.Size = new System.Drawing.Size(237, 21);
            this.cmbProduit.TabIndex = 1;
            // 
            // lblProduit
            // 
            this.lblProduit.AutoSize = true;
            this.lblProduit.Location = new System.Drawing.Point(16, 36);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(40, 13);
            this.lblProduit.TabIndex = 0;
            this.lblProduit.Text = "Produit";
            // 
            // lvLignesCommande
            // 
            this.lvLignesCommande.ContextMenuStrip = this.cmsLignesCommande;
            this.lvLignesCommande.HideSelection = false;
            this.lvLignesCommande.Location = new System.Drawing.Point(25, 175);
            this.lvLignesCommande.MultiSelect = false;
            this.lvLignesCommande.Name = "lvLignesCommande";
            this.lvLignesCommande.Size = new System.Drawing.Size(470, 214);
            this.lvLignesCommande.TabIndex = 4;
            this.lvLignesCommande.UseCompatibleStateImageBehavior = false;
            // 
            // cmsLignesCommande
            // 
            this.cmsLignesCommande.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMiseAJourQuantite,
            this.miSupprimerLigneCourante});
            this.cmsLignesCommande.Name = "cmsLignesCommande";
            this.cmsLignesCommande.Size = new System.Drawing.Size(209, 48);
            // 
            // miMiseAJourQuantite
            // 
            this.miMiseAJourQuantite.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstbxQuantite,
            this.miValider});
            this.miMiseAJourQuantite.Name = "miMiseAJourQuantite";
            this.miMiseAJourQuantite.Size = new System.Drawing.Size(208, 22);
            this.miMiseAJourQuantite.Text = "Mise à jour quantité";
            // 
            // tstbxQuantite
            // 
            this.tstbxQuantite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstbxQuantite.Name = "tstbxQuantite";
            this.tstbxQuantite.Size = new System.Drawing.Size(100, 23);
            // 
            // miValider
            // 
            this.miValider.Name = "miValider";
            this.miValider.Size = new System.Drawing.Size(180, 22);
            this.miValider.Text = "Valider";
            this.miValider.Click += new System.EventHandler(this.miValider_Click);
            // 
            // miSupprimerLigneCourante
            // 
            this.miSupprimerLigneCourante.Name = "miSupprimerLigneCourante";
            this.miSupprimerLigneCourante.Size = new System.Drawing.Size(208, 22);
            this.miSupprimerLigneCourante.Text = "Supprimer ligne courante";
            this.miSupprimerLigneCourante.Click += new System.EventHandler(this.miSupprimerLigneCourante_Click);
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(513, 175);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(96, 70);
            this.btnCreer.TabIndex = 5;
            this.btnCreer.Text = "Créer la commande";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // btnReinitialiserFormulaire
            // 
            this.btnReinitialiserFormulaire.Location = new System.Drawing.Point(513, 309);
            this.btnReinitialiserFormulaire.Name = "btnReinitialiserFormulaire";
            this.btnReinitialiserFormulaire.Size = new System.Drawing.Size(96, 80);
            this.btnReinitialiserFormulaire.TabIndex = 6;
            this.btnReinitialiserFormulaire.Text = "Réinitialiser Formulaire";
            this.btnReinitialiserFormulaire.UseVisualStyleBackColor = true;
            this.btnReinitialiserFormulaire.Click += new System.EventHandler(this.btnReinitialiserFormulaire_Click);
            // 
            // gbxClientDate
            // 
            this.gbxClientDate.Controls.Add(this.lblDateCourante);
            this.gbxClientDate.Controls.Add(this.cmbClient);
            this.gbxClientDate.Controls.Add(this.lblClient);
            this.gbxClientDate.Controls.Add(this.lblDate);
            this.gbxClientDate.Location = new System.Drawing.Point(28, 42);
            this.gbxClientDate.Name = "gbxClientDate";
            this.gbxClientDate.Size = new System.Drawing.Size(238, 100);
            this.gbxClientDate.TabIndex = 7;
            this.gbxClientDate.TabStop = false;
            // 
            // lblDateCourante
            // 
            this.lblDateCourante.AutoSize = true;
            this.lblDateCourante.Location = new System.Drawing.Point(42, 67);
            this.lblDateCourante.Name = "lblDateCourante";
            this.lblDateCourante.Size = new System.Drawing.Size(0, 13);
            this.lblDateCourante.TabIndex = 3;
            // 
            // lblLibelleNombreDItems
            // 
            this.lblLibelleNombreDItems.AutoSize = true;
            this.lblLibelleNombreDItems.Location = new System.Drawing.Point(25, 408);
            this.lblLibelleNombreDItems.Name = "lblLibelleNombreDItems";
            this.lblLibelleNombreDItems.Size = new System.Drawing.Size(149, 13);
            this.lblLibelleNombreDItems.TabIndex = 8;
            this.lblLibelleNombreDItems.Text = "Nombre d\'Items commandés : ";
            // 
            // lblNombreDItems
            // 
            this.lblNombreDItems.AutoSize = true;
            this.lblNombreDItems.Location = new System.Drawing.Point(181, 408);
            this.lblNombreDItems.Name = "lblNombreDItems";
            this.lblNombreDItems.Size = new System.Drawing.Size(13, 13);
            this.lblNombreDItems.TabIndex = 9;
            this.lblNombreDItems.Text = "0";
            // 
            // lblLibelleTotalHT
            // 
            this.lblLibelleTotalHT.AutoSize = true;
            this.lblLibelleTotalHT.Location = new System.Drawing.Point(224, 408);
            this.lblLibelleTotalHT.Name = "lblLibelleTotalHT";
            this.lblLibelleTotalHT.Size = new System.Drawing.Size(58, 13);
            this.lblLibelleTotalHT.TabIndex = 10;
            this.lblLibelleTotalHT.Text = "Total HT : ";
            // 
            // lblTotalHT
            // 
            this.lblTotalHT.AutoSize = true;
            this.lblTotalHT.Location = new System.Drawing.Point(289, 407);
            this.lblTotalHT.Name = "lblTotalHT";
            this.lblTotalHT.Size = new System.Drawing.Size(13, 13);
            this.lblTotalHT.TabIndex = 11;
            this.lblTotalHT.Text = "0";
            // 
            // lblLibelleTotalTTC
            // 
            this.lblLibelleTotalTTC.AutoSize = true;
            this.lblLibelleTotalTTC.Location = new System.Drawing.Point(355, 407);
            this.lblLibelleTotalTTC.Name = "lblLibelleTotalTTC";
            this.lblLibelleTotalTTC.Size = new System.Drawing.Size(64, 13);
            this.lblLibelleTotalTTC.TabIndex = 12;
            this.lblLibelleTotalTTC.Text = "Total TTC : ";
            // 
            // lblTotalTTC
            // 
            this.lblTotalTTC.AutoSize = true;
            this.lblTotalTTC.Location = new System.Drawing.Point(445, 408);
            this.lblTotalTTC.Name = "lblTotalTTC";
            this.lblTotalTTC.Size = new System.Drawing.Size(13, 13);
            this.lblTotalTTC.TabIndex = 13;
            this.lblTotalTTC.Text = "0";
            // 
            // FormCreerCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 453);
            this.Controls.Add(this.lblTotalTTC);
            this.Controls.Add(this.lblLibelleTotalTTC);
            this.Controls.Add(this.lblTotalHT);
            this.Controls.Add(this.lblLibelleTotalHT);
            this.Controls.Add(this.lblNombreDItems);
            this.Controls.Add(this.lblLibelleNombreDItems);
            this.Controls.Add(this.gbxClientDate);
            this.Controls.Add(this.btnReinitialiserFormulaire);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.lvLignesCommande);
            this.Controls.Add(this.gbxAjoutLigneCommande);
            this.Name = "FormCreerCommande";
            this.Text = "Créer une commande";
            this.Load += new System.EventHandler(this.FormCreerCommande_Load);
            this.gbxAjoutLigneCommande.ResumeLayout(false);
            this.gbxAjoutLigneCommande.PerformLayout();
            this.cmsLignesCommande.ResumeLayout(false);
            this.gbxClientDate.ResumeLayout(false);
            this.gbxClientDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox gbxAjoutLigneCommande;
        private System.Windows.Forms.TextBox tbxQuantite;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.ComboBox cmbProduit;
        private System.Windows.Forms.Label lblProduit;
        private System.Windows.Forms.Button btnAjoutUneLigne;
        private System.Windows.Forms.ListView lvLignesCommande;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnReinitialiserFormulaire;
        private System.Windows.Forms.GroupBox gbxClientDate;
        private System.Windows.Forms.Label lblDateCourante;
        private System.Windows.Forms.Label lblLibelleNombreDItems;
        private System.Windows.Forms.Label lblNombreDItems;
        private System.Windows.Forms.Label lblLibelleTotalHT;
        private System.Windows.Forms.Label lblTotalHT;
        private System.Windows.Forms.Label lblLibelleTotalTTC;
        private System.Windows.Forms.Label lblTotalTTC;
        private System.Windows.Forms.ContextMenuStrip cmsLignesCommande;
        private System.Windows.Forms.ToolStripMenuItem miMiseAJourQuantite;
        private System.Windows.Forms.ToolStripMenuItem miSupprimerLigneCourante;
        private System.Windows.Forms.ToolStripTextBox tstbxQuantite;
        private System.Windows.Forms.ToolStripMenuItem miValider;
    }
}