using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Product.ProductService
{
    internal class ProductService
    {
        public class Product()
        {
            public string? name { get; set; }
            public int age { get; set; }
            public string? gender { get; set; }
        }

        public List<Product> GetProduct()
        {
            string path = "D:\\NguyenVanThang\\SEM2_T2306E_PC-\\Product\\Product.json";
            string content = File.ReadAllText(path);
            List<Product> result = new List<Product>();
            result = JsonSerializer.Deserialize<List<Product>>(content);
            return result;
        }

    }
}
