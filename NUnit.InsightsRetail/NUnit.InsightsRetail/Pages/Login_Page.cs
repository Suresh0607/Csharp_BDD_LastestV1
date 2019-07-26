using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUnit.InsightsRetail
{
    public class Login_Page
    {
        private IWebDriver LoginDriver;

        public Login_Page(IWebDriver driver)
        {
            this.LoginDriver = driver;
            
        }

        public void gotologinPage(string userName)
        {
            try
            {
                LoginDriver.Navigate().GoToUrl("https://ce.invigorinsights.com/login.php");
                new WebDriverWait(LoginDriver, TimeSpan.FromSeconds(500000)).Until(
                 d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
                LoginDriver.Manage().Window.Maximize();
                LoginDriver.FindElement(By.XPath("//*[@id='userName']")).SendKeys(userName);
                LoginDriver.FindElement(By.XPath("//*[@id='password']")).SendKeys("Test@123");
                LoginDriver.FindElement(By.XPath("/html/body/div/div/div[1]/div/div[2]/form/fieldset/div[6]/div[2]/button")).Click();
            }catch(Exception e)
            {
                throw (e);
            }
            
        }
    }
}
