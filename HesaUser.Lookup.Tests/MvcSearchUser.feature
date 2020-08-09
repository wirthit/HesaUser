Feature: MvcSearchUsers
	Ability to lookup users from the admin page as a valid user

@mytag
Scenario: Lookup Robinson
	Given I am a user of the system
	And I search for a user by typing in Robinson into a text box on the admin page
	When I click search
	Then 2 matching results are shown on the admin page

Scenario: Lookup Wilson
	Given I am a user of the system
	And I search for a user by typing in Wilson into a text box on the admin page
	When I click search
	Then 2 matching results are shown on the admin page

Scenario: Lookup Robinson then Wilson
	Given I am a user of the system
	And I search for a user by typing in Wilson into a text box on the admin page
	And I search for a user by typing in Robinson into a text box on the admin page
	When I click search
	Then 2 matching results are shown on the admin page