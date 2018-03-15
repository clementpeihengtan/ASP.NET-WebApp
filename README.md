# ASP.NET-WebApp
Simple Web Application that display product information and allow insert, delete and edit product

# Features

- JQuery
- Web API Controllers(C#)
- Repository Pattern
- Dependency Injection With Unity
- Entity Framework

# How to use

1. Clone this repository down.
2. Open the sln file in Visual Studio
3. You will need to create a local database with the format below using SQL server database 
    
    i. Right Click on **ProjectApp.Web**
    
        Add --> new Item 

    ii.  Search for **SQL Server database**
    
    iii. Give it a name and add it 

    iv.  Open Server Explorer on your visual studio. Click on

         Data Connections --> "Databasename"

    v.   Right click on Tables and add new table.

    vi.   Copy the content of dbo.Table into the space provided from previous action. 

    vii.   Now copy the database name and replace it in the following file. Replace everyting after name=.....

    - ProductAPI.Structure --> ProductContext.cs 

    viii.  Copy the database name and connection string and replace them in the file below.  

    - ProductAPI.Strucure --> App.config
    - ProjectApp.Web --> Web.config

4. Build the application
5. Run the application
6. Done!
