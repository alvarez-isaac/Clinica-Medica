create database ClinicaMedica
go

use ClinicaMedica
go

create table Roles(
    idRol INT PRIMARY KEY IDENTITY(1,1),
    nombreRol NVARCHAR(50) NOT NULL
);

insert into Roles values ('Recepcionista'),('Medico'),('Administrador')

create table Especialidades(
idEspecialudad int primary key identity(1,1),
nombreEspecialidad varchar(50),
);

insert into Especialidades values ('Medicina General'),('Cardiología'),('Urología'),('Endocrinología'),('Reumatología'),('Oncología'),('Neurología');

CREATE TABLE Usuario (
    idUsuario INT PRIMARY KEY IDENTITY(1,1),
    nombreUsuario NVARCHAR(50) UNIQUE NOT NULL,
    contraseña NVARCHAR(100),
    idRol INT,
    constraint FKIdRol FOREIGN KEY (idRol) REFERENCES Roles(idRol) on delete cascade,
);
go

insert into Usuario (nombreUsuario, contraseña, idRol) values
('carlos roberto', '123', 3),  -- Administrador
('adriana hasbun', '123', 2),    -- Médico
('juan pablo', '123', 1),    -- Recepcionista
('sofia melendez', '123', 2),    -- Médico
('pedro porro', '123', 3);   -- Administrador
