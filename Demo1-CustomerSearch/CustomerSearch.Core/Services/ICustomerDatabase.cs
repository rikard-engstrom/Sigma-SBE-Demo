using CustomerSearch.Core.Models;
using System.Collections.Generic;

namespace CustomerSearch.Core.Services
{
    public interface ICustomerDatabase
    {
        IEnumerable<Customer> GetAll();
    }
}
