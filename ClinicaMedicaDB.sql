CREATE DATABASE ClinicaMedica;
GO
USE ClinicaMedica;
GO

-- Roles
CREATE TABLE Roles (
  idRol INT IDENTITY(1,1) PRIMARY KEY,
  nombreRol VARCHAR(50) NOT NULL UNIQUE
);
go
create table Especialidades(
idEspecialidad int primary key identity(1,1),
nombreEspecialidad varchar(50),
);
go
insert into Especialidades values ('Medicina General'),('Cardiología'),('Urología'),('Endocrinología'),('Reumatología'),('Oncología'),('Neurología');
go
CREATE TABLE Usuarios (
  idUsuario INT IDENTITY(1,1) PRIMARY KEY,
  nombreUsuario VARCHAR(50) NOT NULL UNIQUE,
  contraseña VARCHAR(100) NOT NULL,
  idRol int,
  constraint FKidRol FOREIGN KEY (idRol) REFERENCES Roles(idRol) on delete cascade,
);
go
CREATE TABLE Pacientes (
  idPaciente INT IDENTITY(1,1) PRIMARY KEY,
  nombrePaciente VARCHAR(120) NOT NULL,
  Telefono VARCHAR(25) NULL,
);
go

create table Medicos (
  idMedico int identity (1,1) primary key,
  nombreMedico varchar(120) not null,
  fechaNacimiento date,
  numero int,
  dui int,
  idUsuario int,
  constraint FKidUsuario foreign key (idUsuario) references Usuarios(idUsuario) on delete cascade
);
go


create table Citas (
  idCita int identity(1,1) primary key,
  idPaciente int not null,
  idMedico int not null,
  idEspecialidad int,
  motivo varchar (100) not null,
  observaciones varchar(500),
  foreign key (idPaciente) references Pacientes(idPaciente),
  foreign key (idMedico) references Medicos(idMedico),
  foreign key (idEspecialidad) references Especialidades(idEspecialidad)
);
go

select*from Citas

insert into Roles (nombreRol) values 
('Administrador'),
('Médico'),
('Recepcionista');
go
insert into Usuarios (nombreUsuario, contraseña, idRol) values
('admin', '123', 1),
('doctor', '123', 2),
('recepcion', '123', 3);
go
insert into Pacientes (nombrePaciente, Telefono) values
('Juan Pérez', '7890-1234'),
('María Gómez', '7123-4567'),
('Luis Rodríguez', '7456-7890');
go

insert into Medicos values
('Dr. Carlos Hernández','1925/12/25',74579867, 01007464, 2);
go

select*from Medicos

insert into Citas values
(1, 1, 2, 'Chequeo general', 'Revisión de presión arterial y peso')

CREATE VIEW VerDoctores AS
SELECT 
    m.idMedico,
    m.nombreMedico as [Nombre del Médico],
    m.fechaNacimiento as [Fecha de Nacimiento],
    m.numero as [Número Telefónico],
    m.dui as DUI,
    r.nombreRol as Rol
FROM Medicos m
INNER JOIN Usuarios u ON m.idUsuario = u.idUsuario
INNER JOIN Roles r ON u.idRol = r.idRol;
go

CREATE VIEW VerCitas AS
SELECT 
    c.idCita,
    p.nombrePaciente as [Nombre del Paciente],
    m.nombreMedico as [Nombre del Médico],
    e.nombreEspecialidad as Especialidad,
    c.motivo as [Motivo de Consulta],
    c.observaciones as Observaciones
FROM Citas c
INNER JOIN Pacientes p ON c.idPaciente = p.idPaciente
INNER JOIN Medicos m ON c.idMedico = m.idMedico
LEFT JOIN Especialidades e ON c.idEspecialidad = e.idEspecialidad;
go

select*from VerCitas