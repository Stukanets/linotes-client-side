@Regression
@Login
Feature: Login
	Verify the ability to login

@Smoke
Scenario: 1. Verify Login as registered user field by field
	Given I have ValidUser user
	When I login to application
	Then I see user login 'Egumas24' in left bar

Scenario: 2. Verify Login as invalid user field by field
	Given I have InvalidUser user
	When I login to application
	Then I see 'ОШИБКА' message
