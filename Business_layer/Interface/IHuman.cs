using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Business_layer.Interface
{
    public interface IHuman
    {

        public abstract string Activity();
        public abstract string Cycling();
        public abstract string LearnOnline();
    }
}
