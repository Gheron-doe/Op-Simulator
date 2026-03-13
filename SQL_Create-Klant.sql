drop table if exists Klant;

create table Klant(
id int identity(1,1) not null,
voornaam nvarchar(50) not null,
familienaam nvarchar(50) not null,
email nvarchar(100) not null,
geboortedatum Date not null,
postcode nvarchar(10) not null,
gemeente nvarchar(50) not null,
straat nvarchar(100) not null,
huisnr nvarchar(5) not null
);
