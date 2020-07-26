# HesaUser
There are four projects:
1) A Web API offering a Surname search on DB persisted data.
2) Some tests against the WEB API
3) An MVC fron end using the above Web API to offer a Surname search for user details.
4) The skeleton of tests for the UI based on SpecFlow but not fully implemented as it would require Selenium Web Drivers to be installed to complete and this is beyond the scope of the test.

Web API
Entity Framework us used to persist a List of User objects where a User object will hold Firstname, Surname, Start date and leave date notionally as example details around the Surname.
An in memory database is used to exercise tests that count results for known surnames.

Front End
An MVC .Net Core site with a simple screen allowing a surname or part of a surname to be searched. 
The text input is validated within the Controller GET method to only accept valid surname characters; this is useful but also aimed at preventing any script being entered.
A SpecFlow test framework exists based on the feature like description in the test question but is currently not implemented but the potential exists to integrate Selenium tests to drive a browser and check UI results.
