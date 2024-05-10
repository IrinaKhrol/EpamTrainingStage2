using Driver;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Chrome;


namespace UnitTestWebDriver
{
    [TestFixture]
    public class CalculatorTests
    {
        public WebDriverManager driverManager;
        public MainPage mainpage;


        [SetUp]
        public void Setup()
        {
            driverManager = new WebDriverManager(new ChromeDriver());
            mainpage = new MainPage(driverManager);
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
            var estimateSummaryPage = computeEnginePage.ClickOpenEstimate();

            estimateSummaryPage.SwitchToTab("Estimate");

            string actualCostEstimate = estimateSummaryPage.GetCostEstimateSummary();

            Assert.That(actualCostEstimate, Is.EqualTo(expectedCost), "The actual cost match the expected value.");
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                var fileName = $"{DateTime.Now:yyyyMMdd-HHmmss}.png";
                string screenshotPath = Path.Combine("..\\..\\..\\Screenshots", fileName);
                driverManager.GetScreenshot().SaveAsFile(screenshotPath);
            }
            driverManager.QuitDriver();
        }
    }
}