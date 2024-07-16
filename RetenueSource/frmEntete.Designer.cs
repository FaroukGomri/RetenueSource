namespace RetenueSource
{
    partial class frmEntete
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
            this.rPM = new System.Windows.Forms.RadioButton();
            this.rPP = new System.Windows.Forms.RadioButton();
            this.nTypeIdentifiant = new System.Windows.Forms.NumericUpDown();
            this.etIdentifiant = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.btClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.nTypeIdentifiant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etIdentifiant.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rPM
            // 
            this.rPM.AutoSize = true;
            this.rPM.Location = new System.Drawing.Point(164, 108);
            this.rPM.Name = "rPM";
            this.rPM.Size = new System.Drawing.Size(41, 17);
            this.rPM.TabIndex = 44;
            this.rPM.Text = "PM";
            this.rPM.UseVisualStyleBackColor = true;
            // 
            // rPP
            // 
            this.rPP.AutoSize = true;
            this.rPP.Checked = true;
            this.rPP.Location = new System.Drawing.Point(103, 108);
            this.rPP.Name = "rPP";
            this.rPP.Size = new System.Drawing.Size(39, 17);
            this.rPP.TabIndex = 43;
            this.rPP.TabStop = true;
            this.rPP.Text = "PP";
            this.rPP.UseVisualStyleBackColor = true;
            // 
            // nTypeIdentifiant
            // 
            this.nTypeIdentifiant.Location = new System.Drawing.Point(103, 18);
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
            this.nTypeIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.nTypeIdentifiant.TabIndex = 42;
            this.nTypeIdentifiant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // etIdentifiant
            // 
            this.etIdentifiant.Location = new System.Drawing.Point(103, 64);
            this.etIdentifiant.Name = "etIdentifiant";
            this.etIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.etIdentifiant.TabIndex = 30;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(42, 108);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 16);
            this.labelControl2.TabIndex = 29;
            this.labelControl2.Text = "Categorie";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(40, 65);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 16);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "Identifiant";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 18);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 16);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "TypeIdentifiant";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btConfirm);
            this.panel2.Controls.Add(this.btClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 54);
            this.panel2.TabIndex = 26;
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(21, 11);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(91, 31);
            this.btConfirm.TabIndex = 4;
            this.btConfirm.Text = "Confirm";
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(118, 11);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(91, 31);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Close";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // frmEntete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 230);
            this.Controls.Add(this.rPM);
            this.Controls.Add(this.rPP);
            this.Controls.Add(this.nTypeIdentifiant);
            this.Controls.Add(this.etIdentifiant);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.panel2);
            this.Name = "frmEntete";
            this.Text = "frmEnteteRetenueSource";
            this.Load += new System.EventHandler(this.frmEntete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nTypeIdentifiant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etIdentifiant.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rPM;
        private System.Windows.Forms.RadioButton rPP;
        private System.Windows.Forms.NumericUpDown nTypeIdentifiant;
        private DevExpress.XtraEditors.TextEdit etIdentifiant;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btConfirm;
        private DevExpress.XtraEditors.SimpleButton btClose;
    }
}