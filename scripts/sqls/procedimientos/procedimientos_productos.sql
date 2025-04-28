use db_piazza_giovanni;

UPDATE productos_pc
SET baja = CASE 
    WHEN baja = 'SI' THEN '1'
    WHEN baja = 'NO' THEN '0'
    ELSE '0' -- Asume que los valores inválidos serán tratados como 0
END;

ALTER TABLE productos_pc
ALTER COLUMN baja bit;

CREATE PROC PROC_REGISTRAR_PRODUCTO(
	@nombre varchar(100),
	@descripcion varchar(max),
	@marca varchar(50),
	@modelo varchar(50),
	@precio decimal(10,2),
	@stock int,
	@baja bit,
	@id_categoria int,
	@id_subcategoria int,

	@resultado int output,
	@mensaje varchar(500) output
)
as
begin 
	set @resultado = 0
	
	if not exists(select * from productos_pc where modelo = @modelo)
	begin
		INSERT into productos_pc(nombre, descripcion, marca, modelo, precio, stock, baja, id_categoria, id_subcategoria) 
		VALUES (@nombre, @descripcion, @marca, @modelo, @precio, @stock, @baja, @id_categoria, @id_subcategoria)

		set @resultado = SCOPE_IDENTITY()
	end
	else 
		set @mensaje = 'Ya existe este modelo.'
end

--declare @idusuariogenerado int
--declare @mensaje varchar(500)

--exec PROC_REGISTRAR_PRODUCTO 'nombre_prueba', 'prueba descripcion', 'MARCA_prueba', 'modelo prueba', 10.00, 123, 0, 1, 2, @idusuariogenerado output, @mensaje output

--select @idusuariogenerado
--select @mensaje

--select * from productos_pc

create PROC PROC_EDITAR_PRODUCTO(
    @id_prod int,
	@nombre varchar(100),
	@descripcion varchar(max),
	@marca varchar(50),
	@modelo varchar(50),
	@precio decimal(10,2),
	@stock int,
	@baja bit,
	@id_categoria int,
	@id_subcategoria int,

	@resultado int output,
	@mensaje varchar(500) output
)
as
begin 
	set @resultado = 1
	
	if not exists(select * from productos_pc pc where pc.modelo = @modelo and pc.id != @id_prod)
		update productos_pc set 
		nombre = @nombre,
		descripcion = @descripcion,
		marca = @marca,
		modelo = @modelo,
		precio = @precio,
		stock = @stock,
		baja = @baja,
		id_categoria = @id_categoria,
		id_subcategoria = @id_subcategoria
		where id = @id_prod
	else
	begin
		set @resultado = 0
		set @mensaje = 'Ya existe este modelo.'
	end
end


--declare @idusuariogenerado int
--declare @mensaje varchar(500)

--exec PROC_EDITAR_PRODUCTO 1, 'juan', 'cruz', 'MARCA_prueba', 'asdfasdf', 10.00, 123, 0, 1, 2, @idusuariogenerado output, @mensaje output

--select @idusuariogenerado
--select @mensaje

--select * from productos_pc

CREATE PROC PROC_ELIMINAR_PRODUCTO(
	@id_prod int,
	@respuesta bit output,
	@mensaje varchar(500) output
)
as
begin 
	set @respuesta = 0
	set @mensaje = ''
	declare @validarError bit = 1
	
	IF EXISTS (SELECT * FROM ventas_detalle vd
	inner join productos_pc p on p.id = vd.producto_id
	where p.id = @id_prod)
	begin
		set @validarError = 0
		set @respuesta = 0
		set @mensaje = @mensaje + 'Este producto no se puede eliminar porque se encuentra relacionado a una venta\n'
	end

	if (@validarError = 1)
	begin 
		delete from productos_pc where id = @id_prod
		set @respuesta = 1
	end
end
