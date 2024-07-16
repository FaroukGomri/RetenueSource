using DevExpress.XtraPrinting.Native.Lines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RetenueSource.Models
{
    public class LigneRetenueSource
    {
        public int Id { get; set; }
        public int EnteteRetenueSourceId { get; set; }
        public int TypeIdentifiant { get; set; }
        public string Identifiant { get; set; }
        public string CategorieContribuable { get; set; }
        public int ActeDepot { get; set; }
        public int AnneeDepot { get; set; }
        public int MoisDepot { get; set; }
        public int BeneficiereTypeIdentifiant { get; set; }
        public string BeneficiereIdentifiant { get; set; }
        public string BeneficiereCategorieContribuable { get; set; }
        public int Resident { get; set; }
        public string NometprenomOuRaisonsociale { get; set; }
        public string Adresse { get; set; }
        public string Activite { get; set; }
        public string AdresseMail { get; set; }
        public string NumTel { get; set; }
        public DateTime DatePayement { get; set; }
        public string Ref_certif_chez_declarant { get; set; }
        public string IdTypeOperation { get; set; }
        public int AnneeFacturation { get; set; }
        public int CNPC { get; set; }
        public int P_Charge { get; set; }
        public decimal MontantHT { get; set; }
        public decimal TauxRS { get; set; }
        public decimal TauxTVA { get; set; }
        public decimal MontantRS { get; set; }
        public decimal MontantTVA { get; set; }
        public decimal MontantTTC { get; set; }
        public string TaxeAdditionnelleCode { get; set; }
        public decimal TaxeAdditionnelleTaux { get; set; }
        public decimal MontantNetServi { get; set; }
        public string CodeDevise { get; set; }
        public decimal TauxChange { get; set; }
        public decimal MontantRSDevise { get; set; }
        public decimal MontantTTCDevise { get; set; }
        public decimal MontantNetServiDevise { get; set; }
        public decimal TotalMontantHT { get; set; }
        public decimal TotalMontantTVA { get; set; }
        public decimal TotalMontantTTC { get; set; }
        public decimal TotalMontantRS { get; set; }
        public string TotalTaxeAdditionnelleCode { get; set; }
        public decimal TotalTaxeAdditionnelleMontant { get; set; }
        public decimal TotalMontantNetServi { get; set; }
        public string TotalMontantDeviseCode { get; set; }
        public decimal TotalMontantDeviseTotalMontantRS { get; set; }
        public decimal TotalMontantDeviseTotalMontantTTC { get; set; }
        public decimal TotalMontantDeviseTotalMontantNetServi { get; set; }

    }
}
