using BDD.Framework;
using OpenQA.Selenium;

namespace BDD.Pages
{
    public class PayGrades : PageBase
    {
        public PayGrades(IWebDriver iWebDriver) : base(iWebDriver)
        {
        }

        public readonly LocatorObject _addButton = new(".//div[@class='orangehrm-header-container']//button[@type='button']", LocatorObject.XPATH);
        public readonly LocatorObject _payGrade = new(".//div[@class='oxd-grid-item oxd-grid-item--gutters']//input[@class='oxd-input oxd-input--active']", LocatorObject.XPATH);
        public readonly LocatorObject _saveButton = new(".//button[@type='submit']", LocatorObject.XPATH);

    }
}
