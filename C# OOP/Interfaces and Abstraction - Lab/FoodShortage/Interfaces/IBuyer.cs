using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage.Interfaces
{
    public interface IBuyer
    {
        string Name { get; }

        int Age { get; }

        int Food { get; }

        int BuyFood();
    }
}
