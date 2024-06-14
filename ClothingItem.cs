using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprog4
{
    internal class ClothingItem : InventoryItem, ISellable
    {
        public string Stoff { get; set; }
        public string Brand { get; set; }

        public double NetPrice()
        {
            return Price * 0.8;
        }

        public double NetSale()
        {
            return NetPrice() * 0.63;
        }

        public ClothingItem(double price, string name, int amount, string color, string size, string stoff, string brand) : base(price, name, amount, color, size) 
        {
            {
                Stoff = stoff;
                Brand = brand;
            }
    }
}
