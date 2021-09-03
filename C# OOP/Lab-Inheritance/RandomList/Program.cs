using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var list = new MyList();

            list.Add("Pesho");
            list.Add("Gosho");
            list.Add("Ivan");
            list.Add("Mitio");
            list.Add("Gosho");

            list.RemoveRandomElement();

            Console.WriteLine(list.Count);

           var returnedElement =  list.ReturnRandomElement();

            Console.WriteLine(returnedElement);
        }
    }
}
