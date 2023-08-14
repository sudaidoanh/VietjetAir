# FlightDocs System: 
Flight Docs System for Vietjet Air is a project that simulates the actual project of the document management project for pilots and crew about VietjetAir's flights and passengers. At the same time, the system administrator can through the system and the granted rights to manage information related to the types of users, information and documents on the system through the API developed for different functions.
## Technology
- C#
- ASP.NET CORE 6.0
- .NET MVC, OAuth2, Authentication Jwt Bearer, Swashbuckle
- Entity Framwork Core 7.0.5
- SQL Server database
## Development process:
- Analyze business and business requirements,
- Design database,
- Design system architecture,
- API Development
- Unit test, debug and fixbug
## Functions:
- Login, authenticate, return access token, verify token, role
- CRUD api for document management, document search, document group search, pagination
- CRUD api for user group management, user group access verification, user search, pagination
- Terminate user session, change owner account, reset user's password, information sent to user email
- Integrate and call API on the system
- Import flight document excel file, import/export user list
## Install Packages
### (View Models layer)
- FluentValidation.AspNetCore Version="11.3.0" 
- Microsoft.AspNetCore.Http.Features Version="5.0.17"  
### (Data layer)
- Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="6.0.16" 
- Microsoft.EntityFrameworkCore" Version="7.0.5"
- Microsoft.EntityFrameworkCore.Design" Version="7.0.5"
- Microsoft.EntityFrameworkCore.SqlServer" Version="7.0.5"
- Microsoft.EntityFrameworkCore.Tools" Version="7.0.5"
- Microsoft.Extensions.Configuration" Version="7.0.0"
- Microsoft.Extensions.Configuration.FileExtensions" Version="7.0.0"
- Microsoft.Extensions.Configuration.Json" Version="7.0.0" 
### (Application layer)
- Microsoft.AspNetCore.Http.Features" Version="5.0.17" 
- Microsoft.IdentityModel.Tokens" Version="6.30.1" (.NET 6.0 does not support version 7.0)
- System.IdentityModel.Tokens.Jwt" Version="6.30.1" (.NET 6.0 does not support version 7.0) 
### (Backend API layer)     
- FluentValidation.AspNetCore" Version="11.3.0" 
- Microsoft.AspNetCore.Authentication.JwtBearer" Version="6.0.16"
- Swashbuckle.AspNetCore" Version="6.5.0" 
## 24-25/5: 
- Create solution project structure  
- Create database with user service tables and seed data for Users, Roles, User Roles table
- Add Swagger to application to manage the API
- Add Authorization header to Swagger
- Create form fluent validation for email and password
- Create login API Authenticate with email and password (AspNetCore.Identity), Attempts a password sign in for a user. If the data matches the database, login successfully, the server will return a jwt
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
## 8/6 - 12/6:
- Create flight controller
- Create form validator when add flight infomation
- Create API for add and get landing and take-off points, create new document with media file storaged in server, folder wwwroot/MediaScr/
## 12/6 - 15/6:
- Create form validator for input form when enter text
- Create API for get all flight docs, remove flight docs, get detail a flight doc
## 15/6 - 19/6:
- Create middleware that navigates each user's access permission rights based on the user's login jwt
## 19/6 - 22/6: 
- Create API for Setting Services as required including: view user list, user account details, delete, edit, reset password, change owner account
- Terminate the user session: the user is logged out of the system and cannot log in until the owner/admin reinstalls the role
- Use JWT cancelling to log out the user's session
## Unfinished: send email
