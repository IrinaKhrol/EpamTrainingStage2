using Driver;
using OpenQA.Selenium;

namespace UnitTestWebDriver
{
    [TestFixture]
    public class Tests
    {
        public IWebDriver? driver;
        public MainPage mainpage;

        protected string code = " git config --global user.name  \"New Sheriff in Town\"\r\n " +
                             "git reset $(git commit-tree HEAD^{tree} -m \"Legacy code\")\r\n " +
                             "git push origin master --force";

        protected string pasteName = "how to gain dominance among developers";

        [SetUp]
        public void Setup()
        {
            mainpage = new MainPage();
        }


        [Test]
        public void VerifyPasteName()
        {
            mainpage.AddText(code);
            mainpage.SetPasteExpiration();
            mainpage.SetPasteName(pasteName);
            mainpage.ClickSubmitButton();

            string actualText = mainpage.GetPasteName();
            Assert.That(actualText, Is.EqualTo(pasteName), "");
        }

        [Test]
        public void VerifyAddText()
        {

            mainpage.AddText(code);
            mainpage.SetPasteExpiration();
            mainpage.SetPasteName("how to gain dominance among developers");
            mainpage.ClickSubmitButton();
            //Thread.Sleep(1000);
            string actualResult = mainpage.GetCode();

            Assert.That(actualResult, Is.EqualTo(code), "Text in the paste match the expected result");
        }

        [TearDown]
        public void TearDown()
        {
            mainpage.QuitDriver();
        }
    }
}