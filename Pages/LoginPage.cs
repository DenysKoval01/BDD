using BDD.Framework;
using OpenQA.Selenium;

namespace BDD.Pages
{
    public class LoginPage : PageBase
    {

        public readonly LocatorObject _username = new(".//input[@name='username']", LocatorObject.XPATH);
        public readonly LocatorObject _password = new(".//input[@name='password']", LocatorObject.XPATH);
        public readonly LocatorObject _login = new("//button[@type='submit']", LocatorObject.XPATH);

        public LoginPage(IWebDriver iWebDriver) : base(iWebDriver)
        {
        }
    }
}
