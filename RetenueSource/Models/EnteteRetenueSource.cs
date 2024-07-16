using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RetenueSource.Models
{
    public class EnteteRetenueSource
    {

        [XmlElement("Id")]
        public int Id { get; set; }

        [XmlElement("TypeIdentifiant")]
        public int TypeIdentifiant { get; set; }

        [XmlElement("Identifiant")]
        public string Identifiant { get; set; }

        [XmlElement("CategorieContribuable")]
        public string CategorieContribuable { get; set; }

        [XmlElement("LigneRetenueSources")]
        public List<LigneRetenueSource> LigneRetenueSources { get; set; }
    }
}
