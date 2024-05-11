using ProjectMarsAutomation.pages;
using ProjectMarsAutomation.Pages;
using ProjectMarsAutomation.utitlities;
using System;
using TechTalk.SpecFlow;

namespace ProjectMarsAutomation.StepDefinitions
{
    [Binding]
    public class SkillFeatureStepDefinitions:CommonDriver
    {

        Skill skillObj;
       // HomePage homePageObj;
        LoginPage LoginPageObj;

        [Given(@"Given enters valid username '([^']*)' and password '([^']*)'  clicks login button")]
        public void GivenGivenEntersValidUsernameAndPasswordClicksLoginButton(string username, string password)
        {
            LoginPageObj = new LoginPage();
            LoginPageObj.LoginActions(username, password);
        }
        [Given(@"user naviagate to skill tab and click Add new button")]
        public void GivenUserNaviagateToSkillTabAndClickAddNewButton()
        {
            skillObj = new Skill();
            skillObj.clickAddnewButton();
        }

        [When(@"User navigates to Skill tab and User adds a  '([^']*)' with  '([^']*)' and clicks on Add button")]
        public void WhenUserNavigatesToSkillTabAndUserAddsAWithAndClicksOnAddButton(string skill, string skilllevel)
        {

         
           ;
            skillObj.AddNewSkill(skill, skilllevel);
            skillObj.SaveNewSkill();
        }

        [Then(@"User should see the '([^']*)' added to the profile")]
        public void ThenUserShouldSeeTheAddedToTheProfile(string sQL)
        {
            throw new PendingStepException();
        }
                           

        [Then(@"User should see the  <skill> added to the profile")]
        public void ThenUserShouldSeeTheSkillAddedToTheProfile()
        {
            throw new PendingStepException();
        }

        [When(@"User edits the <skill> to <new_skill>")]
        public void WhenUserEditsTheSkillToNew_Skill()
        {
            skillObj = new Skill();
            skillObj.EditSkill();
           
        }



        [When(@"User Edits the skill<level> to <new_level>")]
        public void WhenUserEditsTheSkillLevelToNew_Level()
        {
            skillObj = new Skill();
            skillObj.UPdateSkill();
        }

        [When(@"User clicks on Update button to save skill changes")]
        public void WhenUserClicksOnUpdateButtonToSaveSkillChanges()
        {


            skillObj = new Skill();
            skillObj.UPdateSkill();
        }
    

        [Then(@"User should see the <new_skill> and <new_level>")]
        public void ThenUserShouldSeeTheNew_SkillAndNew_Level(Table table)
        {
            throw new PendingStepException();
        }

        [When(@"User deletes  <existing_skill>")]
        public void WhenUserDeletesExisting_Skill()
        {
            skillObj = new Skill();
            skillObj.DeleteSkill();
        }

        [Then(@"User should not see the  <existing_skill> in the profile")]
        public void ThenUserShouldNotSeeTheExisting_SkillInTheProfile(Table table)
        {
            throw new PendingStepException();
        }
    }
}
