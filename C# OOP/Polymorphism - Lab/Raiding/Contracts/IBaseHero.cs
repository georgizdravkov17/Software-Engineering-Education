﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Contracts
{
   public interface IBaseHero
    {
        string Name { get; }

        int Power { get; }

        string CastAbility();
    }
}
