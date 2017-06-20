using System;
using System.Linq;
using JetBrains.Annotations;

namespace Demo.Annotations
{
    public class StringFormatter
    {
        public void M ()
        {
            Format("{0}{1}", "oisjdfo");
        }

        [StringFormatMethod("format")]
        private string Format (string format, params object[] args)
        {
            return null;
        }
    }
}
