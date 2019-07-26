using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using BoDi;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.InsightsRetail.CommonClasses;
using NUnit.InsightsRetail.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using TechTalk.SpecFlow;
using Unity;

namespace NUnit.InsightsRetail.Steps
{
    [Binding]
    public class ReportSteps
    {
        private IWebDriver _driver;        
        MyReports_Page myReportsPage;
        Login_Page login_Page;
        private readonly ScenarioContext scenarioContext;
        private readonly FeatureContext featureContext;

        public ReportSteps(IWebDriver driver)
        {
            this._driver = driver;
        }

        [Given(@"user (.*) logs into the CE Client application")]
        public void GivenUserLogsIntoTheCEClientApplication(string userName)
        {
            this.login_Page = new Login_Page(_driver);
            this.login_Page.gotologinPage(userName);
           

        }

        [Then(@"user logout")]
        public void User_Logout()
        {
            _driver.FindElement(By.XPath("/html/body/div/div[1]/div[1]/a[3]")).Click();
          
        }
        
        [Then(@"user NaviateTo ""(.*)"" in ""(.*)""")]
        public void Then_User_Naviate_To(string MainMenu, string SubMenu)
        {
            myReportsPage = new MyReports_Page(_driver);
            myReportsPage.goTo_MyReportsPage();
            Console.WriteLine("Then_User_Naviate_To");
        }
        
        [Then(@"Click on ""(.*)""")]
        public void ClickOn(string ObjectName)
        {
            myReportsPage = new MyReports_Page(_driver);
            myReportsPage.clickon(ObjectName);
            Console.WriteLine("ClickOn"+ ObjectName);
        }

      
        [Then(@"SelectRadioButton as ""(.*)""")]
        public void SelectRadioButton(string radioButton)
        {
            myReportsPage = new MyReports_Page(_driver);
            myReportsPage.clickon(radioButton);
            Console.WriteLine("SelectRadioButton" + radioButton);
        }


        [Then(@"Enter ""(.*)"" as (.*)")]
        public void Enter(string ObjectName, string ObjectValue)
        {
            myReportsPage = new MyReports_Page(_driver);
            myReportsPage.enter(ObjectName, ObjectValue);
            Console.WriteLine("Enter" + ObjectName);
        }
               
        [Then(@"Select ""(.*)"" as (.*)")]
        public void Select(string ListName, string ListValue)
        {
            myReportsPage = new MyReports_Page(_driver);
            myReportsPage.select(ListName, ListValue);
            Console.WriteLine("Select" + ListName);
        }
        
        [Then(@"Download Report and Verify")]
        public void DownloadReportAndVerify()
        {
           
        }
    }
}
