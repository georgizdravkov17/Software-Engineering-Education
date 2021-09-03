using Raiding.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public abstract class BaseHero : IBaseHero
    {
        public BaseHero(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public int Power { get; set; }

        public abstract string CastAbility();
        
    }
}
