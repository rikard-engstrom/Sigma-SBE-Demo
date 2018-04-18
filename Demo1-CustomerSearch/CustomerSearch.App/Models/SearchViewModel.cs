using System.Collections.Generic;
using CustomerSearch.Core.Models;

namespace CustomerSearch.App.Models
{
    public class SearchViewModel
    {
        public string SearchPhrase { get; internal set; }
        public IEnumerable<Customer> Customers { get; internal set; }
    }
}