using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Demo.Annotations
{
  public class Nullability
  {
    public void Entry()
    {
    }

    private void OperateOnNonNull([NotNull] string key)
    {
    }

    [NotNull]
    //[CanBeNull]
    private object GetOrCreate()
    {
      //return null;
      return new object ();
    }

    [ItemCanBeNull]
    private Task<object> GetOrCreateAsync()
    {
      return Task.Run(() => new object());
    }

    [ItemCanBeNull]
    private IEnumerable<string> GetStrings()
    {
      yield break;
    }

    [ContractAnnotation("null => null; notnull => notnull")]
    private string Transform(string a)
    {
      return a;
    }
  }
}