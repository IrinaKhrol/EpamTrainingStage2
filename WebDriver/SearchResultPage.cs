using OpenQA.Selenium;

namespace Driver
{
    public class SearchResultPage : BasePage
    {
        protected By PricingCalculator = By.CssSelector("a.gs-title[href*='cloud.google.com/products/calculator']");
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
