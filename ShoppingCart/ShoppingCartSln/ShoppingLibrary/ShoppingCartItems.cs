using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{


    public class ShoppingCartItems
    {

        public string _Itemname;
        public double _Price;
        public ShoppingCartItems(string itemname,double price)
        {
            _Itemname = itemname;
            _Price = price;
        }

       public virtual string Itemname
       {
            get { return _Itemname; }
       }

        public virtual double Price
        {
            get { return _Price; }
        }
    }
}
