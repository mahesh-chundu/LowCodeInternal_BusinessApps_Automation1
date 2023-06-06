using log4net;
using log4net.Config;
using OpenQA.Selenium.DevTools.V111.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowCodeInternal_BusinessApps_Automation.Common
{
    public static class ErrorLog
    {
        public static void ErrorMessage(Exception ex)
        {
            ILog log = LogManager.GetLogger(typeof(ErrorLog));
            XmlConfigurator.Configure(new FileInfo("log4net.config"));
            log.Error("An Exception occured:", ex);
        }
    }
}
