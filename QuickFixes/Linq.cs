using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.QuickFixes
{
    public class Linq
    {
        public void A (IEnumerable<string> collection)
        {
            var containsEmptyString = !collection.Any(x => !x.Equals(string.Empty));
        }

        public IEnumerable<string> B (IEnumerable<string> collection)
        {
            foreach (var str in collection)
            {
                if (string.IsNullOrEmpty(str))
                    continue;

                yield return str;
            }
        }
    }
}
