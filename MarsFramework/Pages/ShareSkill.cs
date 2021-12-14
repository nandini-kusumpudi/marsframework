using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        internal void EnterShareSkill(object driver)
        {
            throw new NotImplementedException();
        }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        private IWebElement ServiceTypeOptions { get; set; }

        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationTypeOption { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }

        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTime { get; set; }

        //Click on monday StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement MondayStartTimeDropDown { get; set; }

        //Click on Tueday StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[4]/div[2]/input[1]")]
        private IWebElement TuedayStartTimeDropDown { get; set; }

        //Click on wednesday StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[5]/div[2]/input[1]")]
        private IWebElement WednesdayStartTimeDropDown { get; set; }

        //Click on thusday StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[6]/div[2]/input[1]")]
        private IWebElement ThusdayStartTimeDropDown { get; set; }

        //Click on friday StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[7]/div[2]/input[1]")]
        private IWebElement FridayStartTimeDropDown { get; set; }

        //Click on monday EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement MondayEndTimeDropDown { get; set; }

        //Click on tueday EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[4]/div[3]/input[1]")]
        private IWebElement TuedayEndTimeDropDown { get; set; }

        //Click on wednesday EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[5]/div[3]/input[1]")]
        private IWebElement WednesdayEndTimeDropDown { get; set; }

        //Click on thusday EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[6]/div[3]/input[1]")]
        private IWebElement ThusdayEndTimeDropDown { get; set; }

        //Click on friday EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[7]/div[3]/input[1]")]
        private IWebElement FridayEndTimeDropDown { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input")]
        private IWebElement SkillTradeOption { get; set; } 

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }
        public object GolbalDefinitions { get; private set; }

        internal void EnterShareSkill()
        {
            //click shareskill button
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");

            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//*[@id='account-profile-section']/div/section[1]/div/div[2]/a"), 10);
            ShareSkillButton.Click();

            //enter data in title field
            string sSTitle = GlobalDefinitions.ExcelLib.ReadData(2, "Title");
            Title.SendKeys(sSTitle);
           

            //enter data in Description field
            string sSDescription= GlobalDefinitions.ExcelLib.ReadData(2, "Description");
            Description.SendKeys(sSDescription);

            //enter data in CategoryDropDown field
            CategoryDropDown.Click();

            var selectElementForCategory = new SelectElement(CategoryDropDown);
            // select by text
            selectElementForCategory.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "CategoryDropDownData")); 

            //enter data in SubCategoryDropDown field
            SubCategoryDropDown.Click();
            var selectElementForSubCategory = new SelectElement(SubCategoryDropDown);
            // select by text
            selectElementForSubCategory.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategoryDropDownData"));

            //enter data in Tags field
            string sSTags = GlobalDefinitions.ExcelLib.ReadData(2, "Tags");
            Tags.SendKeys(sSTags);
            Tags.SendKeys(Keys.Enter);

            //enter data in ServiceTypeOptions field
            ServiceTypeOptions.Click();

            //enter data in LocationTypeOption field
            LocationTypeOption.Click();

            //enter data in StartDateDropDown field
            StartDateDropDown.Click();
            string sSStartDateDropDown = GlobalDefinitions.ExcelLib.ReadData(2, "StartDateDropDown");
            StartDateDropDown.SendKeys(sSStartDateDropDown);

            //enter data in EndTimeDropDown field
            EndDateDropDown.Click();
            string sSEndDateDropDown = GlobalDefinitions.ExcelLib.ReadData(2, "EndDateDropDown");
            EndDateDropDown.SendKeys(sSEndDateDropDown);

            // Monday check boxs
            IWebElement mondayCheckBox = Days.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));
            mondayCheckBox.Click();
            string sSMondayStartTimeDropDown = GlobalDefinitions.ExcelLib.ReadData(2, "MondayStartTimeDropDown");
            MondayStartTimeDropDown.SendKeys(sSMondayStartTimeDropDown);
            string sSMondayEndTimeDropDown = GlobalDefinitions.ExcelLib.ReadData(2, "MondayEndTimeDropDown");
            MondayEndTimeDropDown.SendKeys(sSMondayEndTimeDropDown);

            // Tueday check boxs
            IWebElement tuesdayCheckBox = Days.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input"));
            tuesdayCheckBox.Click();
            string sSTuedayStartTimeDropDown = GlobalDefinitions.ExcelLib.ReadData(2, "TuedayStartTimeDropDown");
            TuedayStartTimeDropDown.SendKeys(sSTuedayStartTimeDropDown);
            string sSTuedayEndTimeDropDown = GlobalDefinitions.ExcelLib.ReadData(2, "TuedayEndTimeDropDown");
            TuedayEndTimeDropDown.SendKeys(sSTuedayEndTimeDropDown);
            
            // wednesday check boxs
            IWebElement wednessdayCheckBox = Days.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[1]/div/input"));
            wednessdayCheckBox.Click();
            string sSWednesdayStartTimeDropDown = GlobalDefinitions.ExcelLib.ReadData(2, "WednesdayStartTimeDropDown");
            WednesdayStartTimeDropDown.SendKeys(sSWednesdayStartTimeDropDown);
            string sSWednesdayEndTimeDropDown = GlobalDefinitions.ExcelLib.ReadData(2, "WednesdayEndTimeDropDown");
            WednesdayEndTimeDropDown.SendKeys(sSWednesdayEndTimeDropDown);

            // Thusday check boxs
            IWebElement thusdayCheckBox = Days.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[1]/div/input"));
            thusdayCheckBox.Click();
            string sSThusdayStartTimeDropDown = GlobalDefinitions.ExcelLib.ReadData(2, "ThusdayStartTimeDropDown");
            ThusdayStartTimeDropDown.SendKeys(sSThusdayStartTimeDropDown);
            string sSThusdayEndTimeDropDown = GlobalDefinitions.ExcelLib.ReadData(2, "ThusdayEndTimeDropDown");
            ThusdayEndTimeDropDown.SendKeys(sSThusdayEndTimeDropDown);
           
            // friday check boxs
            IWebElement fridayCheckBox = Days.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[7]/div[1]/div/input"));
            fridayCheckBox.Click();
            string sSFridayStartTimeDropDown = GlobalDefinitions.ExcelLib.ReadData(2, "FridayStartTimeDropDown");
            FridayStartTimeDropDown.SendKeys(sSFridayStartTimeDropDown);
            string sSFridayEndTimeDropDown = GlobalDefinitions.ExcelLib.ReadData(2, "FridayEndTimeDropDown");
            FridayEndTimeDropDown.SendKeys(sSFridayEndTimeDropDown);

            //enter data in SkillTradeOption field
            SkillTradeOption.Click();

            //enter data in creditamount field
            string sSCreditAmount = GlobalDefinitions.ExcelLib.ReadData(2, "CreditAmount");
            CreditAmount.SendKeys(sSCreditAmount);

            //enter data in Active field
            ActiveOption.Click();

            //click save button
            Save.Click();
        }

        internal void EditShareSkill()
        {

        }
    }
}
