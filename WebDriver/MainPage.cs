using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Xml.Linq;

namespace Driver
{
    public class MainPage : BasePage
    {
        protected By SearchIcon => By.CssSelector("div.YSM5S");
        protected By SearchField => By.CssSelector("input.mb2a7b");
        protected By PricingCalculatorLink => By.XPath("//a[contains(text(),'Google Cloud Platform Pricing Calculator')]");

        protected By PricingCalculator = By.CssSelector("a.gs-title[href*='cloud.google.com/products/calculator']");

        protected By AddToEstimateButton = By.CssSelector("span.UywwFc-vQzf8d[jsname='V67aGc']");

        protected By ComputeEngineItem = By.CssSelector("div[data-service-form='8']");

        protected By NumberOfInstances = By.CssSelector("div[jsaction='JIbuQc:qGgAE'] button");

        protected By MashineType = By.CssSelector("div[jsname=kgDJk]");

        public MainPage(IWebDriver driver) : base(driver)
        {
            driver.Url = "https://cloud.google.com/";
            driver.Manage().Window.Maximize();
        }

        public SearchResultPage AddTextToSearchField(string text)
        {
            EnterText(SearchField, text);
            return new SearchResultPage(driver);
        }

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
            //IWebElement element = driver.FindElement(MashineType);
            //Actions actions = new Actions(driver);
            //actions.MoveToElement(element);
            // actions.Perform();
            ScrollDown();
            ClickElement(MashineType);
        }
        public void QuitDriver()
        {
            driver.Quit();
        }
    }
}
