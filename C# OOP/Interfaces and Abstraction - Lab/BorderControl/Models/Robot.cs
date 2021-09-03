using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorderControl.Interfaces;

namespace BorderControl.Models
{
    public class Robot : Inhabitant
    {
        public Robot(string name, string id)
        {
            this.Name = name;
            this.ID = id;
        }

        public string Name { get; private set; }

        public string ID { get; private set; }

        public override string ToString()
        {
            return $"I am robot {this.Name} with {this.ID} ID.";
        }
    }
}
