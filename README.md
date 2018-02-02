# FusionCharts Excel Export Sample Servers

## Overview
This repository contains sample servers for FusionCharts Excel Export.The available .NET servers are as follows :

 * MVC Server (MVC 2+)
 * A Simple Web Application (.aspx)
 * Web API
## Server Installation
* Clone the repository
* Open the server of your choice in visual studio
* Build the application.
* Make sure all the nuget dependency are resolved.
* Run the Application
* Take a note of the URL on which the server is running.The default URL is set as : `http://localhost:8191`, the default URL to be used are as follows :
    * For MVC server : `http://localhost:8191/api/v1.0/export`
    * For Simple Web : `http://localhost:8191/FCExcelExport.aspx`
    * For WebAPI : `http://localhost:8191/FCExcelExport`

## Client Installation

 A Sample client is provided for testing purpose.To run the sample client, the steps are as follows :

   * Build and run `FCExcelExport_Client` project.
   * Select the type of server you have used.
   * From the menu bar , click on "Export AS Excel" button. 
    