using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().Where(w => w.Length % 2 == 0);

            Console.WriteLine(string.Join("/n", words));
        }
    }
}
