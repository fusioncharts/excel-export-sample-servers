# FusionCharts Excel Export Sample Servers

## Overview
This repository contains sample servers for FusionCharts Excel Export.The available .NET servers are as follows :

 * MVC Server (MVC 2+)
 * A Simple Web Application (.aspx)
 * Web API
## Installation
* Clone the repository
* Open the server of your choice in visual studio
* Build the application.
* Make sure all the nuget dependency are resolved.
* Run the Application
* Take a note of the URL on which the server is running.For eg : `http://localhost:12345` , the default URL to be used are as follows :
    * For MVC server : `http://localhost:12345/api/v1.0/export`
    * For Simple Web : `http://localhost:12345/FCExcelExport.aspx`
    * For WebAPI : `http://localhost:12345/FCExcelExport`
* In the client set `exportExcelHandler` as the URL above.(Refer `Sample Client` folder in the repository)
    