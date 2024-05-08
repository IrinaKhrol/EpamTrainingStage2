using OpenQA.Selenium;

namespace Driver
{
    public class SearchResultPage : BasePage
    {
        protected By PricingCalculator = By.CssSelector("a.gs-title[href*='cloud.google.com/products/calculator']");

        public void ClickPricingCalculatorLink()
        {
            ClickElement(PricingCalculator);
        }

        public SearchResultPage(IWebDriver driver) : base(driver)
        {
        }
    }
}
