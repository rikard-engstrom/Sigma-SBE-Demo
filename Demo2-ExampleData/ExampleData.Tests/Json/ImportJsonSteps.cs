using CustomerSearch.Tests.Services;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace CustomerSearch.Tests.Json
{
    [Binding,Scope(Feature = "Import Json")]
    class ImportJsonSteps
    {
        private string _json;
        private IEnumerable<string> _importedEmails;

        [When(@"the following json data")]
        public void WhenTheFollowingJsonData(Table table)
        {
            _json = string.Join("\r\n", table.Rows.Select(x => x[0]));
        }

        [When(@"it is imported")]
        public void WhenItIsImported()
        {
            var service = new JsonImportService();
            _importedEmails = service.ImportJson(_json);
        }

        [Then(@"the following email addresses should be stored")]
        public void ThenTheFollowingEmailAddressesShouldBeStored(Table table)
        {
            var expected = table.Rows.Select(x => x[0]);
            CollectionAssert.AreEqual(expected, _importedEmails);
        }
    }
}
