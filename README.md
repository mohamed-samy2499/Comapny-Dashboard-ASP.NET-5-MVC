# Comapny-Website-ASP.NET Core 5-MVC

## Architecture Used
### Three Tier Architecture
1. Data Access Layer
  - For Dealing with Database Entities And Migrations.
2. Business Logic Layer
  - For Handling the Logic of my application and dealing with Interfaces and Repositories.
3. Presentation Layer
  - For dealing with Views,Controller and ViewModels. 

## Design Patterns Used
1. Repository Design Pattern
  -  To separate the data access layer and maps it to the entities in the business logic through Interfaces to make it easier for extending our application in the future.
2. Unit Of Work
  - To group all DataBase CRUD operations into a single transaction "unit of work".
