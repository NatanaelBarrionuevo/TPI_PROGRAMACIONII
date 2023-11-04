/*  SCRIPT CREACION DE BD  */



-- Drop Database BD_FARMACIA
-- Create Database BD_FARMACIA1
-- USE BD_FARMACIA1

CREATE TABLE Provincias (
	ID_Provincia int identity,
	Descripcion varchar(200) not null,
	constraint PK_Provincias primary key (ID_Provincia)
);

CREATE TABLE Localidades (
	ID_Localidad int identity,
	Descripcion varchar(200) not null,
	ID_Provincia int,
	descuento_localidad float,
	constraint PK_Localidades primary key (ID_Localidad),
	constraint FK_Localidades_Provincias foreign key (ID_Provincia) References Provincias (ID_Provincia)
);

CREATE TABLE Barrios (
	ID_Barrio int identity,
	descripcion varchar(200) not null,
	ID_Localidad int,
	constraint PK_Barrios primary key (ID_Barrio),
	constraint FK_Barrios_Localidad foreign key (ID_Localidad) References Localidades (ID_Localidad)
);


CREATE TABLE Sucursales (
	ID_Sucursal int identity,
	ID_Barrio int , 
	CUIT varchar(50),	
	PuntoDeVenta int,
	direccion varchar(250)
	constraint PK_Sucursales primary key (ID_Sucursal),
	constraint FK_Sucursales_Provinicias foreign key (ID_Barrio) REFERENCES Barrios(ID_Barrio)
);


CREATE TABLE Personas(
	ID_persona int identity,
    apellido varchar(200) NOT NULL,
	nombre varchar(200) NOT NULL,
	dni varchar(15) NOT NULL,
	Fecha_Nacimiento date,
	--ID_Contacto int,
	Sexo bit NOT NULL,
	ID_Barrio int,
	constraint PK_Personas Primary key (ID_persona),
	--constraint fk_Personas_Contactos Foreign key (ID_Contacto) REFERENCES Contactos (ID_Contacto),
	constraint FK_Personas_Barrios foreign key (ID_Barrio) REFERENCES Barrios (ID_Barrio),
	--constraint FK_Personas_Contacto foreign key (id_contacto) REFERENCES Contactos (ID_Contacto)
);

CREATE TABLE Tipos_Contactos(
	id_tipo_contacto int identity,
	Descripcion varchar(200) not null,
	Constraint PK_TIPOS_CONTACTOS PRIMARY KEY (id_tipo_contacto)
)

CREATE TABLE Contactos(
	id_contacto int not null, 
	id_tipo_contacto int not null,
	id_persona int
	constraint PK_Contacto primary key (id_contacto),
	Constraint FK_CONTACTOS_TCONTACTOS FOREIGN KEY (id_tipo_contacto) REFERENCES tipos_Contactos(id_tipo_contacto),
	constraint fk_contactos_personas foreign key (ID_persona ) references personas (ID_persona)
)


CREATE TABLE Medicos
(
	ID_Medico int identity NOT NULL,
	ID_Persona int NOT NULL,
	Matricula varchar(100) NOT NULL,
	constraint PK_MEDICOS Primary Key (ID_Medico),
	constraint FK_MEDICOS_Personas Foreign Key (ID_Persona) REFERENCES Personas (ID_Persona)
);

CREATE TABLE ROLES
(
	ID_Rol int identity ,
	Rol varchar(100) NOT NULL,
	constraint PK_ROLES Primary key (ID_Rol)
);

CREATE TABLE Empleados(
    ID_Empleado int identity,
	ID_Persona int  NOT NULL,
	FechaIngreso date  NOT NULL,
	Activo bit not null, 
	Salario float NOT NULL CHECK(Salario > 0),
	ID_Rol int NOT NULL, 
	ID_Sucursal int NOT NULL,
	constraint PK_Empleados Primary key (ID_Empleado),
	constraint FK_Empleados_Personas foreign key (ID_Persona) REFERENCES Personas (ID_persona),
	constraint FK_Empleados_Roles foreign key (ID_Rol) REFERENCES Roles (ID_Rol),
	constraint FK_Empleados_Sucursales foreign key (ID_Sucursal) REFERENCES Sucursales (ID_Sucursal)
);

CREATE TABLE Categorias_obras_sociales(
	ID_Categoria_OBS int identity,
	categoria varchar(200) not null,
	Constraint PK_CategoriaOBS PRIMARY KEY (ID_Categoria_OBS)
); 

CREATE TABLE Solicitudes(
	ID_Solicitud int identity NOT NULL,
	FechaPeticion date NOT NULL,
	fechaRetorno date, 
	Estado bit,
	constraint PK_Solicitudes Primary Key (ID_Solicitud)
);

CREATE TABLE ObrasSociales(
	ID_ObraSocial int identity NOT NULL,
	ID_Categoria_OBS int,
	nombre varchar(100),
	descuento_OS float 
	constraint PK_ObrasSociales primary key (ID_ObraSocial),
	constraint FK_ObrasSociales_CateOBS FOREIGN KEY (ID_Categoria_OBS) REFERENCES Categorias_obras_sociales (ID_Categoria_OBS)
);

CREATE TABLE Condiciones_iva(
	id_condicion_iva int identity not null,
	condicion_iva varchar(100)
	Constraint PK_CONDICIONES_IVA PRIMARY KEY(id_condicion_iva)
);

CREATE TABLE Clientes
(
    ID_Cliente int identity,
	ID_Persona int  NOT NULL,
	id_condicion_iva int not null,
	ID_ObraSocial int,
	constraint PK_Clientes Primary key (ID_Cliente),
	constraint FK_Clientes_OS FOREIGN KEY (ID_ObraSocial) REFERENCES ObrasSociales(ID_ObraSocial),
	constraint FK_Clientes foreign key (id_condicion_iva) REFERENCES Condiciones_iva(id_condicion_iva),
	constraint FK_Clientes_Personas foreign key (ID_Persona) REFERENCES Personas (ID_persona)
);

CREATE TABLE Transportes(
	ID_Transporte int identity,
	Descripcion_Transporte varchar(100),
	constraint PK_Transportes Primary Key (ID_Transporte)
);

CREATE TABLE Tipos_Proveedores(
	ID_TipoProveedor int identity,
	Descripcion_Tipo varchar(100),
	constraint PK_TipoProveedores primary key (ID_TipoProveedor)
);

CREATE TABLE Proveedores(
	ID_Proveedor int identity,
	ID_TipoProveedor int, 
	ID_Persona int  NOT NULL,
	Cuit varchar (50),
	RazonSocial varchar(50),
	ID_Transporte int NOT NULL,
	id_condicion_iva int,
	constraint PK_Proveedores Primary key (ID_Proveedor),
	constraint FK_Proveedores_Tipo foreign key (ID_TipoProveedor) REFERENCES Tipos_Proveedores (ID_TipoProveedor),
	constraint FK_Proveedores_Personas foreign key (ID_Persona) REFERENCES Personas (ID_persona),
	constraint FK_Proveedores_Transportes foreign key (ID_Transporte) REFERENCES Transportes (ID_Transporte),
	Constraint FK_Proveedores_Condiciones_iva FOREIGN KEY (id_condicion_iva) REFERENCES Condiciones_iva(id_condicion_iva)
);

CREATE TABLE Bancos(
	ID_Banco int identity NOT NULL, 
	NombreBanco varchar(100) NOT NULL,
	constraint PK_Bancos primary key (ID_Banco)
);

CREATE TABLE SucursalesBancos(
	ID_SucursalBanco Int identity NOT NULL, 
	NombreSucursal varchar(100) NOT NULL,
	ID_Barrio int NOT NULL,
	ID_Banco int NOT NULL,
	constraint PK_SucursalesBancos primary key (ID_SucursalBanco),
	constraint FK_SucursalesBancos_Bancos foreign key (ID_Banco) REFERENCES Bancos (ID_Banco),
	constraint FK_SucursalesBancos_Barrios foreign key (ID_Barrio) REFERENCES Barrios (ID_Barrio)
);


CREATE TABLE CuentasBancarias(
	ID_CuentaBancaria int identity,
	ID_SucursaleBanco int NOT NULL,
	DescripcionCuenta varchar(250),
	constraint PK_CuentasBancarias primary key (ID_CuentaBancaria),
	constraint FK_CuentasBancarias_Sucursales foreign key (ID_CuentaBancaria ) REFERENCES SucursalesBancos (ID_SucursalBanco)
);

CREATE TABLE FormasPagos(
	ID_FormaPago int identity NOT NULL,
	descripcion varchar(100) NOT NULL,
	ID_CuentaBancaria int,
	constraint PK_FormasPagos Primary Key (ID_FormaPago),
	constraint PK_FormasPagos_CuentaBancaria foreign Key (ID_CuentaBancaria) REFERENCES CuentasBancarias (ID_CuentaBancaria)
);

CREATE TABLE Unidades(
	ID_Unidad int identity,
	Descripcion varchar(100),
	constraint PK_Unidades Primary Key (ID_Unidad)
);

CREATE TABLE TipoProductos(
	ID_TipoProd int identity,
	DescripcionTipo varchar(200),
	constraint PK_TiposProductos Primary Key (ID_TipoProd)
);

CREATE TABLE Productos
(
	ID_Producto int identity, 
	Descripcion varchar(200),
	PrecioUnitario float NOT NULL CHECK(PrecioUnitario >= 0),
	estado bit NOT NULL, 
	Fec_Vencimiento date,
	StockActual int NOT NULL,	
	StockMinimo int NOT NULL,
	CodigoBarra varchar(100) NOT NULL, 
	BajoReceta bit NOT NULL default 1,
	ID_Unidad int NOT NULL, --FK
	ID_TipoProducto int NOT NULL, --FK
	Descuento_producto float 
	constraint PK_Productos Primary Key (ID_Producto),
	constraint FK_Productos_TipoUnidad foreign key (ID_Unidad) REFERENCES Unidades (ID_unidad),
	constraint FK_Productos_TipoProveedor foreign key (ID_TipoProducto) REFERENCES TipoProductos (ID_TipoProd)
);

CREATE TABLE Medicos_X_ObrasSociales(
	id_MedicoxObrasSociales int identity,
	id_Medico int,
	id_ObraSocial int,
    constraint PK_Medicos_X_ObrasSociales primary key (id_MedicoxObrasSociales),
	constraint FK_MxOS_Medicos foreign key (id_medico) REFERENCES Medicos (ID_Medico),
	constraint FK_MxOS_ObraSocial foreign key (id_ObraSocial) REFERENCES ObrasSociales (ID_ObraSocial)
);

CREATE TABLE Reintegros(
	ID_Reintegro int identity NOT NULL,
	ID_ObraSocial int NOT NULL,
	ID_Cliente int NOT NULL,
	ID_FormaPago int NOT NULL,
	ID_Cuenta int,
	fecha date,
	constraint PK_Reintegros primary key (ID_Reintegro),
	constraint FK_Reintegros_Clientes foreign key	(ID_Cliente) REFERENCES Clientes (ID_Cliente),
	constraint FK_Reintegros_FormasPago foreign key	(ID_FormaPago) REFERENCES FormasPagos (ID_FormaPago),
	constraint FK_Reintegros_CuentaBancaria foreign key	(ID_Cuenta) REFERENCES CuentasBancarias (ID_CuentaBancaria)
);

CREATE TABLE DetallesReintegros(
	ID_DetalleReintegro int identity NOT NULL,
	ID_Reintegro int NOT NULL,
	ID_Producto int NOT NULL,
	Cantidad_Productos int not null,
	Precio_Producto float not null	
	constraint PK_DetallesReintegros primary key (ID_DetalleReintegro),
	constraint FK_DetallesReintegros_Reintegros foreign key	(ID_DetalleReintegro) REFERENCES Reintegros (ID_Reintegro),
	constraint FK_DetallesReintegros_Productos foreign key	(ID_Producto) REFERENCES Productos (ID_Producto)
);

CREATE TABLE TipoComprobanteCompra(
	ID_Tipo int identity,
	Tipo varchar(100) NOT NULL,
	constraint PK_TipoComprobantes Primary Key (ID_Tipo)
);

CREATE TABLE Compras(
	ID_Compra int identity NOT NULL,
	nro_compra varchar(50)NOT NULL,
	ID_TipoComprobante int NOT NULL,
	ID_Proveedor int NOT NULL,
	Fecha date NOT NULL,
	ID_FormaPago int NOT NULL,
	ID_CuentaBancaria int,
	ID_Transporte int,
	constraint PK_Compras Primary Key (nro_compra),
	constraint FK_Compras_TipoCOmprobantes foreign key (ID_TipoCOmprobante) REFERENCES TipoComprobanteCompra (ID_Tipo),
	constraint FK_Compras_Proveedores foreign key	(ID_Proveedor) REFERENCES Proveedores (ID_Proveedor),
	constraint FK_Compras_FormasPagos foreign key	(ID_FormaPago) REFERENCES FormasPagos (ID_FormaPago),
	constraint FK_Compras_CuentasBancarias foreign key	(ID_CuentaBancaria) REFERENCES CuentasBancarias (ID_CuentaBancaria),
	constraint FK_Compras_Transportes foreign key (ID_Transporte) REFERENCES Transportes (ID_Transporte)	
);

CREATE TABLE DetallesCompras(
	ID_DetalleCompra int identity NOT NULL,
	nro_compra varchar(50) NOT NULL,
	--ID_Descuento int,
	ID_Producto int NOT NULL,
	Cantidad int,
	precio_compra float,
	constraint PK_DetalleCompras Primary kEy (ID_DetalleCompra),
	constraint FK_DetalleCompras_Compras foreign Key (nro_compra) REFERENCES Compras (nro_compra),
	constraint FK_DetalleCompras_Productos foreign Key (ID_Producto) REFERENCES Productos (ID_Producto)
);

CREATE TABLE Ventas(
	ID_Venta int identity NOT NULL,
	ID_Cliente int NOT NULL,
	ID_Empleado int not NULL, 
	Fecha date NOT NULL, 
	ID_FormaPago int NOT NULL,
	ID_CuentaBancaria int,
	--ID_Receta int,
	EntregaPropia bit default 0, 
	nro_venta varchar(50),
	constraint PK_Ventas Primary Key (nro_venta),
	constraint FK_Ventas Foreign key (Id_Empleado) REFERENCES Empleados (ID_Empleado),
	constraint FK_Ventas_Clientes foreign key (ID_Cliente) REFERENCES Clientes (ID_Cliente),
	constraint FK_Ventas_FormasPagos foreign key (ID_FormaPago) REFERENCES FormasPagos (ID_FormaPago),
	constraint FK_Ventas_Cuentas foreign key (ID_CuentaBancaria) REFERENCES CuentasBancarias (ID_CuentaBancaria)
);

CREATE TABLE DetallesVentas
(
	ID_DetalleVenta int identity NOT NULL,
	nro_venta varchar(50)NOT NULL,
	--ID_Descuento int,
	ID_Producto int NOT NULL,
	PrecioVenta float NOT NULL,
	Cantidad int,
	constraint PK_DetalleVentas Primary Key (ID_DetalleVenta),
	constraint FK_DetalleVentas_Ventas Foreign Key (nro_venta) REFERENCES Ventas (nro_venta),
	constraint FK_DetalleVentas_Productos Foreign Key (ID_Producto) REFERENCES Productos (ID_Producto)
);	

create table Recetas (
	ID_Receta int identity unique ,
	ID_ObraSocial int NOT NULL,
	ID_Cliente int NOT NULL,
	ID_Medico int NOT NULL,
	--nro_venta int,
	ID_Solicitud int,
	Fecha_Emision date not null,
	Fecha_Vencimiento date not null,
	constraint PK_Recetas primary key (ID_ObraSocial, ID_Cliente, ID_Medico, fecha_Emision),
	constraint fk_Recetas_solicitudes foreign key (ID_Solicitud) references solicitudes (ID_Solicitud),
	constraint FK_Recetas_ObraSocial foreign key	(ID_ObraSocial) REFERENCES ObrasSociales (ID_ObraSocial),
	constraint FK_Recetas_Clientes foreign key	(ID_Cliente) REFERENCES Clientes (ID_Cliente),
	constraint FK_Recetas_Medicos foreign key	(ID_Medico) REFERENCES Medicos (ID_Medico)
);

