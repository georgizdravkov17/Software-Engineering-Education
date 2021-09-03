using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBoxes
{
    class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity, double price)
        {
            this.SerialNumber = serialNumber;
            this.item = item;
            this.ItemQuantity = itemQuantity;
            this.Price = price;
        }

        public string SerialNumber { get; set; }

        public Item item { get; set; }

        public int ItemQuantity { get; set; }

        public double Price { get; set; }
    }
}
