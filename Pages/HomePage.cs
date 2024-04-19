using OpenQA.Selenium;
namespace ProjectMarsAutomation.Pages
{
    internal class HomePage
    {
        private readonly By LanguageButtonLocator = By.XPath("//a[@class='item active' and @data-tab='first' and text()='Languages']");
        IWebElement LanguageButton;
        private readonly By SkillButtonLocator = By.XPath("//a[@class='item' and @data-tab='second' and text()='Skills']");
        IWebElement SkillButton;
        private readonly By AddNewButtonLocator = By.XPath("//div[@class='ui teal button ' and text()='Add New']");
        IWebElement AddNewButton;
        private readonly By AddNewSkillButtonLocator = By.XPath("//div[@class=\"ui teal button\"]");
        IWebElement AddNewSkillButton;
        public void AddNewLanguage(IWebDriver driver )
        {
            LanguageButton = driver.FindElement(LanguageButtonLocator);
            LanguageButton.Click();
            //Click on add new button
            AddNewButton = driver.FindElement(AddNewButtonLocator);
            AddNewButton.Click();

            //Enter language
            IWebElement LanguageTextBox = driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Language']"));
            LanguageTextBox.SendKeys("English");

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

        //to edit the language
        public void EditLanguage(IWebDriver driver )
        {
                        
            LanguageButton = driver.FindElement(LanguageButtonLocator);
            LanguageButton.Click();
            //Click on the edit Button
            // Waitutilities.WaitToBeVisible(driver, "Id", "SaveButton", 2);

                     IWebElement EditButtonLanguage = driver.FindElement(By.XPath("//span[@class='button']/i[@class='outline write icon']"));
            EditButtonLanguage.Click();
            Thread.Sleep(3000);
            //Enter language
                                         
            IWebElement LanguageTextBox = driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Language']"));
            LanguageTextBox.Click();
            LanguageTextBox.Clear();
            LanguageTextBox.Click();
            LanguageTextBox.SendKeys("Hindi");

            IWebElement LevelDropdownLanguage = driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='level']"));
            LevelDropdownLanguage.Click();
            IWebElement LevelSelectionLanguage = driver.FindElement(By.XPath("//option[@value='Conversational' and text()='Conversational']"));
            LevelSelectionLanguage.Click();
            
                    }
        public void UpdateLanguage(IWebDriver driver)
        {
            
            //Click on update button
            IWebElement UpdateButton = driver.FindElement(By.XPath("//input[@type='button' and @class='ui teal button' and @value='Update']"));
            UpdateButton.Click();
            Thread.Sleep(4000);

        }

        public void DeleteLanguage(IWebDriver driver)
        {
            
            LanguageButton = driver.FindElement(LanguageButtonLocator);
            LanguageButton.Click();
            //Click on delete button
            IWebElement DeleteButton = driver.FindElement(By.XPath("//i[@class='remove icon']"));
            DeleteButton.Click();
            Thread.Sleep(4000);

        }
            public void AddNewSkill(IWebDriver driver)
        {
            //Click on skill
            
            SkillButton = driver.FindElement(SkillButtonLocator);
            SkillButton.Click();
            //Click on add new button
            // IWebElement AddNewButton = driver.FindElement
            AddNewSkillButton = driver.FindElement(AddNewButtonLocator);
            AddNewSkillButton.Click();

            //Enter skill
            IWebElement SkillTextBox = driver.FindElement(By.XPath("//div[@class='ui teal button' and contains(text(), 'Add New')]"));
            SkillTextBox.SendKeys("Dance");

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
        public void EditSkill(IWebDriver driver)
        {
            //Click on skill

            // Waitutilities.WaitToBeVisible(driver, "Id", "SaveButton", 2);
            //Click on skill
            SkillButton = driver.FindElement(SkillButtonLocator);
            SkillButton.Click();
            //Click on the edit Button
            IWebElement EditButton = driver.FindElement(By.XPath("//i[@class='outline write icon']"));
            EditButton.Click();
            Thread.Sleep(3000);

            IWebElement SkillTextBox = driver.FindElement(By.XPath("//input[@type='text' and @name='name' and @placeholder='Add Skill']"));
            SkillTextBox.Click();
            SkillTextBox.Clear();
            SkillTextBox.Click();
            SkillTextBox.SendKeys("song");
            IWebElement LevelDropdownskill = driver.FindElement(By.XPath("//select[@class=\"ui fluid dropdown\" and @name=\"level\"]"));
            LevelDropdownskill.Click();
            IWebElement LevelSelectionskill = driver.FindElement(By.XPath("//option[@value=\"Intermediate\" and text()=\"Intermediate\"]"));
            LevelSelectionskill.Click();
            
        }
        public void UPdateSkill(IWebDriver driver)
        {
            //Click on update button
            IWebElement UpdateButton = driver.FindElement(By.XPath("//input[@type='button' and @class='ui teal button' and @value='Update']"));
            UpdateButton.Click();
            Thread.Sleep(4000);

        }
        public void DeleteSkill(IWebDriver driver)
        {
            //Click on delete button
            SkillButton = driver.FindElement(SkillButtonLocator);
            SkillButton.Click();
            IWebElement DeleteButton = driver.FindElement(By.XPath("//i[@class='remove icon']"));
            DeleteButton.Click();
            Thread.Sleep(4000);

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
