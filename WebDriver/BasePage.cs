using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace Driver
{
    public class BasePage
    {
        protected WebDriverWait wait;
        protected IWebDriver driver;

        public BasePage()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        protected void ClickElement(By locator)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            driver.FindElement(locator).Click();
        }

        protected void EnterText(By locator, string text)
        {
            driver.FindElement(locator).SendKeys(text);
        }

    }
}
