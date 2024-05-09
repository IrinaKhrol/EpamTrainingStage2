using OpenQA.Selenium;

namespace Driver
{
    public class EstimateSummaryPage : BasePage
    {

        protected By CostEstimateSummaryLocator = By.CssSelector(".OtcLZb.OIcOye");

        public string GetCostEstimateSummary()
        {
            return driver.FindElement(CostEstimateSummaryLocator).Text;
        }

        public EstimateSummaryPage(IWebDriver driver) : base(driver)
        {
        }
    }
}
