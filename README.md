# FlightDocs System
## Technology
- ASP.NET CORE 6.0
- Entity Framwork Core 7.0.5
## Install Packages

-- (View Models layer)
- FluentValidation.AspNetCore Version="11.3.0" 
- Microsoft.AspNetCore.Http.Features Version="5.0.17" <br> 
-- (Data layer)
- Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="6.0.16" 
- Microsoft.EntityFrameworkCore" Version="7.0.5"
- Microsoft.EntityFrameworkCore.Design" Version="7.0.5"
- Microsoft.EntityFrameworkCore.SqlServer" Version="7.0.5"
- Microsoft.EntityFrameworkCore.Tools" Version="7.0.5"
- Microsoft.Extensions.Configuration" Version="7.0.0"
- Microsoft.Extensions.Configuration.FileExtensions" Version="7.0.0"
- Microsoft.Extensions.Configuration.Json" Version="7.0.0" <br> 
-- (Application layer)
- Microsoft.AspNetCore.Http.Features" Version="5.0.17" 
- Microsoft.IdentityModel.Tokens" Version="6.30.1" (.NET 6.0 does not support version 7.0)
- System.IdentityModel.Tokens.Jwt" Version="6.30.1" (.NET 6.0 does not support version 7.0) <br> 
-- (Backend API layer)     
- FluentValidation.AspNetCore" Version="11.3.0" 
- Microsoft.AspNetCore.Authentication.JwtBearer" Version="6.0.16"
- Swashbuckle.AspNetCore" Version="6.5.0" 
## 24-25/5: 
- Create solution project structure  
- Create database with user service tables and seed data for Users, Roles, User Roles table
- Add Swagger to application to manage the API
- Add Authorization header to Swagger
- Create form fluent validation for email and password
- Create login API Authenticate with email and password (AspNetCore.Identity),  Attempts a password sign in for a user. If the data matches the database, login successfully, the server will return a jwt
(The user account wought be locked if the sign in fails.) 
## 25/5 - 29/5:
- Create Database relates to user requiments 
- Database configuration User management and Permission
## 29/5 - 1/6:
- Integrated user rights to access API
- Create CRUD API for group permissions including: view group list with pagination, create group, update group, remove group, view group details
## 1/6 - 5/6:
- Create CURD API for group permissions including: get all user account, add user account to group, remove user account from group
- Create API configure system controller 
- Create CU API for general setting: view present general setting, change setting: Theme, Capcha enable, Logo Image
## 5/6 - 8/6:
- Create document controller: configuration
- Create CURD API for document type including: get all document type, add permission to doc type, remove group permission from doc type, get doc type detail, remove doc type, update doctype