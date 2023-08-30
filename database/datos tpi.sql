INSERT INTO [tpi2023tm01].[dbo].[personas] (Dni, Nombre, Apellido, Direccion, FechaNacimiento, Telefono)
VALUES 
(43127777, 'Fabrizio', 'Ortenzi', 'Zeballos 2000', '2001-01-10', '154-8765'),
(43127778, 'Juan', 'Perez', 'Italia 1600', '2002-06-06', '341-9876'),
(43127779, 'Bianca', 'Gomez', 'Pellegrini 1500', '2000-08-22', '123467');


INSERT INTO [tpi2023tm01].[dbo].[tipos_de_usuario] (Descripcion)
VALUES ('Alumno'), ('Profesor'), ('Admin');

INSERT INTO [tpi2023tm01].[dbo].[usuarios] (Contraseña, PersonaDni, TipoDeUsuarioId)
VALUES ('c', 43127777, 1), ('c', 43127778, 2), ('c', 43127779, 3);

INSERT INTO [tpi2023tm01].[dbo].[especialidades] (descEspec)
VALUES ('Ingenieria en Sistemas'), ('Ingenieria Mecanica'), ('Ingenieria Civil'),
('Ingenieria Electrica'), ('Ingenieria Quimica');

INSERT INTO [tpi2023tm01].[dbo].[planes] (IdEspecialidad, anio)
VALUES (1, 2023), (1, 2008);

INSERT INTO [tpi2023tm01].[dbo].[materias] (IdEspecialidad, anio, descMateria, horaSem, horaTot)
VALUES 
(1, 2023, 'Bases de Datos', 4, 120), 
(1, 2023, 'Diseño de Sistemas de Informacion', 6, 150),
(1, 2008, 'Gestion de Datos', 4, 120);

INSERT INTO [tpi2023tm01].[dbo].[cursos] (IdMateria, Año, cupo)
VALUES
(1, 2023, 40),
(1, 2022, 35),
(3, 2023, 40);