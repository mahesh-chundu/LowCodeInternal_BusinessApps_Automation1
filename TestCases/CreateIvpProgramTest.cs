using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using LowCodeInternal_BusinessApps_Automation.Actions;
using NUnit.Framework;
using OpenQA.Selenium;
using MyExtensionMethods;
using MyMethods;
using static LowCodeInternal_BusinessApps_Automation.Common.BasePage;
using LowCodeInternal_BusinessApps_Automation.Common;

namespace LowCodeInternal_BusinessApps_Automation.TestCases
{
    internal class CreateIvpProgramTest
    {
        CreateIvpProgramAction CurrentPage = new CreateIvpProgramAction();
        [SetUp]
        public void QA123_Login()
        {
            LoginPage_OktaPreview_ActionPage Okta = new LoginPage_OktaPreview_ActionPage();
            Okta.Login();
        }
        [TearDown]
        public void QA131_Quit()
        {
            DriverManager.driver.Quit();
        }
        [Test]
        public void QA124_AddNewProgram()
        {
            IvpDashboardAction ivpDashboardTest = new IvpDashboardAction();
            ivpDashboardTest.IVPAddNewProgram();
        }
        [Test]
        public void QA125_CreateProgram()
        {
            QA124_AddNewProgram();
            CurrentPage.As<CreateIvpProgramAction>().Approval();
            CurrentPage.As<CreateIvpProgramAction>().Status();
            CurrentPage.As<CreateIvpProgramAction>().ShipStartDate();
            CurrentPage.As<CreateIvpProgramAction>().ShipEndDate();
            CurrentPage.As<CreateIvpProgramAction>().Year();
            CurrentPage.As<CreateIvpProgramAction>().NationalAcct();
            CurrentPage.As<CreateIvpProgramAction>().Category();
            CurrentPage.As<CreateIvpProgramAction>().AllBranches();
            CurrentPage.As<CreateIvpProgramAction>().SubmitDate();
            CurrentPage.As<CreateIvpProgramAction>().PayMode();
            CurrentPage.As<CreateIvpProgramAction>().SalesType();
            CurrentPage.As<CreateIvpProgramAction>().PurchaseType();
            CurrentPage.As<CreateIvpProgramAction>().AllCustomers();
            CurrentPage.As<CreateIvpProgramAction>().AllShipTos();
            CurrentPage.As<CreateIvpProgramAction>().InvoiceRequired();
            CurrentPage.As<CreateIvpProgramAction>().CalcFactor();
            CurrentPage.As<CreateIvpProgramAction>().IvpProgram();
            CurrentPage.As<CreateIvpProgramAction>().PriceIncrease();
            CurrentPage.As<CreateIvpProgramAction>().Commodity();
            CurrentPage.As<CreateIvpProgramAction>().OwnerName();
            CurrentPage.As<CreateIvpProgramAction>().GroupId();
            CurrentPage.As<CreateIvpProgramAction>().CustomerSearch();
            CurrentPage.As<CreateIvpProgramAction>().SupplierSearch();
            CurrentPage.As<CreateIvpProgramAction>().JodName();
            CurrentPage.As<CreateIvpProgramAction>().DealId();
            CurrentPage.As<CreateIvpProgramAction>().VendorProgramId();
            CurrentPage.As<CreateIvpProgramAction>().Program();
            CurrentPage.As<CreateIvpProgramAction>().Comments();
            CurrentPage.As<CreateIvpProgramAction>().CreateProgram();
            CurrentPage.As<CreateIvpProgramAction>().GetProgramCodeValue();
            CurrentPage.As<CreateIvpProgramAction>().CloseProgram();
        }
        [Test]
        public void QA127_DashboardSearch()
        {
            CurrentPage.As<CreateIvpProgramAction>().DashboardYearFilter();
            CurrentPage.As<CreateIvpProgramAction>().DashboardStatusFilter();
            CurrentPage.As<CreateIvpProgramAction>().ClickExistingProgramLink();
            CurrentPage.As<CreateIvpProgramAction>().GetProgramCodeValue();
            
        }
        [Test]
        public void QA129_AddNotes() 
        {
            CurrentPage.As<CreateIvpProgramAction>().DashboardYearFilter();
            CurrentPage.As<CreateIvpProgramAction>().DashboardStatusFilter();
            CurrentPage.As<CreateIvpProgramAction>().ScrollDown();
            CurrentPage.As<CreateIvpProgramAction>().ClickExistingProgramLink();
            CurrentPage.As<CreateIvpProgramAction>().ClickNoteTab();
            CurrentPage.As<CreateIvpProgramAction>().SaveProgram();
            CurrentPage.As<CreateIvpProgramAction>().CloseProgram();
        }
        [Test]
        public void QA130_SelectExistingRebate()
        {
            CurrentPage.As<CreateIvpProgramAction>().DashboardYearFilter();
            CurrentPage.As<CreateIvpProgramAction>().DashboardStatusFilter();
            CurrentPage.As<CreateIvpProgramAction>().ClickExistingProgramLink();
            CurrentPage.As<CreateIvpProgramAction>().ClickNoteTab();
            CurrentPage.As<CreateIvpProgramAction>().SaveProgram();
            CurrentPage.As<CreateIvpProgramAction>().CloseProgram();
        }
    }
}
