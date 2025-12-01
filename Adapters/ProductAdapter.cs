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
            Button btnAddToCart = view.FindViewById<Button>(Resource.Id.btnAddToCart);
            
            Button btnMinus = view.FindViewById<Button>(Resource.Id.btnMinus);
            Button btnPlus = view.FindViewById<Button>(Resource.Id.btnPlus);
            EditText etAmaount = view.FindViewById<EditText>(Resource.Id.etAmount);
            imgItemImage.SetImageResource(item.ImageResourceId);
            txtName.Text = item.Title;
            txtType.Text = item.ProductType;

            btnShowItem.Click += BtnShowItem_Click;
            btnShowItem.Tag = position;

            btnAddToCart.Click += BtnAddToCart_Click;
            btnAddToCart.Tag = new ButtonInfo(position, etAmaount);

            btnMinus.Click += BtnMinus_Click;
            btnMinus.Tag = etAmaount;
            btnPlus.Click += BtnPlus_Click;
            btnPlus.Tag = etAmaount;
            return view;
        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ButtonInfo info = (ButtonInfo)(btn.Tag);
            Product product = Global.Products[info.Position];
            int amount = int.Parse(info.ETAmount.Text);
            ShoppingCart.Add(product, amount);
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            EditText etAmount = (EditText)btn.Tag;
            int amount = int.Parse(etAmount.Text);
            amount++;
            etAmount.Text = amount.ToString();
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            EditText etAmount = (EditText)btn.Tag;
            int amount = int.Parse(etAmount.Text);
            amount--;
            if(amount>=0)
                etAmount.Text = amount.ToString();
        }

        private void BtnShowItem_Click(object sender, EventArgs e)
        {
            OpenProductDialog();
        }

        private void OpenProductDialog()
        {
            ProductDialog dialog = new ProductDialog(this.context);
            dialog.Show();
        }

        class ButtonInfo: Java.Lang.Object
        {
            public ButtonInfo(int Position, EditText ETAmount)
            {
                this.Position = Position;
                this.ETAmount = ETAmount;
            }

            public int Position;
            public EditText ETAmount;
        }
    }
}