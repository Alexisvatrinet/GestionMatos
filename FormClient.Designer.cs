namespace PPE2
{
    partial class FormClient
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
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.listViewClient = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelClient.Location = new System.Drawing.Point(37, 40);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(98, 31);
            this.labelClient.TabIndex = 1;
            this.labelClient.Text = "Clients";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(296, 26);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(91, 38);
            this.buttonAjouter.TabIndex = 1;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(393, 26);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(91, 38);
            this.buttonModifier.TabIndex = 2;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(490, 26);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(91, 38);
            this.buttonSupprimer.TabIndex = 3;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(587, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 38);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(684, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 38);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(670, 400);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(129, 44);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(535, 400);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(129, 44);
            this.buttonValider.TabIndex = 14;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(296, 169);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(265, 22);
            this.textBoxNom.TabIndex = 10;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(296, 225);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(265, 22);
            this.textBoxAdresse.TabIndex = 11;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(293, 149);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(37, 17);
            this.labelNom.TabIndex = 16;
            this.labelNom.Text = "Nom";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(293, 205);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(60, 17);
            this.labelAdresse.TabIndex = 17;
            this.labelAdresse.Text = "Adresse";
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Location = new System.Drawing.Point(293, 259);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(76, 17);
            this.labelTelephone.TabIndex = 18;
            this.labelTelephone.Text = "Téléphone";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(293, 310);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(33, 17);
            this.labelMail.TabIndex = 19;
            this.labelMail.Text = "Mail";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.HideSelection = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(296, 285);
            this.maskedTextBox1.Mask = "00 00 00 00 00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(265, 22);
            this.maskedTextBox1.TabIndex = 20;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(296, 331);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(265, 22);
            this.textBoxMail.TabIndex = 21;
            this.textBoxMail.TextChanged += new System.EventHandler(this.textBoxMail_TextChanged);
            // 
            // listViewClient
            // 
            this.listViewClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Id,
            this.telephone,
            this.mail,
            this.adresse});
            this.listViewClient.Location = new System.Drawing.Point(28, 98);
            this.listViewClient.Name = "listViewClient";
            this.listViewClient.Size = new System.Drawing.Size(240, 375);
            this.listViewClient.TabIndex = 22;
            this.listViewClient.UseCompatibleStateImageBehavior = false;
            this.listViewClient.View = System.Windows.Forms.View.Details;
            this.listViewClient.SelectedIndexChanged += new System.EventHandler(this.listViewClient_SelectedIndexChanged);
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 197;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 0;
            // 
            // telephone
            // 
            this.telephone.Text = "telephone";
            this.telephone.Width = 0;
            // 
            // mail
            // 
            this.mail.Text = "mail";
            this.mail.Width = 0;
            // 
            // adresse
            // 
            this.adresse.Text = "adresse";
            this.adresse.Width = 0;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 508);
            this.Controls.Add(this.listViewClient);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.labelClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClient";
            this.Text = "Formulaire client";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.ListView listViewClient;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader telephone;
        private System.Windows.Forms.ColumnHeader mail;
        private System.Windows.Forms.ColumnHeader adresse;
    }
}