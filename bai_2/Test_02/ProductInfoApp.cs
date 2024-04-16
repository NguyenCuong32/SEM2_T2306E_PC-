namespace Test_02;

using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Microsoft.Maui.Controls;

namespace ProductInfoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Read JSON file and deserialize it
            var products = LoadProductsFromJson("product.json");

            // Create UI elements to display product information
            var stackLayout = new StackLayout();

            foreach (var product in products)
            {
                var label = new Label
                {
                    Text = $"Product Name: {product.ProductName}\nPrice: ${product.Price}"
                };

                stackLayout.Children.Add(label);
            }

            Content = stackLayout;
        }

        private List<Product> LoadProductsFromJson(string fileName)
        {
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Product>>(json);
            }
        }
    }
}