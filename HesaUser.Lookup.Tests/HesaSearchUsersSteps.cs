using System;
using TechTalk.SpecFlow;

namespace HesaUser.Lookup.Tests
{
    [Binding]
    public class HesaSearchUsersSteps
    {
        [Given(@"I am a user of the system")]
        public void GivenIAmAUserOfTheSystem()
        {
            ScenarioContext.Current.Pending();
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
