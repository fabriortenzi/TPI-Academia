# Trabajo Práctico Integrador

### Universidad Tecnológica Nacional - Facultad Regional Rosario

### Tecnologías de Desarrollo de Software IDE

### Comisión 3EK01 - Grupo 1
### Integrantes

* Ortenzi, Fabrizio
* Rodriguez, Ignacio

## Sistema de Gestión Académica

El Sistema de Gestión Académica permite crear Personas, éstas se identifican con su DNI como clave primaria. Esta persona puede tener muchos Usuarios, identificados con una clave autoincremental generada por la Base de Datos que es el Legajo que va a usar dicha Persona en la Facultad. Dichos Usuarios pueden ser Alumnos, Profesores o Administrativos. Una Persona puede tener varios Usuarios de tipo Alumno, pero dichos Usuarios tienen que pertenecer a distintos Planes de Estudio.  Una Persona solo puede tener un Usuario Profesor y un Usuario Administrativo. Un Administrativo es quien tiene permisos para crear Personas y Usuarios.

El Sistema registra las distintas Especialidades que se dictan en la Facultad (Ingeniería en Sistemas de Información, Ingeniería Mecánica, Ingeniería Civil). Dichas Especialidades pueden tener distintos Planes de Estudio en distintos años. Además, las Especialidades cuentan con distintas Comisiones identificadas por el Número de Comisión que es el que conocemos de la Facultad (107, 204, 303, etc). Las Comisiones son las mismas para todos los Planes de esa Especialidad. Todas éstas pueden ser dadas de alta por un Administrativo.

Estos Planes de Estudio tienen muchas Materias, que no pueden repetir el nombre dentro de un mismo Plan. A estas Materias se le crean distintos Cursos que tienen un cupo máximo. Éstos son para una Materia, Ciclo Lectivo y Comisión. Son todos dadas de alta por cualquier Administrativo y luego éste le asigna uno o más Profesores con distintos cargos.

Los Alumnos se inscriben a dichos Cursos generando un Cursado (Inscripción). Luego, el Profesor carga las notas a esos Cursados y el Alumno las puede consultar. Se pueden eliminar los Cursados hasta antes de que algún Profesor cargue la Nota Final. Un Administrativo no tiene permisos para cambiar Cursados, solo lo modifican un Alumno y un Profesor.

El Profesor puede ver a qué Cursos está asignado en el presente Ciclo Lectivo.


## Diagrama de Clases

![DiagramaClases](assets\DiagramaClases.png)

## Cómo instalar

### Requisitos: 

* Visual Studio 2022 (recomendado)
* .NET 5 SDK
* SQL Server Express 2022

### Pasos

1. Clonar este repositorio
2. Abrir el proyecto TPI.Datos en la terminal y ejecutar el comando: ```dotnet ef database update``` para que cree la Base de Datos con las migraciones en el servidor LOCALHOST\SQLEXPRESS
3. Ejecutar los proyectos





