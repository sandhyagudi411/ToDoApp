Feature: SpecFlowFeature2
	Sample features

Background: 
Given that I am on the Tech Crunch Website

@mytag
Scenario: TestCrunchPage	
	Then User should be able to view Login Link

@mytag
Scenario: TestCrunchPage_Login
When User clicks on Login Link
Then User should be able to view create account link
	
	