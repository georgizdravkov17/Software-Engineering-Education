using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony.Intercases
{
   public interface ICallable
    {
        string Number { get; }

         string Call();
    }
}
