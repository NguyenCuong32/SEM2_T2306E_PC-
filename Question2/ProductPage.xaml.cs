using Question2.Services;

namespace Question2
{
    public partial class ProductPage : ContentPage
    {
        public ProductPage() 
        { 
            InitializeComponent();
            BindingContext = this;

            ProductService productService = new ProductService();
            var products = productService.GetProducts();
            ProductCollection.ItemsSource = products;
        }
    }
}
