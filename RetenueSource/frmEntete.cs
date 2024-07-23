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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace RetenueSource
{
    public partial class frmEntete : DevExpress.XtraEditors.XtraForm
    {
        private RetenueSourceContext _context;
        private EnteteRetenueSource _ers;
        private string actionString;
        public frmEntete(EnteteRetenueSource Entete,string amAction)
        {
            InitializeComponent();
            _context = new RetenueSourceContext();
            _ers = Entete;
            actionString = amAction;
            if (actionString == "Modify")
            {
                nTypeIdentifiant.Value = Convert.ToDecimal(_ers.TypeIdentifiant);
                etIdentifiant.Text = _ers.Identifiant;
                if (_ers.CategorieContribuable == "PP")
                {
                    rPP.Checked = true;
                }
                else if (_ers.CategorieContribuable == "PM")
                {
                    rPM.Checked = true;
                }
            }
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveChanges();
            }
        }

        private bool ValidateForm()
        {
            if (etIdentifiant.Text == String.Empty)
            {
                MessageBox.Show("Identifiant must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void SaveChanges()
        {
            _ers.TypeIdentifiant = (int)nTypeIdentifiant.Value;
            _ers.Identifiant = etIdentifiant.Text;
            if (rPP.Checked)
            {   
                _ers.CategorieContribuable = "PP";
            }
            if (rPM.Checked)
            {
                _ers.CategorieContribuable = "PM";
            }
            if (actionString == "Modify")
            {
                _context.Update(_ers);
            }
            else
            {
                _context.Add(_ers);
            }
            _context.SaveChanges();
            MessageBox.Show("Changes saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEntete_Load(object sender, EventArgs e)
        {

        }
    }

}