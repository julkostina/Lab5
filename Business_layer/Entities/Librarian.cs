using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace Business_layer.Entities
{
    public class Librarian : Human
    {
        public override string Activity()
        {
            return "I like reading";
        }
        public override string Cycling()
        {
            return "I like cycling";
        }
        public Librarian(string firstName, string lastName, string passport, bool connection) : base(firstName, lastName, passport, connection)
        {
            Name = firstName;
            Surname = lastName;
            Passport = passport;
            Connection = connection;
        }

    }
}
