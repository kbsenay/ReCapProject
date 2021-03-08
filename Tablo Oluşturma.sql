Create Table CarImages (
Id int Not Null,
CarId int,
ImagePath varchar(max),
Date datetime,
Primary Key (Id),
Foreign Key (CarId) References Cars (CarId)
);