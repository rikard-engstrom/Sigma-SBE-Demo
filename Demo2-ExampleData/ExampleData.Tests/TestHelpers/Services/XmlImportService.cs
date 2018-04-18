using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace CustomerSearch.Tests.Services
{
    internal class XmlImportService
    {
        internal IEnumerable<string> Import(string xml)
        {
            var doc = XDocument.Parse(xml);
            return doc.Descendants("Emails").Elements().Select(x => x.Value);
        }
    }
}
