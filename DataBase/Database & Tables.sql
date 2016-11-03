create database FeedMe
use FeedMe

-------PeriodType--------
create table PeriodType
(
PeriodId int primary Key Identity(1,1),
PeriodName varchar(20),
Number int
)
select *from PeriodType

Insert into PeriodType values('Hours',1);
Insert into PeriodType values('Days',2);
Insert into PeriodType values('Weeks',3);
Insert into PeriodType values('Months',4);

 delete FROM PeriodType where PeriodId =5

-------Rol--------
create table Rol
(
RoleId int primary KEy identity(1,1), 
RoleName varchar(20),
Number int
)
select * from Rol
Delete FROM Rol where RoleId =1

Insert into Rol values('Client',1);
Insert into Rol values('Users',2);
Insert into Rol values('Admin',3);

-------User--------
create table [User]
(
UserId int primary Key identity(1,1),
Email varchar(100),
Passwordkey varchar(1000),
RoleId int foreign key(RoleId) references Rol,
StoreId int foreign key(StoreId) references Store
)
select *from [User] 

Insert into [User] values('kr8s@gmail.com','12345f',2,2)

-------Store--------
create table Store
(
StoreId int Primary key Identity (1,1),
UrlName varchar(30),
CodName varchar(20),
Discount int,
Amount int,
[Percentage] float,
ProductDescription varchar(100),
PeriodId int foreign key(PeriodId) references PeriodType
)
select * from Store
Insert into Store values('pollotosSantaAna.FeedMe','Pollos',3,15,15,'Resive un descuento en el platillo del pollo don Pato', 2);
-------FeedBack--------
create table FeedBack
(
FeedBackId int primary key identity(1,1),
StoreId int foreign key(StoreId) references Store,
Face int,
Opinion varchar(200),
CreationDate datetime
)
select *From FeedBack
Insert into FeedBack values(1,1,'Good food','12/07/2016')

Insert into FeedBack values(1,1,'Good food','2016/07/13')

Insert into FeedBack values(1,0,'Good food','2016/07/16')

Insert into FeedBack values(1,0,'Good food','2016/08/16')

-------Coupon--------
create table Coupon
(
 CouponId Int primary key Identity (1,1),
 Discount int,
 DiscountDescription varchar(100),
 ActivationStatus int,
 UserId int foreign key(UserId) references [User],
 Email Char(100),
 Amount int,
 CreateDateTime datetime,
 StoreId int foreign key(StoreId) references Store,
 PeriodId int foreign key(PeriodId) references PeriodType
)