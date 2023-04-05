namespace ChopesGames
{
    partial class FormCreerProduit
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
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblPrixHT = new System.Windows.Forms.Label();
            this.lblTauxTVA = new System.Windows.Forms.Label();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.cmbMarque = new System.Windows.Forms.ComboBox();
            this.tbxLibelle = new System.Windows.Forms.TextBox();
            this.tbxDetail = new System.Windows.Forms.TextBox();
            this.tbxPrixHT = new System.Windows.Forms.TextBox();
            this.tbxTauxTVA = new System.Windows.Forms.TextBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(28, 47);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(52, 13);
            this.lblCategorie.TabIndex = 0;
            this.lblCategorie.Text = "Catégorie";
            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.Location = new System.Drawing.Point(28, 79);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(43, 13);
            this.lblMarque.TabIndex = 1;
            this.lblMarque.Text = "Marque";
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(28, 118);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(37, 13);
            this.lblLibelle.TabIndex = 2;
            this.lblLibelle.Text = "Libellé";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(28, 155);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(34, 13);
            this.lblDetail.TabIndex = 3;
            this.lblDetail.Text = "Détail";
            // 
            // lblPrixHT
            // 
            this.lblPrixHT.AutoSize = true;
            this.lblPrixHT.Location = new System.Drawing.Point(29, 296);
            this.lblPrixHT.Name = "lblPrixHT";
            this.lblPrixHT.Size = new System.Drawing.Size(42, 13);
            this.lblPrixHT.TabIndex = 4;
            this.lblPrixHT.Text = "Prix HT";
            // 
            // lblTauxTVA
            // 
            this.lblTauxTVA.AutoSize = true;
            this.lblTauxTVA.Location = new System.Drawing.Point(28, 326);
            this.lblTauxTVA.Name = "lblTauxTVA";
            this.lblTauxTVA.Size = new System.Drawing.Size(55, 13);
            this.lblTauxTVA.TabIndex = 5;
            this.lblTauxTVA.Text = "Taux TVA";
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(153, 38);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(147, 21);
            this.cmbCategorie.TabIndex = 6;
            // 
            // cmbMarque
            // 
            this.cmbMarque.FormattingEnabled = true;
            this.cmbMarque.Location = new System.Drawing.Point(153, 71);
            this.cmbMarque.Name = "cmbMarque";
            this.cmbMarque.Size = new System.Drawing.Size(147, 21);
            this.cmbMarque.TabIndex = 7;
            // 
            // tbxLibelle
            // 
            this.tbxLibelle.Location = new System.Drawing.Point(153, 118);
            this.tbxLibelle.Name = "tbxLibelle";
            this.tbxLibelle.Size = new System.Drawing.Size(147, 20);
            this.tbxLibelle.TabIndex = 8;
            
            // 
            // tbxDetail
            // 
            this.tbxDetail.Location = new System.Drawing.Point(153, 155);
            this.tbxDetail.Multiline = true;
            this.tbxDetail.Name = "tbxDetail";
            this.tbxDetail.Size = new System.Drawing.Size(147, 116);
            this.tbxDetail.TabIndex = 9;
            
            // 
            // tbxPrixHT
            // 
            this.tbxPrixHT.Location = new System.Drawing.Point(153, 289);
            this.tbxPrixHT.Name = "tbxPrixHT";
            this.tbxPrixHT.Size = new System.Drawing.Size(147, 20);
            this.tbxPrixHT.TabIndex = 10;
            this.tbxPrixHT.Leave += new System.EventHandler(this.tbxPrixHT_Leave);
            // 
            // tbxTauxTVA
            // 
            this.tbxTauxTVA.Location = new System.Drawing.Point(153, 326);
            this.tbxTauxTVA.Name = "tbxTauxTVA";
            this.tbxTauxTVA.Size = new System.Drawing.Size(147, 20);
            this.tbxTauxTVA.TabIndex = 11;
            this.tbxTauxTVA.Leave += new System.EventHandler(this.tbxTauxTVA_Leave);
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(179, 365);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(121, 23);
            this.btnCreer.TabIndex = 12;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // FormCreerProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 426);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.tbxTauxTVA);
            this.Controls.Add(this.tbxPrixHT);
            this.Controls.Add(this.tbxDetail);
            this.Controls.Add(this.tbxLibelle);
            this.Controls.Add(this.cmbMarque);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.lblTauxTVA);
            this.Controls.Add(this.lblPrixHT);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.lblMarque);
            this.Controls.Add(this.lblCategorie);
            this.Name = "FormCreerProduit";
            this.Text = "Créer un produit";
            this.Load += new System.EventHandler(this.FormCreerProduit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblPrixHT;
        private System.Windows.Forms.Label lblTauxTVA;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.ComboBox cmbMarque;
        private System.Windows.Forms.TextBox tbxLibelle;
        private System.Windows.Forms.TextBox tbxDetail;
        private System.Windows.Forms.TextBox tbxPrixHT;
        private System.Windows.Forms.TextBox tbxTauxTVA;
        private System.Windows.Forms.Button btnCreer;
    }
}