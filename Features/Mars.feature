Feature: This test suite contains text scenarios for the following

1.user logins to the system
2.User able to choose a language and skil.
3.User able to add the language and skill to profile

Scenario: user is able to login and add a language and choose a  level and save
Given User logins to the project mars page and views own profile 
When User enters a  language and choose a level 
Then user clicks add and save the language

Scenario: Verify user is able to login with inavalid username and password
Given User clicks sign in option to the project mars page
When User enters a  wrong user id and password
Then  user enters emailid and click send verification email

Scenario: Verify user is able to reset password 
Given User clicks sign in option to the project mars page 
When User clicks forgot password
Then user enters emailid and click send verification email

Scenario Outline: Verify user is able to login and edit language and edit the level
Given User logins to the project mars page and views own profile 
When user clicksthe edit button to edit the new language added and level
Then user clicks update and save the changes

Scenario: Verify user is able to login and delet language 
Given User logins to the project mars page and views own profile 
When user clicks the delete button to delet the new language added 


Scenario: Verify user is able to login and add a skill and choose a level and save
Given User logins to the project mars page and views own profile 
When User enters a skill and choose a level
Then user clicks add and save the skill

Scenario: Verify user is able to login and add edit skill and edit a level and save
Given User logins to the project mars page and views own profile
When User clikcs edit button to edit a skill and the level
Then user clicks update and save the skills changes


Scenario: Verify user is able to login and delet skill 
Given User logins to the project mars page and views own profile
When user clicks the delete button to delet the new skill added 