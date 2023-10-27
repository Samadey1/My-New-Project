Feature: Feature1

ACUk website Login Test 

@LoginTest
Scenario: [LoginTest]
	Given that I open the browser
	Then I enter the url link 
	And I click on login button
	Then I enter Email address of a registered user
	And I enter Password
	And I click remember me 
	Then I click on Log in
	And I validate user logged in 
	And then I click logout
	Then I see the website homepage loaded
	And I close browser