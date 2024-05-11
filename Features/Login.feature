Feature:Log in Feature


Scenario: 1- user is able to login to the system and view his profile
When enters valid username '<username>' and password '<password>' clicks login button 
Then User should be redirected to the home page and User should see his name on the topright 
Examples:
| username               | password  |
| jojojoseph93@gmail.com | 123456789 |

  

Scenario Outline: 2- User unable to log in with invalid credentials
When User enters invalid username '<username>' and/or password '<password>' clicks login button
Then User should see an error message

Examples:
| username               | password  |
| jojojoph93@gmail.com | 3456789 |

  Scenario Outline: 3- user uses huge payload of data
When User attempts to log in with a huge payload body to overflow the system clicks login button
Then User should see the validation message 

Scenario Outline: 4- User unable to log in with null username or password
When User attempts to log in with null username or password clicks login button
Then User should see the validation message



Scenario Outline: 5- Verify user is able to reset password 
When User clicks forgot password in the login page
Then user can enter emailid and click send verification email
