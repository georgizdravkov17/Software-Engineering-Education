using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var firstDateInfo = Console.ReadLine().Split();

            var firstDateYear = int.Parse(firstDateInfo[0]);
            var firstDateMonth = int.Parse(firstDateInfo[1]);
            var firstDateDay = int.Parse(firstDateInfo[2]);

            var secondDateInfo = Console.ReadLine().Split();

            var secondDateYear = int.Parse(secondDateInfo[0]);
            var secondDateMonth = int.Parse(secondDateInfo[1]);
            var secondDateDay = int.Parse(secondDateInfo[2]);

            var firstDate = new Date(firstDateYear, firstDateMonth, firstDateDay);

            var secondDate = new Date(secondDateYear, secondDateMonth, secondDateDay);

            Date.GetDifference(DateTime(firstDate), DateTime(secondDate));
        }
    }
}
