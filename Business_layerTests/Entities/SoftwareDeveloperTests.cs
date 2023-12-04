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
    public class SoftwareDeveloperTests
    {
        [TestMethod()]
        public void ActivityTest()
        {
            SoftwareDeveloper human = new SoftwareDeveloper("Mia", "Goth", "311123475", false);
            string actualRes = human.Activity();
            Assert.AreEqual("I can code", actualRes);
        }
        [TestMethod()]
        public void CyclingTest()
        {
            SoftwareDeveloper human = new SoftwareDeveloper("Kate", "Lea", "111123475", true);
            string actualRes = human.Cycling();
            Assert.AreEqual("I don't like cycling", actualRes);
        }
    }
}