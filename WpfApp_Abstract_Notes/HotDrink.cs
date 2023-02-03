using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Abstract_Notes
{
    class HotDrink : Drink
    {
        double _temperature;
        public HotDrink(string name, decimal price, string sku, Size drinkSize, double temperature) : base(name, price, sku, drinkSize)
        {
            _temperature = temperature;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Temperature: {_temperature}";
        }
    }
}