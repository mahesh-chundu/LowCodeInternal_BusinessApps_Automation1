using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LowCodeInternal_BusinessApps_Automation.Common;
using OpenQA.Selenium;

namespace LowCodeInternal_BusinessApps_Automation.PageObjects
{
    internal class LoginPage_OktaPreview_PageObjects:BasePage
    {
        internal IWebElement? oktaUsername => DriverManager.driver.FindElement(By.XPath("//input[@id='okta-signin-username']"));
        internal IWebElement? oktaPassword => DriverManager.driver.FindElement(By.XPath("//input[@id='okta-signin-password']"));
        internal IWebElement? oktaSubmit => DriverManager.driver.FindElement(By.XPath("//input[@id='okta-signin-submit']"));
    }
}
