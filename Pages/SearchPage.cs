using BDD.Framework;
using OpenQA.Selenium;

namespace BDD.Pages
{
    public class SearchPage : PageBase
    {
        public readonly LocatorObject _admin = new(".//ul[@class='oxd-main-menu']/li[@class='oxd-main-menu-item-wrapper'][1]//span[@class='oxd-text oxd-text--span oxd-main-menu-item--name']", LocatorObject.XPATH);

        public SearchPage(IWebDriver iWebDriver) : base(iWebDriver)
        {
        }
    }
}
