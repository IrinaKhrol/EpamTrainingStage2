using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
namespace Driver
{
    public class PricingCalculatorPage : BasePage
    {
        #region locators
        [FindsBy(How = How.XPath, Using = "//input[@ng-model='listingCtrl.computeServer.quantity']")]
        private IWebElement InstancesField;

        [FindsBy(How = How.XPath, Using = "//md-select[@ng-model='listingCtrl.computeServer.series']")]
        private IWebElement SeriesField;

        [FindsBy(How = How.XPath, Using = "//md-select[@ng-model='listingCtrl.computeServer.machineType']")]
        private IWebElement MachineTypeField;

        [FindsBy(How = How.XPath, Using = "//button[@ng-click='listingCtrl.addComputeServer(listingCtrl.computeServer)']")]
        private IWebElement AddToEstimateButton;

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
            PageFactory.InitElements(DriverManager.Driver, this);
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

