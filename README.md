# Convert WCF Service to RESTFUL Service


To convert WCF to RESTFUL service, an operation contract needs to be decorated with “WebInvoke (or) WebGet” to define the Request and Response format.


This WebInvoke attribute resides inside the “System.ServiceModel.Web” namespace is used to define the below parameters at the end point to convert it to RESTFUL Service.

1. Service Method to Invoke (POST/GET/PUT/DELETE)

2. URI template to invoke using friendly URL

3. Request and Response Format

To start with create a new “WCF Service Application” and follow the below steps to modify the WCF end point to JSON RESTFUL Service.


# test urls from browser,
# ==>getbyid
# http://localhost:55739/Service1.svc/api/GetById/2

# ==>getall
# http://localhost:55739/Service1.svc/api/GetAll/
