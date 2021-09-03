using SingleInheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new Animal();

            animal.Eat();

            var dog = new Dog();

            dog.Eat();
            dog.Bark();
        }
    }
}
