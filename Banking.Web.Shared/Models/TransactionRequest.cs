namespace Banking.Web.Shared.Models
{
    public sealed record TransactionRequest(Guid CustomerId, decimal InitialCredit);
}
