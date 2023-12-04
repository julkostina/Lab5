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
    public class HumanTests
    {
        [TestMethod()]
        public void ActivityTest()
        {
            Human human = new Human("Kate", "Smith", "111123475", true);
            string actualRes = human.Activity();
            Assert.AreEqual("I do some activity", actualRes);
        }
        [TestMethod()]
        public void LearnOnlineTest()
        {
            Human human = new Human("Kate", "Smith", "111123475", true);
            string actualRes = human.LearnOnline();
            Assert.AreEqual("I learn online", actualRes);
        }
        [TestMethod()]
        public void LearnOnline1Test()
        {
            Human human = new Human("Kate", "Smith", "111123475", false);
            string actualRes = human.LearnOnline();
            Assert.AreEqual("I don't learn online", actualRes);
        }
        [TestMethod()]
        public void CyclingTest()
        {
            Human human = new Human("Kate", "Smith", "111123475", true);
            string actualRes = human.Cycling();
            Assert.AreEqual("I cannot cycling", actualRes);
        }

    }
}