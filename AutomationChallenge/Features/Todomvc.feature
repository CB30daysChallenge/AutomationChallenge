Feature: Login to the website

Background: 
Given I am on ToDoMvc website
	When I have entered an Items to the list
	| items             |
	| Create C# project |
	| Add feature File  |
	| Implement code    |
	| Add Exceptions to code    |
	| Implement Jenkins   |

@login
Scenario: Login
	When I click on radio button against the below items
	| items             |
	| Create C# project |
	| Add feature File  |
	Then I should see these items are appeared under completed
	And the count before Items left should match with active items
	And the items left, All, Ative, Completed labels are displayed
	And the All label is selected by default
	

