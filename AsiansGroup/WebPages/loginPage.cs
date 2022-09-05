using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsiansGroup.WebPages
{
    public class loginPage : TestExecution
    {
      //  private IWebDriver driver;
        public loginPage(IWebDriver driver)
        {
             this.driver = driver;
        }

        private IWebElement userName_txt => driver.FindElement(By.Id("username"));
        private IWebElement emailddress_txt => driver.FindElement(By.Id("email"));
        private IWebElement password_txt => driver.FindElement(By.Id("password"));
        private IWebElement confirmPassword_txt => driver.FindElement(By.Id("password-confirm"));
        private IWebElement submit_btn => driver.FindElement(By.Id("kc-login"));
        private IWebElement register_lnk => driver.FindElement(By.XPath("//a[text()='Register']"));
        private IWebElement register_btnk => driver.FindElement(By.XPath("//input[@value='Register' and @type='submit']"));

        public void existinguserLogin(string userName, string password)
        {
            userName_txt.SendKeys(userName);
            password_txt.SendKeys(password);
            submit_btn.Click();
        }
        //public void newUserRegistration(string userName, string password, string confirmPassword)
        //{
        //    register_lnk.Click();
        //    userName_txt.SendKeys(generateRandomName()+ "");
        //    password_txt.SendKeys(password);
        //    confirmPassword_txt.SendKeys(confirmPassword);
        //    register_btnk.Click();
        //}

        public static string generateRandomName()
        {
            String str = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcedfghijklmnopqrstuvwxyz";
            Random random = new Random();
            String randomText = null;

            for (int i = 0; i < 6; i++)
            {
                randomText = randomText + str.ElementAt(random.Next(62));
            }
            return randomText;
        }
        public void newUserRegistration()
        {
            string userName = generateRandomName() + "@asians.com";
            string password = generateRandomName() + "2022";
            register_lnk.Click();
            emailddress_txt.SendKeys(userName);
            Console.WriteLine("New User Email Address: "+ emailddress_txt.Text);
            password_txt.SendKeys(password);
            confirmPassword_txt.SendKeys(generateRandomName()+"@2022");
            Console.WriteLine("New User Password : " + confirmPassword_txt.Text);
            register_btnk.Click();
        }
    }
}
