using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NunitTestPilot
{
    public class EpamPageTests
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void CheckEpamMainPageTest()
        {
            var epamMainPage = "https://www.epam.com/";

            _driver.Navigate().GoToUrl(epamMainPage);
            var currentOpenedUrl = _driver.Url.ToString();

            Assert.That(currentOpenedUrl.Equals(epamMainPage));
        }

        [Test]
        public void CheckEpamPageTransitionTest()
        {
            var epamHowWeDoItPage = "https://www.epam.com/how-we-do-it";
            var epamOurWorkPage = "https://www.epam.com/our-work";

            _driver.Navigate().GoToUrl(epamHowWeDoItPage);
            _driver.Navigate().GoToUrl(epamOurWorkPage);
            _driver.Navigate().Refresh();
            _driver.Navigate().Back();

            var currentOpeedUrl = _driver.Url.ToString();

            Assert.That(currentOpeedUrl.Equals(epamHowWeDoItPage));
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}