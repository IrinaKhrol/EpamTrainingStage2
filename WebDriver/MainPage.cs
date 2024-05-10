using OpenQA.Selenium;

namespace Driver
{
    public class MainPage : BasePage
    {
        protected By SearchIcon => By.CssSelector("div.YSM5S");
        protected By SearchField => By.CssSelector("input.mb2a7b");
        protected By PricingCalculatorLink => By.XPath("//a[contains(text(),'Google Cloud Platform Pricing Calculator')]");

        public MainPage(WebDriverManager driverManager) : base(driverManager)
        {
            DriverManager.NavigateToUrl("https://cloud.google.com/");
        }

        public SearchResultPage OpenSurchResult()
        {
            DriverManager.ClickEnter(SearchField);
            return new SearchResultPage(DriverManager);
        }

        public void AddTextToSearchField(string text)
        {
            DriverManager.EnterText(SearchField, text);
        }
    }
}
