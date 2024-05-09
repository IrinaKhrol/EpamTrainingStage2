using Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
            var welcomePricingCalcilator = searchResult.ClickPricingCalculatorLink();
            welcomePricingCalcilator.ClickAddToEstimateButton();
            var computeEnginePage = welcomePricingCalcilator.ClickComputeEngineItem();
            computeEnginePage.ClickNumberOfInstances(3);
            computeEnginePage.ClickMashineType();
            computeEnginePage.ClickChooseMashineType();
            computeEnginePage.ClickSelectAddGps();
            computeEnginePage.ClickChooseGPUType();
            computeEnginePage.AddGPUType();
            computeEnginePage.ClickChooseLocalSSD();
            computeEnginePage.AddLocalSSD();
            computeEnginePage.ClickCommitedUsage();
            Thread.Sleep(1000);
            var expectedCost = computeEnginePage.GetCost();
            computeEnginePage.ClickShare();
            computeEnginePage.ClickOpenEstimate();

            EstimateSummaryPage estimateSummaryPage = new EstimateSummaryPage(driver);
            estimateSummaryPage.SwitchToTabWithTitle("Estimate");

            string actualCostEstimate = estimateSummaryPage.GetCostEstimateSummary();

            Assert.That(actualCostEstimate, Is.EqualTo(expectedCost), "The actual cost match the expected value.");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}