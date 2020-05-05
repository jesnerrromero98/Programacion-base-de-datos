Create database DENTFRESH
GO

Use DENTFRESH
GO

CREATE TABLE Expediente(
Idexpediente int primary key identity (1,1),
Departamento varchar (50),
Municipio varchar (50),
Celular int,
FechaNacimiento int, 
Cedula  varchar (20)
CONSTRAINT Expedientes UNIQUE (cedula, celular)
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

CREATE TABLE Consulta(
IdConsulta int primary key identity (1,1),
TipoConsulta varchar (10),
Idexpediente int 
foreign key (Idexpediente) references Expediente (Idexpediente),
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
