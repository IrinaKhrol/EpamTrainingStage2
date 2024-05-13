using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Driver
{
    public class WelcomePricingCalculator : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "span.UywwFc-vQzf8d[jsname='V67aGc']")]
        protected IWebElement AddToEstimateButton;

        [FindsBy(How = How.CssSelector, Using = "div[data-service-form='8']")]
        protected IWebElement ComputeEngineItem;


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
