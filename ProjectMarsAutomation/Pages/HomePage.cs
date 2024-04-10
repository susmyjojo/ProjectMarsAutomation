using OpenQA.Selenium;
namespace ProjectMarsAutomation.Pages
{
    internal class HomePage
    {
        public void AddNewLanguage(IWebDriver driver)
        {
            //Click on add new button
            IWebElement AddNewButton = driver.FindElement(By.XPath("//div[@class='ui teal button ' and text()='Add New']"));
            AddNewButton.Click();

            //Enter language
            IWebElement LanguageTextBox = driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Language']"));
            LanguageTextBox.SendKeys("Engilsh");

            //choose level 
            IWebElement LevelDropdown = driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
            LevelDropdown.Click();
            IWebElement LevelSelection = driver.FindElement(By.XPath("//option[@value='Basic']"));
            LevelSelection.Click();
        }
            public void SaveNewLanguage(IWebDriver driver)
            {
                //Click on the Save Button
                // Waitutilities.WaitToBeVisible(driver, "Id", "SaveButton", 2);

                IWebElement AddButton = driver.FindElement(By.XPath("//input[@type='button' and @class='ui teal button' and @value='Add']"));
            AddButton.Click();

        }
        public void AddNewSkill(IWebDriver driver)
        {
            //Click on skill
            IWebElement SkillButton = driver.FindElement(By.XPath("//a[@class='item active' and @data-tab='second']"));
            SkillButton.Click();
            //Click on add new button
            IWebElement AddNewButton = driver.FindElement(By.XPath("//div[@class=\"ui teal button\"]"));
            AddNewButton.Click();

            //Enter skill
            IWebElement SkillTextBox = driver.FindElement(By.XPath("//input[@type=\"text\" and @placeholder=\"Add Skill\" and @name=\"name\"]"));
            SkillTextBox.SendKeys("Engilsh");

            //choose level 
            IWebElement LevelDropdownskill = driver.FindElement(By.XPath("//select[@class=\"ui fluid dropdown\" and @name=\"level\"]"));
            LevelDropdownskill.Click();
            IWebElement LevelSelectionskill = driver.FindElement(By.XPath("//option[@value=\"Beginner\" and text()=\"Beginner\"]"));
            LevelSelectionskill.Click();
        }
            public void SaveNewSkill(IWebDriver driver)
            {
                //Click on the Save Button
                // Waitutilities.WaitToBeVisible(driver, "Id", "SaveButton", 2);

                IWebElement AddButtonskill = driver.FindElement(By.XPath("//input[@type=\"button\" and contains(@class, \"ui teal button\") and @value=\"Add\"]"));
            AddButtonskill.Click();

         }
        //to edit the skill
        public void EditLanguageSkill(IWebDriver driver)
        {
            //Click on the edit Button
            // Waitutilities.WaitToBeVisible(driver, "Id", "SaveButton", 2);

            IWebElement EditButtonskill = driver.FindElement(By.XPath("//input[@type=\"button\" and contains(@class, \"ui teal button\") and @value=\"Add\"]"));
            EditButtonskill.Click();
            
            Thread.Sleep(3000);

            //Edit language Textbox
            IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
            editCodeTextbox.Clear();
            editCodeTextbox.SendKeys("Hindi");
        }

        public void VerifyLoggedInUser(IWebDriver driver)
        {
            //Check if the user has logged in successfully
            IWebElement Hijojo = driver.FindElement(By.XPath("//span[@class='item ui dropdown link' and text()='Hi jojo']"));
            if (Hijojo.Text == "Hi jojo")
            {
                Console.WriteLine("User has logged in successfully");
            }
            else
            {
                Console.WriteLine("User hasn't been logged in :( :( :(");
            }
        }
    }
}
