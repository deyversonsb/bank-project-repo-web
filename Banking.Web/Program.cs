using Banking.Web;
using Banking.Web.Services.Customers;
using Banking.Web.Services.Transactions;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddMudServices();

builder.Services.AddScoped<ITransactionService, TransactionService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();

builder.Services.AddHttpClient(WebConfiguration.HttpBankingApi,
    opt =>
    {
        opt.BaseAddress = new Uri(WebConfiguration.Localhost);
    });

await builder.Build().RunAsync();
