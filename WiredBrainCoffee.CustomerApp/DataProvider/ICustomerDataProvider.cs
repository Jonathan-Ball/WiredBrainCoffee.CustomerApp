using System.Collections.Generic;
using System.Threading.Tasks;
using WiredBrainCoffee.CustomerApp.Model;

namespace WiredBrainCoffee.CustomerApp.DataProvider
{
    public interface ICustomerDataProvider
    {
        Task<IEnumerable<Customer>> LoadCustomerAsync();
        Task SaveCustomersAsync(IEnumerable<Customer> customers);
    }
}