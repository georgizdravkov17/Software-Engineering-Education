using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    public class MyList : List<string>
    {

        public MyList()
        {
            this.Mylist = new List<string>();
        }

        private List<string> Mylist { get; }

        public string ReturnRandomElement()
        {
            var random = new Random();

            var randomElement = Mylist[random.Next(0, Mylist.Count - 1)];

            return randomElement;
        }

        public void RemoveRandomElement()
        {
            var random = new Random();

            var randomIndex = random.Next(0, Mylist.Count - 1);


        }
    }
}