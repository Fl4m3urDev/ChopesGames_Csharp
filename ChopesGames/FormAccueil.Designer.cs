namespace ChopesGames
{
    partial class FormAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccueil));
            this.msCreer = new System.Windows.Forms.MenuStrip();
            this.creerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miCreerClient = new System.Windows.Forms.ToolStripMenuItem();
            this.miCreerProduit = new System.Windows.Forms.ToolStripMenuItem();
            this.miCreerCommande = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miModifierProduit = new System.Windows.Forms.ToolStripMenuItem();
            this.listerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miListerCommandes = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAProposDeSpaceBoutique = new System.Windows.Forms.ToolStripMenuItem();
            this.msCreer.SuspendLayout();
            this.SuspendLayout();
            // 
            // msCreer
            // 
            this.msCreer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creerToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.listerToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.msCreer.Location = new System.Drawing.Point(0, 0);
            this.msCreer.Name = "msCreer";
            this.msCreer.Size = new System.Drawing.Size(797, 24);
            this.msCreer.TabIndex = 0;
            this.msCreer.Text = "menuStrip1";
            // 
            // creerToolStripMenuItem
            // 
            this.creerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCreerClient,
            this.miCreerProduit,
            this.miCreerCommande});
            this.creerToolStripMenuItem.Name = "creerToolStripMenuItem";
            this.creerToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.creerToolStripMenuItem.Text = "Créer";
            // 
            // miCreerClient
            // 
            this.miCreerClient.Name = "miCreerClient";
            this.miCreerClient.Size = new System.Drawing.Size(137, 22);
            this.miCreerClient.Text = "Client";
            this.miCreerClient.Click += new System.EventHandler(this.miCreerClient_Click);
            // 
            // miCreerProduit
            // 
            this.miCreerProduit.Name = "miCreerProduit";
            this.miCreerProduit.Size = new System.Drawing.Size(137, 22);
            this.miCreerProduit.Text = "Produit";
            this.miCreerProduit.Click += new System.EventHandler(this.miCreerProduit_Click);
            // 
            // miCreerCommande
            // 
            this.miCreerCommande.Name = "miCreerCommande";
            this.miCreerCommande.Size = new System.Drawing.Size(137, 22);
            this.miCreerCommande.Text = "Commande";
            this.miCreerCommande.Click += new System.EventHandler(this.miCreerCommande_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miModifierProduit});
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // miModifierProduit
            // 
            this.miModifierProduit.Name = "miModifierProduit";
            this.miModifierProduit.Size = new System.Drawing.Size(113, 22);
            this.miModifierProduit.Text = "Produit";
            // 
            // listerToolStripMenuItem
            // 
            this.listerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miListerCommandes});
            this.listerToolStripMenuItem.Name = "listerToolStripMenuItem";
            this.listerToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.listerToolStripMenuItem.Text = "Lister";
            // 
            // miListerCommandes
            // 
            this.miListerCommandes.Name = "miListerCommandes";
            this.miListerCommandes.Size = new System.Drawing.Size(142, 22);
            this.miListerCommandes.Text = "Commandes";
            this.miListerCommandes.Click += new System.EventHandler(this.miListerCommandes_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAProposDeSpaceBoutique});
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aProposToolStripMenuItem.Text = "Aide";
            // 
            // miAProposDeSpaceBoutique
            // 
            this.miAProposDeSpaceBoutique.Name = "miAProposDeSpaceBoutique";
            this.miAProposDeSpaceBoutique.Size = new System.Drawing.Size(217, 22);
            this.miAProposDeSpaceBoutique.Text = "A Propos de ChopesGames";
            this.miAProposDeSpaceBoutique.Click += new System.EventHandler(this.miAProposDeSpaceBoutique_Click);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(797, 446);
            this.Controls.Add(this.msCreer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msCreer;
            this.Name = "FormAccueil";
            this.Text = "Accueil";
            this.msCreer.ResumeLayout(false);
            this.msCreer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msCreer;
        private System.Windows.Forms.ToolStripMenuItem creerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miCreerClient;
        private System.Windows.Forms.ToolStripMenuItem miCreerProduit;
        private System.Windows.Forms.ToolStripMenuItem miCreerCommande;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miModifierProduit;
        private System.Windows.Forms.ToolStripMenuItem listerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miListerCommandes;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miAProposDeSpaceBoutique;
    }
}

