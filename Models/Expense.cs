namespace IdentityAPI;

public class Expense
{
    public int expenseId { get; set; }
    public CustomUser user { get; set; }
    public double amount { get; set; }
    public Tag tag { get; set; }
    public DateOnly date { get; set; }
    public string description { get; set; }
    public int expenseNumber { get; set; }

}
