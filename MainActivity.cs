using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System.Collections.Generic;
using System.Linq;

namespace ListExampleApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ListView lvProducts;
        Spinner spProductFilter;
        ProductAdapter productAdapter;
        string[] productTypes = { "All", "Shirts", "Pans", "Coats" };
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            spProductFilter = FindViewById<Spinner>(Resource.Id.spFilterProducts);
            spProductFilter.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerDropDownItem, productTypes);
            spProductFilter.ItemSelected += SpProductFilter_ItemSelected;

            lvProducts = FindViewById<ListView>(Resource.Id.lvProducts);
            productAdapter = new ProductAdapter(this, Global.Products);
            lvProducts.Adapter = productAdapter;
        }

        private void SpProductFilter_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            string productType = productTypes[e.Position];
            List<Product> filteredItems = new List<Product>();

            if(productType == "All")
                filteredItems = Global.Products;

            foreach (Product item in Global.Products)
            {
                if(item.ProductType == productType)
                    filteredItems.Add(item);
            }

            productAdapter = new ProductAdapter(this, filteredItems);
            lvProducts.Adapter = productAdapter;
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}