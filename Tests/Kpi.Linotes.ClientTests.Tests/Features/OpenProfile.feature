@Regression
@OpenProfile
Feature: Open Profile
	Verify the posibility to open user profile from notes page

@Smoke
Scenario: 1. Verify the posibility to open user profile from notes page
	Given I logged in application as ValidUser
	When I click 'Cabinet' button
	Then I see 'Личный кабинет' as title of the page
