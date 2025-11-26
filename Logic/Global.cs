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
    internal class Global
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product("134565", "Product 1", 86.5, Resource.Drawable.image1, "Shirts"),
            new Product("288745", "Product 2", 196.5, Resource.Drawable.image1, "Shirts"),
            new Product("8685", "Product 3", 95, Resource.Drawable.image2, "Pans"),
            new Product("1357", "Product 4", 104, Resource.Drawable.image2, "Pans"),
            new Product("9864", "Product 5", 34, Resource.Drawable.image2, "Pans"),
            new Product("17845", "Product 6", 243.3, Resource.Drawable.image1, "Coats"),
            new Product("6457", "Product 7", 67, Resource.Drawable.image1, "Shirts"),
            new Product("86787", "Product 8", 72, Resource.Drawable.image1, "Coats"),
            new Product("34234", "Product 9", 41, Resource.Drawable.image1, "Shirts"),
            new Product("54566", "Product 10", 59.9, Resource.Drawable.image1, "Coats"),
            new Product("1784565", "Product 11", 243.3, Resource.Drawable.image1, "Coats"),
            new Product("6896757", "Product 12", 67, Resource.Drawable.image2, "Pans"),
            new Product("8786787", "Product 13", 72, Resource.Drawable.image1, "Coats"),
            new Product("76234", "Product 14", 41, Resource.Drawable.image1, "Shirts"),
            new Product("54436", "Product 15", 59.9, Resource.Drawable.image1, "Coats")
        };
    }
}