using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumBasics
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
            var currentOpenedUrl = _driver.Url;

            Assert.That(currentOpenedUrl.Equals(epamMainPage), "Page loaded incorrect");
        }

        [Test]
        public void CheckEpamPageTransitionTest()
        {
            var epamHowWeDoItUrl = "https://www.epam.com/how-we-do-it";
            var epamOurWorkUrl = "https://www.epam.com/our-work";

            _driver.Navigate().GoToUrl(epamHowWeDoItUrl);
            _driver.Navigate().GoToUrl(epamOurWorkUrl);
            _driver.Navigate().Refresh();
            _driver.Navigate().Back();

            var currentOpeedUrl = _driver.Url.ToString();

            Assert.That(currentOpeedUrl.Equals(epamHowWeDoItUrl), "Pages don't matches");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}