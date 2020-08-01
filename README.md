# Description
This is a VisualStudio 2019 Solution with four projects:
1. A Web API offering a Surname search on DB persisted data.
2. Some tests against the WEB API
3. An MVC front end using the above Web API to offer a Surname search for user details.
4. The skeleton of tests for the UI based on SpecFlow but not fully implemented as it would require Selenium Web Drivers to be installed to complete and this is beyond the scope of the test.

## Web API
Entity Framework is used to persist a List of User objects under Sqlite where a User object will hold Firstname, Surname, Start date and leave date notionally as example details around the Surname.
An in memory database is used to exercise tests that count results for known surnames.

## Front End
An MVC .Net Core site with a simple screen allowing a surname or part of a surname to be searched. 
The text input is validated within the Controller GET method to only accept valid surname characters; this is useful but also aimed at preventing any script being entered.
A SpecFlow test framework exists based on the feature like description in the test question but is currently not implemented but the potential exists to integrate Selenium tests to drive a browser and check UI results.

## Installation
It is expected to run this Solution under Visual Studio 2019 and you will need to configure multiple startup projects to run the Solution. The actual requirement is to run HesaUser.Lookup first, the source Web API then run HesaUSer, the search web page.
### Configuring the multiple startup projects
1. Under Solution Explorer right-click the Solution then select `Set Startup Projects...`
![Select set startup projects](images/SelectSetStartupProjects.png)
2. The HesaUser project which is the Web API search provider should be the first project to run i.e. at the top of the list. If this is not the case select it then click the Up Arrow button until it is at the top of the list.
![Ensure HesaUser is top of the start multiple list](images/EnsureHesaIsFirst.png)
3. Now your Visual Studio Start menu should look like below:
![How the Start Menu should look now](images/StartMultipleNowVisibleInVisualStudio2019.png)

## Usage
