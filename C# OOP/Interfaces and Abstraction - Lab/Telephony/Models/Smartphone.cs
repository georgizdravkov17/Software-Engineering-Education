using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephony.Intercases;

namespace Telephony.Models
{
    public class Smartphone : ICallable, IWebable
    {
        public Smartphone(string number)
        {
            this.Number = number;
        }

        public string Number { get; private set; }

        public string URL { get; private set; }

        public string Call()
        {
            return $"Calling... {this.Number}";
        }

        public string WebSurfing()
        {
            return $"Browsing... {this.URL}";
        }
    }
}
