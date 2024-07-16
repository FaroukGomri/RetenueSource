using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetenueSource.Models
{
    public class Beneficiere
    {
        public int Id { get; set; }
        public int TypeIdentifiant { get; set; }
        public int Resident { get; set; }
        public string Identifiant { get; set; }
        public string CategorieContribuable { get; set; }
        public string NometprenomOuRaisonsociale { get; set; }
        public string Adresse { get; set; }
        public string Activite { get; set; }
        public string AdresseMail { get; set; }
        public string NumTel { get; set; }
    }
}
