namespace Driver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mainpage = new MainPage();
            mainpage.AddText("Hello from WebDriver");
            mainpage.SetPasteExpiration();
            mainpage.SetPasteName("helloweb");
            mainpage.CreateNewPaste();
            mainpage.QuitDriver();

        }
    }
}
