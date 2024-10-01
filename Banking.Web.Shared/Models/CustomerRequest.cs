namespace Banking.Web.Shared.Models
{
    public sealed record CustomerRequest(string Name, string Surname, decimal InitialCredit);
}
