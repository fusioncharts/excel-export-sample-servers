# FusionCharts Excel Export Sample Servers

## Overview
This repository contains contains sample servers for FusionCharts Excel Export.The various available .NET servers are as follows :

 * MVC Server
 * A Simple Web Application (.aspx)
 * Web API
## Installation
* Clone the repository and open `FusionCharts_ExcelExport_Sample_Server.sln` in your workspace.
* Build the entire solution.
* Make sure all the nuget dependency are resolved.
* Set any one of the server as per your need as `StartUp Project`.
* Run the Application
* Take a note of the URL on which the server is running.For eg : `http://localhost:12345` , the the default URL to be used are as follows :
    * For MVC server : `http://localhost:12345/api/v1.0/export`
    * For Simple Web : `http://localhost:12345/FCExcelExport.aspx`
    * For WebAPI : `http://localhost:12345/FCExcelExport`
* In the client set `exportExcelHandler` as the URL above.
    