Feature: Clinical view


@Smoke
Scenario Outline: Navigation to login
Given I login to application
When I select Praticiner and Login as "<DcotorName>"
And I search for a Patient "<PatientName>"
And I logout
Examples:
| DcotorName | PatientName |
|abc|pqr|	
|abc|pqr|
