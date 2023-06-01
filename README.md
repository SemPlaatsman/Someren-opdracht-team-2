# Someren project for InHolland project 'Databases'
This is a group project for a camping trip to Someren. This project focuses on writing SQL queries combined with C# programming structures while using the three-tier architecture (presentation, application, data).

# My contributions
- Students
  - Created the Students panel which shows all Students to the user using the Student model.
  - Created the StudentService to connect the presentation-layer (Students panel) to the data-layer (StudentDAO).
  - The StudentDAO can get all students to return the list to the StudentService.
- Drinks
  - Created the Drinks panel which shows all Drinks and gives the ability to update and delete specific drinks. 
  - Created the DrinkService to connect the presentation-layer (Drinks panel) to the data-layer (DrinkDAO).
  - The DrinkDAO has the option to get all drinks, update a drink, and delete a drink. The get all drinks method only returns all drinks that have a stock amount greater than 1, of which the sales price is greater than 1 drinks token, sorted according to stock, subsequently according to sales value and then according to number of drinks sold. While also not including the drinks 'Water', 'Orangeade' and 'Cherry juice' in the list. This is done with a conditional SQL query.
- Activities
  - Created the Activities panel which provides CRUD (create, read, update, delete) functionality to the user.
  - Created the ActivityService to connect the presentation-layer (Activities panel) to the data-layer (ActivityDAO).
  - The ActivityDAO provides CRUD functionality to the ActivityService.
- Login and Registration
  - Created the LoginUI to let users Login using a username and a password. The LoginUI has a different panel for Registration which requires a username, password (with confirmation field), role, and license key.
  - Created the UserService to connect the presentation-layer (LoginUI) to the data-layer (UserDAO).
  - The UserDAO is mainly used to validate a user password by checking the username and (hashed) password with the username/password combination in the database. If a user is found the UserDAO returns the role of the user and when no user is found the UserDAO returns null.
  - The UserDAO is also used to register a new user (with hashed password) by inserting the data provided by the user in the database.
- Other functionality
  - A global error logger was made to log unexpected errors to a file called errorLogs.txt.
  - Created a custom Exception called SomerenException for expected errors such as when a user forgets to fill a field or provides the wrong value. These errors are expected and are not logged.
  - Created a [password hasher](https://dotnetcodr.com/2016/10/17/how-to-hash-passwords-with-a-salt-in-net/) which uses a salt from the app.config file (and generates and saves one when it doesn't exist) to hash passwords for the Login and Registration process.
