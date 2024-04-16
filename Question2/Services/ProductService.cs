using System.Text.Json;

namespace Question2.Services
{
    public class ProductService
    {
        public class Product() 
        {
            public int id { get; set; }
            public string? productName { get; set; }
            public decimal price { get; set; }
        }

        public List<Product> GetProducts()
        {
            string path = "C:\\Users\\Admin\\OneDrive\\Máy tính\\All Folders\\FAI\\SEM2\\C#\\Question2\\product.json";
            string content = File.ReadAllText(path);
            List<Product> result = new List<Product>();
            result = JsonSerializer.Deserialize<List<Product>>(content);
            return result;
        }
    }
}
