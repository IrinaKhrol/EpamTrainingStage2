using Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestWebDriver
{
    [TestFixture]
    public class Tests
    {
        public IWebDriver driver;
        public MainPage mainpage;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            mainpage = new MainPage();
        }

        [Test]
        public void VerifyPageTitleMatchesPasteName()
        {
            string expectedTitle = "";
            mainpage.SetPasteName(expectedTitle);

            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo(expectedTitle), "Page title does not match the paste name");
        }

        [Test]
        public void VerifyBrowserMatches()
        {
            string expectedUrl = "data:,";

            string actualUrl = driver.Url;

            Assert.That(actualUrl, Is.EqualTo(expectedUrl), "Browser does not match expected URL");
        }

        [TearDown]
        public void TearDown()
        {
            mainpage.QuitDriver();
        }
    }
}