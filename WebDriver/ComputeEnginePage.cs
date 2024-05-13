﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Driver
{
    public class ComputeEnginePage : BasePage
    {
        #region locators
        [FindsBy(How = How.CssSelector, Using = "div[jsaction='JIbuQc:qGgAE'] button")]
        private IWebElement InstancesField;

        [FindsBy(How = How.CssSelector, Using = "div[jsname=kgDJk]")]
        private IWebElement MachineTypeField;

        [FindsBy(How = How.XPath, Using = "/html/body/c-wiz[1]/div/div/div[1]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[3]/div/div/div/div[2]/ul/li[7]")]
        private IWebElement ChooseMachineType;

        [FindsBy(How = How.CssSelector, Using = "[aria-label='Add GPUs']")]
        private IWebElement SelectAddGPUs;

        [FindsBy(How = How.CssSelector, Using = "[data-field-type='158'] .VfPpkd-aPP78e")]
        private IWebElement ClickGPUType;

        [FindsBy(How = How.XPath, Using = "/html/body/c-wiz[1]/div/div/div[1]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[23]/div/div[1]/div/div/div/div[2]/ul/li[3]")]
        private IWebElement ChooseGPUType;

        [FindsBy(How = How.CssSelector, Using = "[data-field-type='180']")]
        private IWebElement ClickLocalSSD;

        [FindsBy(How = How.XPath, Using = "/html/body/c-wiz[1]/div/div/div[1]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[27]/div/div[1]/div/div/div/div[2]/ul/li[3]")]
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
            PageFactory.InitElements(DriverManager.Driver, this);
        }

        public void ClickNumberOfInstances(int count)
        {
            for (int i = 0; i < count; i++)
            {
                DriverManager.ClickElement(InstancesField);
            }
        }

        public void PerformCalculation()
        {
            DriverManager.ScrollDown();
            DriverManager.HideCookieNotification();
            DriverManager.ClickElement(MachineTypeField);
            DriverManager.ClickElement(ChooseMachineType);
            DriverManager.ScrollDown();
            DriverManager.HideCookieNotification();
            DriverManager.ClickElement(SelectAddGPUs);
            DriverManager.ClickElement(ClickGPUType);
            DriverManager.ClickElement(ChooseGPUType);
            DriverManager.ClickElement(ClickLocalSSD);
            DriverManager.ClickElement(ChooseLocalSSD);
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
