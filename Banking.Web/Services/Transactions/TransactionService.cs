
using Banking.Web.Shared.Models;
using System.Net.Http.Json;

namespace Banking.Web.Services.Transactions
{
    internal sealed class TransactionService(
        IHttpClientFactory httpClientFactory) : Service, ITransactionService
    {
        internal readonly HttpClient _httpClient = httpClientFactory.CreateClient(WebConfiguration.HttpBankingApi);

        public async Task<Guid> AddCreditTransactionAsync(TransactionRequest request, CancellationToken cancellationToken = default)
        {
            var content = GetContent(request);

            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsync("v1/transactions/credit", content, cancellationToken);

            var result = await httpResponseMessage.Content.ReadAsStringAsync();

            return Guid.NewGuid();
        }

        public async Task<CustomerTransactionResponse> GetTransactionsByCustomerAsync(Guid customerId, CancellationToken cancellationToken = default)
        {
            var httpResponseMessage = await _httpClient.GetFromJsonAsync<CustomerTransactionResponse>($"v1/transactions/customers/{customerId}", cancellationToken);

            return httpResponseMessage;
        }
    }
}
