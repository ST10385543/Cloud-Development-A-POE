using System.ComponentModel.DataAnnotations;

namespace ST10385543_CLDV6211_Part1.Models.Product;
public class ProductCategory
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsActive {  get; set; }
}

