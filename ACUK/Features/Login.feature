Feature: LoginTest

Navigate to ACUK website and login with a registered email

@LoginTest
Scenario:Login Test to ACUK website

Given that I open the browser
Then I enter the ACUK url link 
And I click on login button
Then I input Email address of a registered user
And I enter Password
And I select remember me button 
When then I click on login
Then I validate user logged in 
And then I click the logout button 
And I see the website homepage loaded
And I close browser


