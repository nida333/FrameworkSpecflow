using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SecretEscapes.Framework;

namespace SecretEscapes.PageObjects
{
    public class HomePage
    {
        [FindsBy(How = How.Id, Using = "sign-in-and-sign-up")]
        public IWebElement SigninPopUp;
        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement EmailField;
        [FindsBy(How = How.Id, Using = "loginButton")]
        public IWebElement LoginBtn;
        [FindsBy(How = How.Id, Using = "iaStepTwo")]
        public IWebElement Step2Popup;
        [FindsBy(How = How.Id, Using = "optOutLink")]
        public IWebElement OutBtn;
        [FindsBy(How = How.Id, Using = "setPasswordContainer")]
        public IWebElement PasswordContainer;
        [FindsBy(How = How.CssSelector, Using = "a[title='Close']")]
        public IWebElement ClosePopupBtn;
        [FindsBy(How = How.Id, Using = "main-container")]
        public IWebElement MainContainer;

       

        public void EnterEmailAddress(string email)
        {
            EmailField.SendKeys(email);
        }

        public void ClickLoginBtn()
        {
            LoginBtn.Click();
        }

       
        public void ClickOptOutBtn()
        {
            OutBtn.Click();
        }
       

        public void CloseSetPasswordPopup()
        {
            ClosePopupBtn.Click();
        }


        public  void NavigateToURL(string url)
        {
            try { 
            Browser.webDriver.Navigate().GoToUrl(url);
            }
            catch(Exception e)
            {

            }
        }


    }
}
