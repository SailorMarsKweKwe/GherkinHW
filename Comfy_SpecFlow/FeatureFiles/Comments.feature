Feature: Product comments
   As a customer
   I want to have opportunity to copy links of useful comments
   In order to save it and use a good tips from comments

   As a customer
   I want to have opportunity to rate other customers' comments
   In order to help the potential buyers to see useful advices
 
   As a customer
   I want to have opportunity to read the product comments
   In order to know about the product features from real owners

Background:
     Given User on the homepage

Scenario: Copy the comment link
	 When User click on the kitchen appliances category 
	 And User click on the freezer category
	 And User click on the second product reviews button
     Then User see the product reviews page
     When User click on the share icon of appropriate comment
     Then User see the popup with a comment link
     When User click on the copy link button
     Then User save link to his messenger

Scenario: Rate comment
	 When User click on the kitchen appliances category 
	 And User click on the microwave category
	 And User click on the first product reviews button
     Then User see the product reviews page
     When User click on the thumbs up icon
     Then User see the authorization popup
     When User enter phone number to the phone field
     And User click the login button
     Then User see the message with the password that came to the user's phone
     When User enter password in password field
     And User click the login button
     Then User see the information popup
     When User click the close popup button
     Then User see the thumbs up counter indicator has increased by one

Scenario: Read the comment
	 When User click on the kitchen appliances category 
	 And User click on the freezer category
	 And User click on the first product reviews button
     Then User see the product reviews page with comments