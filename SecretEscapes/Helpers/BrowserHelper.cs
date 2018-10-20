using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading.Tasks;
using SecretEscapes.Framework;

namespace SecretEscapes.Helpers
{
    public static class BrowserHelper
    {
        public static void BrowserMaximize()

        {
            Browser.webDriver.Manage().Window.Maximize();
        }

        public static void GoBack()
        {
            Browser.webDriver.Navigate().Back();
        }
        public static void Forward()
        {
            Browser.webDriver.Navigate().Forward();
        }

        public static void RefreshPage()
        {
            Browser.webDriver.Navigate().Refresh();
        }
    }
}