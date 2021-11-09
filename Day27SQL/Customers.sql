create table Customers (
studentId int primary key auto_increment,
firstName varchar(20) not null,
lastName varchar(20) not null,
telephone int,
email varchar(30) not null,
tips int
);

insert into Customers (firstName, lastName, telephone, email, tips)
values ('Alnis', 'Anglis', 4345346, 'dsfsdfsd@gmail.vol', 2),
		('Punkis', 'Vacietis', 8765655, 'ghfghgfh@cv.vol', 3),
        ('Ukrii', 'Opaa', 97453253, 'iiioujujyu@uuu.vol', 1);
        
insert into Customers (studentId, firstName, lastName, telephone, email, tips)
values (9, 'Upis', 'Arkls', 8988767, 'eeeeerrr@gmail.vol', 1),
		(8, 'Ziegs', 'Uraa', 32433244, 'uuioopp@mail.vol', 3);
        
select * from Customers;

select * from Customers where tips = 1;

create table Employees(
	EmployeesId INT primary key auto_increment,
    firstName varchar(20) not null,
    lastName varchar(20) not null,
    email varchar(50) not null
    );
    
    
insert into Employees (firstName, lastName, email)
	values  ('Mirdza', 'Kaposts', 'mirdza@oddde.LV'),
			('Modris', 'Atselga', 'atslega@oddde.LV'),
			('Andris', 'Zeme', 'zems@one.LV'),
            ('Adolfs', 'Hitlers', 'DOLFS@INBOX.LV'),
			('Boriss', 'JESHKA', 'JESHA@BOX.LV');
            
alter table Customers
add column EmployeesId int;

alter table Customers
Add foreign key (EmployeesId) references Employees(EmployeesId);

select Customers.firstName, Customers.lastName, Employees.firstName, Employees.lastName
from Customers, Employees
where Customers.EmployeesId = Employees.EmployeesId;

select * from Customers;
select * from Employees;

CREATE TABLE Departments (
	DepartmentsId INT PRIMARY KEY AUTO_INCREMENT,
    Depart1 VARCHAR(20) NOT NULL,
    Depart2 VARCHAR(20) NOT NULL
);

INSERT INTO Departments (Depart1, Depart2)
	SELECT EmployeesId,Employees.firstName
	FROM Employees;
			

ALTER TABLE Employees
ADD COLUMN DepartmentsId INT;
 
ALTER TABLE Employees
ADD FOREIGN KEY (DepartmentsId) REFERENCES Departments(DepartmentsId);

SELECT Employees.firstName, Employees.lastName, Departments.Depart1, Departments.Depart2
FROM Employees, Departments
WHERE Employees.DepartmentsId = Departments.DepartmentsId;

SELECT Employees.EmployeesId, Departments.DepartmentsId
FROM Employees	
INNER JOIN Departments ON Employees.DepartmentsId = Employees.EmployeesId;

select * from Customers;
select * from Employees;
select * from Departments;

