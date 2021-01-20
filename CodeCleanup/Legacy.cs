namespace ReSharperDemo.CodeCleanup
{
    // Code Styles
    // Interactive editor config
    // Code Cleanup
    // Save As ...
    public class Legacy
    {
        private string myKey = "key";

        public void Entry ()
        {
            System.String a = M(myKey, true, 1);
        }

        string M (string key, bool enableSearch, int retryCount)
        {
            return null;
        }
    }
}
