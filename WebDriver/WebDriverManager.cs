using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Driver
{
    public class WebDriverManager
    {
        private readonly WebDriverWait wait;
        private readonly IWebDriver driver;

        public WebDriverManager(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }

        public void ClickElement(By locator)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            driver.FindElement(locator).Click();
        }

        public void EnterText(By locator, string text)
        {
            driver.FindElement(locator).SendKeys(text);
        }

        public void ClickEnter(By locator)
        {
            driver.FindElement(locator).SendKeys(Keys.Enter);
        }

        public void ScrollDown()
        {
            new Actions(driver).SendKeys(Keys.PageDown).Build().Perform();
        }

        public void HideCookieNotification()
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

        public string GetText(By locator)
        {
            return driver.FindElement(locator).Text;
        }

        public Screenshot GetScreenshot()
        {
            if (driver is ITakesScreenshot takesScreenshot)
            {
                return takesScreenshot.GetScreenshot();
            }
            else
            {
                throw new NotSupportedException("This WebDriver instance does not support taking screenshots.");
            }
        }

        public void QuitDriver()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}


