using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            var result = Area(width, height);
            Console.WriteLine(result);
        }
        public static int Area(int width,int height)
        {
            return width * height;
        }
    }
}
