using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony.Intercases
{
   public interface IWebable : ICallable
    {
        string Number { get; }

        string URL { get; }

        string WebSurfing();
    }
}
