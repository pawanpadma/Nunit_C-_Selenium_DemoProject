using NUnit.Framework;
using Nunit_Selenium.Commons;
using OpenQA.Selenium;

using TechTalk.SpecFlow;

namespace Nunit_Selenium.StepDef {

    [Binding]
    public sealed class Hooks {
        public static IWebDriver driver = InitBrowser.Getbrowser();

        [OneTimeSetUp]
        public static void loginToApplication() {
            driver.Navigate().GoToUrl(ReadEnv.ReadData("base", "appUrl"));
            driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public static void CloseBrowser() {
            driver.Quit();
        }
    }
}