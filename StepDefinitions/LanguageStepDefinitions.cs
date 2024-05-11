using NUnit.Framework;
using ProjectMarsAutomation.pages;
using ProjectMarsAutomation.Pages;
using ProjectMarsAutomation.utitlities;
using RazorEngine;
using System;
using System.Runtime.InteropServices;
using TechTalk.SpecFlow;

namespace ProjectMarsAutomation.StepDefinitions
{
    [Binding]
    public class LanguageStepDefinitions : CommonDriver
    {
        Languag LanguageObj;
        HomePage HomePageObj;
        LoginPage LoginPageObj;

        [Given(@"enters valid username '([^']*)' and password '([^']*)'  clicks login button")]
        public void GivenEntersValidUsernameAndPasswordClicksLoginButton(string username, string password)
        {
            LoginPageObj = new LoginPage();
           
            LoginPageObj.LoginActions(username, password);
        }
        [When(@"user naviagate to language tab and click Add new button")]
        public void WhenUserNaviagateToLanguageTabAndClickAddNewButton()
        {
            LanguageObj = new Languag();
            LanguageObj.clickAddnewButton();
        }
        [When(@"User adds a language '([^']*)' with level '([^']*)' clicks  Add button")]
        public void WhenUserAddsALanguageWithLevelClicksAddButton(string language, string languagelevel)
        {
            //Initiate objects
            LanguageObj = new Languag();
            LanguageObj.AddNewLanguage(language, languagelevel); ;
        }


      
        [Then(@"User should see the language '([^']*)' '([^']*)' added to the profile")]
        public void ThenUserShouldSeeTheLanguageAddedToTheProfile(string language, string languagelevel)
        {

        }   
        

        [Given(@"User navigates to Language tab")]
        public void GivenUserNavigatesToLanguageTab()
        {
            HomePageObj = new HomePage();
            HomePageObj.NavigateToLanguageTab();
        }

        [When(@"User edits the existing '([^']*)' to '([^']*)'")]
        public void WhenUserEditsTheExistingTo(string language, string newlanguage)
        {
            LanguageObj = new Languag();
           // LanguageObj.EditLanguage(language, newlanguage);
        }

        [When(@"User Edits the Language '([^']*)' to '([^']*)'")]
        public void WhenUserEditsTheLanguageTo(string level, string newlevel)
        {
            throw new PendingStepException();
        }

        [When(@"User clicks on Update button to save language changes")]
        public void WhenUserClicksOnUpdateButtonToSaveLanguageChanges()
        {
            LanguageObj = new Languag();
          
        }

        [Then(@"User should see the '([^']*)' and '([^']*)'")]
        public void ThenUserShouldSeeTheAnd(string p0, string intermediate)
        {
            throw new PendingStepException();
        }

        [When(@"User deletes  '([^']*)'")]
        public void WhenUserDeletes(string english)
        {
            LanguageObj = new Languag();
           
        }

        [Then(@"User should not see the  '([^']*)' in the profile")]
        public void ThenUserShouldNotSeeTheInTheProfile(string english)
        {
            throw new PendingStepException();
        }

    }

}