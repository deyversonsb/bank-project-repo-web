using Banking.Web.Shared.Models;

namespace Banking.Web.Services.Transactions
{
    public interface ITransactionService
    {
        Task<Guid> AddCreditTransactionAsync(TransactionRequest request, CancellationToken cancellationToken = default);
        Task<CustomerTransactionResponse> GetTransactionsByCustomerAsync(Guid customerId, CancellationToken cancellationToken = default);
    }
}
