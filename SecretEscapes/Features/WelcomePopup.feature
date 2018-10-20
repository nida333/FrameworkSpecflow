Feature: WelcomePopup
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers
	

@Testcase1
Scenario: Verify the  subscription pop up is displayed when user taps on continue
Given  User opens the website
And    Welcome pop up is displayed
When  user enters new email n@mi.com
And    Tap on conitnue
Then  Subscription pop up is displayed

