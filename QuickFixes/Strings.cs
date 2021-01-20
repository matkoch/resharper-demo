namespace ReSharperDemo.QuickFixes
{
    public class Strings
    {
        public void Escaping<T> (int i, string str)
        {
            var path = ""; // Paste: C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe

            var format = $"{i}K ought to be enough for {str}.";

            var paragraph =
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.";
        }
    }
}
