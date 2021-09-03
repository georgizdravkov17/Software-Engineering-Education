using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephony.Intercases;

namespace Telephony.Models
{
    public class StacionaryPhone : ICallable
    {
        public StacionaryPhone(string number)
        {
            this.Number = number;
        }

        public string Number { get; private set; }

        public string Call()
        {
            return $"Dialing... {this.Number}";
        }
    }
}
