Feature: Product comparison
   As a customer
   I want to have opportunity to compare products
   In order to see all products parameters 

   As a customer
   I want to have opportunity to compare smartphone models
   In order to buy the phone that stays charged the longest
 
   As a customer
   I want to have opportunity to compare the dimensions of the products
   In order to choose a product that does not require a home delivery service
 
Background:
     Given User on the homepage

@compareAllParams
Scenario: Compare all parameters
     When User scrolls to the middle of the page to the smartphone block
     And User click on the first product compare icon
     And User click on the second product compare icon	 
     And User click on the third product compare icon
     Then User see the confirmation popup of adding to compare
     When User click on confirmation popup
     Then User see the comparison table of products

Scenario: Compare the battery capacity
     When User click on smartphone category 
     Then User see the smartphone page
     When User click the first smartphone compare icon
     And  User click the second smartphone compare icon
     And  User click the third product compare icon
     Then User see the confirmation popup of adding to compare
     When User click on confirmation popup
     Then User see the comparison table of products
     When User scroll to the battery capacity line
     Then User see the line with battery capacity information

Scenario: Compare product dimensions
     When User click on the home appliances category 
     And User click on the large appliances category	
     And User click the tumble dryers category		 
     And User click on the comparison icon of the four favorite products
     And User click on the third product compare icon
     Then User see the confirmation popup of adding to compare
     When User click on confirmation popup
     Then User see the comparison table of products
     When User scroll to the dimensions line
     Then User see the line with the dimensions of the selected products

