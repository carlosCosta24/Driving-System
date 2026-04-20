use DrivingLicenceSys;

create table Countries(

CountryID int identity(1,1) primary key,
CountryName nvarchar(20) not null

);
create table Persons(

PersonID int identity(1,1) primary key,
NationalNumberID nvarchar(20) not null unique,
FirstName nvarchar(20) not null,
MiddleName nvarchar(20),
LastName nvarchar(20) not null,
BirthDate datetime not null,
Address nvarchar(100) not null,
Phone nvarchar(15) not null,
Email nvarchar(40) unique,
CountryID int not null,
ImagePath nvarchar(100),
Gender char(1) check (Gender in ('M', 'F')) not null,

constraint FK_Persons_Countries
foreign key(CountryID) references Countries(CountryID) 
);

create table Users(
UserID int identity(1,1) primary key,
PersonID int not null unique,
UserName nvarchar(20) not null unique,
PasswordHash nvarchar(255) not null,
IsActive bit not null,

constraint FK_Users_Persons
foreign key(PersonID) references Persons(PersonID)
);

create table Drivers(
DriverID int identity (1,1) primary key,
PersonID int not null unique,
CreatedDate datetime not null,
CreatedByUserID int not null,

constraint FK_Drivers_Persons 
foreign key (PersonID) references Persons(PersonID),

constraint FK_Drivers_Users
foreign key (CreatedByUserID) references Users(UserID)

);