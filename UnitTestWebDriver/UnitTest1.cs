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
        public void VerifyPageName()
        {
            string expectedAddText = "how to gain dominance among developers";
            mainpage.SetPasteName(expectedAddText);

            string actualText = mainpage.GetPasteName();
            Assert.That(actualText, Is.EqualTo(expectedAddText), "");
        }

        [Test]
        public void VerifyAddText()
        {
            string expectedResult = " git config --global user.name  \"New Sheriff in Town\"\r\n " +
                                    "git reset $(git commit-tree HEAD^{tree} -m \"Legacy code\")\r\n " +
                                    "git push origin master --force\r\n";
            mainpage.AddText(expectedResult);
            mainpage.SetPasteExpiration();
            mainpage.SetPasteName("how to gain dominance among developers");
            mainpage.ClickSubmitButton();

            string actualResult = mainpage.GetCode();

            Assert.That(actualResult, Is.EqualTo(expectedResult), "Text in the paste does not match the expected result");
        }

        [TearDown]
        public void TearDown()
        {
            mainpage.QuitDriver();
        }
    }
}