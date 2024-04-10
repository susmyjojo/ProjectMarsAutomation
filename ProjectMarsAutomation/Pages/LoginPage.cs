using OpenQA.Selenium;


namespace ProjectMarsAutomation.pages
{

    public class LoginPage
    {

        private readonly By UsernameTextBoxLocator = By.XPath("//input[@name='email' and @placeholder='Email address']");
        IWebElement usernameTextbox;
        private readonly By PasswordTextBoxLocator = By.XPath("//input[@placeholder='Password']");
        IWebElement passwordTextbox;
       
        private readonly By LoginButtonLocator = By.XPath("//button[@class='fluid ui teal button']");
        IWebElement LoginButton;
        // private readonly By ForgotPasswordLocator = By.XPath("//button[@class='fluid ui teal button']");
        //IWebElement ForgotPasswordLocator;
        //private readonly By VerificationButtonLocator = By.XPath("//button[@id='submit-btn']");
        //IWebElement VerificationButton;
        public void LoginActions(IWebDriver driver, string username, string password)
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //string baseURL = "http://localhost:5000/Home";
            // driver.Navigate().GoToUrl(baseURL);

            Thread.Sleep(5000);
            //identify username feildbox and enter username
            usernameTextbox = driver.FindElement(UsernameTextBoxLocator);
            usernameTextbox.SendKeys(username);
            passwordTextbox = driver.FindElement(PasswordTextBoxLocator);
            passwordTextbox.SendKeys(password);
            //Identify the login button and click on login button
            //waiting 5 seconds
            Thread.Sleep(5000);
            LoginButton = driver.FindElement(LoginButtonLocator);
            LoginButton.Click();
        }
        /* public void Forgotpassword(IWebDriver driver)
         {
              //identify the send verification email button
              ForgotPasswordButton = driver.FindElement(ForgotPasswordLocator);
              ForgotPasswordButton.Click();
          }
         /* public void SendVerificationEmail(IWebDriver driver)
          {
              //identify the send verification email button
              VerificationButton = driver.FindElement(VerificationButtonLocator);
              VerificationButton.Click();
          }
      */
    }
}
