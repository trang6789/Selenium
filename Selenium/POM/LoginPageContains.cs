using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.POM
{
    class LoginPageContains
    {
        public const string username = " Trang.test.mantu@gmail.com";
        public const string pass = "mantu123456";
        public const string baselink = "http://www.google.com/";
        public const string openlink = "//*[@class = 'gb_g' and @href ='https://mail.google.com/mail/?tab=wm&ogbl']";
        public const string login = "//*[@class = 'h-c-header__nav-li g-mail-nav-links']//*[@class = 'h-c-header__nav-li-link ' and @ga-event-action = 'sign in' ]";
        public const string loginlink = "https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
    }
}
