using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LowCodeInternal_BusinessApps_Automation.PageObjects;
using Newtonsoft.Json;
using NUnit.Framework;
using OpenQA.Selenium;
using static LowCodeInternal_BusinessApps_Automation.Common.BasePage;
using LowCodeInternal_BusinessApps_Automation.TestData;

namespace LowCodeInternal_BusinessApps_Automation.Actions
{
    internal class IvpDashboardAction:IvpDashboardPage
    {
        internal IvpDashboardAction IVPAddNewProgram() 
        {
            DriverManager.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            AddNewProgram_Button?.Click();
            return this;
        }
        
    }
}
