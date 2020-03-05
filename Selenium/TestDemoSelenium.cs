﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    internal class TestDemoSelenium
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
            driver.Url = "http://www.google.co.in";

        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

          


       
           

           

        
    }
}