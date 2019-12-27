CREATE DATABASE biblioteca;
GO
USE [biblioteca];

GO
/*
CREATE TABLE Permiso(
	idPermiso INT NOT NULL IDENTITY(1,1),
	codigo INT not null,
    descripcion varchar(80) not null,
    primary key(idPermiso),
);

*/

CREATE TABLE Perfil(
	idPerfil INT IDENTITY(1,1) NOT NULL,
	nombre varchar(50) NOT NULL,
	/*idPermisos INT foreign key references Permiso,*/
	borrado BIT not null DEFAULT 0,
	PRIMARY KEY(idPerfil)
);

CREATE TABLE Usuario(
	idUsuario INT NOT NULL IDENTITY(1,1),
    usuario varchar(40) not null,
    contraseña varchar(40) not null,
    estado varchar(10) null,
    idPerfil int foreign key references Perfil ,
    borrado BIT not null DEFAULT 0,
    PRIMARY KEY(idUsuario)
);

CREATE TABLE Ciudad(
	idCiudad INT not null IDENTITY(1,1),
    nombre varchar(40) not null,
    borrado BIT not null DEFAULT 0,
    PRIMARY KEY(idCiudad)
);

CREATE TABLE TipoDocumento(
	idTipoDoc INT not null IDENTITY(1,1),
    nombre varchar(40) not null,
    borrado BIT not null DEFAULT 0,
    PRIMARY KEY(idTipoDoc)
);

CREATE TABLE EstadoEjemplar(
	
	idEstadoEjemplar INT not null IDENTITY(1,1),
    nombre varchar(40) not null,
    borrado BIT not null DEFAULT 0,
    PRIMARY KEY(idEstadoEjemplar)
);

CREATE TABLE Editorial(
	
	idEditorial INT not null IDENTITY(1,1),
    nombreEditorial varchar(40) not null,
    borrado BIT not null DEFAULT 0,
    PRIMARY KEY(idEditorial)
);

CREATE TABLE Autor(
	
	idAutor INT not null IDENTITY(1,1),
    nombre varchar(40) not null,
    borrado BIT not null DEFAULT 0,
    PRIMARY KEY(idAutor)
);

CREATE TABLE EstadoDetallePrestamo(
	
	idEstadoDetallePrestamo INT not null IDENTITY(1,1),
    nombre varchar(40) not null,
    borrado BIT not null DEFAULT 0,
    PRIMARY KEY(idEstadoDetallePrestamo)
);

CREATE TABLE Genero(

	idGenero INT not null IDENTITY(1,1),
    nombre varchar(40) not null,
    borrado BIT not null DEFAULT 0,
    PRIMARY KEY(idGenero)
);




CREATE TABLE EstadoPrestamo(
	
	idEstadoPrestamo INT not null IDENTITY(1,1),
    nombre varchar(40) not null,
    borrado BIT not null DEFAULT 0,
    PRIMARY KEY(idEstadoPrestamo)
);




CREATE TABLE EstadoPedido(
	
	idEstadoPedido INT not null IDENTITY(1,1),
    nombre varchar(40) not null,
    borrado BIT not null DEFAULT 0,
    PRIMARY KEY(idEstadoPedido)
);




CREATE TABLE Pedido(
	
	idPedido INT not null IDENTITY(1,1),
    idEstadoPedido INT foreign key references EstadoPedido,	
    fechaPedido DATE not null,
    fechaRecepcion DATE not null,
    borrado BIT not null DEFAULT 0,
    PRIMARY KEY(idPedido)
);




CREATE TABLE Barrio(
	
	idBarrio INT not null IDENTITY(1,1),
	idCiudad INT foreign key references Ciudad,
    nombre varchar(32) not null,
    borrado BIT not null DEFAULT 0,
    PRIMARY KEY(idBarrio)
);



CREATE TABLE Proveedor(
	
	idProveedor INT not null IDENTITY(1,1),
	idBarrio INT foreign key references Barrio,
    razonSocial varchar(32) not null,
    telefono INT not null,
    mail varchar(32) not null,
    calle varchar(32) not null,
    nro INT not null,
    borrado BIT not null DEFAULT 0,
    PRIMARY KEY(idProveedor)
);




/*
 Se elimino el campo idUsuario y se cambio el tipo de dato del campo calle a varchar
 */
CREATE TABLE Socio(

	idSocio INT not null IDENTITY(1,1),
    idTipoDoc INT foreign key references TipoDocumento,
    idBarrio INT foreign key references Barrio,
    numeroDocumento INT not null,
    nombre varchar(32) not null,
    apellido varchar(32) not null,
    mail varchar(32) not null,
    telefono INT not null,
    calle varchar(40) not null,
    nro INT not null,
	borrado BIT not null DEFAULT 0,
    PRIMARY KEY(idSocio),
    
);



CREATE TABLE Libro(
	idLibro INT not null IDENTITY(1,1),
    titulo varchar(32) not null,
    añoEdicion INT not null,  
    idGenero INT foreign key references Genero,
    idAutor INT foreign key references  Autor,
    idEditorial INT foreign key references Editorial,
    sector varchar(32)not null,
    estante INT not null,
    borrado BIT not null DEFAULT 0,
    PRIMARY KEY(idLibro)
);



CREATE TABLE Ejemplar(
	
	idEjemplar INT not null,
    idLibro INTeger foreign key references Libro,
    idEstadoEjemplar INT foreign key references EstadoEjemplar,
    borrado BIT not null DEFAULT 0,
    PRIMARY KEY(idEjemplar, idLibro)
);


CREATE TABLE DetallePedido(
	
	idPedido INT not null IDENTITY(1,1),
    idEjemplar INT not null,
    idLibro INT not null,
    cantidad INT not null,
    precio INT not null,
    borrado BIT not null DEFAULT 0,
    PRIMARY KEY(idPedido, idEjemplar, idLibro),

    FOREIGN KEY (idEjemplar,idLibro) REFERENCES Ejemplar(idEjemplar,idLibro),
);


CREATE TABLE Prestamo(
	
	idPrestamo INT not null IDENTITY(1,1),
    idSocio INT foreign key references Socio,
    idEstadoPrestamo INT foreign key references EstadoPrestamo,
    fechaPrestamo DATE not null,
    fechaLimite DATE not null,
    borrado BIT not null DEFAULT 0,
    PRIMARY KEY(idPrestamo)
);


CREATE TABLE DetallePrestamo(
	
	idDetallePrestamo INT not null IDENTITY(1,1),
	idPrestamo INT foreign key references Prestamo,
	idEstadoDetallePrestamo INT foreign key references EstadoDetallePrestamo,
    idEjemplar INT not null,
	idLibro INT not null,
    fechaDevolucion DATE,
    borrado BIT not null DEFAULT 0,
    PRIMARY KEY (idDetallePrestamo),
	FOREIGN KEY (idEjemplar,idLibro) REFERENCES Ejemplar(idEjemplar,idLibro)
);




CREATE TABLE Compra(

	idCompra INT not null IDENTITY(1,1),
	idProveedor INT foreign key references Proveedor,
	fechaCompra DATE not null,
	borrado BIT not null DEFAULT 0,
	PRIMARY KEY(idCompra)
)


CREATE TABLE DetalleCompra(
	idDetalleCompra INT not null IDENTITY(1,1),
	idCompra int foreign key references Compra,
	idLibro INT  foreign key references Libro,
	cantidad INT not null,
	borrado BIT not null DEFAULT 0,
	PRIMARY KEY(idDetalleCompra),
)



						/*** INSERCIÓN DE DATOS ***/


						


/*** Insertando Perfiles ***/

INSERT INTO Perfil (nombre,borrado) VALUES ('Administrador',0)
INSERT INTO Perfil (nombre,borrado) VALUES ('Bibliotecario',0)


/*** Insertando usuarios ***/
INSERT INTO Usuario (usuario, contraseña, estado, idPerfil, borrado) VALUES ('Miguel123', '123123', 'S', 2,0)
INSERT INTO Usuario (usuario, contraseña, estado, idPerfil, borrado) VALUES ('Juan321', '123123', 'N', 2,0)
INSERT INTO Usuario (usuario, contraseña, estado, idPerfil, borrado) VALUES ('ADMIN', 'ADMIN', 'S', 1,0)
INSERT INTO Usuario (usuario, contraseña, estado, idPerfil, borrado) VALUES ('Gustavo', '123123', 'S', 2,0)
INSERT INTO Usuario (usuario, contraseña, estado, idPerfil, borrado) VALUES ('perez121', '123123', 'S', 2,0)
INSERT INTO Usuario (usuario, contraseña, estado, idPerfil, borrado) VALUES ('Jaime12311', '123123', 'S', 2,0)
INSERT INTO Usuario (usuario, contraseña, estado, idPerfil, borrado) VALUES ('Perla131', '123123', 'S', 2,0)

/*** Insertando tipo de documento***/

INSERT INTO TipoDocumento (nombre, borrado) VALUES ('DNI',0);
INSERT INTO TipoDocumento (nombre, borrado) VALUES ('Libreta',0);
INSERT INTO TipoDocumento (nombre, borrado) VALUES ('PASaporte',0);

/*** Insertando Estados preestamos ***/

	INSERT INTO EstadoPrestamo(nombre) VALUES ('Iniciado');
	INSERT INTO EstadoPrestamo(nombre) VALUES ('Finalizado');
	INSERT INTO EstadoPrestamo(nombre) VALUES ('Vencido');
	
/*** Insertando Estados Detalle preestamos ***/
	
	INSERT INTO EstadoDetallePrestamo(nombre) VALUES ('Prestado');
	INSERT INTO EstadoDetallePrestamo(nombre) VALUES ('Devuelto');
	
	
/*** Insertando Estados Ejemplar ***/
	
	INSERT INTO EstadoEjemplar(nombre) VALUES ('Disponible');
	INSERT INTO EstadoEjemplar(nombre) VALUES ('Prestado');
	




/*** Insertando autores ***/

INSERT INTO Autor(nombre)VALUES('Patrick Rockffuss');
INSERT INTO Autor(nombre)VALUES('Stephen King');
INSERT INTO Autor(nombre)VALUES('Brandon sanderson');
INSERT INTO Autor(nombre)VALUES('Hermann Hesse');
INSERT INTO Autor(nombre)VALUES('Gaston Leroux');
INSERT INTO Autor(nombre)VALUES('John Katzenbach');
INSERT INTO Autor(nombre)VALUES('J. R. R. Tolkien');
INSERT INTO Autor(nombre)VALUES('Orson Scott Card');
INSERT INTO Autor(nombre)VALUES('James Dashner');
INSERT INTO Autor(nombre)VALUES('Pittacus Lore');
INSERT INTO Autor(nombre)VALUES('Ray Bradbury');
INSERT INTO Autor(nombre)VALUES('George R. R. Martin');



/*** Insertando ciudades ***/
INSERT INTO Ciudad (nombre,borrado) VALUES ('Córdoba',0);
INSERT INTO Ciudad (nombre,borrado) VALUES ('Rio Cuarto',0);
INSERT INTO Ciudad (nombre,borrado) VALUES ('Cosquin',0);
INSERT INTO Ciudad (nombre,borrado) VALUES ('Carlos Paz',0);


/*** Insertando barrios ***/
INSERT INTO Barrio (idCiudad,nombre,borrado) VALUES (4,'Colon',0);
INSERT INTO Barrio (idCiudad,nombre,borrado) VALUES (1,'Alberdi',0);
INSERT INTO Barrio (idCiudad,nombre,borrado) VALUES (1,'Nueva Córdoba',0);
INSERT INTO Barrio (idCiudad,nombre,borrado) VALUES (1,'Bajo Palermo',0);
INSERT INTO Barrio (idCiudad,nombre,borrado) VALUES (1,'Escobar',0);
INSERT INTO Barrio (idCiudad,nombre,borrado) VALUES (1,'Urca',0);
INSERT INTO Barrio (idCiudad,nombre,borrado) VALUES (2,'Belgrano',0);
INSERT INTO Barrio (idCiudad,nombre,borrado) VALUES (3,'Palermo',0)



/*** Insertando generos ***/

INSERT INTO Genero(nombre,borrado)VALUES('Ciencia',0);
INSERT INTO Genero(nombre,borrado)VALUES('Aventura',0);
INSERT INTO Genero(nombre,borrado)VALUES('Romance',0);
INSERT INTO Genero(nombre,borrado)VALUES('FantASia',0);
INSERT INTO Genero(nombre,borrado)VALUES('Misterio',0);
INSERT INTO Genero(nombre,borrado)VALUES('Terror',0);




/*** Insertando editoriales***/

INSERT INTO Editorial(nombreEditorial,borrado)VALUES('Booket',0);
INSERT INTO Editorial(nombreEditorial,borrado)VALUES('Gradifco',0);
INSERT INTO Editorial(nombreEditorial,borrado)VALUES('Penguin Random House',0);
INSERT INTO Editorial(nombreEditorial,borrado)VALUES('Minotauro',0);
INSERT INTO Editorial(nombreEditorial,borrado)VALUES('HarperCollins',0);
INSERT INTO Editorial(nombreEditorial,borrado)VALUES('Tor Books',0);
INSERT INTO Editorial(nombreEditorial,borrado)VALUES('ZETA',0);
INSERT INTO Editorial(nombreEditorial,borrado)VALUES('Norma',0);
INSERT INTO Editorial(nombreEditorial,borrado)VALUES('Ediciones B',0);


/*** Insertando libros y ejemplares***/




/*** Insertando Socios ***/

INSERT INTO Socio (idTipoDoc,idBarrio,numeroDocumento, nombre, apellido, mail, telefono,calle,nro,borrado) VALUES (1,1,45688952,'Juan','Perez','juanPerez@gmail.com', 4569875,'Pedroni','1250',0)
INSERT INTO Socio (idTipoDoc,idBarrio,numeroDocumento, nombre, apellido, mail, telefono,calle,nro,borrado) VALUES (1,1,45688952,'Ana','Rodriguez','ana@gmail.com', 4854875,'Virgen de la Merced','2005',0)
INSERT INTO Socio (idTipoDoc,idBarrio,numeroDocumento, nombre, apellido, mail, telefono,calle,nro,borrado) VALUES (1,1,45688952,'Emilia','Sanchez','emilia@gmail.com', 4569875,'Mariano Larra','2548',0)

/*** Insertando Proveedores ***/



INSERT INTO Proveedor(idBarrio,razonSocial,telefono,mail,calle,nro,borrado) VALUES (1, 'Alibaba', 31231221, 'Alibaba@gmail.com', 'Chacabuco', 123, 0)
INSERT INTO Proveedor(idBarrio,razonSocial,telefono,mail,calle,nro,borrado) VALUES 	(2,	'Yenni',31231221,'Yenni@gmail.com','Poeta Lugones',123,0)
INSERT INTO Proveedor(idBarrio,razonSocial,telefono,mail,calle,nro,borrado) VALUES 	(3,	'Leas Distribuidora',31231221,'LeasDistribuidora@gmail.com','Yrigoyen',123,0)
INSERT INTO Proveedor(idBarrio,razonSocial,telefono,mail,calle,nro,borrado) VALUES  (1,	'Cuspide Libros',31231221,'CuspideLibros@gmail.com','Velez zarfiel', 123,0)
INSERT INTO Proveedor(idBarrio,razonSocial,telefono,mail,calle,nro,borrado) VALUES 	(2,	'Agape Libros',31231221,'AgapeLibros@gmail.com','Lima', 123,0)
INSERT INTO Proveedor(idBarrio,razonSocial,telefono,mail,calle,nro,borrado) VALUES 	(3,	'El Ateneo',31231221,'ElAteneo@PgmailU.com','Rondeau', 123,0)
INSERT INTO Proveedor(idBarrio,razonSocial,telefono,mail,calle,nro,borrado) VALUES 	(1,	'El Vegano',31231221,'ElVegano@TgmailA.com','Ituzaingo', 123,0)





--SELECT DATEADD(DAY, 10, CONVERT(datetime ,GetDate(), 103));
--select CONVERT(VARCHAR(10),GetDate(), 103);
--SELECT CONVERT(VARCHAR(10), getdate(), 111);
--SELECT CONVERT(VARCHAR(10), DATEADD(DAY, 10, GetDate()), 111);



						/*** Insertando Compras y detalles***/	


INSERT INTO COMPRA (fechaCompra,idProveedor) VALUES (GetDate(),1)
INSERT INTO Libro (titulo,añoEdicion,idGenero,idAutor,idEditorial,sector,estante,borrado) VALUES ('El nombre del viento',2019,2,1,3,'Oro',3,0);
INSERT INTO DetalleCompra(idCompra,idLibro,cantidad) values (1,1,3)
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(1,1,1);
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(1,2,1);
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(1,3,1);




INSERT INTO COMPRA (fechaCompra,idProveedor) VALUES (GetDate(),2)
INSERT INTO Libro (titulo,añoEdicion,idGenero,idAutor,idEditorial,sector,estante,borrado) VALUES ('El Hobbit',2015,4,7,1,'Plata',1,0);
INSERT INTO DetalleCompra(idCompra,idLibro,cantidad) values (2,2,3)
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(2,1,1);
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(2,2,1);
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(2,3,1);




INSERT INTO COMPRA (fechaCompra,idProveedor) VALUES (GetDate(),3)
INSERT INTO Libro (titulo,añoEdicion,idGenero,idAutor,idEditorial,sector,estante,borrado) VALUES ('Fisica I',2018,1,2,3,'Oro',2,0);
INSERT INTO DetalleCompra(idCompra,idLibro,cantidad) values (3,3,3)
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(3,1,1);
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(3,2,1);
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(3,3,1);





INSERT INTO COMPRA (fechaCompra,idProveedor) VALUES (GetDate(),1)
INSERT INTO Libro (titulo,añoEdicion,idGenero,idAutor,idEditorial,sector,estante,borrado) VALUES ('Analisis matematico I',2000,1,3,1,'Plata',1,0);
INSERT INTO DetalleCompra(idCompra,idLibro,cantidad) values (4,4,3)
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(4,1,1);
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(4,2,1);
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(4,3,1);





INSERT INTO COMPRA (fechaCompra,idProveedor) VALUES (GetDate(),2)
INSERT INTO Libro (titulo,añoEdicion,idGenero,idAutor,idEditorial,sector,estante,borrado) VALUES ('It',1990,4,2,4,'Plata',2,0);
INSERT INTO DetalleCompra(idCompra,idLibro,cantidad) values (5,5,3)
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(5,1,1);
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(5,2,1);
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(5,3,1);



INSERT INTO COMPRA (fechaCompra,idProveedor) VALUES (GetDate(),3)
INSERT INTO Libro (titulo,añoEdicion,idGenero,idAutor,idEditorial,sector,estante,borrado) VALUES ('Game of thrones',1990,4,12,4,'Plata',2,0);
INSERT INTO DetalleCompra(idCompra,idLibro,cantidad) values (6,6,3)
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(6,1,1);
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(6,2,1);
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(6,3,1);



INSERT INTO COMPRA (fechaCompra,idProveedor) VALUES (GetDate(),4)
INSERT INTO Libro (titulo,añoEdicion,idGenero,idAutor,idEditorial,sector,estante,borrado) VALUES ('Ender games',1990,4,8,4,'Plata',2,0);
INSERT INTO DetalleCompra(idCompra,idLibro,cantidad) values (7,7,3)
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(7,1,1);
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(7,2,1);
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(7,3,1);



INSERT INTO COMPRA (fechaCompra,idProveedor) VALUES (GetDate(),5)
INSERT INTO Libro (titulo,añoEdicion,idGenero,idAutor,idEditorial,sector,estante,borrado) VALUES ('Soy el numero 4',1990,4,10,4,'Plata',2,0);
INSERT INTO DetalleCompra(idCompra,idLibro,cantidad) values (8,8,3)
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(8,1,1);
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(8,2,1);
INSERT INTO Ejemplar (idLibro,idEjemplar,idEstadoEjemplar) values(8,3,1);







						/*** Insertando Preestamos y Detalles ***/
						
						

						
						/*** Insertando preestamos numero 1 ***/
INSERT INTO Prestamo(idSocio,idEstadoPrestamo,fechaPrestamo,fechaLimite) VALUES (2,1,CONVERT(datetime ,GetDate(), 111),CONVERT(datetime, DATEADD(DAY, 10, GetDate()), 111))
INSERT INTO DetallePrestamo(idPrestamo,idEstadoDetallePrestamo,idLibro,idEjemplar) values(1,1,1,1);
INSERT INTO DetallePrestamo(idPrestamo,idEstadoDetallePrestamo,idLibro,idEjemplar) values(1,1,2,1);

						/*** Insertando preestamos numero 2 ***/
INSERT INTO Prestamo(idSocio,idEstadoPrestamo,fechaPrestamo,fechaLimite) VALUES (1,1,CONVERT(datetime ,GetDate(), 111),CONVERT(datetime, DATEADD(DAY, 10, GetDate()), 111))
INSERT INTO DetallePrestamo(idPrestamo,idEstadoDetallePrestamo,idLibro,idEjemplar) values(2,2,1,2);
INSERT INTO DetallePrestamo(idPrestamo,idEstadoDetallePrestamo,idLibro,idEjemplar) values(2,2,2,2);

						/*** Insertando preestamos numero 3 ***/
INSERT INTO Prestamo(idSocio,idEstadoPrestamo,fechaPrestamo,fechaLimite) VALUES (3,1,CONVERT(datetime ,GetDate(), 111),CONVERT(datetime, DATEADD(DAY, 10, GetDate()), 111))
INSERT INTO DetallePrestamo(idPrestamo,idEstadoDetallePrestamo,idLibro,idEjemplar) values(3,2,1,3);
INSERT INTO DetallePrestamo(idPrestamo,idEstadoDetallePrestamo,idLibro,idEjemplar) values(3,2,2,3);

						/*** Insertando preestamos numero 4 ***/
INSERT INTO Prestamo(idSocio,idEstadoPrestamo,fechaPrestamo,fechaLimite) VALUES (1,1,CONVERT(datetime ,GetDate(), 111),CONVERT(datetime, DATEADD(DAY, 10, GetDate()), 111))
INSERT INTO DetallePrestamo(idPrestamo,idEstadoDetallePrestamo,idLibro,idEjemplar) values(4,2,3,1);
INSERT INTO DetallePrestamo(idPrestamo,idEstadoDetallePrestamo,idLibro,idEjemplar) values(4,2,4,1);

						/*** Insertando preestamos numero 5 ***/
INSERT INTO Prestamo(idSocio,idEstadoPrestamo,fechaPrestamo,fechaLimite) VALUES (2,1,CONVERT(datetime ,GetDate(), 111),CONVERT(datetime, DATEADD(DAY, 10, GetDate()), 111))
INSERT INTO DetallePrestamo(idPrestamo,idEstadoDetallePrestamo,idLibro,idEjemplar) values(5,2,3,2);
INSERT INTO DetallePrestamo(idPrestamo,idEstadoDetallePrestamo,idLibro,idEjemplar) values(5,2,4,2);

						/*** Insertando preestamos numero 6 ***/
INSERT INTO Prestamo(idSocio,idEstadoPrestamo,fechaPrestamo,fechaLimite) VALUES (3,1,CONVERT(datetime ,GetDate(), 111),CONVERT(datetime, DATEADD(DAY, 10, GetDate()), 111))
INSERT INTO DetallePrestamo(idPrestamo,idEstadoDetallePrestamo,idLibro,idEjemplar) values(6,2,3,3);
INSERT INTO DetallePrestamo(idPrestamo,idEstadoDetallePrestamo,idLibro,idEjemplar) values(6,2,4,3);






					/*** DEFINICION DE PROCEDIMIENTOS ALMACENADOS ***/




/*** Listar autores ***/ 
GO  
CREATE PROCEDURE listarAutores  
    
AS   
	SELECT idAutor AS ID, nombre AS Nombre FROM Autor WHERE borrado=0
     
GO  


/*** Listar generos***/ 

GO  
CREATE PROCEDURE listarGeneros
    
AS   
	SELECT idGenero AS ID, nombre AS Nombre FROM Genero WHERE borrado=0
     
GO  




/*** Listar editoriales***/ 

GO  
CREATE PROCEDURE listarEditoriales
    
AS   
	SELECT idEditorial AS ID, nombreEditorial AS Nombre FROM Editorial WHERE borrado=0
     
GO  


/*** Listar libros ***/ 
GO  
CREATE PROCEDURE listarLibros
    

AS   
	SELECT idLibro AS ID, titulo AS Titulo, añoEdicion AS Edicion,G.nombre AS Genero ,A.nombre AS Autor, 
	E.nombreEditorial AS Editorial ,sector AS Sector, estante AS Estante FROM Libro L
	inner join  Genero G on G.idGenero = L.idEditorial
	inner join  Autor A on A.idAutor = L.idAutor
	inner join  Editorial E on E.idEditorial = L.idEditorial
	WHERE  L.borrado=0

GO  
/*** Listar Prestamos***/ 

GO  
CREATE PROCEDURE listarPrestamos
    
AS   
	SELECT P.idPrestamo AS Codigo, S.nombre AS Socio, E.nombre as Estado,P.fechaPrestamo as 'Fecha de Prestamo',P.fechaLimite as 'Fecha de Devolucion' FROM Prestamo P join EstadoPrestamo E on E.idEstadoPrestamo = P.idEstadoPrestamo join Socio S on S.idSocio = P.idSocio WHERE P.borrado=0 
GO  

/*** Listar tipo de documentos ***/ 
GO  
CREATE PROCEDURE listarTipoDoc
    
AS   
	SELECT idTipoDoc AS ID, nombre AS Documento FROM TipoDocumento WHERE borrado=0
     
GO
/*** Listar usuarios ***/ 
GO  
CREATE PROCEDURE listarUsuarios
    
AS   
	SELECT idUsuario AS ID, usuario AS NombreUsuario FROM Usuario WHERE borrado=0
     
GO


/*** Listar barrios ***/ 
GO    

CREATE PROCEDURE listarBarrios
    
AS   
	SELECT idBarrio AS ID, nombre AS Barrio FROM Barrio WHERE borrado=0
     
GO   


/*** Listar socios ***/ 
GO  
CREATE PROCEDURE listarSocios
    
AS   
	SELECT S.idSocio AS Socio, T.nombre AS 'Tipo de Documento', B.nombre Barrio, S.numeroDocumento AS 'Numero de Documento',
	S.nombre AS Nombre, S.apellido AS Apellido, S.mail AS Email, S.telefono AS Telefono, S.calle AS Dirección, S.nro AS Altura
	FROM Socio S
	JOIN TipoDocumento T ON S.idTipoDoc=T.idTipoDoc
	JOIN Barrio B ON S.idBarrio=B.idBarrio
	WHERE S.borrado=0

GO  

/*** Listar Proveedores ***/ 
GO  
CREATE PROCEDURE listarProveedores  
    
AS   
	SELECT P.idProveedor AS ID,P.razonSocial AS 'Razon Social', B.nombre AS Barrio , P.telefono AS Telefono,
	P.mail AS Mail, P.calle as Calle, P.nro as 'Altura'
	FROM Proveedor P 
	join Barrio B on B.idBarrio = P.idBarrio 
	where P.borrado = 0;
GO  









