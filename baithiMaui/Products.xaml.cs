using ProductManger.Service;

namespace MauiApp1;

public partial class Products : ContentPage
{
	public Products()
	{
		InitializeComponent();
		BindingContext = this;
		
		ProductService productService = new ProductService();
        var product = productService.GetProducts();
        ProductCollection.ItemsSource = product;
	}
}