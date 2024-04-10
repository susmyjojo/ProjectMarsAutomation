using OpenQA.Selenium.Chrome;
using ProjectMarsAutomation.pages;
using ProjectMarsAutomation.Pages;
using ProjectMarsAutomation.utitlities;
using System;
using TechTalk.SpecFlow;

namespace ProjectMarsAutomation.StepDefinitions
{
    [Binding]
    public class MarsStepDefinitions :CommonDriver
    {

        [BeforeScenario]
        //Open Chrome/Firefox browser
        public void SetUpsigninpage()
        {
            //Open Chrome/Firefox browser
            driver = new ChromeDriver();
            Signinpage SigninpageObj = new Signinpage();
            SigninpageObj.SigninActions(driver);
        }
        [Given(@"User logins to the project mars page and views own profile")]
        public void GivenUserLoginsToTheProjectMarsPageAndViewsOwnProfile()
        {
            //Open Chrome/Firefox browser
            // driver = new ChromeDriver();
            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.LoginActions(driver, "jojojoseph93@gmail.com", "123456");
            // LoginPage VerificationObj = new LoginPage();
            // VerificationObj.SendVerificationEmail(driver);
            // LoginPage forgotpasswordObj = new LoginPage();
            // forgotpasswordObj.Forgotpassword(driver);

        }

        [Given(@"User enters a  language and choose a level")]
        public void GivenUserEntersALanguageAndChooseALevel()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.AddNewLanguage(driver);
            //HomePage homePageObj = new HomePage();
            //homePageObj.VerifyLoggedInUser(driver);
        }

        [Given(@"user clicks add and save the language")]
        public void GivenUserClicksAddAndSaveTheLanguage()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.SaveNewLanguage(driver);
            HomePage homePageObjt = new HomePage();
            homePageObjt.EditLanguage(driver);
        }

        [When(@"user enters a skill and choose a level")]
        public void WhenUserEntersASkillAndChooseALevel()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.AddNewSkill(driver);
            HomePage homePageObjt = new HomePage();
            homePageObjt.Editskill(driver);
        }

        [Then(@"user clicks add and save the language")]
        public void ThenUserClicksAddAndSaveTheLanguage()
        {
            throw new PendingStepException();
        }
    }
}
