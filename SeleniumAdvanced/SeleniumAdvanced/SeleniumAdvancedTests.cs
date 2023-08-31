using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAdvanced
{
    public class SeleniumAdvancedTests
    {
        private Actions _action;
        private IWebDriver _driver;
        private IJavaScriptExecutor? _js;
        private WebDriverWait _waiter;

        [SetUp, Order(1)]
        public void SetupBrowser()
        {
            _driver = new ChromeDriver();
            _action = new Actions(_driver);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://www.epam.com/");

            _js = _driver as IJavaScriptExecutor;
        }

        [SetUp, Order(2)]
        public void SetupWaiter()
        {
            var timeout = TimeSpan.FromSeconds(5);
            var pollingInterval = TimeSpan.FromMilliseconds(250);

            _waiter = new WebDriverWait(_driver, timeout)
            {
                PollingInterval = pollingInterval
            };

            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
        }
            
            [Test]
        public void CheckJoinOutTeemButtonOnCareersDropDownOnHeader()
        {
            var expectedPage = "https://www.epam.com/careers/job-listings";
            var careersButtonOnMainPageUrl = _driver.FindElement(By.XPath("//*[contains(@class, 'item-link') and @href = '/careers']")); 
            var joinOurTeamOnDropDownCareersUrl = _driver.FindElement(By.XPath("//a[contains(@class, 'top') and contains(@href, 'job')]"));

            _action.MoveToElement(careersButtonOnMainPageUrl).MoveToElement(joinOurTeamOnDropDownCareersUrl).Click().Build().Perform();
            var actualPage = _driver.Url;

            Assert.That(actualPage, Is.EqualTo(expectedPage), "Loaded incorrect page");
        }

        [Test]
        public void CheckListOfLanguageDropDownOnHeader()
        {
            List<string> expectedLocalizations = new() { "Global (English)", "Hungary (English)", "СНГ (Русский)", "Česká Republika (Čeština)", "India (English)", "Україна (Українська)", "Czech Republic (English)", "日本 (日本語)", "中国 (中文)", "DACH (Deutsch)", "Polska (Polski)" };
            var languageDropdonButtonLocator = "//*[@class = 'location-selector__button']";
            var listOfLocalizationsLocator = "//*[@class = 'location-selector__item']";

            var languageDropdonButtonElement = _driver.FindElement(By.XPath(languageDropdonButtonLocator));
            _waiter.Until(d => languageDropdonButtonElement.Displayed);
            languageDropdonButtonElement.Click();
            var ListOfLocalizations = _driver.FindElements(By.XPath(listOfLocalizationsLocator));
            var actualLocalizations = ListOfLocalizations.Select(a => a.GetDomProperty("innerText").ToList());

            Assert.That(actualLocalizations, Is.EqualTo(expectedLocalizations), "Localizations are not equal");
        }

        [TestCase("Automation", "20")]
        public void CheckQuantityOfSearchResults(string searchQuery, string ExpectedQuantityOfArticles)
        {

            var headerSearchButtonLocator = "//span [contains(@class, 'search-icon')]";
            var searchFieldLocator = "//*[@id = 'new_form_search']";
            var findResultsButtonLocator = "//span [contains (@class, 'bth')]";
            var veiwMoreButtonLocator = "//span [contains (@class,  'more')]";
            var listOfSearchResultsLocator = "//*[@class = 'search-results__items']";
            var tenthSearchResultLocator = "//article [10]";

            _js.ExecuteScript("arguments[0].click()", _driver.FindElement(By.XPath(headerSearchButtonLocator)));
            _driver.FindElement(By.XPath(searchFieldLocator)).SendKeys(searchQuery);
            _driver.FindElement(By.XPath(findResultsButtonLocator)).Click();

            _action.ScrollToElement(_driver.FindElement(By.XPath(tenthSearchResultLocator))).ScrollToElement(_driver.FindElement(By.XPath(veiwMoreButtonLocator))).Build().Perform();

            var actualQuantityOfArticles = _driver.FindElement(By.XPath(listOfSearchResultsLocator)).GetDomProperty("childElementCount");

            Assert.That(actualQuantityOfArticles, Is.EqualTo(ExpectedQuantityOfArticles), "The quantity of articles is not equal");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}