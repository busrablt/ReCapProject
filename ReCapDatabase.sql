create table Colors(
ColorId int primary key identity(1,1),
ColorName nvarchar(20)
)

create table Brands(
BrandId int primary key identity(1,1),
BrandName nvarchar(25)
)

create table Cars(
Id int primary key identity (1,1),
ModelYear int,
DailyPrice int,
Description nvarchar(50),
ColorID int FOREIGN KEY REFERENCES Colors(ColorID),
BrandID int FOREIGN KEY REFERENCES Brands(BrandID),

)






