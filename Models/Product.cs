namespace ProductCatalog.Models;

public class Product
{
    public int ProductId { get; set; }
    public string Image { get; set; } = "";
    public string ProductName { get; set; } = "";
    public string ProductCategory { get; set; } = "";
    public decimal ProductPrice { get; set; }
}
