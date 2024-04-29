using OpenQA.Selenium;

namespace Driver
{
    public class MainPage : BasePage
    {
        protected By AcceptPrivacy => By.CssSelector("button[mode='primary']");
        protected By Addtext => By.CssSelector(".textarea.-form.js-paste-code");
        protected By AddName => By.Id("postform-name");
        protected By PasteExpirationDropdown => By.Id("select2-postform-expiration-container");
        protected By PasteExpirationOption => By.CssSelector(".select2-results__option[id*='10M']");
        protected By CreateNewPasteButton => By.CssSelector("button[type='submit']");

        public MainPage() : base()
        {
            driver.Url = "https://pastebin.com/";
            driver.Manage().Window.Maximize();
            ClickAcceptPrivacy();
        }

        private void ClickAcceptPrivacy()
        {
            ClickElement(AcceptPrivacy);
        }
        public void AddText(string text)
        {
            EnterText(Addtext, text);
        }

        public void SetPasteExpiration()
        {
            ClickElement(PasteExpirationDropdown);
            ClickElement(PasteExpirationOption);
        }

        public void SetPasteName(string name)
        {
            EnterText(AddName, name);
        }

        public void CreateNewPaste()
        {
            ClickElement(CreateNewPasteButton);
        }

        public void QuitDriver()
        {
            driver.Quit();
        }
    }
}
