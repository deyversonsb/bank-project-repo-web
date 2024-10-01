using Banking.Web.Shared.Enums;

namespace Banking.Web.Shared.Models
{
    public sealed record TransactionResponse(
        Guid Id,
        TransactionType TransactionType,
        string TransactionName,
        decimal Amount,
        DateTime CreatedAtUtc)
    {
        public bool ShowDetails { get; set; } = false;
    }
}
