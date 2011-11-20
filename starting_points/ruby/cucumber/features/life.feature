Feature: Life
   In order to check if Life's game rocks
   As a god
   I want to get rocks string

   Scenario: Check if life rocks
      Given I have called rocks method
      When I ask for
      Then I get "rocks"
