using AsiansGroup.WebPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AsiansGroup
{
    public class TestExecution 
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://console.uat.asians.group/#/domain/list";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [Test]
        public void LoginTest()
        {
            loginPage lp = new loginPage(driver);
            lp.existinguserLogin("test@asians.com", "Test@2022");
            homePage hp = new homePage(driver);
            hp.validteHomePageField("Domain");
            hp.validteHomePageUserProfile("test@asians.com");
            Assert.Pass();
        }

        [Test]
        public void NewUserRegistrationTest()
        {
            loginPage lp = new loginPage(driver);
            lp.newUserRegistration();
            homePage hp = new homePage(driver);
            hp.validteHomePageField("Domain");
            Assert.Pass();
        }

        [TearDown]
        public void close()
        { 
           driver.Quit();
        }
    }
}