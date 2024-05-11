using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjectMarsAutomation.utitlities;




namespace ProjectMarsAutomation.Pages
{
    internal class HomePage:CommonDriver
    {
             
        private IWebElement LanguageButton = driver.FindElement(By.XPath("//a[@class='item active' and @data-tab='first' and text()='Languages']"));
         public void NavigateToLanguageTab()
        {
           
            LanguageButton.Click();

        }
       

      
    }
}
