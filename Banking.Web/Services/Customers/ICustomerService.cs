using Banking.Web.Shared.Models;

namespace Banking.Web.Services.Customers
{
    public interface ICustomerService
    {
        Task<string> RegisterCustomerAsync(CustomerRequest request, CancellationToken cancellationToken = default);
    }
}
