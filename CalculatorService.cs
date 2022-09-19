using CalculatorClassLibrary;
using MongoDB.Driver;
using System.Net.Http;

namespace WebApp.Services
{
    public class CalculatorService : ICalculatorService
    {
        private readonly HttpClient httpClient;

        public CalculatorService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<Calculator>> GetCalculators()
        {

            return await httpClient.GetFromJsonAsync<Calculator[]>("/api/Calculator");

            //throw new NotImplementedException();
        }

    }

}


