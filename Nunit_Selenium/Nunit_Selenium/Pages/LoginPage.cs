using NUnit.Framework;
using Nunit_Selenium.Commons;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nunit_Selenium.Pages {

    public class LoginPage {
        public IWebDriver driver = InitBrowser.Getbrowser();

        // protected readonly WebDriverWait wait;
        // protected readonly WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        private WebDriverWait wait;

        public LoginPage() {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public IWebElement UserNameTextBox { get { return wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("userName"))); } }
        public IWebElement PasswordText { get { return wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("password"))); } }
        public IWebElement LoginButton { get { return wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("loginBtn"))); } }
        public IWebElement LaunchButton { get { return wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("launchFhirServer"))); } }
        public IWebElement SelectPractionerDropDown { get { return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//form[@id='login']//select"))); } }

        public IWebElement SubmitButton { get { return wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("btn"))); } }
        public IWebElement PatientTextBox { get { return wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("searchText"))); } }
        public IWebElement SelectPatient { get { return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@id='scrollable-list']//table//tr"))); } }

        public IWebElement EMRLogoutButton { get { return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//p[contains(@class, 'logout emrEpc')]"))); } }

        public void LoginToAPP() {
            UserNameTextBox.Clear();
            UserNameTextBox.SendKeys(ReadEnv.ReadData("base", "username"));
            PasswordText.Clear();
            PasswordText.SendKeys(ReadEnv.ReadData("base", "password"));
            LoginButton.Click();
            Assert.True(LaunchButton.Displayed);
        }

        public void LoginAs(string Practioner) {
            LaunchButton.Click();
            SelectElement s = new SelectElement(SelectPractionerDropDown);
            s.SelectByText(Practioner);
            SubmitButton.Click();
            Assert.True(PatientTextBox.Displayed);
        }

        public void Search(string patient) {
            PatientTextBox.SendKeys(patient);
            SelectPatient.Click();
        }

        public void Logout() {
            EMRLogoutButton.Click();
            Assert.True(UserNameTextBox.Displayed);
        }
    }
}