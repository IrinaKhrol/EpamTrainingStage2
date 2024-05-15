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
        public JsonReader jsonReader;


        [SetUp]
        public void Setup()
        {
            driverManager = new WebDriverManager(new ChromeDriver());
            mainpage = new MainPage(driverManager);
            jsonReader = new JsonReader();
        }

        [TestCase("C:\\Users\\Irina\\source\\repos\\EpamTrainingStage2\\UnitTestWebDriver\\TestData1.json")]
        [TestCase("C:\\Users\\Irina\\source\\repos\\EpamTrainingStage2\\UnitTestWebDriver\\TestData2.json")]
        public void ComputeEngineSetup(string jsonFilePath)
        {
            FormData formData = jsonReader.ReadFormData(jsonFilePath);

            mainpage.AddTextToSearchField("Google Cloud Platform Pricing Calculator");
            var searchResult = mainpage.OpenSurchResult();
            var welcomePricingCalcilator = searchResult.ClickPricingCalculatorLink();
            welcomePricingCalcilator.ClickAddToEstimateButton();
            var computeEnginePage = welcomePricingCalcilator.ClickComputeEngineItem();
            computeEnginePage.ClickNumberOfInstances(formData.NumberOfInstances);
            computeEnginePage.PerformCalculation(formData.MachineType, formData.GPUType, formData.LocalSSD);
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