set dateformat dmy
use master
if DB_ID ('Senati') is not null
   drop database Senati
go
create database Senati
go
use Senati
---CREAR LAS TABLAS---
-----TABLA CARGO-----
create table Cargo (
  id int primary key identity,
  Detalle char(30) unique )
----TABLA EMPLEADO-----
create table Empleado 
( id int  primary key identity,
  Usuario char(8) unique,
  Nombres char(30) not null,
  Contraseña char(6) not null,
  idCargo int references Cargo )
----INSERTAR DATOS----
insert Cargo values ('Administrador'), ('Vendedor')
insert Empleado values ('12323432','Juan','432222',2)
insert Empleado values ('12345678','Adrian69','123456',1)
go
---PROCEDIMIENTOS ALMACENADOS---
create procedure sp_Empleado_Login --USUARIO: 12323432, CONTRASEÑA: 432222-- o USUARIO: 12345678, CONTRASEÑA: 123456
  @Usuario char(8),
  @Contraseña char(6)
  as select * from Empleado e, Cargo c where Usuario=@Usuario and Contraseña=Contraseña and e.idCargo = c.id
go
create procedure sp_getCargos
   as select * from Cargo
go
create procedure sp_GuardarCargo 
  @id int,
  @Detalle char(30)
  as if ( @id = 0 )
		insert Cargo values (@Detalle)
	 else
		update Cargo set Detalle = @Detalle where id = @id
go
create procedure sp_EliminarCargo 
  @id int
  as
  begin
	delete from Cargo where id = @id
  end
go
create procedure sp_BuscarCargo
@Detalle char(30)
  as
	select id,Detalle from Cargo where Detalle like @Detalle + '%'
go
-----TABLA CURSOS----- 
create table Curso(
  id_curso int primary key identity,
  Curso_nombre char(30)
);
---INSERT CURSOS---
insert into Curso values ('Algebra')
insert into Curso values ('Fisica')
insert into Curso values ('Comunicacion')
insert into Curso values ('Quimica')
---PROCEDIMIENTOS ALMACENADOS---
create procedure sp_getCursos
	as select * from Curso
go
create procedure sp_GuardarCurso
  @id_curso int,
  @Curso_nombre char(30)
  as if ( @id_curso = 0 )
		insert Curso values (@Curso_nombre)
	 else
		update Curso set Curso_nombre = @Curso_nombre where id_curso = @id_curso
go
create procedure sp_EliminarCurso
  @id_curso int
  as
  begin
	delete from Curso where id_curso = @id_curso
  end
go
-----TABLA PROFESOR----- 
create table Profesor(
  id_profesor int primary key identity,
  Profesor_nombre char(30))
-----INSERT PROFESORES----- 
insert into Profesor values ('Omar')
insert into Profesor values ('Walter Rios')
insert into Profesor values ('Maria')
insert into Profesor values ('Luciana')

---PROCEDIMIENTOS ALMACENADOS---
create procedure sp_getProfesores
	as select * from Profesor
go
create procedure sp_GuardarProfesor
  @id_profesor int,
  @Profesor_nombre char(30)
  as if ( @id_profesor = 0 )
		insert Profesor values (@Profesor_nombre)
	 else
		update Profesor set Profesor_nombre = @Profesor_nombre where id_profesor = @id_profesor
go
create procedure sp_EliminarProfesor
  @id_profesor int
  as
  begin
	delete from Profesor where id_profesor = @id_profesor
  end
go

-----TABLA DISTRITO----- 
create table Distrito(
  id_distrito int primary key identity,
  Distrito_nombre char(30))

insert into Distrito values ('Callao')
insert into Distrito values ('Lince')
insert into Distrito values ('Lima')
insert into Distrito values ('Ventanilla')

select * from Distrito
---PROCEDIMIENTOS ALMACENADOS---
create procedure sp_getDistritos
	as select * from Distrito
go

-----TABLA ALUMNOS----- 
create table Alumno(
  id int primary key identity,
  Dni char(8) unique,
  Nombres char(30) not null,
  Apellidos char (30) not null,
  Celular char(9) not null,
  Email char(30) not null,
  Fecha_nac date )

---INSERT ALUMNO---
insert Alumno values ('72624112','Adrian','Sangama','980345098','Sangama@gmail.com','2020/12/03')
go

select * from Alumno

---PROCEDIMIENTOS ALMACENADOS---
create procedure sp_getAlumnos
	as select * from Alumno 
go

create procedure sp_GuardarAlumno
   @id int,
   @Dni char(8),
   @Nombres char(30),
   @Apellidos char (30),
   @Celular char(9),
   @Email char(30),
   @Fecha_nac date
   as if ( @id = 0 )
		  insert Alumno values(@Dni,@Nombres,@Apellidos,@Celular,@Email,@Fecha_nac)
	  else 
		  update Alumno set Dni=@Dni,Nombres=@Nombres ,Apellidos=@Apellidos ,Celular=@Celular ,Email=@Email ,Fecha_nac=@Fecha_nac where id=@id
go

create procedure sp_EliminarAlumno
  @id int
  as
  begin
	delete from Alumno where id = @id
  end
go









