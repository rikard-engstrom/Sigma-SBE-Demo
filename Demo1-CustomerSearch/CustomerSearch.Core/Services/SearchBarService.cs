using CustomerSearch.Core.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CustomerSearch.Core.Services
{
    public class SearchBarService
    {
        private ICustomerDatabase _database;

        public SearchBarService(ICustomerDatabase database)
        {
            _database = database;
        }

        public IEnumerable<Customer> SearchByName(string searchPhrase)
        {
            if (string.IsNullOrWhiteSpace(searchPhrase))
            {
                return new Customer[0];
            }

            var searchPattern = CreateSearchPattern(searchPhrase);
            return QueryCustomers(searchPattern);
        }

        private Regex CreateSearchPattern(string searchPhrase)
        {
            var phrase = searchPhrase.Replace("c","[c|k]");
            return new Regex(phrase, RegexOptions.IgnoreCase);
        }

        private IEnumerable<Customer> QueryCustomers(Regex searchPattern)
        {
            return _database.GetAll()
                                .Where(x => searchPattern.IsMatch(x.FamilyName))
                                .OrderBy(x => x.FamilyName)
                                .ThenBy(x => x.GivenName);
        }
    }
}
