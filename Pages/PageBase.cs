using BDD.Framework;
using OpenQA.Selenium;

namespace BDD.Pages
{
    public class PageBase
    {

        public static IWebDriver _iWebDriver;
        public readonly SeleniumActions SeleniumActions;

        public PageBase(IWebDriver iWebDriver)
        {
            _iWebDriver = iWebDriver;
            SeleniumActions = new SeleniumActions(iWebDriver);
        }
    }
}
