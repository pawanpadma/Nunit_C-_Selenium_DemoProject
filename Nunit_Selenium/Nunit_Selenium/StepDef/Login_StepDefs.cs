using Nunit_Selenium.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Nunit_Selenium.StepDefinitions {

    [Binding]
    public class Login_StepDefs {
        public LoginPage login;

        public Login_StepDefs() {
            login = new LoginPage();
        }

        [Given(@"I login to application")]
        public void GivenILoginToApplication() {
            login.LoginToAPP();
        }

        [When(@"I select Praticiner and Login as ""(.*)""")]
        public void WhenISelectPraticinerAndLoginAs(string parctioner) {
            login.LoginAs(parctioner);
        }

        [When(@"I search for a Patient ""(.*)""")]
        public void WhenISearchForAPatient(string patient) {
            login.Search(patient);
        }

        [When(@"I logout")]
        public void WhenILogout() {
            login.Logout();
        }
    }
}