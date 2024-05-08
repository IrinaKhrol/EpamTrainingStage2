using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver
{
    public class SearchProductPage : BasePage
    {

        protected By AddToEstimateButton = By.CssSelector("span.UywwFc-vQzf8d[jsname='V67aGc']");

        protected By ComputeEngineItem = By.CssSelector("div[data-service-form='8']");

        protected By NumberOfInstances = By.CssSelector("div[jsaction='JIbuQc:qGgAE'] button");

        protected By MashineType = By.CssSelector("div[jsname=kgDJk]");

        protected By ChooseMashineType = By.XPath("/html/body/c-wiz[1]/div/div/div[1]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[3]/div/div/div/div[2]/ul/li[7]");

        protected By SelectAddGPUs = By.CssSelector("[aria-label='Add GPUs']");

        protected By ClickGPUType = By.CssSelector("[data-field-type='158'] .VfPpkd-aPP78e");

        protected By ChooseGPUType = By.XPath("/html/body/c-wiz[1]/div/div/div[1]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[23]/div/div[1]/div/div/div/div[2]/ul/li[3]");

        protected By ClickLocalSSD = By.XPath("/html/body/c-wiz[1]/div/div/div[1]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[27]/div/div[1]/div/div/div/div[1]/div");

        protected By ChooseLocalSSD = By.XPath("/html/body/c-wiz[1]/div/div/div[1]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[27]/div/div[1]/div/div/div/div[2]/ul/li[3]");

        protected By ChooseCommitedUsage = By.CssSelector("label.zT2df[for='1-year']");

        protected By Share = By.CssSelector("span.FOBRw-vQzf8d[jsname='V67aGc']");

        protected By OpenEstimate = By.CssSelector("a.tltOzc.MExMre.rP2xkc.jl2ntd[track-name='open estimate summary']");

        protected By CostEstimateSummaryLocator = By.XPath("//h6[contains(text(), 'Cost Estimate Summary')]/following-sibling::h6");


        public void ClickAddToEstimateButton()
        {
            ClickElement(AddToEstimateButton);
        }

        public void ClickComputeEngineItem()
        {
            ClickElement(ComputeEngineItem);
        }

        public void ClickNumberOfInstances(int count)
        {

            for (int i = 0; i < count; i++)
            {
                ClickElement(NumberOfInstances);
            }
        }

        public void ClickMashineType()
        {
            ScrollDown();
            HideCookieNotification();
            ClickElement(MashineType);
        }

        public void ClickChooseMashineType()
        {
            ClickElement(ChooseMashineType);
        }

        public void ClickSelectAddGps()
        {
            ScrollDown();
            HideCookieNotification();
            Thread.Sleep(1000);
            ClickElement(SelectAddGPUs);
        }

        public void ClickChooseGPUType()
        {
            ClickElement(ClickGPUType);
        }

        public void AddGPUType()
        {
            ClickElement(ChooseGPUType);
        }

        public void ClickChooseLocalSSD()
        {
            ClickElement(ClickLocalSSD);
        }

        public void AddLocalSSD()
        {
            ClickElement(ChooseLocalSSD);
        }

        public void ClickCommitedUsage()
        {
            ClickElement(ChooseCommitedUsage);
        }

        public void ClickShare()
        {
            ClickElement(Share);
        }

        public void ClickOpenEstimate()
        {
            ClickElement(OpenEstimate);
        }

        public string GetCostEstimateSummary()
        {
            return driver.FindElement(CostEstimateSummaryLocator).Text;
        }



        public SearchProductPage(IWebDriver driver) : base(driver)
        {
        }
    }
}
