using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FinalTest
{
    public class Tests
    {

        IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            
        }

        [Test]
        public void LearnMoreButtonTest()
        {
            _driver.Navigate().GoToUrl("https://www.epam.com/careers");
            var learnMoreButtonLocator = "//*[contains(@href, 'ukraine')]//*[contains(@class, 'desktop')]";
            var learnMorePageUrl = "https://www.epam.com/about/newsroom/press-releases/2022/epam-launches-ukraine-assistance-fund";
            _driver.FindElement(By.XPath(learnMoreButtonLocator)).Click();

            Assert.That(_driver.Url, Is.EqualTo(learnMorePageUrl), $"Page {learnMorePageUrl} should be opened");
        }

        [Test]
        public void SwitchLanguageTest() 
        {
            _driver.Navigate().GoToUrl("https://training.by/ru");
            _driver.FindElement(By.XPath("//*[@class= 'FlexRow-module_root__mHK4u FlexRow-module_size-36__KmXJ6 FlexRow-module_spacing-6__NmXEo locale-switch-lang-raw FlexRow-module_container__TNapY FlexRow-module_align-items-center__QpNAN']")).Click();
            _driver.FindElement(By.XPath("//*[@class= 'styles_locale-switch-dropdown_item__OeQfh'][2]")).Click();

            Assert.That(_driver.Url, Is.EqualTo("https://training.by/ru"), $"Language should be switched to rus");
        }

        [TearDown]
        public void Teardown() 
        {
            _driver.Quit();
        }
    }
}