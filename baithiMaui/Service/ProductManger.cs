using System.Text.Json;

namespace ProductManger.Service
{
    public class ProductService
    {
        public class Product()
        {
            public int id { get; set; }
            public double price { get; set; }
            public string? productName { get; set; }
        }

        public List<Product> GetProducts()
        {
            string path = "\\Product.json";
            string content = File.ReadAllText(path);
            List<Product> result = new List<Product>();
            result = JsonSerializer.Deserialize<List<Product>>(content);
            return result;
        }   
    }
}
