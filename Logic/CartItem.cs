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
    class CartItem: Product
    {        
        public int Amount { get; set; }
        public CartItem(Product product, int amount):base(product.ProductId, product.Title, product.Price, product.ImageResourceId, product.ProductType)
        {
            this.Amount = amount;
        }
    }
}