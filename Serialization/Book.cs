using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class Book
    {
        private DateTime publishDate;
        private DateTime registationDate;

        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlAttribute("isbn")]
        public string Isbn { get; set; }

        [XmlAttribute("author")]
        public string Author { get; set; }

        [XmlAttribute("title")]
        public string Title { get; set; }
        [XmlElement("genre")]
        public Genre Genre { get; set; }

        [XmlElement("publisher")]
        public string Publisher { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("publish_date")]
        public string PublishDate
        {
            get
            {
                return publishDate.ToString("yyyy-MM-dd");
            }
            set
            {
                publishDate= DateTime.Parse(value);
            }
        }

        [XmlElement("registration_date")]
        public string RegistrationDate
        {
            get
            {
                return registationDate.ToString("yyyy-MM-dd");
            }
            set
            {
                registationDate = DateTime.Parse(value);
            }
        }
        public Book()
        {

        }

    }
    public enum Genre
    {
        Computer,
        Fantasy,
        Romance,
        Horror,

        [XmlEnum("Science Fiction")]
        ScienceFiction
    }
}
