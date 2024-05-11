using NUnit.Framework;
using ProjectMarsAutomation.pages;
using ProjectMarsAutomation.Pages;
using ProjectMarsAutomation.utitlities;

namespace ProjectMarsAutomation.StepDefinitions
{
    [Binding]

   
    public class LogInFeaturesStepDefinitions : CommonDriver

    {
       
       // HomePage HomePageObj;
        LoginPage LoginPageObj;

        [When(@"enters valid username '([^']*)' and password (.*)")]
        public void WhenEntersValidUsernameAndPassword(string username, string password)
        {
            LoginPageObj = new LoginPage();
            LoginPageObj.LoginActions(username, password);
           
        }

                
        [Then(@"User should be redirected to the home page and User should see his name on the topright")]
        public void ThenUserShouldBeRedirectedToTheHomePageAndUserShouldSeeHisNameOnTheTopright()
        {
           
        }
       
        [When(@"User enters invalid username ""([^""]*)"" and/or password ""([^""]*)"" clicks login button")]
        public void WhenUserEntersInvalidUsernameAndOrPasswordClicksLoginButton(string username, string password)
        {
            LoginPageObj = new LoginPage();
            LoginPageObj.LoginActions(username, password);
        }

                       
        [Then(@"User should see an error message")]
        public void ThenUserShouldSeeAnErrorMessage()
        {
            LoginPageObj = new LoginPage();
          
        }

        [When(@"User attempts to log in with a huge payload body to overflow the system clicks login button")]
        public void WhenUserAttemptsToLogInWithAHugePayloadBodyToOverflowTheSystemClicksLoginButton()
        {
            throw new PendingStepException();
        }


        [Then(@"User should see the validation message")]
        public void ThenUserShouldSeeTheValidationMessage()
        {
            throw new PendingStepException();
        }

        [When(@"User attempts to log in with null username or password clicks login button")]
        public void WhenUserAttemptsToLogInWithNullUsernameOrPasswordClicksLoginButton()
        {
            throw new PendingStepException();
        }


        [When(@"User clicks forgot password in the login page")]
        public void WhenUserClicksForgotPasswordInTheLoginPage()
        {
            throw new PendingStepException();
        }

        [Then(@"user can enter emailid and click send verification email")]
        public void ThenUserCanEnterEmailidAndClickSendVerificationEmail()
        {
            throw new PendingStepException();
        }
    }
}
