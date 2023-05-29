Feature: Work with currenicies try to add and delete

@positive
Scenario Outline: Add new currency
	Given user open home page https://opensource-demo.orangehrmlive.com/
	And user login into system
		| Field | Value    |
		| Admin | admin123 |
	When user choose admin tab
	And user choose Pay Grades from drop down menu
	And user add new pay grades
	And user enter min salary <Minsalary> and max salary <Maxsalary>
	And user click on save button
	Then user check min <Minsalary> and max <Maxsalary> salary added

Examples:
	| Minsalary | Maxsalary |
	| 1000      | 5000      |

@negative
Scenario Outline: Do not add new currency
	Given user open home page https://opensource-demo.orangehrmlive.com/
	And user login into system
		| Field | Value    |
		| Admin | admin123 |
	When user choose admin tab
	And user choose Pay Grades from drop down menu
	And user add new pay grades
	And user enter min salary <Minsalary> and max salary <Maxsalary>
	And user click on cancel button
	Then user check min and max salary did not added

Examples:
	| Minsalary | Maxsalary |
	| 1300      | 5600      |