using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsiansGroup.WebPages
{
    public class homePage : TestExecution
    {
       
        public homePage(IWebDriver driver)
        {
             this.driver = driver; 
        }

        private IWebElement domain_lnk => driver.FindElement(By.XPath("//a[@href='#/domain/list']"));

        private IWebElement userProfile_lnk => driver.FindElement(By.XPath("//ul[@class='c-header-nav float-right']//child::*[@class='c-header-nav-link']"));

        private IWebElement userProfileCard => driver.FindElement(By.XPath("//div[@class='pt-0 dropdown-menu show']"));

        public void validteHomePageField(string validation)
        {
            string homePageFieldLink = domain_lnk.Text;
            Assert.True(homePageFieldLink.ToLower().Contains(validation.ToLower()));
            Console.WriteLine(validation+" link displayed on home page");
        }

        public void validteHomePageUserProfile(string username)
        {
            userProfile_lnk.Click();
            Assert.True(userProfileCard.Text.ToLower().Contains(username.ToLower()));
            Console.WriteLine(username + " displayed on home page user profile");
        }
    }
}
