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
    internal class ProductAdapter : BaseAdapter<Product>
    {
        List<Product> products;
        Context context;

        public ProductAdapter(Context context, List<Product> products)
        {
            this.products = products;
            this.context = context;
        }
        public override Product this[int position]
        {
            get { return products[position]; }
        }

        public override int Count
        {
            get { return products.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            Product item = products[position];

            View view = LayoutInflater.From(context).Inflate(Resource.Layout.product_item_layout, parent, false);

            ImageView imgItemImage = view.FindViewById<ImageView>(Resource.Id.imgProductImage);
            TextView txtName = view.FindViewById<TextView>(Resource.Id.tvProductTitle);
            TextView txtType = view.FindViewById<TextView>(Resource.Id.tvProductType);
            Button btnShowItem = view.FindViewById<Button>(Resource.Id.btnShowItem);

            imgItemImage.SetImageResource(item.ImageResourceId);
            txtName.Text = item.Title;
            txtType.Text = item.ProductType;

            btnShowItem.Click += BtnShowItem_Click; ;
            btnShowItem.Tag = position;

            return view;
        }

        private void BtnShowItem_Click(object sender, EventArgs e)
        {
            OpenProductDialog();
        }

        private void OpenProductDialog()
        {
            
        }
    }
}