using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver _driver;
        public static string url = "https://www.linkedin.com/";

        [AssemblyInitialize]
        public static void SetUp(TestContext context)
        {
            _driver = new ChromeDriver();
            
        }

        [TestMethod]
        public void SignIn()
        {
            _driver.Navigate().GoToUrl(url);
            _driver.FindElement(By.Id("reg-firstname")).SendKeys("Rose Lyn");
            _driver.FindElement(By.Id("reg-lastname")).SendKeys("Damo");
            _driver.FindElement(By.Id("reg-email")).SendKeys("rose.lyn.c.damo@accenture.com");
            _driver.FindElement(By.Id("reg-password")).SendKeys("Qwerty1234");
            _driver.FindElement(By.Id("registration-submit")).Click();
        }
        [TestMethod]
        public void LogIn()
        {
            _driver.Navigate().GoToUrl(url);
            _driver.FindElement(By.Id("login-email")).SendKeys("rose.lyn.c.damo@accenture.com");
            _driver.FindElement(By.Id("login-password")).SendKeys("Qwerty1234");
            _driver.FindElement(By.Id("login-submit")).Click();
        }
        [TestMethod]
        public void CreatePost()
        {
            _driver.Navigate().GoToUrl(url);
            _driver.FindElement(By.Id("login-email")).SendKeys("rose.lyn.c.damo@accenture.com");
            _driver.FindElement(By.Id("login-password")).SendKeys("Qwerty1234");
            _driver.FindElement(By.Id("login-submit")).Click();
            _driver.FindElement(By.CssSelector("button[class='Sans-17px-black-70%']")).Click();
            _driver.FindElement(By.CssSelector("textarea[class='sharing-textarea__textarea sharing-textarea__textarea--original ember-text-area ember-view']")).SendKeys("Hello People!");
            _driver.FindElement(By.CssSelector("button[class='sharing-share-box__post-button post ember-view']")).Click();
        }
        [TestMethod]
        public void FriendReq()
        {
            _driver.Navigate().GoToUrl(url);
            _driver.FindElement(By.Id("login-email")).SendKeys("rose.lyn.c.damo@accenture.com");
            _driver.FindElement(By.Id("login-password")).SendKeys("Qwerty1234");
            _driver.FindElement(By.Id("login-submit")).Click();
            _driver.FindElement(By.CssSelector("input[class='ember-text-field ember-view']")).SendKeys("Jervis Carlo");
            _driver.FindElement(By.CssSelector("button[class='nav-search-button']")).Click();
            _driver.FindElement(By.CssSelector("button[class='search-result__actions--primary button-secondary-medium m5']")).Click();

        }


    }
}
