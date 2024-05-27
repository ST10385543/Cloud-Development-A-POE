using ST10385543_CLDV6211_Part1.Data;
using ST10385543_CLDV6211_Part1.Models.User;

namespace ST10385543_CLDV6211_Part1.Business;
public class UserHandler(ApplicationDbContext context)
{
    public void InsertUserAccount(UserAccount userAccount)
    {
        UserAccount account = new UserAccount
        {
            FullName = userAccount.FullName,
            EmailAddress = userAccount.EmailAddress,
            PhoneNumber = userAccount.PhoneNumber,
            IsActive = true
        };

        context.UserAccount.Add(account);
        context.SaveChanges();
    }
}
