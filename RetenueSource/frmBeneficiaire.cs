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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetenueSource
{
    public partial class frmBeneficiaire : DevExpress.XtraEditors.XtraForm
    {
        string actionString;
        private RetenueSourceContext _context;
        private Beneficiere _beneficiere;

        public frmBeneficiaire(Beneficiere beneficiere, string amAction)
        {
            InitializeComponent();
            _context = new RetenueSourceContext();
            _beneficiere = beneficiere;
            actionString = amAction;
            if (amAction == "Modify")
            {
                nTypeIdentifiant.Value = Convert.ToDecimal(_beneficiere.TypeIdentifiant);
                etIdentifiant.Text = _beneficiere.Identifiant;
                if (_beneficiere.CategorieContribuable == "PP")
                {
                    rPP.Checked = true;
                }
                else if (_beneficiere.CategorieContribuable == "PM")
                {
                    rPM.Checked = true;
                }
                cbResident.Checked = _beneficiere.Resident == 1;
                etNomPrenom.Text = _beneficiere.NometprenomOuRaisonsociale;
                etAdresse.Text = _beneficiere.Adresse;
                etActivite.Text = _beneficiere.Activite;
                etAdresseMail.Text = _beneficiere.AdresseMail;
                etNumTel.Text = _beneficiere.NumTel;
            }
            else if (amAction != "Add" &&  amAction != "Modify")
            {
                etIdentifiant.Text = amAction;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
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
            if (etNomPrenom.Text == String.Empty)
            {
                MessageBox.Show("Nom et Prenom must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (etAdresse.Text == String.Empty)
            {
                MessageBox.Show("Adresse must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (etActivite.Text == String.Empty)
            {
                MessageBox.Show("Activite must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (etAdresseMail.Text == String.Empty)
            {
                MessageBox.Show("AdresseMail must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Regex.IsMatch(etNumTel.Text, @"^\d{8}$"))
            {
                MessageBox.Show("NumTel must be a number with exact length of 8", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void SaveChanges()
        {
            _beneficiere.TypeIdentifiant = (int)nTypeIdentifiant.Value;
            _beneficiere.Identifiant = etIdentifiant.Text;
            if (rPP.Checked)
            {
                _beneficiere.CategorieContribuable = "PP";
            }
            if (rPM.Checked)
            {
                _beneficiere.CategorieContribuable = "PM";
            }
            if (cbResident.Checked)
            {
                _beneficiere.Resident = 1;
            }
            else
            {
                _beneficiere.Resident = 0;
            }
            _beneficiere.NometprenomOuRaisonsociale = etNomPrenom.Text;
            _beneficiere.Adresse = etAdresse.Text;
            _beneficiere.Activite = etActivite.Text;
            _beneficiere.AdresseMail = etAdresseMail.Text;
            _beneficiere.NumTel = etNumTel.Text;

            if (actionString == "Modify")
            {
                _context.Update(_beneficiere);
            }
            else
            {
                _context.Add(_beneficiere);
            }
            _context.SaveChanges();
            MessageBox.Show("Changes saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}