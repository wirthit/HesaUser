# Description
This is a VisualStudio 2019 Solution with three projects to demonstrate a simple MVC user lookup page:
1. A Web API offering a Surname search endpoint on DB persisted data and an MVC front end using the Web API giving a Surname search UI to get and display associated user details.
2. Some tests against the WEB API
3. The skeleton of tests for the UI based on SpecFlow but not fully implemented as it would require Selenium Web Drivers to be installed to complete and this is beyond the scope of the test.

## Web API
Entity Framework is layered on Sqlite to query and persist a List of User objects where each User object will notionally hold first name, surname, employment start date and leave date, these will be our example details.<br><br>
For testing the Web API an in memory database is used to provide a specific set of details to count results for known surnames.<br><br>
One GET endpoint is provided api/Users/Filter which for a request receives a Surname filter string i.e. find surnames containing the given filter text. The response is a Json array of the above user details associaed with the given request surname or an empty list if no matching surnames are found.

## Front End
This is an MVC .Net Core site with a single screen allowing part of a surname to be entered to search for associated user detail.<br><br>
The text input is validated within the Controller GET method to only accept valid surname characters; this is generally useful but also aimed at preventing any malicious script being entered.<br><br>
A SpecFlow test framework exists based on the feature like description in the test question but is currently not implemented but the potential exists to integrate Selenium tests to drive a browser and check UI results.

