﻿using NUnit.Framework;
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
    class Email
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\TNG77\\chromedriver_win32 (3)");

        }

        [Test]
        public void testEmail()
        {
            driver.Navigate().GoToUrl("http://www.google.com/");
            driver.Manage().Window.Maximize();
            IWebElement open = driver.FindElement(By.XPath("//*[@class = 'gb_g' and @href ='https://mail.google.com/mail/?tab=wm&ogbl']"));
            open.Click();
            Thread.Sleep(2000);

            IWebElement login = driver.FindElement(By.XPath("//*[@class = 'h-c-header__nav-li g-mail-nav-links']//*[@class = 'h-c-header__nav-li-link ' and @ga-event-action = 'sign in' ]"));
            login.Click();
            Thread.Sleep(2000);

            driver.SwitchTo();
            driver.Navigate().GoToUrl("https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin");
            
            IWebElement username = driver.FindElement(By.XPath("//*[@type = 'email' and @name = 'identifier' ]"));
            //IWebElement username = driver.FindElement(By.XPath("//input[@type= 'email']"));
            username.SendKeys("Trang.test.mantu@gmail.com");
            IWebElement nextbutton = driver.FindElement(By.XPath("//*[@class= 'RveJvd snByac' and text() = 'Tiếp theo']"));
            nextbutton.Click();
            Thread.Sleep(2000);

            IWebElement pass = driver.FindElement(By.XPath("//*[@type= 'password' ]"));
            pass.SendKeys("mantu123456");
            IWebElement next2 = driver.FindElement(By.XPath("//*[@class= 'RveJvd snByac' and text()='Tiếp theo']"));
            next2.Click();
            Thread.Sleep(2000);

        }

        [Test]
        public void testEmail2()
        {
            driver.Navigate().GoToUrl("http://www.google.com/");
            driver.Manage().Window.Maximize();
            IWebElement open = driver.FindElement(By.XPath("//*[@class = 'gb_g' and text()='Gmail']//self::a"));
            open.Click();
            Thread.Sleep(2000);

            IWebElement login = driver.FindElement(By.XPath("//*[@class = 'h-c-header__cta-list header__nav--ltr' ]//descendant::a[2]"));
            login.Click();
            Thread.Sleep(2000);

            driver.SwitchTo();
            driver.Navigate().GoToUrl("https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin");
            IWebElement username = driver.FindElement(By.XPath("//*[@type= 'email']//self::input"));
            //IWebElement username = driver.FindElement(By.XPath("//input[@type= 'email']"));
            username.SendKeys("Trang.test.mantu@gmail.com");
            IWebElement nextbutton = driver.FindElement(By.XPath("//*[@id= 'identifierNext']//descendant::span[2]"));
            nextbutton.Click();
            Thread.Sleep(2000);

            IWebElement pass = driver.FindElement(By.XPath("//*[@type= 'password']//self::input"));
            pass.SendKeys("mantu123456");
            IWebElement next2 = driver.FindElement(By.XPath("//*[@id= 'passwordNext']//descendant::span[2]"));
            next2.Click();
            Thread.Sleep(2000);

        }
    }
}