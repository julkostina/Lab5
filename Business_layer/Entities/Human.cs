using Business_layer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business_layer.Entities
{
    public class Human : IHuman
    {
        string firstName;
        string lastName;
        string passport;
        bool connection;
        public virtual string Activity()
        {
            return "I do some activity";
        }
        public virtual string Cycling()
        {
            return "I cannot cycling";
        }
        public virtual string LearnOnline()
        {
            
            return (connection)? "I learn online": "I don't learn online";
        }
        public string Name { get { return firstName; } protected set { firstName = value; } }
        public string Surname { get { return lastName; } protected set { lastName = value; } }
        public string Passport { get { return passport; } protected set { passport = value; } }
        public bool Connection { get { return connection; } protected set { connection = value; } } 
        public Human(string firstName, string lastName, string passport, bool connection)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.passport = passport;
            this.connection = connection;
        }
    }
}
