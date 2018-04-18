using Newtonsoft.Json;
using NUnit.Framework;
using System.Collections.Generic;

namespace CustomerSearch.Tests.TestHelpers
{
    static class Asserts
    {
        public static object CollectionAsserts { get; private set; }

        internal static void AreEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual)
        {
            var expectedJson = JsonConvert.SerializeObject(expected);
            var actualJson = JsonConvert.SerializeObject(actual);
            Assert.AreEqual(expectedJson, actualJson);
        }
    }
}
