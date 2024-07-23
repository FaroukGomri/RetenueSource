using DevExpress.XtraEditors;
using RetenueSource.Data;
using RetenueSource.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;


namespace RetenueSource
{
    public partial class frmListEntete : DevExpress.XtraEditors.XtraForm
    {

        private RetenueSourceContext _context;

        public frmListEntete()
        {
            InitializeComponent();
            _context = new RetenueSourceContext();
            showData();
        }

        private void showData()
        {
            var Entete = _context.EnteteRetenueSources.ToList();
            gridControl2.DataSource = Entete;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var newEntete = new EnteteRetenueSource();
            var EnteteForm = new frmEntete(newEntete, "Add");
            if (EnteteForm.ShowDialog() == DialogResult.OK)
            {
                showData();
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            var selectedRow = getSelectedRow();
            if (selectedRow != null)
            {
                _context.EnteteRetenueSources.Remove(selectedRow);
                _context.SaveChanges();
                showData();
            }
        }

        private EnteteRetenueSource getSelectedRow()
        {
            int focusedRowHandle = gridView2.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                var selectedRow = gridView2.GetFocusedRow();
                var data = selectedRow as EnteteRetenueSource;
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

        private void btModify_Click(object sender, EventArgs e)
        {
            var selectedRow = getSelectedRow();
            if (selectedRow != null)
            {
                var EnteteForm = new frmEntete(selectedRow, "Modify");
                if (EnteteForm.ShowDialog() == DialogResult.OK)
                {
                    showData();
                }
            }
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            var selectedRow = getSelectedRow();
            if (selectedRow != null)
            {
                var ListLigneForm = new frmListLigne(selectedRow.Id);
                ListLigneForm.ShowDialog();
            }
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            try
            {
                var entetes = _context.EnteteRetenueSources.ToList();
                var arrayOfEnteteRetenueSource = new ArrayOfEnteteRetenueSource
                {
                    EnteteRetenueSources = new List<EnteteRetenueSource>()
                };
                foreach (var entete in entetes)
                {
                    var lignes = _context.LigneRetenueSources
                                        .Where(l => l.EnteteRetenueSourceId == entete.Id)
                                        .ToList();
                    entete.LigneRetenueSources = lignes;
                    arrayOfEnteteRetenueSource.EnteteRetenueSources.Add(entete);
                }
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "XML files (*.xml)|*.xml",
                    Title = "Save as XML"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    XmlExporter.ExportToXml(arrayOfEnteteRetenueSource, saveFileDialog.FileName);
                    MessageBox.Show("Data exported successfully.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while exporting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}