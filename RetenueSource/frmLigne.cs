using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.XtraEditors;
using RetenueSource.Data;
using RetenueSource.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetenueSource
{
    public partial class frmLigne : DevExpress.XtraEditors.XtraForm
    {
        string actionString;
        int _EnteteId;
        private RetenueSourceContext _context;
        private LigneRetenueSource _ligne;

        public frmLigne(LigneRetenueSource ligne, string amAction, int EnteteId)
        {
            InitializeComponent();
            _context = new RetenueSourceContext();
            _ligne = ligne;
            _EnteteId = EnteteId;
            actionString = amAction;
            if (actionString == "Modify")
            {
                etBeneficiereIdentifiant.Text = _ligne.BeneficiereIdentifiant;
                etIdentifiant.Text = _ligne.Identifiant;
                cActeDepot.Checked = _ligne.ActeDepot == 1;
                nAnneeDeopt.Value = Convert.ToDecimal(_ligne.AnneeDepot);
                nMoisDepot.Value = Convert.ToDecimal(_ligne.MoisDepot);
                deDatePayement.DateTime = _ligne.DatePayement;
                cCNPC.Checked = _ligne.CNPC == 1;
                cP_Charge.Checked = _ligne.P_Charge == 1;
                etRef_certif.Text = _ligne.Ref_certif_chez_declarant;
                etIdTypeOperation.Text = _ligne.IdTypeOperation;
                nAnneeFact.Value = Convert.ToDecimal(_ligne.AnneeFacturation);
                nHT.Value = _ligne.MontantHT;
                nRS.Value = _ligne.MontantRS;
                nTVA.Value = _ligne.MontantTVA;
                nTTC.Value = _ligne.MontantTTC;
                nTRS.Value = _ligne.TauxRS;
                nTTVA.Value = _ligne.TauxTVA;
                etTaxeAdditionnelleCode.Text = _ligne.TaxeAdditionnelleCode;
                nTaxeAdditionnelleTaux.Value = _ligne.TaxeAdditionnelleTaux;
                nMontantNetServi.Value = _ligne.MontantNetServi;
                etCodeDevise.Text = _ligne.CodeDevise;
                nTauxChange.Value = _ligne.TauxChange;
                nMontantRSDevise.Value = _ligne.MontantRSDevise;
                nMontantTTCDevise.Value = _ligne.MontantTTCDevise;
                nMontantNetServiDevise.Value = _ligne.MontantNetServiDevise;
                nTotalMontantHT.Value = _ligne.TotalMontantHT;
                nTotalMontantTVA.Value = _ligne.TotalMontantTVA;
                nTotalMontantTTC.Value = _ligne.TotalMontantTTC;
                nTotalMontantRS.Value = _ligne.TotalMontantRS;
                etTotalTaxeAdditionnelleCode.Text = _ligne.TotalTaxeAdditionnelleCode;
                nTotalTaxeAdditionnelleMontant.Value = _ligne.TotalTaxeAdditionnelleMontant;
                nTotalMontantNetServi.Value = _ligne.TotalMontantNetServi;
                etTotalMontantDeviseCode.Text = _ligne.TotalMontantDeviseCode;
                nTotalMontantDeviseTotalMontantRS.Value = _ligne.TotalMontantDeviseTotalMontantRS;
                nTotalMontantDeviseTotalMontantTTC.Value = _ligne.TotalMontantDeviseTotalMontantTTC;
                nTotalMontantDeviseTotalMontantNetServi.Value = _ligne.TotalMontantDeviseTotalMontantNetServi;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {

            string BeneficiereIdentifiant = etBeneficiereIdentifiant.Text;
            if (BeneficiereIdentifiant == string.Empty)
            {
                MessageBox.Show("BeneficiereIdentifiant must not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var lineBenef = _context.Beneficieres.FirstOrDefault(B => B.Identifiant == BeneficiereIdentifiant);
            if (lineBenef == null)
            {
                var errForm = new ErrBeneficiere();
                if (errForm.ShowDialog() == DialogResult.OK)
                {
                    var newBeneficiaire = new Beneficiere();
                    var beneficiaireForm = new frmBeneficiaire(newBeneficiaire, BeneficiereIdentifiant);
                    beneficiaireForm.ShowDialog();
                }
                return;
            }
            var Entete_ = _context.EnteteRetenueSources.Find(_EnteteId);
            var Benef_ = lineBenef;
            _ligne.EnteteRetenueSourceId = Entete_.Id;
            _ligne.TypeIdentifiant = Entete_.TypeIdentifiant;
            _ligne.CategorieContribuable = Entete_.CategorieContribuable;
            _ligne.BeneficiereIdentifiant = Benef_.Identifiant;
            _ligne.BeneficiereTypeIdentifiant = Benef_.TypeIdentifiant;
            _ligne.BeneficiereCategorieContribuable = Benef_.CategorieContribuable;
            _ligne.Resident = Benef_.Resident;
            _ligne.NometprenomOuRaisonsociale = Benef_.NometprenomOuRaisonsociale;
            _ligne.Adresse = Benef_.Adresse;
            _ligne.Activite = Benef_.Activite;
            _ligne.AdresseMail = Benef_.AdresseMail;
            _ligne.NumTel = Benef_.NumTel;
            if (cActeDepot.Checked)
            {
                _ligne.ActeDepot = 1;
            }
            else
            {
                _ligne.ActeDepot = 0;
            }
            if (cCNPC.Checked)
            {
                _ligne.CNPC = 1;
            }
            else
            {
                _ligne.CNPC = 0;
            }
            if (cP_Charge.Checked)
            {
                _ligne.P_Charge = 1;
            }
            else
            {
                _ligne.P_Charge = 0;
            }
            if (etIdentifiant.Text == String.Empty)
            {
                MessageBox.Show("Identifiant must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _ligne.Identifiant = etIdentifiant.Text;
            }
            _ligne.AnneeDepot = (int)nAnneeDeopt.Value;
            _ligne.MoisDepot = (int)nMoisDepot.Value;
            if (deDatePayement.EditValue != null)
            {
                _ligne.DatePayement = deDatePayement.DateTime;
            }
            else
            {
                MessageBox.Show("Please select a payment date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (etRef_certif.Text == String.Empty)
            {
                MessageBox.Show("Ref_certif must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _ligne.Ref_certif_chez_declarant = etRef_certif.Text;
            }
            if (etIdTypeOperation.Text == String.Empty)
            {
                MessageBox.Show("IdTypeOperation must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _ligne.IdTypeOperation = etIdTypeOperation.Text;
            }
            _ligne.AnneeFacturation = (int)nAnneeFact.Value;
            _ligne.MontantHT = nHT.Value;
            _ligne.MontantRS = nRS.Value;
            _ligne.MontantTVA = nTVA.Value;
            _ligne.MontantTTC = nTTC.Value;
            _ligne.TauxRS = nTRS.Value;
            _ligne.TauxTVA = nTTVA.Value;
            if (etTaxeAdditionnelleCode.Text == String.Empty)
            {
                MessageBox.Show("TaxeAdditionnelleCode must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _ligne.TaxeAdditionnelleCode = etTaxeAdditionnelleCode.Text;
            }
            _ligne.TaxeAdditionnelleTaux = nTaxeAdditionnelleTaux.Value;
            _ligne.MontantNetServi = nMontantNetServi.Value;
            if (etCodeDevise.Text == String.Empty)
            {
                MessageBox.Show("CodeDevise must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _ligne.CodeDevise = etCodeDevise.Text;
            }
            _ligne.TauxChange = nTauxChange.Value;
            _ligne.MontantRSDevise = nMontantRSDevise.Value;
            _ligne.MontantTTCDevise = nMontantTTCDevise.Value;
            _ligne.MontantNetServiDevise = nMontantNetServiDevise.Value;
            _ligne.TotalMontantHT = nTotalMontantHT.Value;
            _ligne.TotalMontantTVA = nTotalMontantTVA.Value;
            _ligne.TotalMontantTTC = nTotalMontantTTC.Value;
            _ligne.TotalMontantRS = nTotalMontantRS.Value;
            if (etTotalTaxeAdditionnelleCode.Text == String.Empty)
            {
                MessageBox.Show("TotalTaxeAdditionnelleCode must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _ligne.TotalTaxeAdditionnelleCode = etTotalTaxeAdditionnelleCode.Text;
            }
            _ligne.TotalTaxeAdditionnelleMontant = nTotalTaxeAdditionnelleMontant.Value;
            _ligne.TotalMontantNetServi = nTotalMontantNetServi.Value;
            if (etTotalMontantDeviseCode.Text == String.Empty)
            {
                MessageBox.Show("TotalMontantDeviseCode must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _ligne.TotalMontantDeviseCode = etTotalMontantDeviseCode.Text;
            }

            _ligne.TotalMontantDeviseTotalMontantRS = nTotalMontantDeviseTotalMontantRS.Value;
            _ligne.TotalMontantDeviseTotalMontantTTC = nTotalMontantDeviseTotalMontantTTC.Value;
            _ligne.TotalMontantDeviseTotalMontantNetServi = nTotalMontantDeviseTotalMontantNetServi.Value;
            if (actionString == "Modify")
            {
                _context.Update(_ligne);
            }
            else
            {
                _context.Add(_ligne);
            }
            _context.SaveChanges();
            MessageBox.Show("Changes saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}