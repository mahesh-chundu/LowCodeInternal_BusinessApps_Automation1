using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LowCodeInternal_BusinessApps_Automation.Common.BasePage;

namespace LowCodeInternal_BusinessApps_Automation.PageObjects
{
    internal class IvpDashboardPage
    {
        internal IWebElement? AddNewProgram_Button => DriverManager.driver.FindElement(By.XPath("//button[text()='ADD NEW PROGRAM']"));
        internal IWebElement? dashboardYearFilterClick => DriverManager.driver.FindElement(By.XPath("//div[@id='Dropdown_Year']"));
        internal IWebElement? dashboardStatusFilter => DriverManager.driver.FindElement(By.XPath("//input[@id='Input_Status']"));
        internal IWebElement? programSearchFilter => DriverManager.driver.FindElement(By.XPath("//input[@id='Input_Program']"));
        internal IWebElement? programLinkClick => DriverManager.driver.FindElement(By.XPath("//td[@data-header='Program']//a"));
    }
}
