create database Session4
use Session4

create table Orders(
ID int primary key identity(1,1),
TransactionTypeID int,
SupplierID int,
SourceWarehouseID int,
DestinationWarehouseID int,
Date date,
constraint fk_transaction_type_id foreign key (TransactionTypeID) references TransactionTypes(ID),
constraint fk_supplier_id foreign key (SupplierID) references Suppliers(ID),
constraint fk_source_warehouse_id foreign key (SourceWarehouseID) references Warehouses(ID),
constraint fk_destination_warehouse_id foreign key (DestinationWarehouseID) references Warehouses(ID)
)

create table Suppliers(
ID int primary key identity(1,1),
Name char(30))

create table OrderItems(
ID int primary key identity(1,1),
OrderID int,
PartID int,
BatchNumber char(10),
Amount money,
constraint fk_part_id foreign key (PartID) references Parts(ID),
constraint fk_order_id foreign key (OrderID) references Orders(ID)
)

create table Parts(
ID int primary key identity(1,1),
Name char(30),
EffectiveLife char(30),
BatchNumberHasRequired char(10),
MinimumAmount money)

create table TransactionTypes(
ID int primary key identity(1,1),
Name char(30))

create table Warehouses(
ID int primary key identity(1,1),
Name char(30))

insert into TransactionTypes values ( 'Purchase Order')
insert into TransactionTypes values ( 'Warehouse Management')

insert into Suppliers values ( 'Sam Sung')
insert into Suppliers values ( 'Apple')

insert into Warehouses values ('Ha Noi')
insert into Warehouses values ('Ha Nam')
insert into Warehouses values ('Bac Ninh')
insert into Warehouses values ('Long An')

insert into Parts values ('Iphone', 'True', 'True',10)
insert into Parts values ('GalaxyS10', 'True', 'True',10)
insert into Parts values ('R7-Lite', 'True', 'True',10)
insert into Parts values ('Oppo','True','False',10)

create view purchase
as
select Orderitems.OrderID, Parts.Name as 'Part Name' ,TransactionTypes.Name as 'Transaction Type',
 Warehouses.Name as'Destination',Orders.Date, OrderItems.Amount, OrderItems.ID, Suppliers.Name as 'suppliers'
from Orders inner join TransactionTypes on Orders.TransactionTypeID = TransactionTypes.id
			inner join Warehouses on Orders.DestinationWarehouseID = Warehouses.id
			inner join OrderItems on Orders.ID = OrderItems.OrderID
			inner join Suppliers on Orders.SupplierID = Suppliers.ID
			inner join Parts on OrderItems.PartID = Parts.ID
where TransactionTypes.id = 1

create view warehouse
as
select Orderitems.OrderID, Parts.Name as 'Part Name' ,TransactionTypes.Name as 'Transaction Type',
w1.Name as 'Source', w2.Name as'Destination',Orders.Date, OrderItems.Amount, OrderItems.ID
from Orders inner join Warehouses w1 on Orders.SourceWarehouseID =  w1.ID
			inner join Warehouses w2 on Orders.DestinationWarehouseID =  w2.ID	
			inner join TransactionTypes on Orders.TransactionTypeID = TransactionTypes.ID
			inner join OrderItems on Orders.ID = OrderItems.OrderID
			inner join Parts on OrderItems.PartID = Parts.ID
where TransactionTypes.ID = 2