using OpenQA.Selenium;

namespace Driver
{
    public class EstimateSummaryPage : BasePage
    {

        protected By CostEstimateSummaryLocator = By.CssSelector(".OtcLZb.OIcOye");

        public string GetCostEstimateSummary()
        {
            return DriverManager.GetText (CostEstimateSummaryLocator);
        }

        public EstimateSummaryPage(WebDriverManager driverManager) : base(driverManager)
        {
        }
    }
}
