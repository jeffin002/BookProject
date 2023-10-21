use BookProject
go

create table AppUser
(
	AppUserId int primary key identity(1,1) not null,
	Name varchar(50) not null,	
	Phone varchar(100) not null,	
	UserName varchar(50) unique not null,
	Password varchar(50) not null,
	CreatedDate datetime default Getdate() not null,
	updatedDate  datetime default Getdate() not null,
	AddressID int foreign key references Address(Addressid) not null
)



select * from AppUser
create table AddressType
(
	AddressTypeId int identity(1,1) primary key not null,
	AddressType varchar(50) not null
)
insert into AddressType values('shipping'),('billing')

create table Address
(
	AddressId int identity(1,1) primary key not null,
	Address varchar(100) not null,
	District varchar(50) not null,
	state varchar(50) not null,
	pincode varchar(50) not null,	
	AddressTypeId int foreign key references AddressType(AddressTypeid) not null
)




select * from AppUser

create table Role
(
	RoleID  int identity(1,1) primary key not null,
	RoleName varchar(50) not null
)

insert into Role values('Admin'),('User')

select * from role


create table category
(
	CategorieID int primary key identity(1,1) not null,
	CategorieName varchar(100) not null,
	CategorieImage varchar(300) not null,
	CategorieDescription varchar(500) not null,	
)

alter table category
add Image varchar(350)

insert inro


EXEC sp_rename 'category.CategorieDescription', 'Description', 'COLUMN';
alter table 
drop column 

ALTER TABLE category
DROP COLUMN CategorieImage;

drop table category

exec sp_rename 'Categories' ,'category'

select * from Categories

create table AppUserRole
(
	AppUserRoleID int primary key identity(1,1) not null,
	AppUserId int foreign key references AppUser(AppUserId) not null,
	AppRoleID int foreign key references Role(RoleId) not null
)

create table Author
(
	AuthorId int primary key identity(1,1) not null,
	AuthorName varchar(50) not null,	 
)

create table status
(
	StatusId int identity(1,1) primary key, 
	StatusName varchar(50) not null
)
insert into status values('Avaliable'),('Not Avaliable')


create table Book
(
	BookId int primary key identity(1,1) not null,
	BookName varchar(50) not null,
	BookDescription  varchar(300) not null,
	CategorieId int foreign key references Category(categoryid) not null,
	BookUnitPrice Money not null,
	StatusId int foreign key references Status(statusid) not null,
	BookImage varchar(300) not null,
	PublishedDate varchar(50) not null
)
alter table book
drop column publisheddate

alter table book
add PublishedDate varchar(50) not null

ALTER TABLE Book
DROP CONSTRAINT FK__Book__CategorieI__619B8048;


ALTER TABLE Book
Add CategoryId int foreign key references Category(categoryid);

-- Step 1: Drop the existing foreign key constraint
ALTER TABLE Book
DROP CONSTRAINT FK_Category_CategorieId;

alter table book 
drop column CategorieId

create table BookAuthor
(
	BookAuthorId int primary key identity(1,1) not null,
	BookId int foreign key references book(bookid) not null,
	AuthorId int  foreign key references Author(Authorid) not null
)

create table BookOrder
(
	OrderID int primary key identity(1,1) not null,
	OrderDate datetime default GetDate() not null,
	OrderTotal money not null,
	OrderEmail varchar(100) not null,
	AppUserId int foreign key references AppUser(AppUserId) not null
)
	
create table OrderItems
(
	OrderItemId int primary key identity(1,1) not null,
	OrderId int foreign key references BookOrder(OrderID) not null,
	BookId int foreign key references Book(Bookid) not null,
	Quantity int not null
)
	
create table ShoppingCart
(
	ShoppingCartId int primary key identity(1,1) not null,
	BookId int foreign key references Book(Bookid) not null,
	AppUserID int foreign key references AppUser(AppUserId) not null,	
	CreatedDate datetime default Getdate() not null,
	updatedDate  datetime default Getdate() not null,
	Quantity int not null,
)


select SCOPE_IDENTITY() from Address

select * from Address

DELETE FROM Address where AddressId=1

select * from appuser
delete from AppUser where appuserid =2
