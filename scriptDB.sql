USE [Administracion_Peliculas]
GO
/****** Object:  Table [dbo].[Actores]    Script Date: 3/8/2020 6:43:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Actores](
	[ID] [int] IDENTITY(0,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Sexo] [char](1) NOT NULL,
	[Foto] [varbinary](max) NULL,
 CONSTRAINT [pk_act] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Actores_Peliculas]    Script Date: 3/8/2020 6:43:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actores_Peliculas](
	[ID] [int] IDENTITY(0,1) NOT NULL,
	[idActor] [int] NOT NULL,
	[idPelicula] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Generos]    Script Date: 3/8/2020 6:43:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Generos](
	[ID] [int] IDENTITY(0,1) NOT NULL,
	[NombreGenero] [varchar](100) NULL,
 CONSTRAINT [pk_gen] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Peliculas]    Script Date: 3/8/2020 6:43:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Peliculas](
	[ID] [int] IDENTITY(0,1) NOT NULL,
	[Titulo] [varchar](150) NOT NULL,
	[GeneroID] [int] NULL,
	[FechaEstreno] [date] NULL,
	[Foto] [varbinary](max) NULL,
 CONSTRAINT [pk_pel] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Actores_Peliculas]  WITH CHECK ADD  CONSTRAINT [fk_actor] FOREIGN KEY([idActor])
REFERENCES [dbo].[Actores] ([ID])
GO
ALTER TABLE [dbo].[Actores_Peliculas] CHECK CONSTRAINT [fk_actor]
GO
ALTER TABLE [dbo].[Actores_Peliculas]  WITH CHECK ADD  CONSTRAINT [fk_pelis] FOREIGN KEY([idPelicula])
REFERENCES [dbo].[Peliculas] ([ID])
GO
ALTER TABLE [dbo].[Actores_Peliculas] CHECK CONSTRAINT [fk_pelis]
GO
ALTER TABLE [dbo].[Peliculas]  WITH CHECK ADD  CONSTRAINT [fk_gen_pel] FOREIGN KEY([GeneroID])
REFERENCES [dbo].[Generos] ([ID])
GO
ALTER TABLE [dbo].[Peliculas] CHECK CONSTRAINT [fk_gen_pel]
GO
ALTER TABLE [dbo].[Actores]  WITH CHECK ADD CHECK  (([Sexo]='F' OR [Sexo]='M'))
GO
/****** Object:  StoredProcedure [dbo].[BusquedasGenerales]    Script Date: 3/8/2020 6:43:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[BusquedasGenerales]
@busqueda varchar(100)
as
select a.Nombre as Actor, a.FechaNacimiento as 'Nacimiento',a.Sexo, p.Titulo as 'Pelicula', g.NombreGenero, p.FechaEstreno as 'Estreno', a.Foto
from Actores a
inner join Actores_Peliculas ap on ap.idActor = a.ID
inner join Peliculas p on p.ID = ap.idPelicula
inner join Generos g on g.ID = p.ID
where p.Titulo like @busqueda+'%' or p.FechaEstreno like @busqueda+'%' or g.NombreGenero like '%'+@busqueda+'%' or a.Nombre like @busqueda+'%' 
or a.FechaNacimiento like @busqueda+'%' or a.Sexo like @busqueda+'%'
GO
/****** Object:  StoredProcedure [dbo].[DetallesAvanzadosActor]    Script Date: 3/8/2020 6:43:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DetallesAvanzadosActor]
@nombreactor varchar(100)
as
select a.Nombre as Actor,p.Titulo as 'Pelicula', g.NombreGenero as 'Genero Pelicula', p.Foto as 'Foto Pelicula'
from Actores a
inner join Actores_Peliculas ap on ap.idActor = a.ID
inner join Peliculas p on p.ID = ap.idPelicula
inner join Generos g on g.ID = p.ID
where a.Nombre like @nombreactor+'%'
GO
/****** Object:  StoredProcedure [dbo].[DetallesAvanzadosPeliculas]    Script Date: 3/8/2020 6:43:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DetallesAvanzadosPeliculas]
@tituloPelicula varchar(100)
as
select p.Titulo as 'Pelicula', g.NombreGenero as 'Genero Pelicula', a.Nombre as 'Nombre Actor',a.Foto as 'Foto Actor'
from Actores a
inner join Actores_Peliculas ap on ap.idActor = a.ID
inner join Peliculas p on p.ID = ap.idPelicula
inner join Generos g on g.ID = p.ID
where p.Titulo like @tituloPelicula+'%'
GO
/****** Object:  StoredProcedure [dbo].[EliminarActoresPeliculas]    Script Date: 3/8/2020 6:43:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EliminarActoresPeliculas]
@id int
as
delete from Actores_Peliculas
where ID = @id

GO
/****** Object:  StoredProcedure [dbo].[EliminarAutor]    Script Date: 3/8/2020 6:43:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EliminarAutor]
@id int 
as
delete from Actores where ID = @id

GO
/****** Object:  StoredProcedure [dbo].[EliminarPelicula]    Script Date: 3/8/2020 6:43:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EliminarPelicula]
@id int
as
delete from Peliculas where ID = @id

GO
/****** Object:  StoredProcedure [dbo].[GuardarParametroXML]    Script Date: 3/8/2020 6:43:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[GuardarParametroXML]
	 @xmlDocumento xml
	as
	begin
		set nocount on;

		insert into Actores_Peliculas
		select 
		Actores_Peliculas.value('(idActor/text())[1]','int') as ID,
		Actores_Peliculas.value('(idPelicula/text())[1]','int') as ID
		from 
		@xmlDocumento.nodes('/Actores_Peliculas') as temptable(Actores_Peliculas)
	end

GO
/****** Object:  StoredProcedure [dbo].[InsertarXMLDB]    Script Date: 3/8/2020 6:43:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertarXMLDB]
@xml xml
as
begin
      set nocount on;
 
      insert into Actores_Peliculas
      select
      misDatos.value('(idActor/text())[1]','int') as idActor, 
      misDatos.value('(idPelicula/text())[1]','int') as idActor 
      from
      @xml.nodes('data/misDatos')as temptable(misDatos)
end
GO
/****** Object:  StoredProcedure [dbo].[ModificarActor]    Script Date: 3/8/2020 6:43:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ModificarActor]
@id int, @nombre varchar(100), @fecha date, @sexo char(1), @foto varbinary(max)
as
update Actores set Nombre = @nombre,  FechaNacimiento = @fecha, Sexo = @sexo, Foto = @foto where ID = @id

GO
/****** Object:  StoredProcedure [dbo].[ModificarActoresPeliculas]    Script Date: 3/8/2020 6:43:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ModificarActoresPeliculas]
@id int, @idActor int, @idPelicula int
as
update Actores_Peliculas 
set idActor = @idActor, idPelicula = @idPelicula
where ID = @id
GO
/****** Object:  StoredProcedure [dbo].[ModificarPelicula]    Script Date: 3/8/2020 6:43:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ModificarPelicula]
@id int, @titulo varchar(150), @idGenero int, @estreno date, @foto varbinary(max)
as
update Peliculas 
set Titulo = @titulo, GeneroID = @idGenero, FechaEstreno = @estreno , Foto = @foto
where ID = @id

GO
/****** Object:  StoredProcedure [dbo].[MostrarActores]    Script Date: 3/8/2020 6:43:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MostrarActores]
as
select ID, Nombre, FechaNacimiento as 'Nacimiento',Sexo,Foto as 'Fotografia' from Actores
GO
/****** Object:  StoredProcedure [dbo].[MostrarDatosActoresPeliculas]    Script Date: 3/8/2020 6:43:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MostrarDatosActoresPeliculas]
as
select a.Nombre as Actor, a.FechaNacimiento as 'Nacimiento', p.Titulo as 'Titulo Pelicula', p.FechaEstreno as 'Estreno'
from Actores a
inner join Actores_Peliculas ap on ap.idActor = a.ID
inner join Peliculas p on p.ID = ap.idPelicula
GO
/****** Object:  StoredProcedure [dbo].[MostrarPeliculas]    Script Date: 3/8/2020 6:43:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MostrarPeliculas]
as
select * from Peliculas

GO
/****** Object:  StoredProcedure [dbo].[RegistrarActor]    Script Date: 3/8/2020 6:43:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[RegistrarActor]
@nombre varchar(100), @fecha date, @sexo char(1), @foto varbinary(max)
as
insert into Actores(Nombre,FechaNacimiento,Sexo,Foto) values(@nombre,@fecha,@sexo,@foto)

GO
/****** Object:  StoredProcedure [dbo].[RegistrarPelicula]    Script Date: 3/8/2020 6:43:26 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[RegistrarPelicula]
@titulo varchar(150), @idGenero int, @estreno date, @foto varbinary(max)
as
insert into Peliculas (Titulo, GeneroID, FechaEstreno, Foto) values(@titulo,@idGenero, @estreno, @foto) 
GO
