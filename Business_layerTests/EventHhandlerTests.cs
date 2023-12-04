using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_layer.Entities;
using System.Collections;

namespace Business_layer.Tests
{
    [TestClass()]
    public class EventHhandlerTests
    {
        [TestMethod()]
        public void GetNotificationTest()
        {
            EventHhandler Event = new EventHhandler();
            ArrayList list = new ArrayList() { new Student("Natasha", "Kampush", 170, 60, "123456789", "KB12345678", true) };
            ArrayList stList = Student.StudentsWithIdealWeight(ref list);
            int actual = 0;

            for (int i = 0; i < 1; i++)
            {
                if (list[i] != null && list[i] is Student)
                {
                    Student st = (Student)list[i];
                    Event.IdealWeightEvent += Show;
                    if (stList.Count > 0)
                    {
                        Event.GetNotification(st, stList);
                    }
                    Event.IdealWeightEvent -= Show;
                }
            }
            void Show(object sender, OverFlowedEventArgs e)
            {
                actual++;
            }
            Assert.IsTrue(actual==1);
        }
    }
}