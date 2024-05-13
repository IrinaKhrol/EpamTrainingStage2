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
        public IWebDriver Driver {get;}

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

        public void ClickElement(IWebElement element)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            element.Click();
        }

        public void EnterText(IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public void ClickEnter(IWebElement element)
        {
            element.SendKeys(Keys.Enter);
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

        public string GetText(IWebElement element)
        {
            return element.Text;
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


