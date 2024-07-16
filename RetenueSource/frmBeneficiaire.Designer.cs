namespace RetenueSource
{
    partial class frmBeneficiaire
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.btClose = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.etIdentifiant = new DevExpress.XtraEditors.TextEdit();
            this.etAdresse = new DevExpress.XtraEditors.TextEdit();
            this.etNomPrenom = new DevExpress.XtraEditors.TextEdit();
            this.Adresse = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.etNumTel = new DevExpress.XtraEditors.TextEdit();
            this.etAdresseMail = new DevExpress.XtraEditors.TextEdit();
            this.etActivite = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.nTypeIdentifiant = new System.Windows.Forms.NumericUpDown();
            this.rPP = new System.Windows.Forms.RadioButton();
            this.rPM = new System.Windows.Forms.RadioButton();
            this.cbResident = new DevExpress.XtraEditors.CheckEdit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.etIdentifiant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etAdresse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etNomPrenom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etNumTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etAdresseMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etActivite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTypeIdentifiant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbResident.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbResident);
            this.panel1.Controls.Add(this.rPM);
            this.panel1.Controls.Add(this.rPP);
            this.panel1.Controls.Add(this.nTypeIdentifiant);
            this.panel1.Controls.Add(this.etNumTel);
            this.panel1.Controls.Add(this.etAdresseMail);
            this.panel1.Controls.Add(this.etActivite);
            this.panel1.Controls.Add(this.labelControl7);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.labelControl9);
            this.panel1.Controls.Add(this.etAdresse);
            this.panel1.Controls.Add(this.etNomPrenom);
            this.panel1.Controls.Add(this.Adresse);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.etIdentifiant);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 230);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btConfirm);
            this.panel2.Controls.Add(this.btClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 54);
            this.panel2.TabIndex = 1;
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(461, 11);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(91, 31);
            this.btConfirm.TabIndex = 4;
            this.btConfirm.Text = "Confirm";
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(558, 11);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(91, 31);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Close";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "TypeIdentifiant";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(40, 81);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 16);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Identifiant";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(42, 124);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Categorie";
            // 
            // etIdentifiant
            // 
            this.etIdentifiant.Location = new System.Drawing.Point(103, 80);
            this.etIdentifiant.Name = "etIdentifiant";
            this.etIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.etIdentifiant.TabIndex = 9;
            // 
            // etAdresse
            // 
            this.etAdresse.Location = new System.Drawing.Point(325, 121);
            this.etAdresse.Name = "etAdresse";
            this.etAdresse.Size = new System.Drawing.Size(100, 20);
            this.etAdresse.TabIndex = 15;
            // 
            // etNomPrenom
            // 
            this.etNomPrenom.Location = new System.Drawing.Point(325, 77);
            this.etNomPrenom.Name = "etNomPrenom";
            this.etNomPrenom.Size = new System.Drawing.Size(100, 20);
            this.etNomPrenom.TabIndex = 14;
            // 
            // Adresse
            // 
            this.Adresse.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adresse.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Adresse.Appearance.Options.UseFont = true;
            this.Adresse.Appearance.Options.UseForeColor = true;
            this.Adresse.Location = new System.Drawing.Point(273, 122);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(46, 16);
            this.Adresse.TabIndex = 12;
            this.Adresse.Text = "Adresse";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(230, 78);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(89, 16);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Nom et Prenom";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(270, 34);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(49, 16);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Resident";
            // 
            // etNumTel
            // 
            this.etNumTel.Location = new System.Drawing.Point(547, 121);
            this.etNumTel.Name = "etNumTel";
            this.etNumTel.Size = new System.Drawing.Size(100, 20);
            this.etNumTel.TabIndex = 21;
            // 
            // etAdresseMail
            // 
            this.etAdresseMail.Location = new System.Drawing.Point(547, 77);
            this.etAdresseMail.Name = "etAdresseMail";
            this.etAdresseMail.Size = new System.Drawing.Size(100, 20);
            this.etAdresseMail.TabIndex = 20;
            // 
            // etActivite
            // 
            this.etActivite.Location = new System.Drawing.Point(547, 33);
            this.etActivite.Name = "etActivite";
            this.etActivite.Size = new System.Drawing.Size(100, 20);
            this.etActivite.TabIndex = 19;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(497, 122);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(44, 16);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "NumTel";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(472, 78);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(69, 16);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "AdresseMail";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(500, 34);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(41, 16);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "Activite";
            // 
            // nTypeIdentifiant
            // 
            this.nTypeIdentifiant.Location = new System.Drawing.Point(103, 34);
            this.nTypeIdentifiant.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nTypeIdentifiant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nTypeIdentifiant.Name = "nTypeIdentifiant";
            this.nTypeIdentifiant.Size = new System.Drawing.Size(100, 21);
            this.nTypeIdentifiant.TabIndex = 22;
            this.nTypeIdentifiant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rPP
            // 
            this.rPP.AutoSize = true;
            this.rPP.Checked = true;
            this.rPP.Location = new System.Drawing.Point(103, 124);
            this.rPP.Name = "rPP";
            this.rPP.Size = new System.Drawing.Size(37, 17);
            this.rPP.TabIndex = 23;
            this.rPP.TabStop = true;
            this.rPP.Text = "PP";
            this.rPP.UseVisualStyleBackColor = true;
            // 
            // rPM
            // 
            this.rPM.AutoSize = true;
            this.rPM.Location = new System.Drawing.Point(164, 124);
            this.rPM.Name = "rPM";
            this.rPM.Size = new System.Drawing.Size(39, 17);
            this.rPM.TabIndex = 24;
            this.rPM.Text = "PM";
            this.rPM.UseVisualStyleBackColor = true;
            // 
            // cbResident
            // 
            this.cbResident.Location = new System.Drawing.Point(325, 34);
            this.cbResident.Name = "cbResident";
            this.cbResident.Properties.Caption = "";
            this.cbResident.Size = new System.Drawing.Size(75, 18);
            this.cbResident.TabIndex = 25;
            // 
            // frmBeneficiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 230);
            this.Controls.Add(this.panel1);
            this.Name = "frmBeneficiaire";
            this.Text = "frmBeneficiaire";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.etIdentifiant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etAdresse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etNomPrenom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etNumTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etAdresseMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etActivite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTypeIdentifiant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbResident.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btConfirm;
        private DevExpress.XtraEditors.SimpleButton btClose;
        private DevExpress.XtraEditors.TextEdit etIdentifiant;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit etNumTel;
        private DevExpress.XtraEditors.TextEdit etAdresseMail;
        private DevExpress.XtraEditors.TextEdit etActivite;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit etAdresse;
        private DevExpress.XtraEditors.TextEdit etNomPrenom;
        private DevExpress.XtraEditors.LabelControl Adresse;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.NumericUpDown nTypeIdentifiant;
        private System.Windows.Forms.RadioButton rPM;
        private System.Windows.Forms.RadioButton rPP;
        private DevExpress.XtraEditors.CheckEdit cbResident;
    }
}