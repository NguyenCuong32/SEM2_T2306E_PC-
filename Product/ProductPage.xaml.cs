
using Product.ProductService;
using Product.ProductService.Service;

using System.Collections.ObjectModel;

namespace ProductManagement;

public partial class ProductPage : ContentPage
{
	public ProductPage()
	{
		InitializeComponent();
    
		BindingContext = this;
		
		ProductService studentService = new ProductService();
        var students = studentService.GetProduct();
        ProductCollection.ItemsSource = students;
    }
}