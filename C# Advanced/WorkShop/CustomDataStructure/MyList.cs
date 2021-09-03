using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructure
{
    public class MyList
    {
        private int[] data;
        private int count;

        public MyList()
        {

        }

        public MyList(int[] data)
        {
            this.Data = data;
        }

        public int[] Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void AddItem(int element)
        {

            if(data.Length == count)
            {
                ResizeArray();
            }

            data[data.Length] = element;
            count++;
        }

        public int RemoveAt(int index)
        {
            if (!isIndexValid(index))
            {
                throw new Exception("Index is not valid!");   
            }

            var removedElement = data[index];

            for (int i = removedElement; i < data.Length; i++)
            {
                data[i] = data[i + 1];
            }

            count--;
            return removedElement;
        }

        public bool Contains(int element)
        {
            var isFound = false;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == element)
                {
                    isFound = true;
                    break;
                }

            }

            return isFound;
        }

        public int[] Swap(int firstIndex, int secondIndex)
        {
            if(isIndexValid(firstIndex) && isIndexValid(secondIndex))
            {
                var firstValue = data[firstIndex];
                var secondValue = data[secondIndex];

                data[firstIndex] = secondValue;
                data[secondValue] = firstValue;
            }
            else
            {
                throw new Exception("Not valid index!");
            }

            return data;
            
        }

        private bool isIndexValid(int index)
        {
            return index < 0 || index >= data.Length ? false : true;
            
        }

        private void ResizeArray()
        {
            var newDataLenght = count * 2;
            var newDataArray = new int[newDataLenght];
            
            for (int i = 0; i < data.Length; i++)
            {
                newDataArray[i] = data[i];
            }

            data = newDataArray;
        }
    }
}
