drop table if exists Adres;

create table Adres(
id int identity(1,1) not null,
postcode nvarchar(4) not null,
gemeente nvarchar(30) not null,
straat nvarchar(100) not null,
huisnr nvarchar(5) not null,
constraint PK_Adres primary key clustered (id asc)
);

drop table if exists Voornaam_M;

create table Voornaam_M(
id int identity(1,1) not null,
voornaam nvarchar(25) not null,
constraint PK_Voornaam_M primary key clustered (id asc)
);


drop table if exists Voornaam_V;

create table Voornaam_V(
id int identity(1,1) not null,
voornaam nvarchar(25) not null,
constraint PK_Voornaam_V primary key clustered (id asc)
);

drop table if exists Familinaam;

create table Familinaam(
id int identity(1,1) not null,
familienaam nvarchar(50) not null,
constraint PK_Familienaam primary key clustered (id asc),
);
