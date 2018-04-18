using CustomerSearch.Tests.Services;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace CustomerSearch.Tests.Xml
{
    [Binding, Scope(Feature = "Import Xml")]
    class ImportXmlSteps
    {
        private string _xml;
        private IEnumerable<string> _importedEmails;

        [When(@"the following xml data")]
        public void WhenTheFollowingXmlData(Table table)
        {
            _xml = string.Join("\r\n", table.Rows.Select(x => x[0]));
        }

        [When(@"it is imported")]
        public void WhenItIsImported()
        {
            _importedEmails = new XmlImportService().Import(_xml);
        }

        [Then(@"the following email addresses should be stored")]
        public void ThenTheFollowingEmailAddressesShouldBeStored(Table table)
        {
            var expected = table.Rows.Select(x => x[0]);
            CollectionAssert.AreEqual(expected, _importedEmails);
        }
    }
}
