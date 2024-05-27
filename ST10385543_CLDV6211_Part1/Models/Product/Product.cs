using System.ComponentModel.DataAnnotations;

namespace ST10385543_CLDV6211_Part1.Models.Product;
public class Product
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int QuantityAvailable { get; set; }
    public bool IsActive {get; set; }
    public int ProductCategoryId { get; set; }
}
