namespace IdentityAPI;

public class SavingsAccount
{
    public int accountId { get; set; }
    public CustomUser user { get; set; }
    public string goalName { get; set; }
    public double goalAmount { get; set; }
    public double currentAmount { get; set; }
    public DateOnly? startDate { get; set; }
    public DateOnly? endDate { get; set; }
    public DateOnly lockInPerioid { get; set; }
    public UserType userType { get; set; } = UserType.User;
    public AccountType accountType { get; set; } = AccountType.Bronze;

}
