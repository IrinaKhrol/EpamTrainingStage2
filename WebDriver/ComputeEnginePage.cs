using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Driver
{
    public class ComputeEnginePage : BasePage
    {
        #region locators
        [FindsBy(How = How.CssSelector, Using = "div[jsaction='JIbuQc:qGgAE'] button")]
        public IWebElement InstancesField;

        [FindsBy(How = How.CssSelector, Using = "div[jsname=kgDJk]")]
        public IWebElement MachineTypeField;

        [FindsBy(How = How.XPath, Using = "/html/body/c-wiz[1]/div/div/div[1]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[3]/div/div/div/div[2]/ul/li[7]")]
        public IWebElement ChooseMachineType;

        [FindsBy(How = How.CssSelector, Using = "[aria-label='Add GPUs']")]
        public IWebElement SelectAddGPUs;

        [FindsBy(How = How.CssSelector, Using = "[data-field-type='158'] .VfPpkd-aPP78e")]
        public IWebElement ClickGPUType;

        [FindsBy(How = How.XPath, Using = "/html/body/c-wiz[1]/div/div/div[1]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[23]/div/div[1]/div/div/div/div[2]/ul/li[3]")]
        public IWebElement ChooseGPUType;

        [FindsBy(How = How.XPath, Using = "/html/body/c-wiz[1]/div/div/div[1]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[27]/div/div[1]/div/div/div/div[1]/div")]
        public IWebElement ClickLocalSSD;

        [FindsBy(How = How.XPath, Using = "/html/body/c-wiz[1]/div/div/div[1]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[27]/div/div[1]/div/div/div/div[2]/ul/li[3]")]
        public IWebElement ChooseLocalSSD;

        [FindsBy(How = How.CssSelector, Using = "label.zT2df[for='1-year']")]
        public IWebElement ChooseCommitedUsage;

        [FindsBy(How = How.CssSelector, Using = "span.FOBRw-vQzf8d[jsname='V67aGc']")]
        public IWebElement Share;

        [FindsBy(How = How.CssSelector, Using = "a.tltOzc.MExMre.rP2xkc.jl2ntd[track-name='open estimate summary']")]
        public IWebElement OpenEstimate;

        [FindsBy(How = How.CssSelector, Using = "label.gt0C8e.MyvX5d.D0aEmf")]
        public IWebElement CostLocator;
        #endregion


        public ComputeEnginePage(WebDriverManager driverManager) : base(driverManager)
        {
            PageFactory.InitElements(DriverManager.Driver, this);
        }

        public void ClickNumberOfInstances(int count)
        {
            for (int i = 0; i < count; i++)
            {
                DriverManager.ClickElement(InstancesField);
            }
        }

        public void ClickMashineType()
        {
            DriverManager.ScrollDown();
            DriverManager.HideCookieNotification();
            DriverManager.ClickElement(MachineTypeField);
        }

        public void ClickChooseMashineType()
        {
            DriverManager.ClickElement(ChooseMachineType);
        }

        public void ClickSelectAddGps()
        {
            DriverManager.ScrollDown();
            DriverManager.HideCookieNotification();
            Thread.Sleep(1000);
            DriverManager.ClickElement(SelectAddGPUs);
        }

        public void ClickChooseGPUType()
        {
            DriverManager.ClickElement(ClickGPUType);
        }

        public void AddGPUType()
        {
            DriverManager.ClickElement(ChooseGPUType);
        }

        public void ClickChooseLocalSSD()
        {
            DriverManager.ClickElement(ClickLocalSSD);
        }

        public void AddLocalSSD()
        {
            DriverManager.ClickElement(ChooseLocalSSD);
        }

        public void ClickCommitedUsage()
        {
            DriverManager.ClickElement(ChooseCommitedUsage);
        }

        public void ClickShare()
        {
            DriverManager.ClickElement(Share);
        }

        public EstimateSummaryPage ClickOpenEstimate()
        {
            DriverManager.ClickElement(OpenEstimate);
            return new EstimateSummaryPage(DriverManager);
        }

        public string GetCost() 
        {
            return DriverManager.GetText(CostLocator);
        }
    }
}
