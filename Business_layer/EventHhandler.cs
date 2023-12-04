using Business_layer.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
    public delegate void IdealWeightDelegate(object sender, OverFlowedEventArgs e);
    public class EventHhandler
    {
        public event IdealWeightDelegate IdealWeightEvent;

        public void GetNotification(Student human, ArrayList list)
        {
            if (list != null)
            {
                IdealWeightEvent.Invoke(this, new OverFlowedEventArgs($"Student {human.Name} {human.Surname} has ideal weight!"));
            }
        }
    }

    public class OverFlowedEventArgs
    {
        private string message;
        public OverFlowedEventArgs(string message)
        {
            this.message = message;
        }
        public string StudentWithIdealWeight { get { return message; } }
    }
}
