CREATE PROC PROC_REGISTRAR_USUARIO(
	@nombre varchar(30),
	@apellido varchar(30),
	@zipcode int,
	@domicilio varchar(80),
	@email varchar(50),
	@usuario varchar(30),
	@pass varchar(300),
	@id_perfil int,
	@baja varchar(2),

	@id_user_resultado int output,
	@mensaje varchar(500) output
)
as
begin 
	set @id_user_resultado = 0
	set @mensaje = ''
	
	if not exists(select * from usuarios where email = @email)
	begin
		INSERT into usuarios(nombre, apellido, zipcode, domicilio, email, usuario, pass, perfil_id, baja) 
		VALUES (@nombre, @apellido, @zipcode, @domicilio, @email, @usuario, @pass, @id_perfil, @baja)

		set @id_user_resultado = SCOPE_IDENTITY()
	end
	else 
		set @mensaje = 'Este Email ya esta registrado'
end

--declare @idusuariogenerado int
--declare @mensaje varchar(500)

--exec PROC_REGISTRAR_USUARIO 'nombre_prueba', 'ap_prueba', 1234, 'domicilio_prueba', 'email45@prueba.com', 'prueba', 123, 3, 'NO', @idusuariogenerado output, @mensaje output

--select @idusuariogenerado
--select @mensaje

select u.id, u.nombre, u.apellido, u.zipcode, u.domicilio, u.email, u.usuario, u.pass, p.descripcion, 
	CASE 
        WHEN baja = 1 THEN 'SI'
        ELSE 'NO'
    END AS baja
from usuarios u
inner join perfiles p on p.id_perfiles = u.perfil_id
order by u.id desc

alter PROC PROC_EDITAR_USUARIO(
	@id_user int,
	@nombre varchar(30),
	@apellido varchar(30),
	@zipcode int,
	@domicilio varchar(80),
	@email varchar(50),
	@usuario varchar(30),
	@pass varchar(300),
	@id_perfil int,
	@baja varchar(2),

	@respuesta bit output,
	@mensaje varchar(500) output
)
as
begin 
	set @respuesta = 0
	set @mensaje = ''
	
	if not exists(select * from usuarios where email = @email and id != @id_user)
	begin
		update usuarios set 
		nombre = @nombre,
		apellido = @apellido,
		zipcode = @zipcode,
		domicilio = @domicilio,
		email = @email,
		usuario = @usuario,
		pass = @pass,
		perfil_id = @id_perfil,
		baja = @baja
		where id = @id_user

		set @respuesta = 1
		
	end
	else 
		set @mensaje = 'Este Email ya esta registrado'
end


declare @idusuariogenerado int
declare @mensaje varchar(500)

exec PROC_EDITAR_USUARIO 1, 'editNombre', 'ap_prueba', 1234, 'domicilio_prueba', '@prueba.com', 'prueba', 123, 3, 'NO', @idusuariogenerado output, @mensaje output


select @idusuariogenerado
select @mensaje

select * from usuarios;

CREATE PROC PROC_ELIMINAR_USUARIO(
	@id_user int,
	@respuesta bit output,
	@mensaje varchar(500) output
)
as
begin 
	set @respuesta = 0
	set @mensaje = ''
	declare @validarError bit = 1
	
	IF EXISTS (SELECT * FROM ventas_cabecera vc
	inner join usuarios u on u.id = vc.usuario_id
	where u.id = @id_user)
	begin
		set @validarError = 0
		set @respuesta = 0
		set @mensaje = @mensaje + 'Este usuario no se puede eliminar porque se encuentra relacionado a una venta\n'
	end

	if (@validarError = 1)
	begin 
		delete from usuarios where id = @id_user
		set @respuesta = 1
	end
end


--select p.id_permiso, p.nombreAcceso from Permiso p
--inner join perfiles r on r.id_perfiles = p.id_perfil
--inner join usuarios u on u.perfil_id = r.id_perfiles

UPDATE usuarios
SET baja = CASE 
    WHEN baja = 'SI' THEN '1'
    WHEN baja = 'NO' THEN '0'
    ELSE '0' -- Asume que los valores inválidos serán tratados como 0
END;

ALTER TABLE usuarios
ALTER COLUMN baja bit;