using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp.Services;

namespace MauiApp;

public partial class ProductPage : ContentPage
{
    public ProductPage()
    {
        InitializeComponent();
        BindingContext = this;

        ProductService productService = new ProductService();
        var product = productService.GetProducts();
        productCollection.ItemsSource = product;
    }
}