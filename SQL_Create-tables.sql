drop table if exists Adres;
drop table if exists Klant;

create table Adres(
id int identity(1,1) not null,
postcode nvarchar(4) not null,
gemeente nvarchar(30) not null,
straat nvarchar(100) not null,
huisnr nvarchar(5) not null,
constraint PK_Adres primary key clustered (id asc)
);

create table Klant(
id int identity(1,1) not null,
voornaam nvarchar(25) not null,
familienaam nvarchar(50) not null,
email nvarchar(100) not null,
geboortedatum Date not null,
adresID int not null,
constraint PK_Klant primary key clustered (id asc),
constraint FK_Klant_Adres foreign key (adresID) references Adres(id)
);