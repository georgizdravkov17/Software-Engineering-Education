using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var dog = new Dog();

            var cat = new Cat();

            dog.Bark();

            cat.Meow();
        }
    }
}
