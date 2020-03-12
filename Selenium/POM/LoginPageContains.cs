using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.POM
{
    class LoginPageContains
    {
        public const string baselink = "http://www.google.com/";
        public const string openlink = "//*[@id = 'viewport']//descendant::a[text()='Gmail']";
        public const string login = "//*[@class = 'h-c-header__cta-list header__nav--ltr' ]//descendant::a[contains( text(),'Đăng nhập')]";
        public const string loginlink = "https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
        public const string username = "Trang.test.mantu@gmail.com";
        public const string pass = "mantu123456";
        public const string usernamelink = "//*[@type= 'email']";
        public const string passlink = "//*[@type= 'password']";
        public const string nextbutton1 = "//*[@id= 'identifierNext']//descendant::span[contains( text(),'Tiếp theo')]";
        public const string nextbutton2 = "//*[@id= 'passwordNext']//descendant::span[contains( text(),'Tiếp theo')]";
    }
}
