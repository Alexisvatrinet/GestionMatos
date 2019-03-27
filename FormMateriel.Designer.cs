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
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonInt = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Site = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mtbf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_utilisateur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_constructeur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_categorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelMateriel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.labelCat = new System.Windows.Forms.Label();
            this.labelConst = new System.Windows.Forms.Label();
            this.comboBoxConst = new System.Windows.Forms.ComboBox();
            this.textBoxIdCat = new System.Windows.Forms.TextBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.textBoxIdClient = new System.Windows.Forms.TextBox();
            this.textBoxIdConst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.textBoxCat = new System.Windows.Forms.TextBox();
            this.textBoxConst = new System.Windows.Forms.TextBox();
            this.id_intervention = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.labelMtbf.Size = new System.Drawing.Size(242, 17);
            this.labelMtbf.TabIndex = 35;
            this.labelMtbf.Text = "Temps moyen entre panne en année";
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
            this.textBoxSite.TabIndex = 3;
            // 
            // textBoxMtbf
            // 
            this.textBoxMtbf.Location = new System.Drawing.Point(294, 224);
            this.textBoxMtbf.Name = "textBoxMtbf";
            this.textBoxMtbf.Size = new System.Drawing.Size(265, 22);
            this.textBoxMtbf.TabIndex = 4;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(294, 114);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(265, 22);
            this.textBoxNom.TabIndex = 2;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(533, 399);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(125, 44);
            this.buttonValider.TabIndex = 10;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(668, 399);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(125, 44);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonInt
            // 
            this.buttonInt.Location = new System.Drawing.Point(726, 32);
            this.buttonInt.Name = "buttonInt";
            this.buttonInt.Size = new System.Drawing.Size(108, 38);
            this.buttonInt.TabIndex = 25;
            this.buttonInt.Text = "Intervention";
            this.buttonInt.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Enabled = false;
            this.buttonSupprimer.Location = new System.Drawing.Point(571, 32);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(91, 38);
            this.buttonSupprimer.TabIndex = 14;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Enabled = false;
            this.buttonModifier.Location = new System.Drawing.Point(474, 32);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(91, 38);
            this.buttonModifier.TabIndex = 13;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(377, 32);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(91, 38);
            this.buttonAjouter.TabIndex = 12;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Id,
            this.Site,
            this.Mtbf,
            this.Description,
            this.id_utilisateur,
            this.id_constructeur,
            this.id_categorie,
            this.id_intervention});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(41, 93);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(220, 395);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 100;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 0;
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
            // id_utilisateur
            // 
            this.id_utilisateur.Text = "id_utilisateur";
            this.id_utilisateur.Width = 0;
            // 
            // id_constructeur
            // 
            this.id_constructeur.Text = "id_constructeur";
            this.id_constructeur.Width = 0;
            // 
            // id_categorie
            // 
            this.id_categorie.Text = "id_categorie";
            this.id_categorie.Width = 0;
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
            this.textBoxMail.Location = new System.Drawing.Point(294, 332);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(265, 22);
            this.textBoxMail.TabIndex = 6;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(585, 113);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(249, 79);
            this.textBoxDesc.TabIndex = 7;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(587, 94);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(79, 17);
            this.labelDescription.TabIndex = 40;
            this.labelDescription.Text = "Description";
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.Enabled = false;
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Location = new System.Drawing.Point(585, 222);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(235, 24);
            this.comboBoxCat.TabIndex = 8;
            this.comboBoxCat.Visible = false;
            this.comboBoxCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxCat_SelectedIndexChanged);
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Location = new System.Drawing.Point(587, 204);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(69, 17);
            this.labelCat.TabIndex = 43;
            this.labelCat.Text = "Categorie";
            // 
            // labelConst
            // 
            this.labelConst.AutoSize = true;
            this.labelConst.Location = new System.Drawing.Point(587, 255);
            this.labelConst.Name = "labelConst";
            this.labelConst.Size = new System.Drawing.Size(89, 17);
            this.labelConst.TabIndex = 46;
            this.labelConst.Text = "Constructeur";
            // 
            // comboBoxConst
            // 
            this.comboBoxConst.Enabled = false;
            this.comboBoxConst.FormattingEnabled = true;
            this.comboBoxConst.Location = new System.Drawing.Point(585, 275);
            this.comboBoxConst.Name = "comboBoxConst";
            this.comboBoxConst.Size = new System.Drawing.Size(235, 24);
            this.comboBoxConst.TabIndex = 9;
            this.comboBoxConst.Visible = false;
            this.comboBoxConst.SelectedIndexChanged += new System.EventHandler(this.comboBoxConst_SelectedIndexChanged);
            // 
            // textBoxIdCat
            // 
            this.textBoxIdCat.Enabled = false;
            this.textBoxIdCat.Location = new System.Drawing.Point(324, 438);
            this.textBoxIdCat.Name = "textBoxIdCat";
            this.textBoxIdCat.ShortcutsEnabled = false;
            this.textBoxIdCat.Size = new System.Drawing.Size(23, 22);
            this.textBoxIdCat.TabIndex = 47;
            this.textBoxIdCat.TabStop = false;
            this.textBoxIdCat.Visible = false;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.Enabled = false;
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(294, 273);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(265, 24);
            this.comboBoxClient.TabIndex = 5;
            this.comboBoxClient.Visible = false;
            this.comboBoxClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxClient_SelectedIndexChanged);
            // 
            // textBoxIdClient
            // 
            this.textBoxIdClient.Enabled = false;
            this.textBoxIdClient.Location = new System.Drawing.Point(294, 438);
            this.textBoxIdClient.Name = "textBoxIdClient";
            this.textBoxIdClient.Size = new System.Drawing.Size(23, 22);
            this.textBoxIdClient.TabIndex = 49;
            this.textBoxIdClient.TabStop = false;
            this.textBoxIdClient.Visible = false;
            // 
            // textBoxIdConst
            // 
            this.textBoxIdConst.Enabled = false;
            this.textBoxIdConst.Location = new System.Drawing.Point(353, 438);
            this.textBoxIdConst.Name = "textBoxIdConst";
            this.textBoxIdConst.ShortcutsEnabled = false;
            this.textBoxIdConst.Size = new System.Drawing.Size(23, 22);
            this.textBoxIdConst.TabIndex = 50;
            this.textBoxIdConst.TabStop = false;
            this.textBoxIdConst.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Client cat const";
            this.label2.Visible = false;
            // 
            // textBoxClient
            // 
            this.textBoxClient.Location = new System.Drawing.Point(294, 275);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(265, 22);
            this.textBoxClient.TabIndex = 52;
            // 
            // textBoxCat
            // 
            this.textBoxCat.Location = new System.Drawing.Point(585, 222);
            this.textBoxCat.Name = "textBoxCat";
            this.textBoxCat.Size = new System.Drawing.Size(235, 22);
            this.textBoxCat.TabIndex = 53;
            // 
            // textBoxConst
            // 
            this.textBoxConst.Location = new System.Drawing.Point(585, 275);
            this.textBoxConst.Name = "textBoxConst";
            this.textBoxConst.Size = new System.Drawing.Size(235, 22);
            this.textBoxConst.TabIndex = 54;
            // 
            // id_intervention
            // 
            this.id_intervention.Text = "id_intervention";
            this.id_intervention.Width = 0;
            // 
            // FormMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 508);
            this.Controls.Add(this.textBoxConst);
            this.Controls.Add(this.textBoxCat);
            this.Controls.Add(this.textBoxClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIdConst);
            this.Controls.Add(this.textBoxIdClient);
            this.Controls.Add(this.labelConst);
            this.Controls.Add(this.comboBoxConst);
            this.Controls.Add(this.labelCat);
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
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonInt);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelMateriel);
            this.Controls.Add(this.textBoxIdCat);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.comboBoxCat);
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
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonInt;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelMateriel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Site;
        private System.Windows.Forms.ColumnHeader Mtbf;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader id_utilisateur;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.Label labelCat;
        private System.Windows.Forms.ColumnHeader id_categorie;
        private System.Windows.Forms.Label labelConst;
        private System.Windows.Forms.ComboBox comboBoxConst;
        private System.Windows.Forms.TextBox textBoxIdCat;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.TextBox textBoxIdClient;
        private System.Windows.Forms.TextBox textBoxIdConst;
        private System.Windows.Forms.ColumnHeader id_constructeur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.TextBox textBoxCat;
        private System.Windows.Forms.TextBox textBoxConst;
        private System.Windows.Forms.ColumnHeader id_intervention;
    }
}