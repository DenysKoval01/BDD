using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.Framework
{
    public class LocatorObject
    {
        private readonly string _objectValue;
        public const string ID = "ID";
        public const string CSS = "CSS";
        public const string XPATH = "XPATH";
        public const string LINK_TEXT = "LINKTEXT";
        public const string PARTIAL_LINK_TEXT = "PARTIALLINKTEXT";
        public const string CLASS = "CLASS";
        public const string NAME = "NAME";

        public By LocatorValue
        {
            get; private set;
        }

        public LocatorObject(string locator, string locatorType)
        {
            _objectValue = locator;
            LocatorValue = GetLocatorObject(_objectValue, locatorType);
        }

        public By GetLocatorObject(string locator, string locatorType)
        {
            switch (locatorType.ToUpper())
            {
                case ID:
                    LocatorValue = By.Id(locator);
                    break;
                case CSS:
                    LocatorValue = By.CssSelector(locator);
                    break;
                case XPATH:
                    LocatorValue = By.XPath(locator);
                    break;
                case LINK_TEXT:
                    LocatorValue = By.LinkText(locator);
                    break;
                case CLASS:
                    LocatorValue = By.ClassName(locator);
                    break;
                case NAME:
                    LocatorValue = By.Name(locator);
                    break;
                case PARTIAL_LINK_TEXT:
                    LocatorValue = By.PartialLinkText(locator);
                    break;
            }
            return LocatorValue;
        }
    }
}
