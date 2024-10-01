namespace Banking.Web.Shared.Models
{
    public sealed record CustomerTransactionResponse(
        Guid? CustomerId,
        string Name,
        string Surname,
        decimal? Balance)
    {
        public List<TransactionResponse> Transactions { get; set; }
    }
}
