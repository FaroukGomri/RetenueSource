using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RetenueSource
{

    public partial class frmMdiParent : DevExpress.XtraEditors.XtraForm
    {

        private string connectionString = Program.ConnectionString;

        public frmMdiParent()
        {
            InitializeComponent();
        }

        public string getConnectionString()
        {
            return connectionString;
        }

        private void btListBeneficiaire_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    frmListeBeneficiaire listeBeneficiaire = new frmListeBeneficiaire();
                    listeBeneficiaire.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmMdiParent_Load(object sender, EventArgs e)
        {

        }

        private void btCreateFolder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmListEntete ListEntete = new frmListEntete();
            ListEntete.ShowDialog();
        }
    }
}