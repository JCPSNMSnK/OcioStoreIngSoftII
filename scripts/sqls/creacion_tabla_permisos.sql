


----- Necesitas ejecutar este codigo para eliminar la columna id y agregarla nuevamente con otra configuracion :)
alter table usuarios
drop column id;

ALTER TABLE usuarios
DROP CONSTRAINT PK_id_usuarios;

ALTER TABLE usuarios
ADD id INT IDENTITY;

ALTER TABLE usuarios 
ADD CONSTRAINT PK_id_usuarios PRIMARY KEY(id);

alter table perfiles 
add constraint PK_id_perfil primary key(id_perfiles);

------- ^^^^^^ hasta aca ^^^^^^
--- ahora si podes crear(CREATE) o modificar(ALTER) los procedimientos registrar, editar y eliminar
go
USE [db_piazza_giovanni]
go
CREATE TABLE permiso(
	id_permiso int NOT NULL,
	id_perfil int NOT NULL,
	nombreAcceso varchar(150) NOT NULL,
	fechaCreacion datetime CONSTRAINT DF_producto_fecha_publicacion DEFAULT GETDATE(),
	CONSTRAINT PK_id_permiso primary key(id_permiso),
	CONSTRAINT FK_id_perfil foreign key(id_perfil) REFERENCES perfiles(id_perfiles),
);

--select * from usuarios;
--select * from perfiles;

-- select u.id, u.nombre, u.apellido, u.zipcode, u.domicilio, u.email, u.usuario, u.pass, p.id_perfiles, p.descripcion, u.baja from usuarios --u
-- inner join perfiles p on p.id_perfiles = u.perfil_id;

--select pr.id_perfiles, p.nombreAcceso, u.nombre
--from permiso p
--inner join perfiles pr on pr.id_perfiles = p.id_perfil
--inner join usuarios u on u.perfil_id = pr.id_perfiles
--where u.id = 2

insert into permiso (id_permiso, id_perfil, nombreAcceso)
values
(1, 1, 'UserButton'),
(2, 1, 'ConsultasButton'),
(3, 1, 'MsgButton'),
(4, 1, 'ProductsButton'),
(5, 1, 'StatsButton'),
(6, 1, 'ReceiptsButton'),
(7, 3, 'ConsultasButton'),
(8, 3, 'MsgButton'),
(9, 3, 'ProductsButton'),
(10, 3, 'ReceiptsButton'),
(11, 1, 'BackupButton'),
(12, 2, 'UserButton'),
(13, 2, 'ConsultasButton'),
(14, 2, 'MsgButton'),
(15, 2, 'ProductsButton'),
(16, 2, 'StatsButton'),
(17, 2, 'ReceiptsButton');


