using ShoppingLibrary;
using System;
using System.Collections.Generic;

namespace MyShoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ShoppingCart mycart = new ShoppingCart();

            var item = new ShoppingCartItems("Bread", 50);
            
            mycart.AddShoppingCartItems (item);

            item = new ShoppingCartItems("Milk", 80);

            mycart.AddShoppingCartItems(item);

            item = new ShoppingCartItems("Apples", 30);

            mycart.AddShoppingCartItems(item);

            item = new ShoppingCartItems("PS3", 7700);

            mycart.AddShoppingCartItems(item);
            
            List<ShoppingCartItems> ShoppingCartItem = mycart.myshoppingCartItems();

            foreach(ShoppingCartItems ShoppingCartItems in ShoppingCartItem)
            {
                Console.WriteLine(_ = ShoppingCartItems._Itemname + "\t\t\t\t" + "R" + ShoppingCartItems._Price);
            }


            Console.WriteLine("Subtotal:" + "\t\t\t" + "R" + mycart.GetSubTotal());
            Console.WriteLine("WithVAT:" + "\t\t\t" + "R" + mycart.GetSubtotalWithVat());
        }
    }
}
