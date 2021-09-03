using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
   public class Engine
    {
        public Engine(int engineSpeed,int enginePower)
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }

        public int EngineSpeed { get; private set; }

        public int EnginePower { get; private set; }

    }
}
