Feature: UsingCalculatorDefectDensity
	In order to calculate the Defect Density and SSI for second release
	As a system quality engineer
	I want to use my calculator to execute these calculations

@DefectDensity
Scenario: Calculating defect density
	Given I have a calculator
	When I have entered "100" and "50" into calculator the and press Defect Density
	Then the defect density result should be "2"

@DefectDensity
Scenario: Calculating defect density when the CSI value is 0
	Given I have a calculator
	When I have entered "100" and "0" into calculator the and press Defect Density
	Then the defect density result should be positive infinity

@SSI
Scenario: Calculating SSI for second release
	Given I have a calculator
	When I have entered "50", "20" and "4" into the calculator and press SSI
	Then the SSI result for second release should be "66"