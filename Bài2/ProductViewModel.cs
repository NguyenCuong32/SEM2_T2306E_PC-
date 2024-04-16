using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProductViewer.Models;

namespace ProductViewer.ViewModels
{
    public class ProductViewModel
    {
        public List<Product> Products { get; private set; }

        public ProductViewModel()
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            string json = File.ReadAllText("products.json");
            Products = JsonConvert.DeserializeObject<List<Product>>(json);
        }
    }
}
