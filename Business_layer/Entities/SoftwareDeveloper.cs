using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer.Entities
{
    public class SoftwareDeveloper : Human
    {
        public override string Activity()
        {
            return "I can code";
        }
        public override string Cycling()
        {
            return "I don't like cycling";
        }
        public SoftwareDeveloper(string firstName, string lastName, string passport, bool connection) : base(firstName, lastName, passport,connection)
        {
            Name = firstName;
            Surname = lastName;
            Passport = passport;
        }
    }
}