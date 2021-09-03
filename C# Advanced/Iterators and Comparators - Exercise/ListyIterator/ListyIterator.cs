using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
   public class ListyIterator : IEnumerable<int>
    {
        public ListyIterator()
        {

        }

        public ListyIterator( List<int> numbers)
        {
            this.Numbers = numbers;
            this.index = 0;
        }

        public List<int> Numbers { get; set; }

        public int index { get; set; }

        public bool Move()
        {     
            return IsValidIndex(index) ? true : false;
            index++;
        }

        public bool HasNext()
        {
            return index < Numbers.Count - 2 ? true : false;
                     
        }

        public int Print()
        {
            if(Numbers.Count == 0)
            {
                throw new Exception("The list is empty!");
            }

            return Numbers[index];
            
        }

        public bool IsValidIndex(int index)
        {
            if(index < Numbers.Count - 1)
            {
                return true;
            }
            else
            {
                throw new Exception("The index is not valid");
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Numbers.Count; i++)
            {
                yield return this.Numbers[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
