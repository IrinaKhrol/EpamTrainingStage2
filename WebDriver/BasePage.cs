using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage()
        {
            driver = new ChromeDriver();
        }

        protected void ClickElement(By locator) 
        {
            driver.FindElement(locator).Click();
        }

        protected void EnterText(By locator, string text)
        {
            driver.FindElement(locator).SendKeys(text);
        }
    }

}
