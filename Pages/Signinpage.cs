using OpenQA.Selenium;

namespace ProjectMarsAutomation.Pages
{
    internal class Signinpage
    {
        private readonly By SigninButtonLocator = By.XPath("//a[@class=\"item\"][text()=\"Sign In\"]");
        IWebElement SigninButton;
        private readonly By ForgotPasswordButtonLocator = By.XPath("//a[@class='pointerCursor' and text()='Forgot your password?']");
        IWebElement ForgotButton;
        private readonly By VerificationButtonLocator = By.XPath("//div[@class='fluid ui teal button' and text()='SEND VERIFICATION EMAIL']");
        IWebElement VerificationButton;

        public void SigninActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //Launch mars project and navigate to the website login page
            string baseURL = "http://localhost:5000/Home";
            driver.Navigate().GoToUrl(baseURL);
            //identify signin button
            SigninButton = driver.FindElement(SigninButtonLocator);
            SigninButton.Click();

        }
        public void ForgotPassowrd(IWebDriver driver )
        {
            
            ForgotButton = driver.FindElement(ForgotPasswordButtonLocator);
          ForgotButton.Click();
        }
        public void SendVerificationEmail(IWebDriver driver ,string emailid)
        {

            IWebElement TypeEmail = driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Email address' and @name='email']"));
            TypeEmail.Click();
            TypeEmail.SendKeys(emailid);
            VerificationButton = driver.FindElement(VerificationButtonLocator);
            VerificationButton.Click();
        }
       

    }

        
     
    
}
