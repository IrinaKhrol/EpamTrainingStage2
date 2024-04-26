using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver
{
    public class MainPage : BasePage
    {

        protected By Addtext => By.Id("postform-text");
        public MainPage(): base()
        {
            driver.Url = "https://pastebin.com/";
            driver.Manage().Window.Maximize();
        }

        public void AddText(string text) 
        {
            EnterText(Addtext, text);
        }
    }
}
