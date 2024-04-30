using Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

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
        public void VerifyPageName()
        {
            string expectedAddText = "how to gain dominance among developers";
            mainpage.SetPasteName(expectedAddText);

            string actualText = mainpage.GetPasteName();
            // Сравниваем ожидаемый текст с фактическим
            Assert.AreEqual(expectedAddText, actualText, "Текст не соответствует ожидаемому значению");
        }

        [Test]
        public void VerifyBrowserMatchesUrl()
        {
            string expectedUrl = "https://0bin.net/";

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

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