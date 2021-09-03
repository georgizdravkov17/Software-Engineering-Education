using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyInheritance
{
   public class StartUp
    {
        public static void Main(string[] args)
        {
            var animal = new Animal();

            animal.Eat();

            var dog = new Dog();

            dog.Bark();

            var puppy = new Puppy();

            puppy.Wheep();
        }
    }
}
