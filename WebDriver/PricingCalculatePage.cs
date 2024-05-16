using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using Core;

namespace Driver
{
    public class PricingCalculatorPage : BasePage
    {
        #region locators
        [FindsBy(How = How.XPath, Using = "//md-select[@ng-model='listingCtrl.computeServer.gpuType']")]
        private IWebElement GPUTypeField;

        [FindsBy(How = How.XPath, Using = "//md-select[@ng-model='listingCtrl.computeServer.localSsd']")]
        private IWebElement LocalSSDField;

        [FindsBy(How = How.XPath, Using = "//md-select[@ng-model='listingCtrl.computeServer.commitmentTerm']")]
        private IWebElement CommitedUsageField;

        [FindsBy(How = How.XPath, Using = "//form[@name='emailForm']")]
        private IWebElement ShareField;

        [FindsBy(How = How.XPath, Using = "//button[@ng-click='listingCtrl.openEmailForm()']")]
        private IWebElement OpenEstimateField;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-list-item-text ng-binding']")]
        private IWebElement CostLocator;
        #endregion

        public PricingCalculatorPage(WebDriverManager DriverManager) : base(DriverManager)
        {
        }

        public void ClickChooseGPUType()
        {
            DriverManager.ClickElement(GPUTypeField);
        }

        public void AddGPUType()
        {
            DriverManager.ClickElement(GPUTypeField);
        }

        public void ClickChooseLocalSSD()
        {
            DriverManager.ClickElement(LocalSSDField);
        }

        public void AddLocalSSD()
        {
            DriverManager.ClickElement(LocalSSDField);
        }

        public void ClickCommitedUsage()
        {
            DriverManager.ClickElement(CommitedUsageField);
        }

        public void ClickShare()
        {
            DriverManager.ClickElement(ShareField);
        }

        public void ClickOpenEstimate()
        {
            DriverManager.ClickElement(OpenEstimateField);
        }

        public string GetCost()
        {
            return CostLocator.Text;
        }

        public EstimateSummaryPage ReturnToEstimate()
        {
            ClickOpenEstimate();
            return new EstimateSummaryPage(DriverManager);
        }
    }
}

