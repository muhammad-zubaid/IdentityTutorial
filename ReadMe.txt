https://www.tektutorialshub.com/asp-net/asp-net-identity-tutorial-basics/
***************************************************************************************************************************
Identity Tables: 
AspNetUsers
Stores Users Information like login name, password etc
AspNetRoles
Stores User Roles
AspNetUserRoles
Associates Particular roles to User
AspNetUserLogins
This table to hold information about 3rd party/external logins like facebook, google etc
AspNetUserClaims
Stores Claims associated with the user

***************************************************************************************************************************

Managers:
ASP.Net Identity has high-level classes called Managers, which is used by our application to manage Identity models like users, roles, claims etc. Currently, ASP.NET Identity Provides two managers. UserManger andRoleManager

Identity Models:
The Identity Models represent the domain model. ASP.NET Identity provides the basic Interface for these models. For Example, IUser Interface for User Model and IRole for Roles, IClaim for Claims.

Use Store:
The Managers uses the UseStore to talk to the Stores. The stores define how the users, roles are persisted to the database. The User Manager is decoupled from the UserStore.

This decoupling enables us to create our own implementation of User Store

The ASP.Net Identity brings its own default implementation of Use Store in Using Entity Framework in the namespace Microsoft.AspNet.Identity.EntityFramework. This Framework defines the Concrete implementation of the User Store specific to Entity Framework. It also has concrete classes for Identity Models.