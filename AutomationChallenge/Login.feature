Feature: Login to the website
	
@mytag
Scenario: Login
	Given I am on ToDoMvc anjularjs website
	When I have entered a task
	Then the entered task should be added to the Todo list
