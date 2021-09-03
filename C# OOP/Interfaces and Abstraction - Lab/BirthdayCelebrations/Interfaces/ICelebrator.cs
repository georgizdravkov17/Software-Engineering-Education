using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations.Interfaces
{
   public interface ICelebrator
    {
        string Name { get; }

        string Birthday { get; }
    }
}
