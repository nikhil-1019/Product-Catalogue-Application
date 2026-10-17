using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers;

public class ProductDetailsController : Controller
{
    private static readonly List<Product> Products = new()
    {
        new Product { ProductId = 1, Image = "https://images.unsplash.com/photo-1496181133206-80ce9b88a853?w=700", ProductName = "Laptop", ProductCategory = "Electronics", ProductPrice = 55000 },
        new Product { ProductId = 2, Image = "https://images.unsplash.com/photo-1511707171634-5f897ff02aa9?w=700", ProductName = "Mobile Phone", ProductCategory = "Electronics", ProductPrice = 25000 },
        new Product { ProductId = 3, Image = "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?w=700", ProductName = "Headphones", ProductCategory = "Accessories", ProductPrice = 2000 },
        new Product { ProductId = 4, Image = "https://images.unsplash.com/photo-1523275335684-37898b6baf30?w=700", ProductName = "Smart Watch", ProductCategory = "Accessories", ProductPrice = 5000 }
    };

    public IActionResult Index() => View(Products);

    public IActionResult Details(int id)
    {
        var product = Products.FirstOrDefault(p => p.ProductId == id);
        if (product is null) return NotFound();
        return View(product);
    }
}
