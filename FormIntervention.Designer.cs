namespace PPE2
{
    partial class FormIntervention
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
            this.labelMail = new System.Windows.Forms.Label();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.labelPlanifie = new System.Windows.Forms.Label();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Plan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Etat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Commentaire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelIntervention = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelCommentaire = new System.Windows.Forms.Label();
            this.labelEtat = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.textBoxEtat = new System.Windows.Forms.TextBox();
            this.textBoxComm = new System.Windows.Forms.TextBox();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPlan = new System.Windows.Forms.MaskedTextBox();
            this.textBoxIdSelect = new System.Windows.Forms.TextBox();
            this.textBoxIdClient = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelValider = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxObjet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdObjet = new System.Windows.Forms.TextBox();
            this.textBoxObjet = new System.Windows.Forms.TextBox();
            this.checkBoxDone = new System.Windows.Forms.CheckBox();
            this.labelCancel = new System.Windows.Forms.Label();
            this.textBoxCancel = new System.Windows.Forms.TextBox();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(317, 260);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(33, 17);
            this.labelMail.TabIndex = 36;
            this.labelMail.Text = "Mail";
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Location = new System.Drawing.Point(317, 209);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(76, 17);
            this.labelTelephone.TabIndex = 35;
            this.labelTelephone.Text = "Téléphone";
            // 
            // labelPlanifie
            // 
            this.labelPlanifie.AutoSize = true;
            this.labelPlanifie.Location = new System.Drawing.Point(583, 209);
            this.labelPlanifie.Name = "labelPlanifie";
            this.labelPlanifie.Size = new System.Drawing.Size(77, 17);
            this.labelPlanifie.TabIndex = 33;
            this.labelPlanifie.Text = "Planifié le :";
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(320, 229);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(222, 22);
            this.textBoxTelephone.TabIndex = 7;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(320, 280);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(222, 22);
            this.textBoxMail.TabIndex = 8;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(523, 424);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(129, 44);
            this.buttonValider.TabIndex = 13;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(658, 424);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(129, 44);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(738, 39);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(91, 38);
            this.buttonSupprimer.TabIndex = 3;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(641, 39);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(91, 38);
            this.buttonModifier.TabIndex = 2;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(544, 39);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(91, 38);
            this.buttonAjouter.TabIndex = 1;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Plan,
            this.Etat,
            this.Commentaire,
            this.idint});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(41, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(252, 395);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Plan
            // 
            this.Plan.Text = "Planifié";
            this.Plan.Width = 135;
            // 
            // Etat
            // 
            this.Etat.Text = "Terminée";
            // 
            // Commentaire
            // 
            this.Commentaire.Text = "Commentaire";
            this.Commentaire.Width = 0;
            // 
            // idint
            // 
            this.idint.Text = "id_int";
            this.idint.Width = 0;
            // 
            // labelIntervention
            // 
            this.labelIntervention.AutoSize = true;
            this.labelIntervention.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelIntervention.Location = new System.Drawing.Point(35, 37);
            this.labelIntervention.Name = "labelIntervention";
            this.labelIntervention.Size = new System.Drawing.Size(157, 31);
            this.labelIntervention.TabIndex = 20;
            this.labelIntervention.Text = "Intervention";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(320, 175);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(222, 22);
            this.textBoxAdresse.TabIndex = 6;
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(317, 155);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(60, 17);
            this.labelAdresse.TabIndex = 34;
            this.labelAdresse.Text = "Adresse";
            // 
            // labelCommentaire
            // 
            this.labelCommentaire.AutoSize = true;
            this.labelCommentaire.Location = new System.Drawing.Point(583, 99);
            this.labelCommentaire.Name = "labelCommentaire";
            this.labelCommentaire.Size = new System.Drawing.Size(91, 17);
            this.labelCommentaire.TabIndex = 43;
            this.labelCommentaire.Text = "Commentaire";
            // 
            // labelEtat
            // 
            this.labelEtat.AutoSize = true;
            this.labelEtat.Location = new System.Drawing.Point(583, 260);
            this.labelEtat.Name = "labelEtat";
            this.labelEtat.Size = new System.Drawing.Size(33, 17);
            this.labelEtat.TabIndex = 42;
            this.labelEtat.Text = "Etat";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(317, 311);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 17);
            this.labelClient.TabIndex = 41;
            this.labelClient.Text = "Client";
            // 
            // textBoxEtat
            // 
            this.textBoxEtat.Location = new System.Drawing.Point(586, 280);
            this.textBoxEtat.Name = "textBoxEtat";
            this.textBoxEtat.Size = new System.Drawing.Size(212, 22);
            this.textBoxEtat.TabIndex = 11;
            this.textBoxEtat.TextChanged += new System.EventHandler(this.textBoxEtat_TextChanged);
            // 
            // textBoxComm
            // 
            this.textBoxComm.Location = new System.Drawing.Point(586, 119);
            this.textBoxComm.Multiline = true;
            this.textBoxComm.Name = "textBoxComm";
            this.textBoxComm.Size = new System.Drawing.Size(212, 73);
            this.textBoxComm.TabIndex = 10;
            this.textBoxComm.TextChanged += new System.EventHandler(this.textBoxComm_TextChanged);
            // 
            // textBoxClient
            // 
            this.textBoxClient.Location = new System.Drawing.Point(320, 331);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(222, 22);
            this.textBoxClient.TabIndex = 5;
            // 
            // maskedTextBoxPlan
            // 
            this.maskedTextBoxPlan.Location = new System.Drawing.Point(586, 229);
            this.maskedTextBoxPlan.Mask = "00/00/0000";
            this.maskedTextBoxPlan.Name = "maskedTextBoxPlan";
            this.maskedTextBoxPlan.Size = new System.Drawing.Size(212, 22);
            this.maskedTextBoxPlan.TabIndex = 12;
            this.maskedTextBoxPlan.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxPlan.TextChanged += new System.EventHandler(this.maskedTextBoxPlan_TextChanged);
            // 
            // textBoxIdSelect
            // 
            this.textBoxIdSelect.Enabled = false;
            this.textBoxIdSelect.Location = new System.Drawing.Point(57, 12);
            this.textBoxIdSelect.Name = "textBoxIdSelect";
            this.textBoxIdSelect.Size = new System.Drawing.Size(25, 22);
            this.textBoxIdSelect.TabIndex = 45;
            this.textBoxIdSelect.TabStop = false;
            this.textBoxIdSelect.Text = "id";
            this.textBoxIdSelect.Visible = false;
            // 
            // textBoxIdClient
            // 
            this.textBoxIdClient.Enabled = false;
            this.textBoxIdClient.Location = new System.Drawing.Point(89, 12);
            this.textBoxIdClient.Name = "textBoxIdClient";
            this.textBoxIdClient.Size = new System.Drawing.Size(25, 22);
            this.textBoxIdClient.TabIndex = 47;
            this.textBoxIdClient.Visible = false;
            this.textBoxIdClient.TextChanged += new System.EventHandler(this.textBoxIdClient_TextChanged);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.labelInfo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelInfo.Location = new System.Drawing.Point(317, 450);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 20);
            this.labelInfo.TabIndex = 48;
            // 
            // labelValider
            // 
            this.labelValider.AutoSize = true;
            this.labelValider.Location = new System.Drawing.Point(435, 482);
            this.labelValider.Name = "labelValider";
            this.labelValider.Size = new System.Drawing.Size(0, 17);
            this.labelValider.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 50;
            // 
            // comboBoxObjet
            // 
            this.comboBoxObjet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxObjet.Enabled = false;
            this.comboBoxObjet.FormattingEnabled = true;
            this.comboBoxObjet.Location = new System.Drawing.Point(320, 119);
            this.comboBoxObjet.Name = "comboBoxObjet";
            this.comboBoxObjet.Size = new System.Drawing.Size(222, 24);
            this.comboBoxObjet.TabIndex = 9;
            this.comboBoxObjet.Visible = false;
            this.comboBoxObjet.SelectedIndexChanged += new System.EventHandler(this.comboBoxObjet_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 100);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Objet";
            // 
            // textBoxIdObjet
            // 
            this.textBoxIdObjet.Enabled = false;
            this.textBoxIdObjet.Location = new System.Drawing.Point(119, 12);
            this.textBoxIdObjet.Name = "textBoxIdObjet";
            this.textBoxIdObjet.Size = new System.Drawing.Size(25, 22);
            this.textBoxIdObjet.TabIndex = 53;
            this.textBoxIdObjet.Visible = false;
            // 
            // textBoxObjet
            // 
            this.textBoxObjet.Enabled = false;
            this.textBoxObjet.Location = new System.Drawing.Point(320, 119);
            this.textBoxObjet.Name = "textBoxObjet";
            this.textBoxObjet.Size = new System.Drawing.Size(222, 22);
            this.textBoxObjet.TabIndex = 9;
            // 
            // checkBoxDone
            // 
            this.checkBoxDone.AutoSize = true;
            this.checkBoxDone.Location = new System.Drawing.Point(586, 311);
            this.checkBoxDone.Name = "checkBoxDone";
            this.checkBoxDone.Size = new System.Drawing.Size(94, 21);
            this.checkBoxDone.TabIndex = 54;
            this.checkBoxDone.Text = "Accomplie";
            this.checkBoxDone.UseVisualStyleBackColor = true;
            this.checkBoxDone.Visible = false;
            // 
            // labelCancel
            // 
            this.labelCancel.AutoSize = true;
            this.labelCancel.Location = new System.Drawing.Point(583, 311);
            this.labelCancel.Name = "labelCancel";
            this.labelCancel.Size = new System.Drawing.Size(60, 17);
            this.labelCancel.TabIndex = 57;
            this.labelCancel.Text = "Annulée";
            // 
            // textBoxCancel
            // 
            this.textBoxCancel.Enabled = false;
            this.textBoxCancel.Location = new System.Drawing.Point(586, 331);
            this.textBoxCancel.Name = "textBoxCancel";
            this.textBoxCancel.Size = new System.Drawing.Size(212, 22);
            this.textBoxCancel.TabIndex = 56;
            // 
            // buttonAbort
            // 
            this.buttonAbort.Enabled = false;
            this.buttonAbort.Location = new System.Drawing.Point(363, 39);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(98, 38);
            this.buttonAbort.TabIndex = 58;
            this.buttonAbort.Text = "Abandonner";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // FormIntervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 508);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.labelCancel);
            this.Controls.Add(this.textBoxCancel);
            this.Controls.Add(this.checkBoxDone);
            this.Controls.Add(this.textBoxObjet);
            this.Controls.Add(this.textBoxIdObjet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxObjet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelValider);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxIdClient);
            this.Controls.Add(this.textBoxIdSelect);
            this.Controls.Add(this.maskedTextBoxPlan);
            this.Controls.Add(this.labelCommentaire);
            this.Controls.Add(this.labelEtat);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.textBoxEtat);
            this.Controls.Add(this.textBoxComm);
            this.Controls.Add(this.textBoxClient);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelPlanifie);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelIntervention);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormIntervention";
            this.Text = "FormIntervention";
            this.Load += new System.EventHandler(this.FormIntervention_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.Label labelPlanifie;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelIntervention;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelCommentaire;
        private System.Windows.Forms.Label labelEtat;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.TextBox textBoxEtat;
        private System.Windows.Forms.TextBox textBoxComm;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlan;
        private System.Windows.Forms.ColumnHeader Etat;
        private System.Windows.Forms.ColumnHeader Plan;
        private System.Windows.Forms.ColumnHeader Commentaire;
        private System.Windows.Forms.ColumnHeader idint;
        private System.Windows.Forms.TextBox textBoxIdSelect;
        private System.Windows.Forms.TextBox textBoxIdClient;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelValider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxObjet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdObjet;
        private System.Windows.Forms.TextBox textBoxObjet;
        private System.Windows.Forms.CheckBox checkBoxDone;
        private System.Windows.Forms.Label labelCancel;
        private System.Windows.Forms.TextBox textBoxCancel;
        private System.Windows.Forms.Button buttonAbort;
    }
}