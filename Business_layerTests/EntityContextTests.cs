using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data_layer;
using System;
using Business_layer.Entities;

namespace Data_layer.Tests
{
    [TestClass()]
    public class EntityContextTests
    {
        [TestMethod()]
        public void CreateFileTest()
        {
            string actual=EntityContext<Human>.CreateFile("test");
            string expected = "C:\\Users\\User\\source\\repos\\Lab_work5\\Business_layerTests\\bin\\Debug\\net7.0\\test";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CreateFile1Test()
        {
            string actual = EntityContext<Human>.CreateFile("");
            string expected = null;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void WriteFileTest()
        {
            EntityContext<string>.DeleteFile("C:\\Users\\User\\source\\repos\\Lab_work5\\Business_layerTests\\bin\\Debug\\net7.0\\test");
            string path = EntityContext<Human>.CreateFile("test");

            EntityContext<string>.WriteFile("Succesful test", path);
            string actual = EntityContext<string>.ReadFile(path);
            string expected = "Succesful test";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void WriteFile1Test()
        {
            EntityContext<string>.DeleteFile("C:\\Users\\User\\source\\repos\\Lab_work5\\Business_layerTests\\bin\\Debug\\net7.0\\test");
            string path = EntityContext<Human>.CreateFile("test");

            EntityContext<string>.WriteFile("", path);
            string actual = EntityContext<string>.ReadFile(path);
            string expected = "";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ReadFileTest()
        {
            EntityContext<string>.DeleteFile("C:\\Users\\User\\source\\repos\\Lab_work5\\Business_layerTests\\bin\\Debug\\net7.0\\test");
            string path = EntityContext<string>.CreateFile("test");
            
            EntityContext<string>.WriteFile("Succesful test",path);
            string actual=EntityContext<string>.ReadFile(path);
            string expected = "Succesful test";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ReadFile1Test()
        {
            EntityContext<string>.DeleteFile("C:\\Users\\User\\source\\repos\\Lab_work5\\Business_layerTests\\bin\\Debug\\net7.0\\test");
            string path = EntityContext<Human>.CreateFile("test");

            EntityContext<string>.WriteFile("", path);
            string actual = EntityContext<string>.ReadFile(path);
            string expected = "";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void DeleteFileTest()
        {
            string path = EntityContext<Human>.CreateFile("test");
            EntityContext<string>.DeleteFile(path);

            Assert.IsTrue(!File.Exists(path));
        }
        
    }
}