Feature: Import Json
To make our system operational we need to be able to import some json data.

Scenario: Import email addresses
When the following json data
| json             |
| {"Emails":[      |
| "one@mail.com",  |
| "two@mail.com",  |
| "three@mail.com" |
| ]}               |
When it is imported
Then the following email addresses should be stored
| Emails         |
| one@mail.com   |
| two@mail.com   |
| three@mail.com |