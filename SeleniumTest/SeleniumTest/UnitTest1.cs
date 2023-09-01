using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;

namespace SeleniumTest
{
    public class Tests
    {
        private Actions _action;
        private IWebDriver _driver;
        private const string _headerElementLocator = "//*[contains (@class, 'desktop-logo')]//descendant::*[contains (@class, 'header__logo-light')]";
        private const string _CareersButtonLocator = "//*[contains(@class, 'item-link') and @href = '/careers']";

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _action = new Actions(_driver);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://www.epam.com/");
        }

        [Test]
        public void CheckMainPageHeaderElement()
        {
            var headerElement = _driver.FindElement(By.XPath(_headerElementLocator));

            Assert.True(headerElement.Displayed, "Header element is not presented");
        }

        [Test]
        public void CheckApplyButtonOnHiringLocationsPage()
        {
            var headerElement = _driver.FindElement(By.XPath(_CareersButtonLocator));
        



            //Assert.;
        }

    }
}