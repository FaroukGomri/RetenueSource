using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RetenueSource.Models
{
    [XmlRoot("ArrayOfEnteteRetenueSource")]
    public class ArrayOfEnteteRetenueSource
    {
        [XmlElement("EnteteRetenueSource")]
        public List<EnteteRetenueSource> EnteteRetenueSources { get; set; }
    }

    public static class XmlExporter
    {
        public static void ExportToXml(ArrayOfEnteteRetenueSource data, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ArrayOfEnteteRetenueSource));
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, data);
            }
        }
    }
}
