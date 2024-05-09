using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Driver
{
    public class BasePage
    {
        protected WebDriverWait wait;
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
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

        protected void ClickEnter(By locator)
        {
            driver.FindElement(locator).SendKeys(Keys.Enter);
        }

        protected void ScrollDown()
        {
            new Actions(driver).SendKeys(Keys.PageDown).Build().Perform();
        }

        protected void HideCookieNotification()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementsByClassName('glue-cookie-notification-bar')[0].style.display = 'none';");
        }

        public void SwitchToTabWithTitle(string title)
        {
            List<string> windowHandles = new List<string>(driver.WindowHandles);

            foreach (string handle in windowHandles)
            {
                driver.SwitchTo().Window(handle);
                if (driver.Title.Contains(title))
                {
                    return;
                }
            }

            throw new NotFoundException($"Tab with title '{title}' was not found.");
        }
    }
}
