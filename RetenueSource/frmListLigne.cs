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

namespace RetenueSource
{
    public partial class frmListLigne : DevExpress.XtraEditors.XtraForm
    {

        private RetenueSourceContext _context;
        private int _EnteteId;

        public frmListLigne(int EnteteId)
        {
            InitializeComponent();
            _context = new RetenueSourceContext();
            _EnteteId = EnteteId;
            showData();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showData()
        {
            var ligne = _context.LigneRetenueSources.Where(l => l.EnteteRetenueSourceId == _EnteteId).ToList();
            gridControl2.DataSource = ligne;
        }

        private LigneRetenueSource getSelectedRow()
        {
            int focusedRowHandle = gridView2.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                var selectedRow = gridView2.GetFocusedRow();
                var data = selectedRow as LigneRetenueSource;
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

        private void btModify_Click_1(object sender, EventArgs e)
        {
            var selectedRow = getSelectedRow();
            if (selectedRow != null)
            {
                var LigneForm = new frmLigne(selectedRow, "Modify", _EnteteId);
                if (LigneForm.ShowDialog() == DialogResult.OK)
                {
                    showData();
                }
            }
        }

        private void btAdd_Click_1(object sender, EventArgs e)
        {
            var newLigne = new LigneRetenueSource();
            var LigneForm = new frmLigne(newLigne, "Add", _EnteteId);
            if (LigneForm.ShowDialog() == DialogResult.OK)
            {
                showData();
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            var selectedRow = getSelectedRow();
            if (selectedRow != null)
            {
                _context.LigneRetenueSources.Remove(selectedRow);
                _context.SaveChanges();
                showData();
            }
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            try
            {
                var lignes = _context.LigneRetenueSources.Where(l => l.EnteteRetenueSourceId == _EnteteId).ToList();
                if (lignes.Any())
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "XML files (*.xml)|*.xml",
                        Title = "Save as XML"
                    };
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ExportToXml(lignes, saveFileDialog.FileName);
                        MessageBox.Show("Data exported successfully.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No data to export.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while exporting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExportToXml(List<LigneRetenueSource> data, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<LigneRetenueSource>));
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, data);
            }
        }

        private void frmListLigne_Load(object sender, EventArgs e)
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView2.Columns)
            {
                column.MinWidth = 100;
            }
        }
    }
}