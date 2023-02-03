using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Abstract_Notes
{
    abstract class Drink : Product
    {
        public enum Size { Tall, Grande, Venti, Trenta }

        Size _drinkSize;

        public Drink(string name, decimal price, string sku, Size drinkSize) : base(name, price, sku)
        {
            _drinkSize = drinkSize;
        }

        public Size DrinkSize
        {
            get => _drinkSize;
        }

        // Override the ToString()

        public override string ToString()
        {
            return base.ToString() + $" - Drink Size: {_drinkSize.ToString()}";
        }

        public override bool InStock()
        {
            if (DrinkSize <= Size.Venti) return false;
            return true;
        }
    }
}