using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business_layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Business_layer.Entities.Tests
{
    [TestClass()]
    public class StudentTests
    {
        [TestMethod()]
        public void ActivityTest()
        {
            Student student = new Student("Jane", "Fox", 170, 60, "123456789", "KB12345678", false);
            string actualRes = student.Activity();
            Assert.AreEqual("I study in university", actualRes);
        }

        [TestMethod()]
        public void CyclingTest()
        {
            Student student = new Student("Jane", "Fox", 170, 60, "123456789", "KB12345678", false);
            string actualRes = student.Cycling();
            Assert.AreEqual("I don't like cycling", actualRes);
        }

        [TestMethod()]
        public void StudentsWithIdealWeightTest()
        {
            ArrayList arrayList = new ArrayList() { new Student("Jane", "Fox", 170, 60, "123456789", "KB12345678", false),
                new Student("Kate", "Fox", 170, 56, "123456789", "KB12345678", true),
                new Student("Sheila", "Sims", 156, 46, "123456789", "KB12345678", false) };

            ArrayList expectedRes = new ArrayList() { new Student("Jane", "Fox", 170, 60, "123456789", "KB12345678", false),
                new Student("Sheila", "Sims", 156, 46, "123456789", "KB12345678", false) };
            ArrayList actualRes = Student.StudentsWithIdealWeight(ref arrayList);
            for (int i = 0; i < expectedRes.Count; i++)
            {
                Student expected = (Student)expectedRes[i];
                Student actual = (Student)actualRes[i];

                Assert.AreEqual(expected.Name, actual.Name);
                Assert.AreEqual(expected.Surname, actual.Surname);
                Assert.AreEqual(expected.StudentCard, actual.StudentCard);
                Assert.AreEqual(expected.Height, actual.Height);
                Assert.AreEqual(expected.Weight, actual.Weight);
                Assert.AreEqual(expected.Passport, actual.Passport);
            }
        }
        [TestMethod()]
        public void StudentsWithIdealWeight1Test()
        {
            ArrayList arrayList = new ArrayList() { new Student("Jane", "Fox", 150, 60, "123456789", "KB12345678", false),
                new Student("Kate", "Fox", 170, 56, "123456789", "KB12345678", true),
                new Student("Sheila", "Sims", 156, 76, "123456789", "KB12345678", false) };

            ArrayList expectedRes = new ArrayList() { };
            ArrayList actualRes = Student.StudentsWithIdealWeight(ref arrayList);
            for (int i = 0; i < expectedRes.Count; i++)
            {
                Student expected = (Student)expectedRes[i];
                Student actual = (Student)actualRes[i];

                Assert.AreEqual(expected.Name, actual.Name);
                Assert.AreEqual(expected.Surname, actual.Surname);
                Assert.AreEqual(expected.StudentCard, actual.StudentCard);
                Assert.AreEqual(expected.Height, actual.Height);
                Assert.AreEqual(expected.Weight, actual.Weight);
                Assert.AreEqual(expected.Passport, actual.Passport);
            }
        } 
    }
}