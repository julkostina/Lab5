using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business_layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer.Entities.Tests
{
    [TestClass()]
    public class LibrarianTests
    {
        [TestMethod()]
        public void ActivityTest()
        {
            Librarian human = new Librarian("Kate", "Smith", "111123475", true);
            string actualRes = human.Activity();
            Assert.AreEqual("I like reading", actualRes);
        }
        [TestMethod()]
        public void CyclingTest()
        {
            Librarian human = new Librarian("Kate", "Smith", "111123475", true);
            string actualRes = human.Cycling();
            Assert.AreEqual("I like cycling", actualRes);
        }
    }
}