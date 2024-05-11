Feature:Language Feature




Scenario Outline:1- user is able to add a language and choose a level and save
Given enters valid username '<username>' and password '<password>'  clicks login button 
When user naviagate to language tab and click Add new button
And User adds a language '<language>' with level '<level>' clicks  Add button
Then User should see the language '<language>' '<level>' added to the profile

Examples:
| username               | password     | language |  level     |
| jojojoseph93@gmail.com | 123456789    | English  |  Advanced  |



Scenario Outline:2-User is able to edit language and level
Given User navigates to Language tab
When User edits the existing '<language>' to '<new_language>' 
And User Edits the Language '<level>' to '<new_level>'
And User clicks on Update button to save language changes
Then User should see the '<new_language>' and '<new_level>'
Examples:
| language | level        | new _language | new_level    |
| English  | Advanced     | Hindi         | Intermediate |
| French   | Beginner     | Arabic        | Advanced     |
| Spanish  | Intermediate | Tamil         | Expert       |



Scenario Outline:3-User is able to delete language
Given User navigates to Language tab
When User deletes  '<existing_language>'
Then User should not see the  '<existing_language>' in the profile
Examples:
| existing_language |

| English           |
| French            |
| Spanish           |