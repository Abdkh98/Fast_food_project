create database DB_SMP
use DB_SMP
go
create table Category
(
ID INT PRIMARY KEY IDENTITY(1,1),
CAT_Name nvarchar(50)  null, 
Cat_Cover image  null,
)
go
create table Suppliers
(
ID INT PRIMARY KEY IDENTITY(1,1),
Supp_Name nvarchar(50)  null, 
Supp_Phone nvarchar(50)  null,
Supp_Email nvarchar(50)  null,
Supp_image image  null,
)
go
create table Purchases
(
ID INT PRIMARY KEY IDENTITY(1,1),
Cat_id  int  null,
Supp_id int null,
Pur_name nvarchar(50)  null,
Pur_Type nvarchar(50)  null,
Pur_Cat nvarchar(50)  null,
Pur_Supp nvarchar(50)  null,
Pur_Det nvarchar(50)  null,
Pur_Buy float  null,
Pur_Sell float  null,
Pur_Qt float  null,
Pur_Tsell float  null,
Pur_Tbuy float null,
Pur_TRev float  null,
CONSTRAINT FK_Purchases_Category FOREIGN KEY (Cat_Id) REFERENCES Category(Id),
    CONSTRAINT FK_Purchases_Suppliers FOREIGN KEY (Supp_Id) REFERENCES Suppliers(Id)
)
go
create table Sells
(
ID INT PRIMARY KEY IDENTITY(1,1),
Sell_nameItem nvarchar(50) null,
Sell_nameClient nvarchar(50) null,
Sell_Price float null,
Sell_Qt float null,
Sell_TPrice float null,
Sell_Date datetime null,
)
go
create table Users
(
ID INT PRIMARY KEY IDENTITY(1,1),
User_Name nvarchar(50) null,
User_Pass nvarchar(50) null,
User_Roll nvarchar(50) null,
User_State nvarchar(50) null,
User_image image  null,

)
go