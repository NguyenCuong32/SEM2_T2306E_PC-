
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class ProductService
{
    private string filePath = "product.json";

    public List<Product> GetProducts()
    {
        string jsonString = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<Product>>(jsonString);
    }
}
