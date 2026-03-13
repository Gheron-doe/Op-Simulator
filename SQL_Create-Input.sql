drop table if exists Adres;

create table Adres(
id int identity(1,1) not null,
postcode nvarchar(4) not null,
gemeente nvarchar(30) not null,
straat nvarchar(100) not null,
huisnr nvarchar(5) not null,
constraint PK_Adres primary key clustered (id asc)
);

drop table if exists Naam;

create table Naam(
id int identity(1,1) not null,
voornaam nvarchar(25) not null,
familienaam nvarchar(50) not null
constraint PK_Naam primary key clustered (id asc),
);