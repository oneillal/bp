Feature: SpecFlowFeature1
	Given values for Systolic and Diastolic
	calculate the blood pressure and it's 
	associated category

@bpnormal
Scenario: Calculate normal blood pressure
	Given I run the application
	And I have entered 100 into systolic field
	And I have entered 63 into the diastolic field
	Then the result should be normal on the screen

@bplow
Scenario: Calculate low blood pressure
	Given I run the application
	And I have entered 88 into systolic field
	And I have entered 55 into the diastolic field
	Then the result should be low on the screen

@bpprehigh
Scenario: Calculate prehigh blood pressure
	Given I run the application
	And I have entered 121 into systolic field
	And I have entered 86 into the diastolic field
	Then the result should be prehigh on the screen

@bphigh
Scenario: Calculate high blood pressure
	Given I run the application
	And I have entered 144 into systolic field
	And I have entered 99 into the diastolic field
	Then the result should be high on the screen