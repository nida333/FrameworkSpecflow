using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecretEscapes.Helpers;

namespace SecretEscapes.Framework
{
    public static class Browser
    {
        public static IWebDriver webDriver;
        public static object WebDriver { get; internal set; }
       // public static object ConfigurationManager { get; private set; }

        private static FirefoxOptions GetFirefoxOptions()
        {
            FirefoxProfileManager manager = new FirefoxProfileManager();
            FirefoxOptions options = new FirefoxOptions();
            {
                var profileManager = new FirefoxProfileManager();
                FirefoxProfile profile = profileManager.GetProfile("default");
                // IWebDriver driver = new FirefoxDriver(profile);
                // FirefoxProfile = manager.GetProfile("default"),

                options.AcceptInsecureCertificates = true;
            };

            return options;
        }

        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized");
            option.AddArgument("enable-automation");
            option.AddArgument("--disable-infobars");
            return option;
        }
        private static InternetExplorerOptions GetIEOptions()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            options.EnsureCleanSession = true;
            options.ElementScrollBehavior = InternetExplorerElementScrollBehavior.Bottom;
            return options;
        }

        private static FirefoxDriver GetFirefoxDriver()
        {
            FirefoxOptions options = new FirefoxOptions();
            FirefoxDriver driver = new FirefoxDriver(GetFirefoxOptions());
            return driver;
        }

        private static ChromeDriver GetChromeDriver()
        {
            ChromeDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }
        private static InternetExplorerDriver GetIEDriver()
        {
            InternetExplorerDriver driver = new InternetExplorerDriver(GetIEOptions());
            return driver;
        }
        public static void InitilaizeDriver(string BrowserName)
        {
            switch (BrowserName)
            {
                case "Firefox":
                    webDriver = GetFirefoxDriver();

                    break;

                case "Chrome":
                    webDriver = GetChromeDriver();
                    break;

                case "IExplorer":
                    webDriver = GetIEDriver();
                    break;
            }
            //specify the page load timeout duration
            webDriver.Manage()
                  .Timeouts().PageLoad = TimeSpan.FromSeconds(Convert.ToDouble(ConfigurationManager.AppSettings.Get("PageLoadTimeout")));
            //specify the element load timeout duration
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Convert.ToDouble(ConfigurationManager.AppSettings.Get("ElementLoadTimeout")));
            BrowserHelper.BrowserMaximize();
        }
    }
}