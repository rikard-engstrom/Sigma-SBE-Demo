Feature: Import Xml
To make our system operational we need to be able to import some xml data.

Scenario: Import email addresses
When the following xml data
| xml                           |
| <Emails>                      |
| <Email>one@mail.com</Email>   |
| <Email>two@mail.com</Email>   |
| <Email>three@mail.com</Email> |
| </Emails>                     |
When it is imported
Then the following email addresses should be stored
| Emails         |
| one@mail.com   |
| two@mail.com   |
| three@mail.com |