using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
namespace Driver
{
    public class PricingCalculatorPage : BasePage
    {
        #region locators
        [FindsBy(How = How.XPath, Using = "//input[@ng-model='listingCtrl.computeServer.quantity']")]
        public IWebElement InstancesField;

        [FindsBy(How = How.XPath, Using = "//md-select[@ng-model='listingCtrl.computeServer.series']")]
        public IWebElement SeriesField;

        [FindsBy(How = How.XPath, Using = "//md-select[@ng-model='listingCtrl.computeServer.machineType']")]
        public IWebElement MachineTypeField;

        [FindsBy(How = How.XPath, Using = "//button[@ng-click='listingCtrl.addComputeServer(listingCtrl.computeServer)']")]
        public IWebElement AddToEstimateButton;

        [FindsBy(How = How.XPath, Using = "//md-select[@ng-model='listingCtrl.computeServer.gpuType']")]
        public IWebElement GPUTypeField;

        [FindsBy(How = How.XPath, Using = "//md-select[@ng-model='listingCtrl.computeServer.localSsd']")]
        public IWebElement LocalSSDField;

        [FindsBy(How = How.XPath, Using = "//md-select[@ng-model='listingCtrl.computeServer.commitmentTerm']")]
        public IWebElement CommitedUsageField;

        [FindsBy(How = How.XPath, Using = "//form[@name='emailForm']")]
        public IWebElement ShareField;

        [FindsBy(How = How.XPath, Using = "//button[@ng-click='listingCtrl.openEmailForm()']")]
        public IWebElement OpenEstimateField;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-list-item-text ng-binding']")]
        public IWebElement CostLocator;
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
            //driver.SwitchTo().Alert().Accept();
            return new EstimateSummaryPage(DriverManager);
        }
    }
}

