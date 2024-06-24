using Microsoft.AspNetCore.Identity;

namespace IdentityAPI;

public class ApplicationUser : IdentityUser
{
    public string Fname { get; set; }
    public string Lname { get; set; }
    public int PhoneNumber { get; set; }
    public string University { get; set; }
    
}