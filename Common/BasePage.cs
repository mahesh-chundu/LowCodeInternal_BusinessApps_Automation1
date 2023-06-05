using LowCodeInternal_BusinessApps_Automation.Actions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json;
using LowCodeInternal_BusinessApps_Automation.TestData;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace LowCodeInternal_BusinessApps_Automation.Common
{
    internal  class BasePage
    {
        public static class DriverManager
        {
            public static IWebDriver driver { get; set; } = null!;
        }
    }
}
namespace MyExtensionMethods
{
    public static class ExtensionMethods
    {
        public static CreateIvpProgramAction As<CreateIvpProgramAction>(this object CurrentPage) where CreateIvpProgramAction : class
        {
            return (CreateIvpProgramAction)CurrentPage;
        }
    }
}
namespace MyMethods
{
    public static class ExMethods
    {
        public static void WaitForReady(this IWebDriver DriverManager, int timeout = 300)
        {
            int num = 2000;
            timeout *= 1000;
            bool flag;
            do
            {
                Thread.Sleep(num);
                flag = (bool)((IJavaScriptExecutor)DriverManager).ExecuteScript("return jQuery.active == 0");
                timeout -= num;
            }
            while (!flag && timeout > 0);
        }
    }
}

