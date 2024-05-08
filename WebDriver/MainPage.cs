using OpenQA.Selenium;

namespace Driver
{
    public class MainPage : BasePage
    {
        protected By SearchIcon => By.CssSelector("div.YSM5S");
        protected By SearchField => By.CssSelector("input.mb2a7b");
        protected By PricingCalculatorLink => By.XPath("//a[contains(text(),'Google Cloud Platform Pricing Calculator')]");

        public MainPage(IWebDriver driver) : base(driver)
        {
            driver.Url = "https://cloud.google.com/";
            driver.Manage().Window.Maximize();
        }

        public SearchResultPage OpenSurchResult()
        {
            ClickEnter(SearchField);
            return new SearchResultPage(driver);
        }

        public void AddTextToSearchField(string text)
        {
            EnterText(SearchField, text);
        }
        public void QuitDriver()
        {
            driver.Quit();
        }
    }
}
