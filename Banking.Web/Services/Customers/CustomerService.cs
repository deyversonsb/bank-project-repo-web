using Banking.Web.Shared.Models;

namespace Banking.Web.Services.Customers
{
    internal sealed class CustomerService(
        IHttpClientFactory httpClientFactory) : Service, ICustomerService
    {
        internal readonly HttpClient _httpClient = httpClientFactory.CreateClient(WebConfiguration.HttpBankingApi);
        public async Task<string> RegisterCustomerAsync(CustomerRequest request, CancellationToken cancellationToken = default)
        {
            var content = GetContent(request);

            var httpResponseMessage = await _httpClient.PostAsync("v1/accounts", content, cancellationToken);

            httpResponseMessage.EnsureSuccessStatusCode();

            return await httpResponseMessage.Content.ReadAsStringAsync(cancellationToken);
        }
    }
}
