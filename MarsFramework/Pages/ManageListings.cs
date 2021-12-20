using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MarsFramework.Pages
{
    internal class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]")]
        private IWebElement delete { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]")]
        private IWebElement yesButton { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]")]
        private IWebElement edit { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")]
        private IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]")]
        private IWebElement Save { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement clickActionsButton { get; set; }


        internal void EditManageListing()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");

            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[3]"), 10);
            manageListingsLink.Click();

            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]"), 10);
            edit.Click();

            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"), 10);
            string EditTitle = GlobalDefinitions.ExcelLib.ReadData(2, "Title");
            Title.Clear();
            Title.SendKeys(EditTitle);

            Save.Click();

        }
        internal void DeleteManageListing()
        {
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[3]"), 10);
            manageListingsLink.Click();

            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]"), 10);
            delete.Click();

            yesButton.Click();
        }


    }
}
