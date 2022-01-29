Feature: Filter the products
   As a customer
   I want to have opportunity to filter the products
   In order to select the most suitable product for me

   As a customer
   I want to have opportunity to filter vacuum cleaners by type of dustcollector
   In order to buy the one that gives less dust into the room

   As a customer 
   I want to have opportunity to filter the product by popularity
   In order to buy the most trendy product
    
Background:
     Given User on the homepage

@filterPrice
Scenario: Filter products by price
	 When User click on demanded category of products
	 And User enter suitable price limits on the left part of page
	 And  User click to apply filters button
     Then User see the filtered products

@filterCollectorType
Scenario: Filter the products by dust collector type
	When User click on home appliances category 
	And User click on small appliances category
	And User click 'Пилосос' button
    Then User see the vacuum-cleaner page
    When User click on 'Контейнер' check-box
    Then User see the products filtered by dustollector type

@popularityFilter
Scenario: Filter the products by popularity
	When User click on smartfon category 
	Then User see the smartfon page
    When User click on popularity rating
    Then User see the most popular smartfon page
   