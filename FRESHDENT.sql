Create database FRESHDENT
GO

Use FRESHDENT
GO

CREATE TABLE Expediente(
Idexpediente int primary key identity (1,1),
Nombre varchar (50),
Apellido varchar (50), 
Departamento varchar (50),
Municipio varchar (50),
Celular int,
FechaNacimiento int, 
Cedula  varchar (20)
CONSTRAINT Expedientes UNIQUE (cedula, celular,Idexpediente)
);

create table Especialidad(
IdEspecialidad int primary key identity (1,1),
NombreEspecialidad varchar (50),
DescpEspecialidad  varchar (200),
CONsTRAINT Nombre_especilidad UNIQUE (NombreEspecialidad,DescpEspecialidad)
);

create table RecetaMedica(
IdReceta int primary key identity (1,1),
NombreMedicamento varchar (30),
Cantidad int,
Indicaciones varchar (200)
);
create table Cita(
IdCita int primary key identity (1,1),
NuevaCita datetime DEFAULT GETDATE(),
FechaCita date,
HoraDisponible time,
Precio int,
Idexpediente int 
foreign key (Idexpediente) references Expediente (Idexpediente),
IdEspecialidad int
foreign key (IdEspecialidad) references Especialidad (IdEspecialidad),
CONSTRAINT Citas UNIQUE (HoraDisponible,Precio,FechaCita)
);
CREATE TABLE Consulta(
IdConsulta int primary key identity (1,1),
TipoConsulta varchar (10),
IdCita int 
foreign key (IdCita) references Cita (IdCita),
IdEspecialidad int
foreign key (IdEspecialidad) references Especialidad (IdEspecialidad),
CONSTRAINT Nivel CHECK (tipoconsulta= 'programada' OR tipoconsulta='noprogramada')
);

CREATE TABLE Consulta_Receta(
IdConsulta int,
IdReceta int,
foreign key (IdConsulta) references Consulta (IdConsulta),
foreign key (IdReceta) references RecetaMedica (IdReceta),
);

									--Procedimientos Almacenados--
			--expediente--
 Create PROCEDURE RegPaciente
   @b int ,@Idexpediente int,@Nombre varchar(50),@Apellido varchar(50) ,@Departamento varchar (50), @Municipio varchar (50), @Celular int, @FechaNacimiento int,  @Cedula  varchar (20)
AS 
BEGIN
IF @b=1
   INSERT INTO Expediente VALUES (@Nombre,@Apellido, @Departamento, @Municipio,@Celular,@FechaNacimiento,@Cedula);
IF @b=2
   DELETE FROM Expediente WHERE idexpediente=@idexpediente;
IF @b=3
   Select * From Expediente
IF @b=4
  UPDATE Expediente set Nombre=@Nombre, Departamento=@Departamento, Municipio=@Municipio where Idexpediente=@Idexpediente 
IF @b=5
  select * from Expediente
  where Nombre LIKE '%'+@Nombre+'%' 
END
go
          --Especialidad--
 Create PROCEDURE RegEspecialidad
   @b int ,@IdEspecialidad int , @NombreEspecialidad varchar (50),@DescpEspecialidad  varchar (200)
AS 
BEGIN
IF @b=1
   INSERT INTO Especialidad VALUES (@NombreEspecialidad,@DescpEspecialidad);
IF @b=2
   DELETE FROM Especialidad WHERE IdEspecialidad=@IdEspecialidad;
IF @b=3
   Select * From Especialidad
IF @b=4
  UPDATE Especialidad set NombreEspecialidad=@NombreEspecialidad ,DescpEspecialidad=@DescpEspecialidad where IdEspecialidad=@IdEspecialidad 
IF @b=5
  select * from Especialidad
  where NombreEspecialidad LIKE '%'+@NombreEspecialidad+'%' 
END
go
        --RecetaMedica--
 Create PROCEDURE RegRecetaMdica
   @b int ,@IdReceta int, @NombreMedicamento varchar (30), @Cantidad int, @Indicaciones varchar (200)
AS 
BEGIN
IF @b=1
   INSERT INTO RecetaMedica VALUES (@NombreMedicamento,@Cantidad,@Indicaciones);
IF @b=2
   DELETE FROM RecetaMedica WHERE IdReceta=@IdReceta;
IF @b=3
   Select * From RecetaMedica
IF @b=4
  UPDATE RecetaMedica set NombreMedicamento=@NombreMedicamento, Cantidad=@Cantidad, Indicaciones=@Indicaciones where IdReceta=@IdReceta 
IF @b=5
  select * from RecetaMedica
  where NombreMedicamento LIKE '%'+@NombreMedicamento+'%' 
END
go

--Cita--
 Create PROCEDURE RegCita
   @b int ,@IdCita int,@NuevaCita datetime,@FechaCita date, @HoraDisponible time, @Precio int, @Idexpediente int,@IdEspecialidad int
AS 
BEGIN
IF @b=1
   INSERT INTO Cita VALUES (@NuevaCita,@FechaCita,@HoraDisponible,@Precio,@Idexpediente,@IdEspecialidad);
IF @b=2
   DELETE FROM Cita WHERE IdCita=@IdCita;
IF @b=3
 select  C.IdCita, e.Idexpediente, E.Nombre,E.Apellido,E.Celular,E.Departamento,E.Municipio,
		 C.FechaCita,C.HoraDisponible,C.Precio
   FROM Cita as C INNER JOIN  Expediente as E on C.Idexpediente=e.Idexpediente
IF @b=4
  UPDATE Cita set FechaCita=@FechaCita, HoraDisponible=@HoraDisponible, Precio=@Precio where IdCita=@IdCita 
IF @b=5
  select * from Cita
  where IdCita LIKE '%'+@IdCita+'%' 
END
go
  --RegConsulta--
   Create PROCEDURE RegConsulta
   @b int ,@IdConsulta int,@TipoConsulta varchar (10),@IdCita int, @IdEspecialidad int
AS 
BEGIN
IF @b=1
   INSERT INTO Consulta VALUES (@TipoConsulta ,@IdCita,@IdEspecialidad);
IF @b=2
   DELETE FROM Consulta WHERE IdConsulta=@IdConsulta;
IF @b=3
 select Con.IdConsulta,c.FechaCita,c.Precio,c.HoraDisponible,TipoConsulta from Consulta as Con
  inner join Especialidad as E on Con.IdEspecialidad=e.IdEspecialidad
  inner join Cita as C on C.IdCita=Con.IdCita
IF @b=4
  UPDATE Consulta set TipoConsulta=@TipoConsulta where IdConsulta=@IdConsulta 
IF @b=5
  select * from Consulta
  where IdConsulta LIKE '%'+@IdConsulta+'%' 
END
go
  --Consulta-Receta--
  -------------------------------------------------OJO---------------------------------------------------------------------

--Con este procediemiento alamcenado tengo una duda pero haganlo asi como esta, por cualquier cosa solo se modifica o solo se elimina x
 -- cualquier cosa 

  --Consulta-Receta--
Create PROCEDURE RegRecetaRegConsulta
   @b int ,@IdReceta int, @IdConsulta int 
AS 
BEGIN
IF @b=1
   INSERT INTO Consulta_Receta VALUES (@IdConsulta,@IdReceta);
IF @b=2
   DELETE FROM Consulta_Receta WHERE IdReceta=@IdReceta or IdConsulta=IdConsulta;
IF @b=3
   Select * From Consulta_Receta
IF @b=4
  select * from Consulta_Receta
  where IdConsulta LIKE '%'+@IdConsulta+'%' 
END
go