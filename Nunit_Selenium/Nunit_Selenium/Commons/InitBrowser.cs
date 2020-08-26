using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nunit_Selenium.Commons {

    public class InitBrowser {
        public static IWebDriver driver;

        // public ReadEnv env;
        public string browser = null;

        public static IWebDriver Getbrowser() {
            //string browser =
            string browser = ReadEnv.ReadData("base", "browser");
            if (browser.Equals("chrome", StringComparison.OrdinalIgnoreCase)) {
                if (driver == null) {
                    driver = new ChromeDriver();
                    return driver;
                } else
                    return driver;
            }
            if (browser.Equals("firefox", StringComparison.OrdinalIgnoreCase)) {
                if (driver == null) {
                    driver = new FirefoxDriver();
                    return driver;
                } else
                    return driver;
            }
            return driver;
        }
    }
}