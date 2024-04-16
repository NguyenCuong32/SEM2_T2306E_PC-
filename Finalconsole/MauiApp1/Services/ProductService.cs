using System.Text.Json;

namespace MauiApp.Services;

public class ProductService
{
    public class Product() 
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public double Price { get; set; }
    }

    public List<Product> GetProducts()
    {
        string path = "D:\\Workplace\\Programming\\Aptech\\C#\\Finalconsole\\MauiApp1\\Product.json";
        string content = File.ReadAllText(path);
        List<Product> result = new List<Product>();
        result = JsonSerializer.Deserialize<List<Product>>(content);
        return result;
    }
}