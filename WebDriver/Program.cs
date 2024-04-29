
using OpenQA.Selenium.Chrome;

namespace Driver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mainpage = new MainPage(new ChromeDriver());
            var searchResult = mainpage.AddTextToSearchField("Google Cloud Platform Pricing Calculator");
            searchResult.ClickPricingCalculatorLink();
            mainpage.ClickAddToEstimateButton();
            mainpage.ClickComputeEngineItem();
            mainpage.ClickNumberOfInstances(3);
            mainpage.ClickMashineType();
            //mainpage.QuitDriver();

        }
    }
}
