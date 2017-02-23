using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Serialization.Tests
{
    [TestClass()]
    public class CatalogTests
    {
        [TestMethod()]
        public void SerialiseTest()
        {
            var books = BooksGetter.GetBooks();
            var catalog = new Catalog(books) { Date = "2016-02-05" };
            catalog.Serialise(@"D:\VALIANTSIN\TAT LAB\Serialization\Serialization\xmlFiles\Serialization.xml");
        }

        [TestMethod()]
        public void DeserialiseTest()
        {
            var catalog = Catalog.Deserialise(@"D:\VALIANTSIN\TAT LAB\Serialization\Serialization\xmlFiles\RD. HW - AT Lab. C#. 08 - Books.xml");
            catalog.Serialise(@"D:\VALIANTSIN\TAT LAB\Serialization\Serialization\xmlFiles\Deserialization.xml");
        }
    }
}