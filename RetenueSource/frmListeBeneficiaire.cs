using DevExpress.XtraEditors;
using RetenueSource.Data;
using RetenueSource.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetenueSource
{
    public partial class frmListeBeneficiaire : DevExpress.XtraEditors.XtraForm
    {
        private RetenueSourceContext _context;

        public frmListeBeneficiaire()
        {
            InitializeComponent();
            _context = new RetenueSourceContext();
            showData();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var newBeneficiaire = new Beneficiere();
            var beneficiaireForm = new frmBeneficiaire(newBeneficiaire, "Add");
            if (beneficiaireForm.ShowDialog() == DialogResult.OK)
            {
                showData();
            }
        }

        private void showData()
        {
            var beneficiaires = _context.Beneficieres.ToList();
            gridControl2.DataSource = beneficiaires;
        }
        
        private Beneficiere getSelectedRow()
        {
            int focusedRowHandle = gridView2.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                var selectedRow = gridView2.GetFocusedRow();
                var data = selectedRow as Beneficiere;
                if (data != null)
                {
                    return data;
                }
            }
            else
            {
                MessageBox.Show("No row is focused.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            var selectedRow = getSelectedRow();
            if (selectedRow != null)
            {
                _context.Beneficieres.Remove(selectedRow);
                _context.SaveChanges();
                showData();
            }
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            var selectedRow = getSelectedRow();
            if (selectedRow != null)
            {
                var beneficiaireForm = new frmBeneficiaire(selectedRow, "Modify");
                if (beneficiaireForm.ShowDialog() == DialogResult.OK)
                {
                    showData();
                }
            }
        }

    }
}