using NUnit.Framework;
using SecretEscapes.Framework;
using SecretEscapes.Utils;
using System;
using TechTalk.SpecFlow;

namespace SecretEscapes
{
    [Binding]
    public class WelcomePopupSteps
    {
        [Given(@"User opens the website")]
        public void GivenUserOpensTheWebsite()
        {
            Browser.InitilaizeDriver("Chrome");
            PageFactory.HomePage.NavigateToURL("https://www.secretescapes.com/");
            
        }
        
        [Given(@"Welcome pop up is displayed")]
        public void GivenWelcomePopUpIsDisplayed()
        {
            Assert.IsTrue(PageFactory.HomePage.SigninPopUp.Displayed);
            //comments
        }
        
        
        
        [When(@"user enters new email n@mi\.com")]
        public void WhenUserEntersNewEmailNMi_Com()
        {
            PageFactory.HomePage.EnterEmailAddress(Constants.Email);
        }
        
        [When(@"Tap on conitnue")]
        public void WhenTapOnConitnue()
        {
            PageFactory.HomePage.ClickLoginBtn();
        }
        
        
        
        [Then(@"Subscription pop up is displayed")]
        public void ThenSubscriptionPopUpIsDisplayed()
        {
            Assert.IsTrue(PageFactory.HomePage.Step2Popup.Displayed);
            Browser.webDriver.Quit();
            
        }
        
        
    }
}
