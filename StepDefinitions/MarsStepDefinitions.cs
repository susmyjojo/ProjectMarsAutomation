using OpenQA.Selenium.Chrome;
using ProjectMarsAutomation.pages;
using ProjectMarsAutomation.Pages;
using ProjectMarsAutomation.utitlities;

namespace ProjectMarsAutomation.StepDefinitions
{
    [Binding]
    public class MarsStepDefinitions : CommonDriver
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
                  LoginPage LoginPageObj = new LoginPage();
                  LoginPageObj.LoginActions(driver, "jojojoseph93@gmail.com", "123456789");
              }

      

            [When(@"User enters a  language and choose a level")]
        public void WhenUserEntersALanguageAndChooseALevel()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.AddNewLanguage(driver);

        }

        [Then(@"user clicks add and save the language")]
        public void ThenUserClicksAddAndSaveTheLanguage()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.SaveNewLanguage(driver);
        }

        [When(@"user clicksthe edit button to edit the new language added and level")]
        public void WhenUserClickstheEditButtonToEditTheNewLanguageAddedAndLevel()
        {
            HomePage homePageObjt = new HomePage();
            homePageObjt.EditLanguage(driver);
        }

        [Then(@"user clicks update and save the changes")]
        public void ThenUserClicksUpdateAndSaveTheChanges()
        {
            HomePage homePageObjt = new HomePage();
            homePageObjt.UpdateLanguage(driver);
        }

        [When(@"User enters a skill and choose a level")]
        public void WhenUserEntersASkillAndChooseALevel()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.AddNewSkill(driver);
        }

        [Then(@"user clicks add and save the skill")]
        public void ThenUserClicksAddAndSaveTheSkill()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.SaveNewSkill(driver);

        }

        [When(@"User clikcs edit button to edit a skill and the level")]
        public void WhenUserClikcsEditButtonToEditASkillAndTheLevel()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.EditSkill(driver);
        }
        [Then(@"user clicks update and save the skills changes")]
        public void ThenUserClicksUpdateAndSaveTheSkillsChanges()
        {

            HomePage homePageObj = new HomePage();
            homePageObj.UPdateSkill(driver);
        }

        [When(@"user clicks the delete button to delet the new language added")]
        public void WhenUserClicksTheDeleteButtonToDeletTheNewLanguageAdded()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.DeleteLanguage(driver); 
        }

        [When(@"user clicks the delete button to delet the new skill added")]
        public void WhenUserClicksTheDeleteButtonToDeletTheNewSkillAdded()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.DeleteSkill(driver);
        }

       [Given(@"User clicks sign in option to the project mars page")]
        public void GivenUserClicksSignInOptionToTheProjectMarsPage()
        {
            Signinpage SigninpageObj = new Signinpage();
            SigninpageObj.SigninActions(driver);
        }

        [When(@"User clicks forgot password")]
        public void WhenUserClicksForgotPassword()
        {
            Signinpage SigninpageObj = new Signinpage();
            SigninpageObj.ForgotPassowrd(driver);
        }

        [Then(@"user enters emailid and click send verification email")]
        public void ThenUserEntersEmailidAndClickSendVerificationEmail()
        {
            Signinpage SigninpageObj = new Signinpage();
            SigninpageObj.SendVerificationEmail(driver ,"jojojoseph93@gmail.com");
        }

        [When(@"User enters a  wrong user id and password")]
        public void WhenUserEntersAWrongUserIdAndPassword()
        {
            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.InvalidCredentials(driver, "jojojoseph93@gmail.com", "1234567");
        }

        
    }
}
