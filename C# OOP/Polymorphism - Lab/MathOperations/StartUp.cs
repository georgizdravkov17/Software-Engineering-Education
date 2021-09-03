using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            var mathOperations = new MathOperations();

            Console.WriteLine(mathOperations.Add(2,3));
            Console.WriteLine(mathOperations.Add(2.5,2.7,2.8));
            Console.WriteLine(mathOperations.Add(2.2,3.3,4.4));
        }
    }
}
