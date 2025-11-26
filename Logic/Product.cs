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
	class Product
	{
		public string ProductId { get; set; }
		public string Title { get; set; }  
		public string Details { get; set; } 
		public double Price { get; set; }
		public int ImageResourceId { get; set; }   
		public string ProductType { get; set; }

		public Product(string id, string title, double price, int imageId, string productType)
        {
			this.ProductId = id;
			this.Title = title;
			this.Price = price;
			this.ImageResourceId = imageId;
			this.ProductType = productType;
        }
	}
}