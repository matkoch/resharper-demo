using System.Linq;

namespace ReSharperDemo.Intentions
{
    public class Simplification
    {
        public int M(string text)
        {
            if (!text.Any(x => !char.IsLetter(x)))
                return 1;
            return 0;
        }
    }
}
