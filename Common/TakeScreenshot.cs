using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LowCodeInternal_BusinessApps_Automation.Common.BasePage;

namespace LowCodeInternal_BusinessApps_Automation.Common
{
    public static class TakeScreenshot
    {
        public static void Screenshot()
        {
            for (int i = 1; i <= 2; i++)
            {
                var screenshot = DriverManager.driver.TakeScreenshot();
                string fileName = $"screenshot_{DateTime.Now.ToString("yyyyMMddHHmmss")}_{i}.png";
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Screenshots", fileName);
                screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Png);
            }
        }
    }
}
