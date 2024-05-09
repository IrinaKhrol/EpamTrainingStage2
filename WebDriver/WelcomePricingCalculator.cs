using OpenQA.Selenium;

namespace Driver
{
    public class WelcomePricingCalculator : BasePage
    {
        protected By AddToEstimateButton = By.CssSelector("span.UywwFc-vQzf8d[jsname='V67aGc']");

        protected By ComputeEngineItem = By.CssSelector("div[data-service-form='8']");

        public WelcomePricingCalculator(IWebDriver driver) : base(driver)
        {
        }

        public void ClickAddToEstimateButton()
        {
            ClickElement(AddToEstimateButton);
        }

        public ComputeEnginePage ClickComputeEngineItem()
        {
            ClickElement(ComputeEngineItem);
            return  new ComputeEnginePage(driver);
        }
    }
}
