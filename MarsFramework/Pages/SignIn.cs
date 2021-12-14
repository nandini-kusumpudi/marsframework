﻿using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MarsFramework.Pages
{
    class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }

        #endregion

        internal void LoginSteps()
        {
            GlobalDefinitions.driver.Navigate().GoToUrl("http://localhost:5000/");

            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Signin");

            //signinbutton
            //Click on Join button
            SignIntab.Click();

            //Enter Email
            string userName = GlobalDefinitions.ExcelLib.ReadData(2, "UserName");
            Email.SendKeys(userName);

            //Enter Password
            string userPassword = GlobalDefinitions.ExcelLib.ReadData(2, "Password");
            Password.SendKeys(userPassword);

            //click on login button
            LoginBtn.Click();
        }
    }
}