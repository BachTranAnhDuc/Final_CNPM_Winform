create database eShopManager;

use eShopManager;


/* Create Tables*/
create table Employee
(
	ID varchar(20),
	nameEmployee nvarchar(100),
	uname varchar(50),
	pwd varchar(50),
	addresses nvarchar(100),
	primary key(ID)
);



/* Insert values */


insert into Employee (ID, nameEmployee, uname, pwd, addresses) values ('001', 'Bach Tran Anh Duc', 'username001', '123456', 'Ho Chi Minh City');
insert into Employee (ID, nameEmployee, uname, pwd, addresses) values ('002', 'Hoang Tuan Anh', 'username002', '123456', 'Ho Chi Minh City');




select * from Employee;