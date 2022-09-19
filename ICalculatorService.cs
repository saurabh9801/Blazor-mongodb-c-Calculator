using CalculatorClassLibrary;

namespace WebApp.Services
{
    public interface ICalculatorService
    {
        Task<IEnumerable<Calculator>> GetCalculators();


    }


}
