using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LowCodeInternal_BusinessApps_Automation.Common.BasePage;
using NUnit.Framework;
using LowCodeInternal_BusinessApps_Automation.Common;

namespace LowCodeInternal_BusinessApps_Automation.PageObjects
{
    internal class CreateIvpProgramPage
    {
        internal IWebElement? approval => DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_Approval']"));
        internal IWebElement? status => DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_Status']"));
        internal IWebElement? shipStartDate => DriverManager.driver.FindElement(By.XPath("//div[@id='b4-Input_ShipStart2']//input[@id='b4-b4-Input_TextVar']"));
        internal IWebElement shipEndDate => DriverManager.driver.FindElement(By.XPath("//div[@id='b4-Input_ShipEnd2']//input[@id='b4-b7-Input_TextVar']"));
        internal IWebElement? year => DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_Year']"));
        internal IWebElement? nationalAcct => DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_NationalAcctInd']"));
        internal IWebElement? category => DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_Category']"));
        internal IWebElement? allBranches => DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_AllBranches']"));
        internal IWebElement? submitDate => DriverManager.driver.FindElement(By.XPath("//div[@id='b4-Input_SubmitDate2']//input[@id='b4-b1-Input_TextVar']"));
        internal IWebElement? payMode => DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_PayMode']"));
        internal IWebElement? salesType => DriverManager.driver.FindElement(By.XPath("//div[@id='b4-$b5']//../following-sibling::div//button[1]"));
        internal IWebElement? salesType1 => DriverManager.driver.FindElement(By.XPath("//div[@id='b4-$b5']//../following-sibling::div//button[2]"));
        internal IWebElement? salesType2 => DriverManager.driver.FindElement(By.XPath("//div[@id='b4-$b5']//../following-sibling::div//button[3]"));
        internal IWebElement? purchaseType => DriverManager.driver.FindElement(By.XPath("//div[@id='b4-$b6']//../following-sibling::div//button[1]"));
        internal IWebElement? purchaseType1 => DriverManager.driver.FindElement(By.XPath("//div[@id='b4-$b6']//../following-sibling::div//button[2]"));
        internal IWebElement? allCustomers => DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_AllCustomers']"));
        internal IWebElement? allShipTos => DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_AllShipTos']"));
        internal IWebElement? invoiceRequired => DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_InvoiceRequiredInd']"));
        internal IWebElement? calcFactor => DriverManager.driver.FindElement(By.XPath("//label[text()='Calc. Factor:']//../following-sibling::div//input"));
        internal IWebElement? ivpProgram => DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_IVPProgram']"));
        internal IWebElement? priceIncrease => DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_PriceIncrease']"));
        internal IWebElement? commodity => DriverManager.driver.FindElement(By.XPath("//select[@id='b4-Dropdown_CommodityInd']"));
        internal IWebElement? ownerNameClick => DriverManager.driver.FindElement(By.CssSelector(".drop-down-field-value"));
        internal IWebElement? ownerNameSearch => DriverManager.driver.FindElement(By.XPath("//div[@class='dropdown-search-box']//input"));
        internal IWebElement? ownerNameSelect => DriverManager.driver.FindElement(By.XPath("//div[@id='b4-b3-ChoicesList']//span"));
        internal IWebElement? groupId => DriverManager.driver.FindElement(By.XPath("//input[@id='b4-Input_GroupId']"));
        internal IWebElement? customerSearch => DriverManager.driver.FindElement(By.XPath("//label[@id='b4-Label_Customer']//../following-sibling::a"));
        internal IWebElement? customerClickDropdown => DriverManager.driver.FindElement(By.XPath("//div[@id='b4-LazyDropdownSearch_Customer']"));
        internal IWebElement? customerSearchTerm => DriverManager.driver.FindElement(By.XPath("//input[@id='b4-b8-Input_SearchTerm']"));
        internal IWebElement? customerSelect => DriverManager.driver.FindElement(By.XPath("//div[@class='choices__item needsclick choices__item--choice choices__item--selectable is-highlighted']//span"));
        internal IWebElement? supplierSearch => DriverManager.driver.FindElement(By.XPath("//label[@id='b4-Label_Supplier']//../following-sibling::a"));
        internal IWebElement? supplierClickDropdown => DriverManager.driver.FindElement(By.XPath("//div[@id='b4-LazyDropdownSearch_Supplier']"));
        internal IWebElement? supplierSearchTerm => DriverManager.driver.FindElement(By.XPath("//input[@id='b4-b10-Input_SearchTerm']"));
        internal IWebElement? supplierSelect => DriverManager.driver.FindElement(By.XPath("//div[@class='choices__item needsclick choices__item--choice choices__item--selectable is-highlighted']//span"));
        internal IWebElement? jobName => DriverManager.driver.FindElement(By.XPath("//input[@id='b4-Input_JobName']"));
        internal IWebElement? dealId => DriverManager.driver.FindElement(By.XPath("//input[@id='b4-Input_DealId']"));
        internal IWebElement? vendorProgramId => DriverManager.driver.FindElement(By.XPath("//input[@id='b4-Input_VendorProgramId']"));
        internal IWebElement? program => DriverManager.driver.FindElement(By.XPath("//input[@id='b4-Input_Program']"));
        internal IWebElement? comments => DriverManager.driver.FindElement(By.XPath("//textarea[@id='b4-TextArea_Comments']"));
        internal IWebElement? createProgramButton => DriverManager.driver.FindElement(By.XPath("//div[@id='b4-b12-Button']//button"));
        internal IWebElement? closeProgramButton => DriverManager.driver.FindElement(By.XPath("//div[@id='b1-Actions']//a"));
        internal IWebElement? getProgramCodeValue => DriverManager.driver.FindElement(By.XPath("//input[@id='b4-Input_ProgramCode']"));
        internal IWebElement? dashboardYearFilterClick => DriverManager.driver.FindElement(By.XPath("//div[@id='Dropdown_Year']"));
        internal IWebElement? dashboardStatusFilter => DriverManager.driver.FindElement(By.XPath("//input[@id='Input_Status']"));
        internal IWebElement? programSearchFilter => DriverManager.driver.FindElement(By.XPath("//input[@id='Input_Program']"));
        internal IWebElement? programLinkClick => DriverManager.driver.FindElement(By.XPath("//td[@data-header='Program']//a"));
        internal IWebElement? clickNoteTab => DriverManager.driver.FindElement(By.XPath("//div[@id='b5-TabHeader_Note']//span"));
        internal IWebElement? addNewNote => DriverManager.driver.FindElement(By.XPath("//button[text()='ADD NEW NOTE']"));
        internal IWebElement? addNote => DriverManager.driver.FindElement(By.XPath("//textarea[@id='b5-b49-TextArea_Note']"));
        internal IWebElement? AddNoteButton => DriverManager.driver.FindElement(By.XPath("//div[@class='btn-label OSInline']//span[text()='Add Note']//..//..//..//button"));
        internal IWebElement? programCodeOnEditScreen => DriverManager.driver.FindElement(By.XPath("//span[@class='OSFillParent']"));
        internal IWebElement? saveProgram => DriverManager.driver.FindElement(By.XPath("//div[@class='btn-label OSInline']//span[text()='SAVE PROGRAM']//..//..//..//button"));
    }
}
