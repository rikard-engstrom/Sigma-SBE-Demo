Feature: Search for customers by name
When customers come to our office our staff must be able find them in our system to minimize the effort of our staff as well as the wait for our customers. 
The most common way of doing this is to type in the customers name in the search bar. 
Since this is often done under stressful situations the search should be forgiving when it comes of spelling mistakes.

Background: 
Given that the following customers exists in the database
| Given name  | Family name | Email                   |
| Anton       | Ericsson    | anton@mail.com          |
| Lars-Magnus | Eriksson    | lm.eriksson@ericsson.se |
| Avantgarde  | Ericzon     | myggan@sticket.se       |
| Jonny       | Erixon      | thex@gmail.com          |

Scenario: Search for Ericsson should also find Eriksson
When searching for 'Ericsson'
Then the result includes all these customers
| Given name  | Family name | Email                   |
| Anton       | Ericsson    | anton@mail.com          |
| Lars-Magnus | Eriksson    | lm.eriksson@ericsson.se |