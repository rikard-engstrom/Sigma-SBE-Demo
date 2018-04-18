using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace CustomerSearch.Tests.Services
{
    internal class JsonImportService
    {
        internal IEnumerable<string> ImportJson(string json)
        {
            var o = JObject.Parse(json);
            return o["Emails"].Values<string>();
        }
    }
}
