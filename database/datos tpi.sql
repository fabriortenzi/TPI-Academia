USE [tpi2023tm01]


DELETE FROM [dbo].[cursados] WHERE (Id > 0);
DBCC CHECKIDENT('[dbo].[cursados]', RESEED, 0);

DELETE FROM [dbo].[profesores_cursos] WHERE (Id > 0);
DBCC CHECKIDENT('[dbo].[profesores_cursos]', RESEED, 0);

DELETE FROM [dbo].[cursos] WHERE (Id > 0);
DBCC CHECKIDENT('[dbo].[cursos]', RESEED, 0);

DELETE FROM [dbo].[materias] WHERE (Id > 0);
DBCC CHECKIDENT('[dbo].[materias]', RESEED, 0);


DELETE FROM [dbo].[usuarios] WHERE (Legajo > 0);
DBCC CHECKIDENT('[dbo].[usuarios]', RESEED, 0);


DELETE FROM [dbo].[planes] WHERE (Id > 0);
DBCC CHECKIDENT('[dbo].[planes]', RESEED, 0);


DELETE FROM [dbo].[comisiones] WHERE (Id > 0);
DBCC CHECKIDENT('[dbo].[comisiones]', RESEED, 0);


DELETE FROM [dbo].[especialidades] WHERE (Id > 0);
DBCC CHECKIDENT('[dbo].[especialidades]', RESEED, 0);


DELETE FROM [dbo].[tipos_de_usuario] WHERE (Id > 0);
DBCC CHECKIDENT('[dbo].[tipos_de_usuario]', RESEED, 0);


DELETE FROM [dbo].[personas] WHERE (Dni > 0);



INSERT INTO [tpi2023tm01].[dbo].[personas] (Dni, Nombre, Apellido, Direccion, FechaNacimiento, Telefono)
VALUES 
(43127777, 'Fabrizio', 'Ortenzi', 'Zeballos 2000', '2001-01-10', '154-8765'),
(43127778, 'Juan', 'Perez', 'Italia 1600', '2002-06-06', '341-9876'),
(43127779, 'Bianca', 'Gomez', 'Pellegrini 1500', '2000-08-22', '123467');


INSERT INTO [tpi2023tm01].[dbo].[tipos_de_usuario] (Descripcion)
VALUES ('Alumno'), ('Profesor'), ('Admin');

INSERT INTO [tpi2023tm01].[dbo].[especialidades] (Descripcion)
VALUES ('Ingenieria en Sistemas'), ('Ingenieria Mecanica'), ('Ingenieria Civil'),
('Ingenieria Electrica'), ('Ingenieria Quimica');

INSERT INTO [tpi2023tm01].[dbo].[planes] (anio, EspecialidadId)
VALUES (2023, 1), (2008, 3);

INSERT INTO [dbo].[comisiones]([NroComision],[EspecialidadId])
VALUES(101,1),(102,2),(103,1),(104,3),(105,2);


INSERT INTO [tpi2023tm01].[dbo].[usuarios] (Contraseña, PersonaDni, TipoDeUsuarioId)
VALUES ('c', 43127777, 1), ('c', 43127778, 2), ('c', 43127779, 3);


INSERT INTO [tpi2023tm01].[dbo].[materias] (PlanId, Descripcion, HorasSemanales, HorasTotales)
VALUES 
(1, 'Bases de Datos', 4, 120), 
(1, 'Diseño de Sistemas de Informacion', 6, 150),
(2, 'Gestion de Datos', 4, 120);


INSERT INTO [tpi2023tm01].[dbo].[cursos] (CicloLectivo, MateriaId, ComisionId, Cupo, Dia, HoraInicio, HoraFin)
VALUES 
    (2023,1, 1, 30, 'Lunes', '08:00:00', '12:00:00'),
    (2023, 2, 2, 25, 'Martes', '09:00:00', '13:00:00'),
    (2023, 3, 3, 40, 'Miércoles', '10:00:00', '14:00:00'),
    (2023, 1, 4, 20, 'Jueves', '11:00:00', '15:00:00'),
    (2023, 2, 5, 35, 'Viernes', '12:00:00', '16:00:00');

