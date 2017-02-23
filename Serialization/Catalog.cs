using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    [XmlRoot("catalog", Namespace = "http://library.by/catalog")]
    public class Catalog
    {
        private DateTime date;

        [XmlElement("book")]
        public List<Book> Books { get; set; }

        [XmlAttribute("date")]
        public string Date
        {
            get { return Convert.ToDateTime(date).ToString("yyy-MM-dd"); }
            set { date = DateTime.Parse(value); }

        }
        public Catalog()
        {
            Books = new List<Book>();
        }

        public Catalog(IEnumerable<Book> books)
        {
            Books = books.ToList();
        }
        public void Serialise(string filePath)
        {
            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add("", "http://library.by/catalog");
            var xmlSerialiser = new XmlSerializer(typeof(Catalog));
            xmlSerialiser.Serialize(new XmlTextWriter(filePath, Encoding.UTF8), this, namespaces);
        }

        public static Catalog Deserialise(string filePath)
        {
            var xmlSerialiser = new XmlSerializer(typeof(Catalog));
            return (Catalog)xmlSerialiser.Deserialize(new XmlTextReader(filePath));
        }
    }
}
