using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprog4
{
    internal class ElectronicItem : InventoryItem, ISellable
    {
        public string Insurance { get; set; }
        public string Voltage { get; set; }

        public double NetPrice()
        {
            return Price * 0.78;
        }

        public double NetSale()
        {
            return NetPrice() * 0.9
        }
        public ElectronicItem(double price, string name, int amount, string color, string size, string insurance, double voltage) : base(price, name, amount, color, size)
        { 
            Insurance = insurance;
            Voltage = voltage;
        }
    }
}
