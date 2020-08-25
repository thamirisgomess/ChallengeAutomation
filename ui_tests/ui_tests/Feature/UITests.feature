@UITests @UI
Feature: UITests

Background: 
	Given I navigate to automationpractice website 

@Positive @TestCase01
Scenario: Create a new account 		
	Given I go to click on Sign in button, enter Email address "thamigomess@gmail.com" and click Create an account button
	And I verify that personal information page is open and enter the request informations: Title "Mrs.", First Name "Thamiris", Last Name "Gomes", Password "Test1234", Address "Rua Manoel barreto,671", City "Orlando", Zip/Postal "12345", Satet "Florida" country "United States" and  phone number "71991894729"
	Then I verify that account has been created and are able to see the ootions "My Account"

@Negative @TestCase02
Scenario: Create a new account and verify the error message		
	Given I go to click on Sign in button, enter Email address "none" and click Create an account button
	Then I verify the erro messagem "1.Invalid email address."
	When I go to click on Sign in button, enter Email address "test@gmail.com" and click Create an account button
	Then I verify the erro messagem "1.An account using this email address has already been registered. Please enter a valid password or request a new one."
	Given I go to click on Sign in button, enter Email address "" and click Create an account button
	Then I verify the erro messagem "1.Invalid email address."

@Positive @TestCase03
Scenario: Signin with an account created
	Given I go to click on Sign in button 
	And I enter the email "thamigomess@gmail.com", Password "Test1234" And verify that the page loads "successfully" with message "none"

@Negative @TestCase04
Scenario: Signin with an account created and verify the error message	
	Given I go to click on Sign in button 
	And I enter the email "test", Password "Test1234" And verify that the page loads "error" with message "1.Invalid email address."
	And I enter the email "thamigomess@gmail.com", Password "12323" And verify that the page loads "error" with message "1.Invalid password."
	And I enter the email "", Password "12323" And verify that the page loads "error" with message "1.An email address required."
	And I enter the email "thamigomess@gmail.com", Password "" And verify that the page loads "error" with message "1.Password is required."
	
@Positive @TestCase05
Scenario: Signin with an account created, add an item in the cart and remove it
Given I go to click on Sign in button 
	And I enter the email "thamigomess@gmail.com", Password "Test1234" And verify that the page loads "successfully" with message "none"
	When I click on Women button and search "Blouse" item 
	And I select a T-shit in Stock and Add to cart
	And I verfy the T-shirt select and click on Proceed to Checkout
	Then I verify the card contains 1 product
	When I go to cart item and click to remove the product from my cart
	Then I verify the message "Your shopping cart is empty."

@Positive @TestCase06
Scenario: Signin with an account created and add a Woamen T-shirt in the cart
	Given I go to click on Sign in button 
	And I enter the email "thamigomess@gmail.com", Password "Test1234" And verify that the page loads "successfully" with message "none"
	When I click on Women button and search "Blouse" item 
	And I select a T-shit in Stock and Add to cart
	And I verfy the T-shirt select and click on Proceed to Checkout
	Then I verify the card contains 1 product
	When In the summary page I verify the qty equal "1", Total equals "19.25" and click on Proceed to checkout button
	And I confirm the Address and click on Proceed to checkout button
	And I Choose a shipping option for this address and click on Proceed to checkout button
	Then I inform the payment option and I confirm my order

@Positive @TestCase07
Scenario: Contact us
	Given I go to click on Contact us button and verify the contact page displayed 
	And I select Subject Heading "Custome service", Email address "thamigomess@gmail.com", Message ""
	Then I verify that success message "Your message has been successfully sent to our team."

@Positive @TestCase08
Scenario: Check my orders
	Given I click on My orders link under My account option
	And I verify my history order is displayed with "1" item
	Then I click Back to your account button

@Positive @TestCase09
Scenario: Check my personal info
	Given I click on My personal info link under My account option
	And I verify that authentication page displayed
	And I enter the Current Password "Test1234", change my password to "1234Test", confirm "1234Test" adn Click save button
	Then I verify the success message  "Your personal information has been successfully updated."

@Positive @TestCase10
Scenario: Sigin out
	Given I go to click on Sign out button
	Then I verify that authentication page displayed
