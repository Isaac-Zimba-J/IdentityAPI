
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityAPI;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly UserManager<ApplicationUser> userManager;
    private readonly SignInManager<ApplicationUser> signInManager;

    public UserController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        this.userManager = userManager;
        this.signInManager = signInManager;
    }  

    [HttpPost("register-user")]
    public async Task<IActionResult> Register(CustomUser model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var user = new ApplicationUser()
        {
            UserName = model.Fname + model.Lname,
            Email = model.Email,
            PasswordHash = model.Password,
            Fname = model.Fname,
            Lname = model.Lname,
            PhoneNumber = model.PhoneNumber,
            University = model.University
        };

        var result = await userManager.CreateAsync(user, user.PasswordHash);
        
        if (result.Succeeded)
            return Ok("Registration successfull.");
        var errors = result.Errors.Select(e => e.Description).ToList();
        return BadRequest(new { Errors = errors });
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(string email, string password)
    {
        var signInResult = await signInManager.PasswordSignInAsync(
            userName: email!,
            password: password!,
            isPersistent: false,
            lockoutOnFailure: false
        );
        if (signInResult.Succeeded)
        {
            return Ok("loged in succesffully");
        }

        return BadRequest("Error occured on login");
    }
}
