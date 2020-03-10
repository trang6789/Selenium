using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium
{
    class InputFieldcs
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\TNG77\\chromedriver_win32 (3)");
        }


        [Test]
        public void test()
        {
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-first-form-demo.html");
            driver.Manage().Window.Maximize();
            IWebElement searchBar = driver.FindElement(By.Id("user-message"));
            searchBar.SendKeys("Hi");
            Thread.Sleep(2000);
            IWebElement button = driver.FindElement(By.XPath("//*[@id='get-input']/button"));
            button.Click();
            Thread.Sleep(2000);
            IWebElement mess = driver.FindElement(By.Id("display"));
            Assert.AreEqual("Hi", mess.Text);
            driver.Close();

        }

        [Test]
        public void Practice2()
        {
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-first-form-demo.html");
            driver.Manage().Window.Maximize();
            //IWebElement searchBar1 = driver.FindElement(By.XPath("//*[@id='sum1']"));
            IWebElement searchBar1 = driver.FindElement(By.XPath("//*[@id='gettotal']//*[@type='text' and @id='sum1']"));
            searchBar1.SendKeys("1");
            Thread.Sleep(2000);

            IWebElement searchBar2 = driver.FindElement(By.XPath("//*[@id='gettotal']//*[@type='text' and @id='sum2']"));
            searchBar2.SendKeys("1");
            Thread.Sleep(2000);

            IWebElement button = driver.FindElement(By.XPath("//*[@type='button' and text()='Get Total']"));
            button.Click();
            Thread.Sleep(2000);
                        
            IWebElement mess = driver.FindElement(By.XPath("//span[@id='displayvalue']"));
            Assert.AreEqual("2", mess.Text);
            driver.Close();

        }

        //[TearDown]
        //public void closeBrowser()
        //{
        //    driver.Close();
        //}
    }
}
