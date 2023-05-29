using BDD.Framework;
using OpenQA.Selenium;

namespace BDD.Pages
{
    public class SurePopUp : PageBase
    {

        public readonly LocatorObject _yesSureDelete = new("//div[@class='orangehrm-modal-footer']/button[2]", LocatorObject.XPATH);

        public SurePopUp(IWebDriver iWebDriver) : base(iWebDriver)
        {
        }
    }
}
