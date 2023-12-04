using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bussiness_layer
{
    public class Exceptions
    {
        public Exceptions() { }

        public static Regex validNameSurname = new (@"^[A-Z]{1}[a-z]{3,20}$");

        public static Regex validPassport = new (@"^\d{9}$");

        public static Regex validStCard = new (@"^KB\d{8}$");

        public static Regex validWeightHeight = new(@"^\d{2,3}$");


    }
}
