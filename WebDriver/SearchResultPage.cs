using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Core;

namespace Driver
{
    public class SearchResultPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "a.gs-title[href*='cloud.google.com/products/calculator']")]
        protected IWebElement PricingCalculator;

        public SearchResultPage(WebDriverManager driverManager) : base(driverManager)
        {
        }

        public WelcomePricingCalculator ClickPricingCalculatorLink()
        {
            DriverManager.ClickElement(PricingCalculator);
            return new WelcomePricingCalculator(DriverManager);
        }
    }
}
