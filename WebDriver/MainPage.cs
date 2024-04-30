using OpenQA.Selenium;

namespace Driver
{
    public class MainPage : BasePage
    {
        protected By Addtext => By.Id("content");
        protected By ExpirationOption => By.CssSelector("#expiration option[value='never']");
        protected By AddName => By.CssSelector("input[name='paste-excerpt']");

        protected By SubmitButton = By.XPath("//*[@id=\"main\"]/form/div[1]/div[2]/div/div/button");

        public MainPage() : base()
        {
            driver.Url = "https://0bin.net/";
            driver.Manage().Window.Maximize();
        }

        public void AddText(string text)
        {
            EnterText(Addtext, text);
        }

        public void SetPasteExpiration()
        {
            ClickElement(ExpirationOption);
        }

        public void SetPasteName(string name)
        {
            EnterText(AddName, name);
        }

        public string GetPasteName()
        {

            string text = element.GetAttribute("value");

            // Возвращаем полученный текст
            return text;
        }

        public void ClickButton()
        {
            ClickElement(SubmitButton);
        }

        public void QuitDriver()
        {
            driver.Quit();
        }
    }
}
