Feature: SpecFlowScenarioOutlineFeature
	Sample features

Scenario Outline: Login with Spotify Website
Given user navigates to Spotify Website
When User should be able to view Login button and User clicks on Login button
And User enters Username as '<username>' and Password as '<password>'
Then the login should be successful
Examples:
| username               | password  |
| snehahegde51@yahoo.com | Sneha@51  |
| abcxyz91@rediff.com    | AbcXyz@91 |



	
	