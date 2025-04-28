use db_piazza_giovanni;

CREATE TABLE categorias_pc (
    id_categoria int IDENTITY(1,1) PRIMARY KEY,
    descripcion_categoria VARCHAR(MAX) NULL
);

INSERT INTO [dbo].[categorias_pc] (descripcion_categoria)
SELECT DISTINCT 
    categoria
FROM [dbo].[productos_pc]
WHERE categoria IS NOT NULL;

--select * from categorias_pc

ALTER TABLE [dbo].[productos_pc]
ADD id_categoria INT;

UPDATE productos_pc
SET id_categoria = c.id_categoria
FROM productos_pc p
INNER JOIN categorias_pc c ON p.categoria = c.descripcion_categoria;

--select p.id_categoria, categoria
--from productos_pc p

ALTER TABLE [dbo].[productos_pc]
DROP COLUMN categoria;

ALTER TABLE [dbo].[productos_pc]
ADD CONSTRAINT FK_productos_categorias
FOREIGN KEY (id_categoria) REFERENCES categorias_pc(id_categoria);


CREATE TABLE subcategorias_pc (
    id_subcategoria int IDENTITY(1,1),
    id_categoria int NOT NULL,
    descripcion_subcategoria varchar(MAX) NULL,
	CONSTRAINT PK_subcategorias PRIMARY KEY (id_subcategoria, id_categoria),
    CONSTRAINT FK_subcategorias_categorias FOREIGN KEY (id_categoria) REFERENCES [dbo].[categorias_pc](id_categoria)
);

INSERT INTO [dbo].[subcategorias_pc] (descripcion_subcategoria, id_categoria)
VALUES 
    ('Almacenamiento', 1),
    ('Cables de Energia', 1),
    ('CPU', 1),
    ('Estabilizadores y UPS', 1),
    ('Fuentes de Energia', 1),
    ('Gabinetes', 1),
    ('Placas de Video', 1),
    ('Placas Madre',1),
    ('RAM', 1),
    ('Refrigeracion', 1);

ALTER TABLE [dbo].[productos_pc]
ADD id_subcategoria INT;

UPDATE productos_pc
SET id_subcategoria = s.id_subcategoria
FROM productos_pc p
INNER JOIN subcategorias_pc s ON p.subcategoria = s.descripcion_subcategoria;

--select p.id_subcategoria, subcategoria
--from productos_pc p

ALTER TABLE [dbo].[productos_pc]
DROP COLUMN subcategoria;

ALTER TABLE [dbo].[productos_pc]
ADD CONSTRAINT FK_productos_subcategorias
FOREIGN KEY (id_subcategoria, id_categoria) 
REFERENCES [dbo].[subcategorias_pc](id_subcategoria, id_categoria);