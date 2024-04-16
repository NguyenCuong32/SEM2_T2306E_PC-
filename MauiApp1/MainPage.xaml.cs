
using Microsoft.Maui.Controls;
using System.Collections.Generic;

public partial class MainPage : ContentPage
{
	private ProductService productService;

	public MainPage()
	{
		InitializeComponent();
		productService = new ProductService();
		ShowProducts();
	}

	private void InitializeComponent()
	{
		throw new NotImplementedException();
	}

	private void ShowProducts()
	{
		List<Product> products = productService.GetProducts();
		foreach (Product product in products)
		{
			Label label = new Label
			{
				Text = $"Product ID: {product.Id}\nProduct Name: {product.ProductName}\nPrice: {product.Price.ToString("C")}",
				FontSize = 20
			};
			stackLayout.Children.Add(label);
		}
	}
}
