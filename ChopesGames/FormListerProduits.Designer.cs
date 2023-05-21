namespace ChopesGames
{
    partial class FormListerProduits
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
            this.lblRechercheCatalogue = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.cmbMarque = new System.Windows.Forms.ComboBox();
            this.lvProduits = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblRechercheCatalogue
            //
            this.lblRechercheCatalogue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRechercheCatalogue.AutoSize = true;
            this.lblRechercheCatalogue.Location = new System.Drawing.Point(239, 9);
            this.lblRechercheCatalogue.Name = "lblRechercheCatalogue";
            this.lblRechercheCatalogue.Size = new System.Drawing.Size(171, 13);
            this.lblRechercheCatalogue.TabIndex = 0;
            this.lblRechercheCatalogue.Text = "Recherche dans le catalogue par :";
            // 
            // lblCategorie
            //
            this.lblCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(22, 50);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(52, 13);
            this.lblCategorie.TabIndex = 1;
            this.lblCategorie.Text = "Catégorie";
            // 
            // lblMarque
            //
            this.lblMarque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMarque.AutoSize = true;
            this.lblMarque.Location = new System.Drawing.Point(22, 91);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(43, 13);
            this.lblMarque.TabIndex = 2;
            this.lblMarque.Text = "Marque";
            // 
            // cmbCategorie
            //
            this.cmbCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(89, 47);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(173, 21);
            this.cmbCategorie.TabIndex = 3;
            this.cmbCategorie.SelectedIndexChanged += new System.EventHandler(this.cmbCategorie_SelectedIndexChanged);
            // 
            // cmbMarque
            // 
            this.cmbMarque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMarque.FormattingEnabled = true;
            this.cmbMarque.Location = new System.Drawing.Point(89, 88);
            this.cmbMarque.Name = "cmbMarque";
            this.cmbMarque.Size = new System.Drawing.Size(173, 21);
            this.cmbMarque.TabIndex = 4;
            this.cmbMarque.SelectedIndexChanged += new System.EventHandler(this.cmbMarque_SelectedIndexChanged);
            // 
            // lvProduits
            //
            this.lvProduits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProduits.HideSelection = false;
            this.lvProduits.Location = new System.Drawing.Point(25, 129);
            this.lvProduits.Name = "lvProduits";
            this.lvProduits.Size = new System.Drawing.Size(601, 349);
            this.lvProduits.TabIndex = 5;
            this.lvProduits.UseCompatibleStateImageBehavior = false;
            // 
            // FormListerProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.lvProduits);
            this.Controls.Add(this.cmbMarque);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.lblMarque);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblRechercheCatalogue);
            this.Name = "FormListerProduits";
            this.Text = "Liste des Produits";
            this.Load += new System.EventHandler(this.FormListerProduits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRechercheCatalogue;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.ComboBox cmbMarque;
        private System.Windows.Forms.ListView lvProduits;
    }
}