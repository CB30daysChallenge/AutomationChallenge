Feature: Login to the website
	
@login
Scenario: Login
	Given I am on ToDoMvc website
	When I have entered an Items to the list
	| items             |
	| Create C# project |
	| Add feature File  |
	| Implement code    |
	Then I should see the radio button infront of the added items
	And the count before Items left should match with active items
	And the items left, All, Ative, Completed labels are displayed
	And the All label is selected
	



















