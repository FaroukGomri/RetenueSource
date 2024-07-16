namespace RetenueSource
{
    partial class frmListLigne
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
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btExport = new DevExpress.XtraEditors.SimpleButton();
            this.btModify = new DevExpress.XtraEditors.SimpleButton();
            this.btRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(722, 345);
            this.gridControl2.TabIndex = 3;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btExport);
            this.panel2.Controls.Add(this.btModify);
            this.panel2.Controls.Add(this.btRemove);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.btClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 54);
            this.panel2.TabIndex = 2;
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(231, 11);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(91, 31);
            this.btExport.TabIndex = 7;
            this.btExport.Text = "Export";
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btModify
            // 
            this.btModify.Location = new System.Drawing.Point(328, 11);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(91, 31);
            this.btModify.TabIndex = 6;
            this.btModify.Text = "Modify";
            this.btModify.Click += new System.EventHandler(this.btModify_Click_1);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(522, 11);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(91, 31);
            this.btRemove.TabIndex = 5;
            this.btRemove.Text = "Remove";
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(425, 11);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(91, 31);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Add";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click_1);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(619, 11);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(91, 31);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Close";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // frmListLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 399);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.panel2);
            this.Name = "frmListLigne";
            this.Text = "frmListLigne";
            this.Load += new System.EventHandler(this.frmListLigne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btModify;
        private DevExpress.XtraEditors.SimpleButton btRemove;
        private DevExpress.XtraEditors.SimpleButton btAdd;
        private DevExpress.XtraEditors.SimpleButton btClose;
        private DevExpress.XtraEditors.SimpleButton btExport;
    }
}