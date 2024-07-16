namespace RetenueSource
{
    partial class frmListEntete
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListEntete));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btListBeneficiaire = new DevExpress.XtraBars.BarButtonItem();
            this.btCreateFolder = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btGenerate = new DevExpress.XtraEditors.SimpleButton();
            this.btModify = new DevExpress.XtraEditors.SimpleButton();
            this.btRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btClose = new DevExpress.XtraEditors.SimpleButton();
            this.btExport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btListBeneficiaire,
            this.btCreateFolder});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(722, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 390);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(722, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 390);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(722, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 390);
            // 
            // btListBeneficiaire
            // 
            this.btListBeneficiaire.Caption = "ListBeneficiaire";
            this.btListBeneficiaire.Id = 1;
            this.btListBeneficiaire.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btListBeneficiaire.ImageOptions.SvgImage")));
            this.btListBeneficiaire.Name = "btListBeneficiaire";
            // 
            // btCreateFolder
            // 
            this.btCreateFolder.Caption = "CreateFolder";
            this.btCreateFolder.Id = 2;
            this.btCreateFolder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btCreateFolder.ImageOptions.SvgImage")));
            this.btCreateFolder.Name = "btCreateFolder";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 390);
            this.panel1.TabIndex = 4;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(722, 336);
            this.gridControl2.TabIndex = 1;
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
            this.panel2.Controls.Add(this.btGenerate);
            this.panel2.Controls.Add(this.btModify);
            this.panel2.Controls.Add(this.btRemove);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.btClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 54);
            this.panel2.TabIndex = 0;
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(231, 11);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(91, 31);
            this.btGenerate.TabIndex = 7;
            this.btGenerate.Text = "Generate";
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // btModify
            // 
            this.btModify.Location = new System.Drawing.Point(328, 11);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(91, 31);
            this.btModify.TabIndex = 6;
            this.btModify.Text = "Modify";
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
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
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
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
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(134, 11);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(91, 31);
            this.btExport.TabIndex = 8;
            this.btExport.Text = "Export";
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // frmListEntete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 390);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmListEntete";
            this.Text = "frmListEntete";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem btListBeneficiaire;
        private DevExpress.XtraBars.BarButtonItem btCreateFolder;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btModify;
        private DevExpress.XtraEditors.SimpleButton btRemove;
        private DevExpress.XtraEditors.SimpleButton btAdd;
        private DevExpress.XtraEditors.SimpleButton btClose;
        private DevExpress.XtraEditors.SimpleButton btGenerate;
        private DevExpress.XtraEditors.SimpleButton btExport;
    }
}