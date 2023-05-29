using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.Drivers
{
    public class BrowserOptions
    {
        public ChromeDriverService ChromeDriverService
        {
            get
            {
                ChromeDriverService chromeDriverService =
                    ChromeDriverService.CreateDefaultService(@".");
                return chromeDriverService;
                ;
            }
        }

        public ChromeOptions ChromeOptions
        {
            get
            {
                ChromeOptions chromeOptions = new()
                {
                    AcceptInsecureCertificates = true
                };
                return chromeOptions;
            }
        }
    }
}
