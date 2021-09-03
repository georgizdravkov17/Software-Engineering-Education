using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            Animal cat = new Cat("Pesho", "WIskas");
            Animal dog = new Dog("Ivan", "Granuli");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}
