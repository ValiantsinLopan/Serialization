using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class Catalog
    {
        private DateTime date;
        [XmlElement("book")]
        public List<Book> Books { get; set; }

        [XmlAttribute()]
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
    }
}
