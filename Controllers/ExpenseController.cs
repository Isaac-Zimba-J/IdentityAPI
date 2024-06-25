using Microsoft.AspNetCore.Mvc;
namespace IdentityAPI;

[Route("api/[controller]")]
[ApiController]

public class ExpenseController : ControllerBase
{
    [HttpGet("get-expenses")]
    public async Task<IActionResult> fetchExpenses()
    {
        var expenses = new List<Expense> {
            new Expense {
                expenseId = 1,
                user = new CustomUser { Fname = "John", Lname = "Doe", Email = "isaac@gmail.com", PhoneNumber = 970187487, University = "CBU" },
                amount = 23,
                tag = new Tag { TagId = 1, TagName = "Internet", Colour= "#87987"},
                date = new DateOnly(2021, 10, 10),
                description = "Internet subscription",
                expenseNumber = 1
            }
        };
        return Ok(expenses);
    }
}
