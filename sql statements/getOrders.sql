
--make new order
INSERT INTO Orders(ForeignStudent,ForeignDrink)
VALUES(1, 41)

UPDATE  Drinks
SET stock = stock-1
WHERE Id = 1 AND stock > 0

--select Orders
SELECT Orders.Id , Students.studentFirstName, Drinks.name  
--debug
,Drinks.stock
--enddebug
FROM Orders
JOIN Students on ForeignStudent = Students.studentID
JOIN Drinks on ForeignDrink = Drinks.id
WHERE Drinks.stock >0

