using SeleniumExtras.PageObjects;
using Core;

namespace Driver
{
    public abstract class BasePage
    {
        protected WebDriverManager DriverManager;

        protected BasePage(WebDriverManager driverManager)
        {
            DriverManager = driverManager;
            PageFactory.InitElements(DriverManager.Driver, this);
        }

        public void SwitchToTab(string title) 
        {
            DriverManager.SwitchToTabWithTitle(title);
        }
    }

}
