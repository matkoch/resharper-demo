using System.Collections.Generic;

namespace ReSharperDemo.Analysis
{
    public class CognitiveComplexity
    {
        private static IEnumerable<int> Foo(ICollection<int> numbers)
        {
            foreach (int i in numbers)
            {
                foreach (var j in numbers)
                {
                    foreach (var k in numbers)
                    {
                        yield return i * j * k;
                    }
                }
            }
        }
        private static IEnumerable<int> Bar(ICollection<int> numbers)
        {
            foreach (int i in numbers)
            {
            }
            foreach (var j in numbers)
            {
            }
            foreach (var k in numbers)
            {
            }

            yield break;
        }

        private static object M(
            IDictionary<string, object> dictionary,
            string key,
            object defaultValue)
        {
            if (dictionary == null)
                dictionary = new Dictionary<string, object>();

            if (dictionary.TryGetValue(key, out var value))
                return value;
            return defaultValue;
        }
    }
}
