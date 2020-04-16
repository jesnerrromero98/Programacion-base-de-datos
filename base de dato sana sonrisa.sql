create database FRESHDENT
go
use FRESHDENT
go

create table registropaciente(
idregpaciente int  primary key identity (1,1),
nombrepac varchar (20),
apeidopac varchar (20),
direccion varchar (100),
departamento varchar (50),
municipio varchar (50),
celular int,
telefono int,
edad int, 
cedula  varchar (20)
CONSTRAINT Registro_paciente UNIQUE (cedula, telefono , celular)
);

create table citas(
idcitas int primary key identity (1,1),
nuevascitas datetime DEFAULT GETDATE(),
fechacita date,
horadisponible time,
precio int,
idregpaciente int,
foreign key (idregpaciente) references registropaciente (idregpaciente),
CONsTRAINT Nombre_citas UNIQUE (horadisponible,precio,fechacita)
);

create table especialidad(
codespecialidad int primary key identity (1,1),
nombrespecialidad varchar (50),
descespecialidad  varchar (200),
idcitas int,
foreign key (idcitas) references citas (idcitas),
CONsTRAINT Nombre_especilidad UNIQUE (nombrespecialidad,descespecialidad)
);

create table consultas (
idconsulta int primary key identity (1,1),
tipoconsulta varchar (10),
idregpaciente int,
idcitas int,
foreign key (idcitas) references citas (idcitas),
foreign key (idregpaciente) references registropaciente (idregpaciente),
CONSTRAINT Nivel CHECK (tipoconsulta= 'programada' OR tipoconsulta='noprogramada')
);

create table recetamedica(
idreceta int primary key identity (1,1),
nombremedicamento varchar (30),
cantidad int,
indicaciones varchar (200),
idregpaciente int,
foreign key (idregpaciente) references registropaciente (idregpaciente),
);

create table expediente (
idexpediente int primary key identity (1,1),
idregpaciente int,
idconsulta int,
codespecialidad int,
idcitas int,
idreceta int,
foreign key (idregpaciente) references registropaciente (idregpaciente),
foreign key (idconsulta) references consultas (idconsulta),
foreign key (codespecialidad) references especialidad (codespecialidad),
foreign key (idcitas) references citas (idcitas),
foreign key (idreceta) references recetamedica (idreceta)
);
 
--registro paciente                                               --procedimientos almacenados--


CREATE PROCEDURE registro_pacientes
   @b int, @idregpaciente int, @nombrepac varchar (20),@apeidopac varchar (20),@direccion varchar (100), @departamento varchar (50),
   @municipio varchar (50),@celular int, @telefono int,@edad int, @cedula  varchar (20)
AS 
BEGIN
SET NOCOUNT ON;
IF @b=1
   INSERT INTO registropaciente VALUES (@nombrepac, @apeidopac, @direccion, @departamento, @municipio, @celular, @telefono, @edad, @cedula);
IF @b=2
   DELETE FROM registropaciente WHERE idregpaciente=@idregpaciente;
IF @b=3
   SELECT * FROM registropaciente
IF @b=4
UPDATE registropaciente set nombrepac=@nombrepac, apeidopac=@apeidopac, direccion=@direccion, departamento=@departamento,
       municipio=@municipio, celular=@celular, telefono=@telefono where idregpaciente=@idregpaciente
IF @b=5
 select * from registropaciente
 where nombrepac LIKE '%'+@nombrepac+'%' 
END
GO

  -- citas--


CREATE PROCEDURE Cita
   @b int, @idcitas int, @nuevascitas datetime, @fechacita date, @horadisponible time, @precio int, @idregpaciente int

AS 
BEGIN
SET NOCOUNT ON;
IF @b=1
   INSERT INTO citas VALUES (@nuevascitas, @fechacita, @horadisponible,@precio,@idregpaciente);
IF @b=2
   DELETE FROM citas WHERE idcitas=@idcitas;
IF @b=3
   SELECT 
         c.idcitas, P.idregpaciente, P.nombrepac,P.direccion,P.celular,P.departamento,P.municipio,
		 c.fechacita,c.horadisponible,c.precio
   FROM registropaciente as P INNER JOIN citas as C on C.idregpaciente=P.idregpaciente
   
IF @b=4
UPDATE citas set nuevascitas=@nuevascitas, fechacita=@fechacita, horadisponible=@horadisponible, precio=@precio where idcitas=@idcitas
IF @b=5
 select * from citas
 where nuevascitas LIKE '%'+@nuevascitas+'%' 
END
GO

                            --especialidades--
CREATE PROCEDURE especialidades
   @b int,@codespecialidad int, @nombrespecialidad varchar (50),@descespecialidad  varchar (200),@idcitas int
AS 
BEGIN
SET NOCOUNT ON;
IF @b=1
   INSERT INTO especialidad VALUES (@nombrespecialidad, @descespecialidad,@idcitas);
IF @b=2
   DELETE FROM especialidad WHERE codespecialidad=@codespecialidad;
IF @b=3
   SELECT * FROM especialidad --duda--
IF @b=4
UPDATE especialidad set nombrespecialidad=@nombrespecialidad where codespecialidad=@codespecialidad
IF @b=5
 select * from especialidad
 where nombrespecialidad LIKE '%'+@nombrespecialidad+'%' 
END
GO

              --consulta--

CREATE PROCEDURE consulta
   @b int,@idconsulta int, @tipoconsulta varchar (10),@idregpaciente int,@idcitas int
AS 
BEGIN
SET NOCOUNT ON;
IF @b=1
   INSERT INTO consultas VALUES (@tipoconsulta, @idregpaciente, @idcitas);
IF @b=2
   DELETE FROM consultas WHERE idconsulta=@idconsulta;
IF @b=3
   SELECT 
         t.idconsulta,C.idcitas, P.idregpaciente, P.nombrepac,P.direccion,P.celular,P.departamento,P.municipio,
		 c.fechacita,c.horadisponible,c.precio,t.tipoconsulta
   FROM registropaciente as P INNER JOIN citas as C on C.idregpaciente=P.idregpaciente inner join consultas as T on c.idcitas=t.idcitas
   
IF @b=4
UPDATE consultas set tipoconsulta=@tipoconsulta where idconsulta=@idconsulta
IF @b=5
 select * from consultas
 where tipoconsulta LIKE '%'+@tipoconsulta+'%' 
END
GO
                   --resetamedica--

CREATE PROCEDURE reseta
   @b int, @idreceta int,@nombremedicamento varchar (30),@cantidad int, @indicaciones varchar (200), @idregpaciente int
AS 
BEGIN
SET NOCOUNT ON;
IF @b=1
   INSERT INTO recetamedica VALUES (@nombremedicamento, @cantidad, @indicaciones, @idregpaciente);
IF @b=2
   DELETE FROM recetamedica WHERE idreceta=@idreceta;
IF @b=3
   SELECT  R.idreceta,P.idregpaciente, P.nombrepac,P.direccion,P.celular,P.departamento,P.municipio,R.nombremedicamento,
         R.cantidad,R.indicaciones
   FROM registropaciente as P INNER JOIN recetamedica as R on R.idregpaciente=P.idregpaciente
IF @b=4
UPDATE recetamedica set nombremedicamento=@nombremedicamento, cantidad=@cantidad, indicaciones=@indicaciones where idreceta=@idreceta
IF @b=5
 select * from recetamedica
 where nombremedicamento LIKE '%'+@nombremedicamento+'%' 
END
GO

                    --expediente--
CREATE PROCEDURE expedientemedico
   @b int, @idreceta int,@idconsulta int,@codespecialidad int,@idexpediente int, @idregpaciente int,@idcitas int

AS 
BEGIN
SET NOCOUNT ON;
IF @b=1
   INSERT INTO expediente VALUES (@idreceta, @codespecialidad, @idcitas,@idconsulta, @idregpaciente);
IF @b=2
   DELETE FROM expediente WHERE idexpediente=@idexpediente;
IF @b=3
   SELECT e.idexpediente,t.fechacita,t.precio,p.nombrepac,p.apeidopac,p.direccion,p.departamento,p.municipio,p.celular,c.tipoconsulta,
   d.nombrespecialidad,d.descespecialidad,r.nombremedicamento,r.cantidad,r.indicaciones
   from registropaciente as p  inner join expediente as e on p.idregpaciente=e.idregpaciente
   inner join consultas as c on c.idconsulta=e.idconsulta 
   inner join especialidad as d on d.codespecialidad=e.codespecialidad
   inner join citas as t on t.idcitas=e.idcitas
   inner join recetamedica as r on r.idreceta=e.idreceta

IF @b=4
  select * from expediente
  where idexpediente LIKE '%'+@idexpediente+'%' 
END
GO  
			 


