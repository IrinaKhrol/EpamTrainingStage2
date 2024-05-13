using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Driver
{
    public class MainPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "div.YSM5S")]
        protected IWebElement SearchIcon;

        [FindsBy(How = How.CssSelector, Using = "input[type='text'][aria-label='Search']")]
        protected IWebElement SearchField;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Google Cloud Platform Pricing Calculator')]")]
        protected IWebElement PricingCalculatorLink;


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
