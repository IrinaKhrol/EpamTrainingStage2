using OpenQA.Selenium;

namespace Driver
{
    public class SearchResultPage : BasePage
    {
        protected By PricingCalculator = By.CssSelector("a.gs-title[href*='cloud.google.com/products/calculator']");

        public WelcomePricingCalculator ClickPricingCalculatorLink()
        {
            ClickElement(PricingCalculator);
            return new WelcomePricingCalculator(driver);
        }

        public SearchResultPage(IWebDriver driver) : base(driver)
        {
        }
    }
}
