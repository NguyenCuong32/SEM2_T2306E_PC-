using System.Text.Json;

namespace Bai2;

public class ProductService
{
    public class Product()
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
    }
    public List<Product> GetProducts()
    {
        string path = "/Users/dung/code/learn2/Thi C sharp/SEM2_T2306E_PC-/Bai2/Product.json";
        string content = File.ReadAllText(path);
        List<Product> result = new List<Product>();
        result = JsonSerializer.Deserialize<List<Product>>(content);
        return result;
    }

}
