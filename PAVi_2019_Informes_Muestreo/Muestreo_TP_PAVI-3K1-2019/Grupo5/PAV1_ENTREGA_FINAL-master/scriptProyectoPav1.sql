USE [PAVGarzonPassadore]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 10/30/2019 09:18:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Perfiles](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Perfiles] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Perfiles] ON
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (1, N'Administrador', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (2, N'Vendedor', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (3, N'Tester', 0)
SET IDENTITY_INSERT [dbo].[Perfiles] OFF
/****** Object:  Table [dbo].[Marcas]    Script Date: 10/30/2019 09:18:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Marcas](
	[idMarca] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED 
(
	[idMarca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Marcas] ON
INSERT [dbo].[Marcas] ([idMarca], [nombre], [borrado]) VALUES (1, N'Philips', 0)
INSERT [dbo].[Marcas] ([idMarca], [nombre], [borrado]) VALUES (2, N'Sony', 0)
INSERT [dbo].[Marcas] ([idMarca], [nombre], [borrado]) VALUES (3, N'Samsung', 0)
INSERT [dbo].[Marcas] ([idMarca], [nombre], [borrado]) VALUES (4, N'Siemens', 0)
INSERT [dbo].[Marcas] ([idMarca], [nombre], [borrado]) VALUES (5, N'Atma', 0)
INSERT [dbo].[Marcas] ([idMarca], [nombre], [borrado]) VALUES (8, N'Aurora', 0)
INSERT [dbo].[Marcas] ([idMarca], [nombre], [borrado]) VALUES (10, N'ElectroLux', 0)
INSERT [dbo].[Marcas] ([idMarca], [nombre], [borrado]) VALUES (11, N'Moulinex', 0)
INSERT [dbo].[Marcas] ([idMarca], [nombre], [borrado]) VALUES (12, N'GAMA', 0)
INSERT [dbo].[Marcas] ([idMarca], [nombre], [borrado]) VALUES (13, N'Black & Decker', 0)
INSERT [dbo].[Marcas] ([idMarca], [nombre], [borrado]) VALUES (14, N'Surrey', 0)
INSERT [dbo].[Marcas] ([idMarca], [nombre], [borrado]) VALUES (15, N'Drean', 0)
SET IDENTITY_INSERT [dbo].[Marcas] OFF
/****** Object:  Table [dbo].[Facturas]    Script Date: 10/30/2019 09:18:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Facturas](
	[id_factura] [int] IDENTITY(1,1) NOT NULL,
	[nro_factura] [int] NULL,
	[fecha] [date] NOT NULL,
	[id_usuario] [int] NULL,
	[nombreCliente] [varchar](50) NOT NULL,
	[subtotal] [decimal](18, 2) NOT NULL,
	[descuento] [decimal](18, 2) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Facturas] PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Facturas] ON
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [id_usuario], [nombreCliente], [subtotal], [descuento], [borrado]) VALUES (5, 0, CAST(0x32400B00 AS Date), 1, N'Marcos Levis', CAST(35250.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [id_usuario], [nombreCliente], [subtotal], [descuento], [borrado]) VALUES (6, 0, CAST(0x32400B00 AS Date), 1, N'Alejandro Garzon', CAST(13000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [id_usuario], [nombreCliente], [subtotal], [descuento], [borrado]) VALUES (7, 0, CAST(0x32400B00 AS Date), 1, N'Claudio Marquez', CAST(81000.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [id_usuario], [nombreCliente], [subtotal], [descuento], [borrado]) VALUES (8, 0, CAST(0x32400B00 AS Date), 1, N'Juan Salcedo', CAST(37000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [id_usuario], [nombreCliente], [subtotal], [descuento], [borrado]) VALUES (9, 0, CAST(0x32400B00 AS Date), 1, N'Claudia', CAST(3000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [id_usuario], [nombreCliente], [subtotal], [descuento], [borrado]) VALUES (10, 0, CAST(0x32400B00 AS Date), 1, N'Francisco', CAST(1250.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [id_usuario], [nombreCliente], [subtotal], [descuento], [borrado]) VALUES (11, 0, CAST(0x32400B00 AS Date), 1, N'Gaston', CAST(59000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [id_usuario], [nombreCliente], [subtotal], [descuento], [borrado]) VALUES (12, 0, CAST(0x32400B00 AS Date), 1, N'Mario Perez', CAST(8250.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [id_usuario], [nombreCliente], [subtotal], [descuento], [borrado]) VALUES (13, 0, CAST(0x50400B00 AS Date), 1, N'Carla Martinez', CAST(3000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [id_usuario], [nombreCliente], [subtotal], [descuento], [borrado]) VALUES (14, 0, CAST(0x50400B00 AS Date), 1, N'Roberto Cura', CAST(8300.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [id_usuario], [nombreCliente], [subtotal], [descuento], [borrado]) VALUES (15, 0, CAST(0x763E0B00 AS Date), 1, N'Tere Vega', CAST(25000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [id_usuario], [nombreCliente], [subtotal], [descuento], [borrado]) VALUES (16, 0, CAST(0x50400B00 AS Date), 1, N'Gabriela Vega', CAST(47000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [id_usuario], [nombreCliente], [subtotal], [descuento], [borrado]) VALUES (17, 0, CAST(0x593E0B00 AS Date), 1, N'Carmen Garcia', CAST(6550.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [id_usuario], [nombreCliente], [subtotal], [descuento], [borrado]) VALUES (18, 0, CAST(0x993E0B00 AS Date), 1, N'Miguel Moreno', CAST(17000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [id_usuario], [nombreCliente], [subtotal], [descuento], [borrado]) VALUES (19, 0, CAST(0xBB3E0B00 AS Date), 1, N'Ana Ruiz', CAST(50000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [id_usuario], [nombreCliente], [subtotal], [descuento], [borrado]) VALUES (20, 0, CAST(0xBD3E0B00 AS Date), 1, N'Rafael Diaz', CAST(26250.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [id_usuario], [nombreCliente], [subtotal], [descuento], [borrado]) VALUES (21, 0, CAST(0x51400B00 AS Date), 1, N'Marcos giraudo', CAST(13000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [id_usuario], [nombreCliente], [subtotal], [descuento], [borrado]) VALUES (22, 0, CAST(0xED3C0B00 AS Date), 1, N'Tere giraudo', CAST(28000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [id_usuario], [nombreCliente], [subtotal], [descuento], [borrado]) VALUES (23, 0, CAST(0x0A3D0B00 AS Date), 1, N'Pedro diaz', CAST(22200.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Facturas] ([id_factura], [nro_factura], [fecha], [id_usuario], [nombreCliente], [subtotal], [descuento], [borrado]) VALUES (24, 0, CAST(0x2E3D0B00 AS Date), 1, N'ana denis', CAST(17600.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0)
SET IDENTITY_INSERT [dbo].[Facturas] OFF
/****** Object:  Table [dbo].[Usuarios]    Script Date: 10/30/2019 09:18:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_perfil] [int] NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[estado] [varchar](10) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (1, 1, N'admin', N'123', N'admin@gmail.com', N'1', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (12, 3, N'Albaro Garzon', N'123', N'albagar@gmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (13, 3, N'Ignacio Passadore', N'123', N'ignapassa@gmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (14, 2, N'Tomas Garzon', N'123', N'tomgar@gmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (15, 2, N'Rocio Antoniaci', N'123', N'roanto@gmail.com', N'S', 0)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
/****** Object:  Table [dbo].[Productos]    Script Date: 10/30/2019 09:18:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productos](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[stock] [int] NOT NULL,
	[precioVenta] [int] NOT NULL,
	[marcaProducto] [int] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON
INSERT [dbo].[Productos] ([id_producto], [nombre], [descripcion], [stock], [precioVenta], [marcaProducto], [borrado]) VALUES (1, N'Heladera Electrolux', N'340 litros', 10, 1250, 10, 0)
INSERT [dbo].[Productos] ([id_producto], [nombre], [descripcion], [stock], [precioVenta], [marcaProducto], [borrado]) VALUES (2, N'Ventilador', N'Turbo', 5, 3000, 5, 0)
INSERT [dbo].[Productos] ([id_producto], [nombre], [descripcion], [stock], [precioVenta], [marcaProducto], [borrado]) VALUES (4, N'Smart TV', N'32 pulgadas', 10, 17000, 1, 0)
INSERT [dbo].[Productos] ([id_producto], [nombre], [descripcion], [stock], [precioVenta], [marcaProducto], [borrado]) VALUES (8, N'Lavarropas Drean', N'Automatico Eco Blanco', 5, 25000, 15, 0)
INSERT [dbo].[Productos] ([id_producto], [nombre], [descripcion], [stock], [precioVenta], [marcaProducto], [borrado]) VALUES (9, N'Aspiradora', N'1800W', 10, 7000, 1, 0)
INSERT [dbo].[Productos] ([id_producto], [nombre], [descripcion], [stock], [precioVenta], [marcaProducto], [borrado]) VALUES (10, N'Aire Acondicionado Split', N'Frio/Calor', 5, 47000, 14, 0)
INSERT [dbo].[Productos] ([id_producto], [nombre], [descripcion], [stock], [precioVenta], [marcaProducto], [borrado]) VALUES (11, N'Licuadora Duravita', N' hr2086/91', 5, 5300, 1, 0)
INSERT [dbo].[Productos] ([id_producto], [nombre], [descripcion], [stock], [precioVenta], [marcaProducto], [borrado]) VALUES (12, N'Picadora ', N'Fresh express', 2, 5200, 11, 0)
SET IDENTITY_INSERT [dbo].[Productos] OFF
/****** Object:  Table [dbo].[FacturasDetalle]    Script Date: 10/30/2019 09:18:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturasDetalle](
	[id_factura_detalle] [int] IDENTITY(1,1) NOT NULL,
	[id_factura] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[precio_unitario] [decimal](18, 2) NOT NULL,
	[cantidad] [decimal](18, 0) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_DetalleFactura] PRIMARY KEY CLUSTERED 
(
	[id_factura_detalle] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[FacturasDetalle] ON
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (9, 5, 1, CAST(1250.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (10, 5, 4, CAST(17000.00 AS Decimal(18, 2)), CAST(2 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (11, 6, 2, CAST(3000.00 AS Decimal(18, 2)), CAST(2 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (12, 6, 9, CAST(7000.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (13, 7, 4, CAST(17000.00 AS Decimal(18, 2)), CAST(2 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (14, 7, 10, CAST(47000.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (15, 8, 2, CAST(3000.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (16, 8, 4, CAST(17000.00 AS Decimal(18, 2)), CAST(2 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (17, 9, 2, CAST(3000.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (18, 10, 1, CAST(1250.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (19, 11, 4, CAST(17000.00 AS Decimal(18, 2)), CAST(2 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (20, 11, 8, CAST(25000.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (21, 12, 1, CAST(1250.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (22, 12, 9, CAST(7000.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (23, 13, 2, CAST(3000.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (24, 14, 2, CAST(3000.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (25, 14, 11, CAST(5300.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (26, 15, 8, CAST(25000.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (27, 16, 10, CAST(47000.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (28, 17, 1, CAST(1250.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (29, 17, 11, CAST(5300.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (30, 18, 4, CAST(17000.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (31, 19, 10, CAST(47000.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (32, 19, 2, CAST(3000.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (33, 20, 8, CAST(25000.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (34, 20, 1, CAST(1250.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (35, 21, 2, CAST(3000.00 AS Decimal(18, 2)), CAST(2 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (36, 21, 9, CAST(7000.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (37, 22, 2, CAST(3000.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (38, 22, 8, CAST(25000.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (39, 23, 4, CAST(17000.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (40, 23, 12, CAST(5200.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (41, 24, 9, CAST(7000.00 AS Decimal(18, 2)), CAST(1 AS Decimal(18, 0)), 0)
INSERT [dbo].[FacturasDetalle] ([id_factura_detalle], [id_factura], [id_producto], [precio_unitario], [cantidad], [borrado]) VALUES (42, 24, 11, CAST(5300.00 AS Decimal(18, 2)), CAST(2 AS Decimal(18, 0)), 0)
SET IDENTITY_INSERT [dbo].[FacturasDetalle] OFF
/****** Object:  ForeignKey [FK__Productos__marca__3D5E1FD2]    Script Date: 10/30/2019 09:18:09 ******/
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK__Productos__marca__3D5E1FD2] FOREIGN KEY([marcaProducto])
REFERENCES [dbo].[Marcas] ([idMarca])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK__Productos__marca__3D5E1FD2]
GO
/****** Object:  ForeignKey [FK__DetalleFa__id_pr__0AD2A005]    Script Date: 10/30/2019 09:18:09 ******/
ALTER TABLE [dbo].[FacturasDetalle]  WITH CHECK ADD  CONSTRAINT [FK__DetalleFa__id_pr__0AD2A005] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[FacturasDetalle] CHECK CONSTRAINT [FK__DetalleFa__id_pr__0AD2A005]
GO
