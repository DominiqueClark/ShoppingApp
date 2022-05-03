using System;
using System.Collections.Generic;
namespace ShoppingLibrary
{
    
    public class ShoppingCart
    {
        List<ShoppingCartItems> _Shoppingitems = new List<ShoppingCartItems>();
        protected string ShoppingCartItems;
        public double total;
        private double _vat = 1.15;
        public ShoppingCart()
        {
            

        }

        public void AddShoppingCartItems(ShoppingCartItems Items)
        {
            _Shoppingitems.Add(Items);

            
        }

        public double GetSubTotal()
        {
            double total = 0;
            foreach (ShoppingCartItems Items in _Shoppingitems)
            {
                total += Items.Price;
            }
            return total;
        }

        public double GetSubtotalWithVat()
        {
            double subtotal = GetSubTotal();

            return Math.Round(subtotal * _vat, 2);

        }
         public List<ShoppingCartItems> myshoppingCartItems()
         {
            return _Shoppingitems;  
         }

        

       
       

    }
}
