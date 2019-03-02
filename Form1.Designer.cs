namespace PPE2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.bouttonOptions = new System.Windows.Forms.ToolStripDropDownButton();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interventionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categorieObjetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bouttonAide = new System.Windows.Forms.ToolStripDropDownButton();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripTop
            // 
            this.toolStripTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bouttonOptions,
            this.bouttonAide});
            this.toolStripTop.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(889, 27);
            this.toolStripTop.TabIndex = 0;
            this.toolStripTop.Text = "toolStrip1";
            // 
            // bouttonOptions
            // 
            this.bouttonOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bouttonOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.objetsToolStripMenuItem,
            this.interventionToolStripMenuItem,
            this.sitesToolStripMenuItem,
            this.categorieObjetToolStripMenuItem,
            this.fermerToolStripMenuItem});
            this.bouttonOptions.Image = ((System.Drawing.Image)(resources.GetObject("bouttonOptions.Image")));
            this.bouttonOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bouttonOptions.Name = "bouttonOptions";
            this.bouttonOptions.Size = new System.Drawing.Size(75, 24);
            this.bouttonOptions.Text = "Options";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.clientsToolStripMenuItem.Text = "Clients...";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // objetsToolStripMenuItem
            // 
            this.objetsToolStripMenuItem.Name = "objetsToolStripMenuItem";
            this.objetsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.objetsToolStripMenuItem.Text = "Objets...";
            // 
            // interventionToolStripMenuItem
            // 
            this.interventionToolStripMenuItem.Name = "interventionToolStripMenuItem";
            this.interventionToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.interventionToolStripMenuItem.Text = "Intervention...";
            // 
            // sitesToolStripMenuItem
            // 
            this.sitesToolStripMenuItem.Name = "sitesToolStripMenuItem";
            this.sitesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.sitesToolStripMenuItem.Text = "Sites...";
            // 
            // categorieObjetToolStripMenuItem
            // 
            this.categorieObjetToolStripMenuItem.Name = "categorieObjetToolStripMenuItem";
            this.categorieObjetToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.categorieObjetToolStripMenuItem.Text = "Categorie objet...";
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.fermerToolStripMenuItem.Text = "Fermer...";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // bouttonAide
            // 
            this.bouttonAide.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bouttonAide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.bouttonAide.Image = ((System.Drawing.Image)(resources.GetObject("bouttonAide.Image")));
            this.bouttonAide.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bouttonAide.Name = "bouttonAide";
            this.bouttonAide.Size = new System.Drawing.Size(54, 24);
            this.bouttonAide.Text = "Aide";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aProposToolStripMenuItem.Text = "A propos ...";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 483);
            this.Controls.Add(this.toolStripTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GestionMatos";
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ToolStripDropDownButton bouttonOptions;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interventionToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton bouttonAide;
        private System.Windows.Forms.ToolStripMenuItem sitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categorieObjetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
    }
}

