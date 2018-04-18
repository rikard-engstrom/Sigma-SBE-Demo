using System.Collections.Generic;
using System.Linq;
using CustomerSearch.Core.Models;
using CustomerSearch.Core.Services;
using CustomerSearch.Tests.TestHelpers;
using Moq;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace CustomerSearch.Tests.SearchBar
{
    [Binding, Scope(Feature = "Search for customers by name")]
    class SearchForCustomersByNameSteps
    {
        private IEnumerable<Customer> _customers;
        private string _searchPhrase;

        [Given(@"that the following customers exists in the database")]
        private void GivenThatTheFolliwingCustomersExistsInTheDatabase(Table table)
        {
            _customers = table.CreateSet<Customer>();
        }

        [When(@"searching for '(.*)'")]
        private void WhenSearchingFor(string searchPhrase)
        {
            _searchPhrase = searchPhrase;
        }

        [Then(@"the result includes all these customers")]
        private void ThenTheResultIncludesAllTheseCustomers(Table table)
        {
            var expected = table.CreateSet<Customer>();

            var database = new Mock<ICustomerDatabase>();
            database.Setup(x => x.GetAll()).Returns(_customers);
            var searchBar = new SearchBarService(database.Object);

            var result = searchBar.SearchByName(_searchPhrase);
            Asserts.AreEqual(expected, result);
        }
    }
}
