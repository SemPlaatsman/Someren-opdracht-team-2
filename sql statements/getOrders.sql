SELECT Orders.Id , Students.studentFirstName, Drinks.name
FROM Orders
JOin Students on ForeignStudent = Students.studentID
JOin Drinks on ForeignDrink = Drinks.id