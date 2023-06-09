﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDD.Framework;

namespace BDD.Drivers
{
    public class BrowserFactory
    {
        private const string Chrome = "chrome";
        IWebDriver _iWebDriver;

        private IWebDriver IWebDriver
        {
            get => _iWebDriver; set => _iWebDriver = value;
        }

        public IWebDriver InitializeBrowser(string browser)
        {
            switch (browser)
            {
                case Chrome:
                    {
                        IWebDriver = new ChromeDriver(new BrowserOptions().ChromeDriverService, new BrowserOptions().ChromeOptions);
                        break;
                    }
                default:
                    {
                        throw new Exception($"Browser value specified - '{browser}' does not match the supported browsers in this project");
                    }
            }
            IWebDriver.Manage().Window.Maximize();
            return IWebDriver;
        }

        public static void CloseBrowser(IWebDriver iWebDriver) => iWebDriver.Quit();
    }
}
