using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium.POM;
using System.Threading;

namespace Selenium.Testscript
{
    class TestLogin
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\TNG77\\chromedriver_win32 (3)");
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

        [Test]
        public void testLogin()
        {
            //driver.Navigate().GoToUrl(LoginPageLocator.baselink);
            //driver.Manage().Window.Maximize();
            LoginPageHelper.goToPage(LoginPageLocator.baselink, driver);

            IWebElement openlink = driver.FindElement(By.XPath(LoginPageLocator.openlink));
            openlink.Click();
            Thread.Sleep(2000);
                       
            IWebElement login = driver.FindElement(By.XPath(LoginPageLocator.login));
            login.Click();
            Thread.Sleep(2000);

            //driver.Navigate().GoToUrl(LoginPageLocator.loginlink);
            driver.SwitchTo().Window(driver.WindowHandles.Last());
           
            IWebElement username = driver.FindElement(By.XPath(LoginPageLocator.usernamelink));
            LoginPageHelper.inputUserName(LoginPageContains.username, username);
            IWebElement nextbutton1 = driver.FindElement(By.XPath(LoginPageLocator.nextbutton1));
            nextbutton1.Click();
            Thread.Sleep(2000);

            IWebElement pass = driver.FindElement(By.XPath(LoginPageLocator.passlink));
            LoginPageHelper.inputPassWord(LoginPageContains.pass, pass);
            Thread.Sleep(2000);
            IWebElement nextbutton2 = driver.FindElement(By.XPath(LoginPageLocator.nextbutton2));
            nextbutton2.Click();
            Thread.Sleep(10000);
            

        }
    }
}
