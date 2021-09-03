using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyImplementation
{
   public interface IPerson
    {
        string FirstName { get; }

        string LastName { get;  }

        int Age { get; }
    }
}
