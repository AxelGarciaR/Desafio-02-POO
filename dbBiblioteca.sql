Create database dbBiblioteca;
go
Use dbBiblioteca;
go

use master
go
drop database dbBiblioteca;

Create table tbPersona(

	carnetPersona varchar(20) primary key,
	nombrePersona varchar(20) not null,
	correoPersona varchar(50) not null,
	tipoPersona varchar(20) not null

);

Create table tbLibro(
	
	ISBN int primary key,
	autorLibro varchar(20) not null,
	tituloLibro varchar(50) not null,
	editorialLibro varchar(20) not null,
	generoLibro varchar(20) not null


);

Create table tbPrestamoLibro(

	idPrestamo int primary key identity(1,1),
	fechaPrestamo date not null,
	finFechaPrestamo date not null,
	moraActivaPrestamo bit not null,
	valorMoraPrestamo decimal(4,2),
	carnetPersona varchar(20),
	ISBN int

);

Alter table tbPrestamoLibro add constraint fk_carnetPersona foreign key (carnetPersona) references tbPersona(carnetPersona);
Alter table tbPrestamoLibro add constraint fk_ISBN foreign key (ISBN) references tbLibro(ISBN);