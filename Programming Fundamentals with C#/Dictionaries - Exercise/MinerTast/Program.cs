using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTast
{
    class Program
    {
        static void Main(string[] args)
        {

            var minerResourses = new Dictionary<string, int>();

            while (true)
            {
                var resourse = Console.ReadLine().ToLower();

                if (resourse.Equals("stop"))
                {
                    break;
                }


                var quantity = int.Parse(Console.ReadLine());

               

                if (!minerResourses.ContainsKey(resourse))
                {
                    minerResourses[resourse] = quantity;
                }

                else
                {

                minerResourses[resourse] += quantity;

                }

            }

            foreach (var kvp in minerResourses)
            {
                var resourse = kvp.Key;
                var quantity = kvp.Value;

                Console.WriteLine($"{resourse} -> {quantity}");
            }
        }
    }
}
