using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMarsAutomation.Pages
{
    internal class Signinpage
    {
        private readonly By SigninButtonLocator = By.XPath("//a[@class=\"item\"][text()=\"Sign In\"]");
        IWebElement SigninButton;

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
    }
}
