using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Demo.Navigation.Test
{
  public static class PrivateInvoke
  {
    public static void Invoke (this object obj, string memberName, params object[] arguments)
    {
      GetMethod(obj, memberName).Invoke(obj, arguments);
    }

    public static T Invoke<T> (this object obj, string memberName, params object[] arguments)
    {
      return (T) GetMethod(obj, memberName).Invoke(obj, arguments);
    }

    private static MethodInfo GetMethod (object obj, string memberName)
    {
      var type = obj.GetType();
      var method = type.GetMethod(memberName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
      Trace.Assert(method != null, "method != null");
      return method;
    }
  }
}