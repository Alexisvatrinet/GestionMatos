namespace PPE2
{
    partial class FormMateriel
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
            this.labelClient = new System.Windows.Forms.Label();
            this.labelMtbf = new System.Windows.Forms.Label();
            this.labelSite = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxSite = new System.Windows.Forms.TextBox();
            this.textBoxMtbf = new System.Windows.Forms.TextBox();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Site = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mtbf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelMateriel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(291, 255);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 17);
            this.labelClient.TabIndex = 36;
            this.labelClient.Text = "Client";
            // 
            // labelMtbf
            // 
            this.labelMtbf.AutoSize = true;
            this.labelMtbf.Location = new System.Drawing.Point(291, 204);
            this.labelMtbf.Name = "labelMtbf";
            this.labelMtbf.Size = new System.Drawing.Size(178, 17);
            this.labelMtbf.TabIndex = 35;
            this.labelMtbf.Text = "Temps moyen entre panne";
            // 
            // labelSite
            // 
            this.labelSite.AutoSize = true;
            this.labelSite.Location = new System.Drawing.Point(291, 150);
            this.labelSite.Name = "labelSite";
            this.labelSite.Size = new System.Drawing.Size(32, 17);
            this.labelSite.TabIndex = 34;
            this.labelSite.Text = "Site";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(291, 94);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(37, 17);
            this.labelNom.TabIndex = 33;
            this.labelNom.Text = "Nom";
            // 
            // textBoxSite
            // 
            this.textBoxSite.Location = new System.Drawing.Point(294, 170);
            this.textBoxSite.Name = "textBoxSite";
            this.textBoxSite.Size = new System.Drawing.Size(265, 22);
            this.textBoxSite.TabIndex = 28;
            // 
            // textBoxMtbf
            // 
            this.textBoxMtbf.Location = new System.Drawing.Point(294, 224);
            this.textBoxMtbf.Name = "textBoxMtbf";
            this.textBoxMtbf.Size = new System.Drawing.Size(265, 22);
            this.textBoxMtbf.TabIndex = 29;
            // 
            // textBoxClient
            // 
            this.textBoxClient.Location = new System.Drawing.Point(294, 275);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(265, 22);
            this.textBoxClient.TabIndex = 30;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(294, 114);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(265, 22);
            this.textBoxNom.TabIndex = 27;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(533, 399);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(129, 44);
            this.buttonValider.TabIndex = 31;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(668, 399);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(129, 44);
            this.buttonCancel.TabIndex = 32;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(682, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 38);
            this.button5.TabIndex = 26;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(585, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 38);
            this.button4.TabIndex = 25;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(488, 25);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(91, 38);
            this.buttonSupprimer.TabIndex = 24;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(391, 25);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(91, 38);
            this.buttonModifier.TabIndex = 22;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(294, 25);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(91, 38);
            this.buttonAjouter.TabIndex = 21;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nom,
            this.Site,
            this.Mtbf,
            this.Description});
            this.listView1.Location = new System.Drawing.Point(41, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(220, 395);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 0;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            // 
            // Site
            // 
            this.Site.Text = "Site";
            // 
            // Mtbf
            // 
            this.Mtbf.Text = "Mtbf";
            this.Mtbf.Width = 0;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 0;
            // 
            // labelMateriel
            // 
            this.labelMateriel.AutoSize = true;
            this.labelMateriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelMateriel.Location = new System.Drawing.Point(35, 39);
            this.labelMateriel.Name = "labelMateriel";
            this.labelMateriel.Size = new System.Drawing.Size(79, 31);
            this.labelMateriel.TabIndex = 20;
            this.labelMateriel.Text = "Objet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Mail";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(294, 330);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(265, 22);
            this.textBoxMail.TabIndex = 37;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(609, 113);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(249, 239);
            this.textBoxDesc.TabIndex = 39;
            this.textBoxDesc.TextChanged += new System.EventHandler(this.textBoxDesc_TextChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(606, 93);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(79, 17);
            this.labelDescription.TabIndex = 40;
            this.labelDescription.Text = "Description";
            // 
            // FormMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 508);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelMtbf);
            this.Controls.Add(this.labelSite);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxSite);
            this.Controls.Add(this.textBoxMtbf);
            this.Controls.Add(this.textBoxClient);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelMateriel);
            this.Name = "FormMateriel";
            this.Text = "FormMateriel";
            this.Load += new System.EventHandler(this.FormMateriel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelMtbf;
        private System.Windows.Forms.Label labelSite;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxSite;
        private System.Windows.Forms.TextBox textBoxMtbf;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelMateriel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Site;
        private System.Windows.Forms.ColumnHeader Mtbf;
        private System.Windows.Forms.ColumnHeader Description;
    }
}