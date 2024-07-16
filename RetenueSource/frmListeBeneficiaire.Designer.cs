using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace RetenueSource
{
    partial class frmListeBeneficiaire
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btClose = new DevExpress.XtraEditors.SimpleButton();
            this.btAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btModify = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btModify);
            this.panel2.Controls.Add(this.btRemove);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.btClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 54);
            this.panel2.TabIndex = 0;
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
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(425, 11);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(91, 31);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Add";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
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
            // btModify
            // 
            this.btModify.Location = new System.Drawing.Point(328, 11);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(91, 31);
            this.btModify.TabIndex = 6;
            this.btModify.Text = "Modify";
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 399);
            this.panel1.TabIndex = 0;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(722, 345);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // frmListeBeneficiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 399);
            this.Controls.Add(this.panel1);
            this.Name = "frmListeBeneficiaire";
            this.Text = "frmListeBeneficiaire";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GridControl gridControl1;
        private GridView gridView1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btModify;
        private DevExpress.XtraEditors.SimpleButton btRemove;
        private DevExpress.XtraEditors.SimpleButton btAdd;
        private DevExpress.XtraEditors.SimpleButton btClose;
        private System.Windows.Forms.Panel panel1;
        private GridControl gridControl2;
        private GridView gridView2;
    }
}