
namespace Driver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mainpage = new MainPage();
            mainpage.AddText(" git config --global user.name  \"New Sheriff in Town\"\r\n " +
                             "git reset $(git commit-tree HEAD^{tree} -m \"Legacy code\")\r\n " +
                             "git push origin master --force\r\n");
            mainpage.SetPasteExpiration();
            mainpage.SetPasteName("how to gain dominance among developers");
            mainpage.ClickSubmitButton();
            mainpage.QuitDriver();
        }
    }
}
