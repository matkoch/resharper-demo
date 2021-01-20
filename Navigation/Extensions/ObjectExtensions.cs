using System.Diagnostics;
using JetBrains.Annotations;

namespace ReSharperDemo.Navigation.Extensions
{
    public static class ObjectExtensions
    {
        [AssertionMethod]
        public static T NotNull<T> (
            [AssertionCondition(AssertionConditionType.IS_NOT_NULL)] this T obj,
            string condition = null)
            where T : class
        {
            Trace.Assert(obj != null, condition ?? "obj != null");
            return obj;
        }
    }
}
