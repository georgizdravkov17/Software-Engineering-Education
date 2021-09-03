using CustomDataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList(new int[] { 1, 2, 3, 4 });

            Console.WriteLine(list.Count);
            Console.WriteLine(list.Contains(2));
            list.Swap(1,3);
            Console.WriteLine(string.Join(" ",list));
            
        }
    }
}
