using Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text.RegularExpressions;

namespace UnitTestWebDriver
{
    [TestFixture]
    public class CalculatorTests
    {
        public IWebDriver driver;
        public MainPage mainpage;


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            mainpage = new MainPage(driver);
        }

        [Test]
        public void TestCalculatorPriceAndSummary()
        {
            mainpage.AddTextToSearchField("Google Cloud Platform Pricing Calculator");
            var searchResult = mainpage.OpenSurchResult();
            searchResult.ClickPricingCalculatorLink();
            SearchProductPage searchProductPage = new SearchProductPage(driver);
            searchProductPage.ClickAddToEstimateButton();
            searchProductPage.ClickComputeEngineItem();
            searchProductPage.ClickNumberOfInstances(3);
            searchProductPage.ClickMashineType();
            searchProductPage.ClickChooseMashineType();
            searchProductPage.ClickSelectAddGps();
            searchProductPage.ClickChooseGPUType();
            searchProductPage.AddGPUType();
            searchProductPage.ClickChooseLocalSSD();
            searchProductPage.ClickCommitedUsage();
            searchProductPage.AddLocalSSD();
            searchProductPage.ClickShare();
            searchProductPage.ClickOpenEstimate();

            string actualCostEstimate = searchProductPage.GetCostEstimateSummary();
            string expectedCostEstimate = "$5,413.26";
            string pattern = @"\$\d+(,\d+)*(\.\d+)?";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(actualCostEstimate);
            if (match.Success)
            {
                string costString = match.Value;
                decimal actualCost = decimal.Parse(costString.Replace("$", "").Replace(",", ""));
                decimal expectedCost = decimal.Parse(expectedCostEstimate.Replace("$", "").Replace(",", ""));
                Assert.That(actualCost, Is.EqualTo(expectedCost), "The actual cost matches the expected value.");
            }
            else
            {
                Assert.Fail("Failed to extract cost from the summary.");
            }

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}