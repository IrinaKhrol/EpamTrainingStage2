using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Driver
{
    public class EstimateSummaryPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = ".OtcLZb.OIcOye")]
        protected IWebElement CostEstimateSummaryLocator;


        public string GetCostEstimateSummary()
        {
            return DriverManager.GetText (CostEstimateSummaryLocator);
        }

        public EstimateSummaryPage(WebDriverManager driverManager) : base(driverManager)
        {
        }
    }
}
