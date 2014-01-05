# WCF Data Services Client Sample

This project serves as an example of consuming an OData endpoint using WCF Data Services.

Goals:

* Use the Unit Of Work pattern for all data access

The unit tests use the following endpoints:

* Read-only endpoint:  http://services.odata.org/V3/OData/OData.svc

* Read/Write endpoint: http://services.odata.org/V3/(S(readwrite))/odata/odata.svc
  (visit this URL in your browser to create a unique URL for your own use, and replace
   it in ENDPOINTS.cs)

To run the sample:

1. Install the "NUnit Test Adapter" Visual Studio extension.

2. Load the solution.

3. Run the unit tests.
