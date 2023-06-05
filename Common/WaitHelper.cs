using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static LowCodeInternal_BusinessApps_Automation.Common.BasePage;

namespace LowCodeInternal_BusinessApps_Automation.Common
{
    public static class WaitHelper
    {
        public static void WaitForElement(this IWebDriver driver, int timeoutInSeconds = 30)
        {
            int num = 2000;
            timeoutInSeconds *= 1000;
            bool flag;
            do
            {
                Thread.Sleep(num);
                flag = (bool)((IJavaScriptExecutor)driver).ExecuteScript("return (typeof jQuery != 'undefined')");
                timeoutInSeconds -= num;
            }
            while(!flag && timeoutInSeconds>0);
        }
    }
}
