using OpenQA.Selenium;
using ProjectMarsAutomation.utitlities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMarsAutomation.Pages
{
    internal class Skill:CommonDriver
    {
        private IWebElement SkillButton = driver.FindElement(By.XPath("//a[@class='item active' and @data-tab='second']"));
        private IWebElement AddNewSkillButton = driver.FindElement(By.XPath("//div[@class=\"ui teal button\"]"));
        //private IWebElement SkillTextBox = driver.FindElement(By.XPath("//div[@class='ui teal button' and contains(text(), 'Add New')]"));
        IWebElement SkillTextBox = driver.FindElement(By.XPath("//input[@type=\"text\" and @placeholder=\"Add Skill\" and @name=\"name\"]"));
        public void clickAddnewButton()
        {
            //Click on skill
            SkillButton.Click();
            //Click on add new button
            AddNewSkillButton.Click();

        }
        public void AddNewSkill(string skill, string skilllevel)
        {
                     
            //Enter skill
            // SkillTextBox.SendKeys(skill);
            //Enter skill
           
            SkillTextBox.SendKeys(skill);
            //choose level 
            IWebElement LevelDropdownskill = driver.FindElement(By.XPath("//select[@class=\"ui fluid dropdown\" and @name=\"level\"]"));
            LevelDropdownskill.Click();
            IWebElement LevelSelectionskill = driver.FindElement(By.XPath("//option[@value=\"Beginner\" and text()=\"Beginner\"]"));
            LevelSelectionskill.Click();
        }
        public void SaveNewSkill()
        {
            //Click on the Save Button
            // Waitutilities.WaitToBeVisible(driver, "Id", "SaveButton", 2);

            IWebElement AddButtonskill = driver.FindElement(By.XPath("//input[@type=\"button\" and contains(@class, \"ui teal button\") and @value=\"Add\"]"));
            AddButtonskill.Click();

        }
        //to edit the skill
        public void EditSkill()
        {
            //Click on skill

            // Waitutilities.WaitToBeVisible(driver, "Id", "SaveButton", 2);
            //Click on skill
          
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
        public void ChooseSkillLevel()
        {

        }
        public void UPdateSkill()
        {
            //Click on update button
            IWebElement UpdateButton = driver.FindElement(By.XPath("//input[@type='button' and @class='ui teal button' and @value='Update']"));
            UpdateButton.Click();
            Thread.Sleep(4000);

        }
        public void DeleteSkill()
        {
            //Click on delete button
           
            SkillButton.Click();
            IWebElement DeleteButton = driver.FindElement(By.XPath("//i[@class='remove icon']"));
            DeleteButton.Click();
            Thread.Sleep(4000);

        }
    }
}
