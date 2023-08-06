using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Collections.Specialized;

namespace Selenium_Basics.Selenium_Basics_2
{
    public class EpamPageInteractionTests
    {
        private Actions _action;
        private IWebDriver _driver;
        private const string _searchIconButtonLocator = "//span [contains(@class, 'search-icon')]";
        private const string _searchFormFieldLocator = "//*[@id = 'new_form_search']";
        private const string _findButtonLocator = "//span [contains (@class, 'bth')]";


        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _action = new Actions(_driver);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://www.epam.com/");
        }

        [Test]
        public void CheckAvailableCountriesIsPresentOnJobListingsPage()
        {
            _driver.FindElement(By.XPath("//*[contains(@class, 'item-link') and @href = '/careers']")).Click();
            _driver.FindElement(By.XPath("//*[@class = 'arrow']//ancestor::*[contains (@href, 'job-listings') and @tabindex = '0']")).Click();
            _action.ScrollToElement(_driver.FindElement(By.XPath("//*[contains (@href, 'net-developer-middle')]"))).Build().Perform();

            var findCountries = _driver.FindElements(By.XPath("//*[contains (@class, 'js-tabs-title')]"));
            var actualCountries = findCountries.Select(f => f.GetDomProperty("innerText").ToList());

            List<string> expectedCountries = new() { "AMERICAS", "EMEA", "APAC" };

            Assert.That(actualCountries, Is.EqualTo(expectedCountries), "Countries are not equal");
        }

        [TestCase ("Automation")]
        [TestCase("Business Analysis")]
        public void CheckSearchPanelResultIsCorrect(string ExpectedSearchResult)
        {
            _driver.FindElement(By.XPath(_searchIconButtonLocator)).Click();
            _driver.FindElement(By.XPath(_searchFormFieldLocator)).SendKeys(ExpectedSearchResult);
            _driver.FindElement(By.XPath(_findButtonLocator)).Click();

            var SearchForm = _driver.FindElement(By.XPath("//input[contains (@aria-describedby, 'results')]"));

            Assert.That(SearchForm.GetDomProperty("value"), Is.EqualTo(ExpectedSearchResult), "Search results don't match");
        }

        [TestCase (5, "Automation")]
        public void CheckEnteredTextIsPresentInSearchResults(int expectedNumberOfWordToSearch, string searchQuery)
        {
            _driver.FindElement(By.XPath(_searchIconButtonLocator)).Click();
            _driver.FindElement(By.XPath(_searchFormFieldLocator)).SendKeys(searchQuery);
            _driver.FindElement(By.XPath(_findButtonLocator)).Click();
            _driver.FindElement(By.XPath("//input[contains (@aria-describedby, 'results')]"));

            var searchResults = _driver.FindElements(By.XPath("//div[@class = 'search-results__items']/article")).ToList();
            var actualNumberOfWordToSearch = searchResults.Where(p => p.GetDomProperty("textContent").Contains(searchQuery)).Count();

            Assert.That(actualNumberOfWordToSearch, Is.AtLeast(expectedNumberOfWordToSearch), "Request text repeated less than 5 times");
        }

        [TestCase("Business Analysis")]
        public void CheckArticleTitleMatch(string expectedSearchResult)
        {
            _driver.FindElement(By.XPath(_searchIconButtonLocator)).Click();
            _driver.FindElement(By.XPath(_searchFormFieldLocator)).SendKeys(expectedSearchResult);
            _driver.FindElement(By.XPath(_findButtonLocator)).Click();

            var firstSearchResult = _driver.FindElement(By.XPath("//article[1]/h3"));
            var firstTitleFromListOfSearchResult = firstSearchResult.GetDomProperty("textContent");
            firstSearchResult.Click();

            var titleOfFirstArticle = _driver.FindElement(By.XPath("//* [@class = 'museo-sans-light']")).GetDomProperty("textContent");

            Assert.That(firstTitleFromListOfSearchResult, Is.EqualTo(titleOfFirstArticle), "Title of the first search result don't match with title of the first article");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}

// 1. (Keyword "contains")
        //*[contains (@class, 'js-tabs-title')] 
// 2. (axis following-sibling/preceding-sibling)
        //*[@class = 'text']/following-sibling::*[@class = 'button-in-columns']
// 3. (axis parent) (https://www.epam.com/careers/epam-without-borders)
        //*[@aria-label= 'Careers']//parent::*[@gradient-text = 'Careers']
// 4. (axis first/last) (https://www.epam.com/search?q=Automation) 
//      article[last()]   
// 5. (axis child (and verify that we can get rid of it using // or /)) (https://www.epam.com/industries/consumer/retail)
        //*[contains (@class, 'categories-switcher-t')]/child::div[@item-index = '0'] 
        //*[contains (@class, 'categories-switcher-t')]/div[@item-index = '0'] 