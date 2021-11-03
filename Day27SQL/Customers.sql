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
        ('Alnis', 'Anglis', 97453253, 'iiioujujyu@uuu.vol', 1);
        
insert into Customers (studentId, firstName, lastName, telephone, email, tips)
values (9, 'Upis', 'Arkls', 8988767, 'eeeeerrr@gmail.vol', 1),
		(8, 'Ziegs', 'Uraa', 32433244, 'uuioopp@gmail.vol', 3);
        
select * from Customers;

select * from Customers where tips = 1;
        


