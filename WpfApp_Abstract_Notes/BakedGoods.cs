using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Abstract_Notes
{
    public class BakedGood : Product
    {
        string _expirationDate;

        public BakedGood(string name, decimal price, string sku, string experationDate) : base(name, price, sku)
        {
            _expirationDate = experationDate;
        }

        public override bool InStock()
        {
            if (_expirationDate != DateTime.Now.ToShortDateString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $" Expiration Date: {_expirationDate}";
        }
    }
}