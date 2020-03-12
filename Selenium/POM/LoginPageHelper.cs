using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.POM
{
    class LoginPageHelper
    {
        public static void inputUserName(string username, IWebElement name)
        {
            name.SendKeys(username);
        }
        public static void inputPassWord(string pass, IWebElement password)
        {
            password.SendKeys(pass);
        }

    }
}
