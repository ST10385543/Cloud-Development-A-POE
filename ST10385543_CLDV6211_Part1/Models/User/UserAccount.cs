using System.ComponentModel.DataAnnotations;

namespace ST10385543_CLDV6211_Part1.Models.User;
public class UserAccount
{
    [Key]
    public int Id { get; set; }
    public string FullName { get; set; }
    public string EmailAddress { get; set; }
    public string PhoneNumber { get; set; }
    public bool IsActive {  get; set; } 

}

