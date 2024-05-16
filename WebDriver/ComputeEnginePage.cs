using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Core;

namespace Driver
{
    public class ComputeEnginePage : BasePage
    {
        #region locators
        [FindsBy(How = How.CssSelector, Using = "div[jsaction='JIbuQc:qGgAE'] button")]
        private IWebElement InstancesField;

        [FindsBy(How = How.XPath, Using = "//div[@jsname='kgDJk']")]
        private IWebElement MachineTypeField;

        [FindsBy(How = How.CssSelector, Using = "ul.VfPpkd-rymPhb")]
        private IWebElement ChooseMachineType;

        [FindsBy(How = How.CssSelector, Using = "[aria-label='Add GPUs']")]
        private IWebElement SelectAddGPUs;

        [FindsBy(How = How.CssSelector, Using = "[data-field-type='158'] .VfPpkd-aPP78e")]
        private IWebElement ClickGPUType;

        [FindsBy(How = How.XPath, Using = "//*[@aria-label='Add GPUs']")]
        private IWebElement ChooseGPUType;

        [FindsBy(How = How.CssSelector, Using = "[data-field-type='180']")]
        private IWebElement ClickLocalSSD;

        [FindsBy(How = How.CssSelector, Using = "[aria-label='Local SSD']")]
        private IWebElement ChooseLocalSSD;

        [FindsBy(How = How.CssSelector, Using = "label.zT2df[for='1-year']")]
        private IWebElement ChooseCommitedUsage;

        [FindsBy(How = How.CssSelector, Using = "span.FOBRw-vQzf8d[jsname='V67aGc']")]
        private IWebElement Share;

        [FindsBy(How = How.CssSelector, Using = "a.tltOzc.MExMre.rP2xkc.jl2ntd[track-name='open estimate summary']")]
        private IWebElement OpenEstimate;

        [FindsBy(How = How.CssSelector, Using = "label.gt0C8e.MyvX5d.D0aEmf")]
        private IWebElement CostLocator;
        #endregion


        public ComputeEnginePage(WebDriverManager driverManager) : base(driverManager)
        {
        }

        public void ClickNumberOfInstances(int count)
        {
            for (int i = 1; i < count; i++)
            {
                DriverManager.ClickElement(InstancesField);
            }
        }

        public void PerformCalculation(string machineType, string gpuType, string localSSD )
        {
            DriverManager.ScrollDown();
            DriverManager.HideCookieNotification();
            DriverManager.ClickElement(MachineTypeField);
            DriverManager.SelectValueInDropdown(ChooseMachineType, machineType);
            DriverManager.ScrollDown();
            DriverManager.HideCookieNotification();
            DriverManager.ClickElement(SelectAddGPUs);
            DriverManager.ClickElement(ClickGPUType);
            DriverManager.SelectValueInDropdown(ChooseGPUType, gpuType);
            DriverManager.ClickElement(ClickLocalSSD);
            DriverManager.SelectInDropdown(ChooseLocalSSD, localSSD);
            DriverManager.ClickElement(ChooseCommitedUsage);
        }

        public void ClickShare()
        {
            DriverManager.HideCookieNotification();
            DriverManager.ClickElement(Share);
        }

        public EstimateSummaryPage ClickOpenEstimate()
        {
            DriverManager.ClickElement(OpenEstimate);
            return new EstimateSummaryPage(DriverManager);
        }

        public string GetCost() 
        {
            DriverManager.RefreshPage();
            return DriverManager.GetText(CostLocator);
        }
    }
}
