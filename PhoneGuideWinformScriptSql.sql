


-- 1
Create Database PhoneGuide;

-- 2
Use PhoneGuide;


-- 3
Create table Guide (
 ID UniqueIdentifier not null,
 Name varchar(50),
 Surname varchar(50),
 PhoneNumber varchar(11),
 EmailAdress varchar(30),
 PRIMARY KEY(ID)
);
