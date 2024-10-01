using System.Text.Json;
using System.Text;

namespace Banking.Web.Services
{
    internal abstract class Service
    {
        protected static StringContent GetContent(object obj)
            => new(JsonSerializer.Serialize(obj), Encoding.UTF8, "application/json");
    }
}
