using System;
using TechTalk.SpecFlow;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

/*
 * Not implemented as it requires driver downloads and therefore will not run directly with one click as required for scritiny of this HESA test solution.
 * 
 * Using MS Edge driver downloaded from https://developer.microsoft.com/en-us/microsoft-edge/tools/webdriver/#downloads
 */

namespace HesaUser.Lookup.Tests
{
    [Binding]
    public class HesaSearchUsersSteps
    {
        IWebDriver browserDriver;

        [Given(@"I am a user of the system")]
        public void GivenIAmAUserOfTheSystem()
        {
            //browserDriver = new EdgeDriver();
        }
        
        [Given(@"I search for a user by typing in Robinson into a text box on the admin page")]
        public void GivenISearchForAUserByTypingInRobinsonIntoATextBoxOnTheAdminPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I search for a user by typing in Wilson into a text box on the admin page")]
        public void GivenISearchForAUserByTypingInWilsonIntoATextBoxOnTheAdminPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click search")]
        public void WhenIClickSearch()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"(.*) matching results are shown on the admin page")]
        public void ThenMatchingResultsAreShownOnTheAdminPage(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
