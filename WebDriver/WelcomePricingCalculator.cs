using OpenQA.Selenium;

namespace Driver
{
    public class WelcomePricingCalculator : BasePage
    {
        protected By AddToEstimateButton = By.CssSelector("span.UywwFc-vQzf8d[jsname='V67aGc']");

        protected By ComputeEngineItem = By.CssSelector("div[data-service-form='8']");

        public WelcomePricingCalculator(WebDriverManager driverManager) : base(driverManager)
        {
        }

        public void ClickAddToEstimateButton()
        {
            DriverManager.ClickElement(AddToEstimateButton);
        }

        public ComputeEnginePage ClickComputeEngineItem()
        {
            DriverManager.ClickElement(ComputeEngineItem);
            return  new ComputeEnginePage(DriverManager);
        }
    }
}
