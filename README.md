# Jesse's Pierre's Sweet and Savory Shop
https://github.com/jessecallahan/SweetAndSavory.Solution

Created 06.19.21</br>
By _**Jesse Callahan**_</br>
Contact: _**Jessetylercallahan@gmail.com**_</br>

## Description
Pierre's Sweet and Savory Shop is a C# application in the .NET MVC Framework that utilizes a local sql database. This application simulates a Factory database, where an owner can see all the Treats and Flavors they belong to. The database utilizes a many to many relationship. This project also utilizes authentication and authorization using Identity. 

## Setup/Installation Requirements

1. Clone this [repository](https://github.com/jessecallahan/Factory.Solution)
2. From the project directory folder (Factory) create a 'appsettings.json' file 
3. First, Copy this into the appsettings.json file:<br/><br/>  `{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=jesse_callahan;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
}`<br/> <br/> *[YOUR-PASSWORD-HERE] is your sql password*
4. Now, from the project directory folder use command 'dotnet restore' in your terminal to load boilerplate
5. Lastly, from the project directory folder use command 'dotnet ef migrations add Initial' in your terminal to run migration on db
6. Finalize that db creation by then using the command 'dotnet ef database update'. If everything works correctly, you should see a 
new sql database schema called jesse_callahan in your workbench.
7. From the project directory folder use command 'dotnet run' in your terminal to run server
8. Copy the local host 5000 server link into your perferred web browser
9. Enjoy!

## Specs
BELOW IS A SCHEMA CHART
![image info](./Factory/wwwroot/images/schema_pic.png)
## Technologies Used
* C#
* MySql
* Entity Framework
* .NET
* MVC
* CSS/HTML
* Identity


