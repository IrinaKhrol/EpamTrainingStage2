namespace Driver
{
    public abstract class BasePage
    {
        protected WebDriverManager DriverManager;

        protected BasePage(WebDriverManager driverManager)
        {
            DriverManager = driverManager;
        }

        public void SwitchToTab(string title) 
        {
            DriverManager.SwitchToTabWithTitle(title);
        }
    }

}
