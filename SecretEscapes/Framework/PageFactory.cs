using SecretEscapes.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SecretEscapes.Framework
{
    public static class PageFactory
    {
        public static HomePage HomePage
        {

            get
            {
                var homePage = new HomePage();
                OpenQA.Selenium.Support.PageObjects.PageFactory.InitElements(Browser.webDriver, homePage);
                return homePage;
                
            }
        }
    }
}
