using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListExampleApp
{
    static class ShoppingCart
    {
        public static List<CartItem> Items = new List<CartItem>();
        public static void Add(Product product, int amount)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if(Items[i].ProductId == product.ProductId)
                {
                    Items[i].Amount += amount;
                    return;
                }
            }
            Items.Add(new CartItem(product, amount));
        }
    }
}