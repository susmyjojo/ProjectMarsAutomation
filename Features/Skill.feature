Feature:Skill Feature


Scenario Outline:1- user is able to add a Skill and choose a level and save
Given Given enters valid username '<username>' and password '<password>'  clicks login button 
And user naviagate to skill tab and click Add new button
When User navigates to Skill tab and User adds a  '<skill>' with  '<level>' and clicks on Add button 
Then User should see the '<skill>' added to the profile

Examples:
| username               | password     | skill|  level     |
| jojojoseph93@gmail.com | 123456789    | SQL  |  Advanced  |



Scenario Outline:User is able to edit skill and level
Given User navigates to Skill tab
When User edits the <skill> to <new_skill> 
And User Edits the <level> to <new_level>
And User clicks on Update button to save changes
Then User should see the <new_skill> and <new_level>
Examples:
| skill | level        | new _skill | new_level    |
| SQL  | Advanced     | CPP       | Intermediate |
| Java   | Beginner     | Coding        | Advanced     |
| C#  | Intermediate | Testing         | Expert       |



Scenario Outline:User is able to delete skill
Given User navigates to Skill tab
When User deletes  <existing_skill>
Then User should not see the  <existing_skill> in the profile
Examples:
| existing_skill |

| SQL           |
| Java           |
| C#          |