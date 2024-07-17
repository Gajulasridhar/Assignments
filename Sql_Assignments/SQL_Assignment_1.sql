
--Q1)creating customers Table
create table Customers (
Customerid char(5) not null,
CompanyName varchar(40) not null,
contactName char(30) null,
Address varchar(60) null,
City char(15) null,
Phone char(24) null,
Fax char(24) null,
)

--creating orders Table

create table Orders(
OrderId integer not null,
customerId char(5) not null,
Orderdate datetime null,
Shippeddate datetime null,
Freight money null,
Shipname varchar(40) null,
Shipaddres varchar(60) null,
Quantity integer null
)

--Q2)

alter table Orders add shipregion int null

--Q3)

alter table Orders alter column shipregion char(8)

--Q4)
alter table orders drop column shipregion

--Q5)

insert into Orders values ( 10, 'ord01', getdate(), getdate(), 100.0, 'Windstar', 'Ocean' ,1)

--Q6)
alter table Orders 
 add constraint df_ConstraintNAme 
 default getdate() for [Orderdate]

 --Q7)
 sp_rename 'Customers.City','Town'