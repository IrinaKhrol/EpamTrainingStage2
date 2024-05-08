
using OpenQA.Selenium.Chrome;

namespace Driver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mainpage = new MainPage(new ChromeDriver());
            mainpage.AddTextToSearchField("Google Cloud Platform Pricing Calculator");
            var searchResult = mainpage.OpenSurchResult();
            searchResult.ClickPricingCalculatorLink();
            //mainpage.ClickAddToEstimateButton();
            //mainpage.ClickComputeEngineItem();
            //mainpage.ClickNumberOfInstances(3);
            //mainpage.ClickMashineType();
           // mainpage.ClickChooseMashineType();
           // mainpage.ClickSelectAddGps();
            //mainpage.ClickChooseGPUType();
            //mainpage.AddGPUType();
            //mainpage.ClickChooseLocalSSD();
            //mainpage.ClickCommitedUsage();
            //mainpage.AddLocalSSD();
           // mainpage.ClickShare();
            //mainpage.ClickOpenEstimate();
            //mainpage.QuitDriver();

        }
    }
}
