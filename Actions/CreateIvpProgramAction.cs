using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using LowCodeInternal_BusinessApps_Automation.PageObjects;
using Newtonsoft.Json;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using static LowCodeInternal_BusinessApps_Automation.Common.BasePage;
using LowCodeInternal_BusinessApps_Automation.TestData;
using NUnit.Framework;
using System.Runtime.CompilerServices;
using LowCodeInternal_BusinessApps_Automation.Common;

namespace LowCodeInternal_BusinessApps_Automation.Actions
{
    internal class CreateIvpProgramAction:CreateIvpProgramPage
    {
        private string inputValue;
        internal CreateIvpProgramAction Approval() 
        {
            Data data = JsonDataProvider.GetData();
            SelectElement dropdown = new SelectElement(approval);
            dropdown.SelectByValue(data?.Approval);
            return this;
        }
        internal CreateIvpProgramAction Status()
        {
            Data data = JsonDataProvider.GetData();
            SelectElement dropdown = new SelectElement(status);
            dropdown.SelectByValue(data?.Status);
            return this;

        }
        internal CreateIvpProgramAction ShipStartDate()
        {
            Data data = JsonDataProvider.GetData();
            shipStartDate?.SendKeys(data?.StartDate);
            return this;

        }
        internal CreateIvpProgramAction ShipEndDate()
        {
            Data data = JsonDataProvider.GetData();
            WaitHelper.WaitForElement(DriverManager.driver, 10);
            shipEndDate?.SendKeys(data?.EndDate);
            return this;
        }
        internal CreateIvpProgramAction Year()
        {
            Data data = JsonDataProvider.GetData();
            SelectElement dropdown = new SelectElement(year);
            dropdown.SelectByValue(data?.Year);
            return this;

        }
        internal CreateIvpProgramAction NationalAcct()
        {
            Data data = JsonDataProvider.GetData();
            SelectElement dropdown = new SelectElement(nationalAcct);
            dropdown.SelectByValue(data?.NationalAcct);
            return this;

        }
        internal CreateIvpProgramAction Category()
        {
            Data data = JsonDataProvider.GetData();
            SelectElement dropdown = new SelectElement(category);
            dropdown.SelectByValue(data?.Category);
            return this;

        }
        internal CreateIvpProgramAction AllBranches()
        {
            Data data = JsonDataProvider.GetData();
            SelectElement dropdown = new SelectElement(allBranches);
            dropdown.SelectByValue(data?.AllBranches);
            return this;

        }
        internal CreateIvpProgramAction SubmitDate()
        {
            Data data = JsonDataProvider.GetData();
            submitDate?.SendKeys(data?.SubmitDate);
            return this;
        }
        internal CreateIvpProgramAction PayMode()
        {
            Data data = JsonDataProvider.GetData();
            SelectElement dropdown = new SelectElement(payMode);
            dropdown.SelectByValue(data?.PayMode);
            return this;

        }
        internal CreateIvpProgramAction SalesType()
        {
            Data data = JsonDataProvider.GetData();
            if (data?.SalesType == "1")
            {
                salesType?.Click();
            }
            else if (data?.SalesType == "2")
            {
                salesType1?.Click();
            }
            else
            {
                salesType2?.Click();
            }
            return this;

        }
        internal CreateIvpProgramAction PurchaseType()
        {
            Data data = JsonDataProvider.GetData();
            if (data?.PurType == "1")
            {
                purchaseType?.Click();
            }
            else
            {
                purchaseType1?.Click();
            }
            return this;
        }
        internal CreateIvpProgramAction AllCustomers()
        {
            Data data = JsonDataProvider.GetData();
            SelectElement dropdown = new SelectElement(allCustomers);
            dropdown.SelectByValue(data?.AllCustomers);
            return this;
        }
        internal CreateIvpProgramAction AllShipTos()
        {
            Data data = JsonDataProvider.GetData();
            SelectElement dropdown = new SelectElement(allShipTos);
            dropdown.SelectByValue(data?.AllShipTos);
            return this;
        }
        internal CreateIvpProgramAction InvoiceRequired()
        {
            Data data = JsonDataProvider.GetData();
            SelectElement dropdown = new SelectElement(invoiceRequired);
            dropdown.SelectByValue(data?.InvoiceRequired);
            return this;
        }
        internal CreateIvpProgramAction CalcFactor()
        {
            Data data = JsonDataProvider.GetData();
            calcFactor?.SendKeys(data?.CalcFactor);
            return this;
        }
        internal CreateIvpProgramAction IvpProgram()
        {
            Data data = JsonDataProvider.GetData();
            SelectElement dropdown = new SelectElement(ivpProgram);
            dropdown.SelectByValue(data?.IvpProgram);
            return this;

        }
        internal CreateIvpProgramAction PriceIncrease()
        {
            Data data = JsonDataProvider.GetData();
            SelectElement dropdown = new SelectElement(priceIncrease);
            dropdown.SelectByValue(data?.PriceIncrease);
            return this;

        }
        internal CreateIvpProgramAction Commodity()
        {
            Data data = JsonDataProvider.GetData();
            SelectElement dropdown = new SelectElement(commodity);
            dropdown.SelectByValue(data?.Commodity);
            return this;

        }
        internal CreateIvpProgramAction OwnerName()
        {
            Data data = JsonDataProvider.GetData();
            WaitHelper.WaitForElement(DriverManager.driver, 10);
            ownerNameClick?.Click();
            Thread.Sleep(1000);
            ownerNameSearch?.SendKeys(data?.OwnerName);
            Thread.Sleep(1000);
            ownerNameSelect?.Click();
            return this;
        }
        internal CreateIvpProgramAction GroupId()
        {
            Data data = JsonDataProvider.GetData();
            groupId?.SendKeys(data?.GroupId);
            return this;
        }
        internal CreateIvpProgramAction CustomerSearch()
        {
            Data data = JsonDataProvider.GetData();
            WaitHelper.WaitForElement(DriverManager.driver, 10);
            customerSearch?.Click();
            customerClickDropdown?.Click();
            customerSearchTerm?.SendKeys(data?.CustomerSearch);
            customerSelect?.Click();
            return this;
        }
        internal CreateIvpProgramAction SupplierSearch()
        {
            Data data = JsonDataProvider.GetData();
            WaitHelper.WaitForElement(DriverManager.driver, 10);
            supplierSearch?.Click();
            supplierClickDropdown?.Click();
            supplierSearchTerm?.SendKeys(data?.SupplierSearch);
            supplierSelect?.Click();
            return this;
        }
        internal CreateIvpProgramAction JodName()
        {
            Data data = JsonDataProvider.GetData();
            jobName?.SendKeys(data?.JobName);
            return this;
        }
        internal CreateIvpProgramAction DealId()
        {
            Data data = JsonDataProvider.GetData();
            dealId?.SendKeys(data?.DealId);
            return this;
        }
        internal CreateIvpProgramAction VendorProgramId()
        {
            Data data = JsonDataProvider.GetData();
            vendorProgramId?.SendKeys(data?.VendorProgramId);
            return this;
        }
        internal CreateIvpProgramAction Program()
        {
            Data data = JsonDataProvider.GetData();
            program?.SendKeys(data?.Program);
            return this;
        }
        internal CreateIvpProgramAction Comments()
        {
            Data data = JsonDataProvider.GetData();
            comments?.SendKeys(data?.Comments);
            return this;
        }
        internal CreateIvpProgramAction CreateProgram()
        {
            createProgramButton?.Click();
            return this;
        }
        internal CreateIvpProgramAction GetProgramCodeValue()
        {
            WaitHelper.WaitForElement(DriverManager.driver, 10);
            inputValue = getProgramCodeValue.GetAttribute("value");
            return this;

        }
        internal CreateIvpProgramAction CloseProgram()
        {
            WaitHelper.WaitForElement(DriverManager.driver, 10);
            closeProgramButton?.Click();
            return this;
        }
        internal CreateIvpProgramAction DashboardYearFilter()
        {
            Data data = JsonDataProvider.GetData();
            WaitHelper.WaitForElement(DriverManager.driver, 10);
            var num = data?.DashboardYearDropdown;
            dashboardYearFilterClick?.Click();
            IWebElement dashboardYearFilterSelect = DriverManager.driver.FindElement(By.XPath($"//div[@id='Dropdown_Year']//div[@data-value='{num}']"));
            dashboardYearFilterSelect.Click();
            return this;
        }
        internal CreateIvpProgramAction DashboardStatusFilter()
        {
            Data data = JsonDataProvider.GetData();
            WaitHelper.WaitForElement(DriverManager.driver, 10);
            dashboardStatusFilter?.SendKeys(data?.DashboardStatusFilter);
            dashboardStatusFilter?.SendKeys(Keys.Enter);
            return this;
        }
        internal CreateIvpProgramAction ScrollDown()
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)DriverManager.driver;
            jsExecutor.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(10000);
            return this;    
        }
        internal CreateIvpProgramAction ClickProgramLink()
        {
            WaitHelper.WaitForElement(DriverManager.driver, 10);
            string value = inputValue;
            programSearchFilter.SendKeys(value);
            Thread.Sleep(1000);
            programSearchFilter?.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            programLinkClick?.Click();
            return this;
        }
        internal CreateIvpProgramAction ClickExistingProgramLink()
        {
            WaitHelper.WaitForElement(DriverManager.driver, 10);
            programLinkClick?.Click();
            return this;
        }
        internal CreateIvpProgramAction ClickNoteTab()
        {
            Data data = JsonDataProvider.GetData();
            WaitHelper.WaitForElement(DriverManager.driver, 10);
            clickNoteTab?.Click();
            addNewNote?.Click();
            addNote?.SendKeys(data?.Note);
            AddNoteButton?.Click();
            return this;
        }
        internal CreateIvpProgramAction SaveProgram()
        {
            WaitHelper.WaitForElement(DriverManager.driver, 10);
            saveProgram?.Click();
            return this;
        }

    }
    
}