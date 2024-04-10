Feature: This test suite contains text scenarios for the following

1.user logins to the system
2.User able to choose a language and skil.
3.User able to add the language and skill to profile

Scenario: Verify user is able to login and add a language and choose a skill level
Given User logins to the project mars page and views own profile
And User enters a  language and choose a level
And user clicks add and save the language
When user enters a skill and choose a level
Then user clicks add and save the language