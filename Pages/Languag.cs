using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjectMarsAutomation.utitlities;

namespace ProjectMarsAutomation.Pages
{
    internal class Languag : CommonDriver
    {
        
        private IWebElement AddNewButton = driver.FindElement(By.XPath("//div[text()='Add New']"));
       private IWebElement LanguageTextBox = driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Language']"));

        public void clickAddnewButton()
        {

            //Click on add new button
            Thread.Sleep(3000);
            AddNewButton.Click();

        }
        public void AddNewLanguage(string language, string languagelevel)
        {

                     
            LanguageTextBox.Click();


        }

    }  
}
