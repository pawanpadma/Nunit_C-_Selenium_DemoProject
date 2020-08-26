using Nunit_Selenium.Commons;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Nunit_Selenium.StepDef {

    [Binding]
    public class StepDf {
        public ReadEnv env;

        //InitBrowser initBrowser = new InitBrowser();
        public IWebDriver driver = InitBrowser.Getbrowser();

        [Given(@"thee first number is (.*)")]
        public void GivenTheeFirstNumberIs(int p0) {
        }

        [Given(@"thee second number is (.*)")]
        public void GivenTheeSecondNumberIs(int p0) {
        }

        [When(@"thee two numbers are added")]
        public void WhenTheeTwoNumbersAreAdded() {
        }

        [Then(@"tehe result should be (.*)")]
        public void ThenTeheResultShouldBe(int p0) {
        }
    }
}