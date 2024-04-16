namespace Test_02;

public class Product
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }
    }
