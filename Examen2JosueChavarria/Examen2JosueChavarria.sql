
CREATE DATABASE EXAMEN2DB

CREATE TABLE INFOCLIENTE
(
	NOMBRE VARCHAR(50),
	CEDULA INT,
	TELEFONO INT,
	DIRECCION VARCHAR(50),
	MONTOPAGO FLOAT,
	DESCUENTO FLOAT,
	SUBTOTAL FLOAT,
	TOTAL FLOAT,
	IVA FLOAT,
)

Select * From INFOCLIENTE

create proc Salvar
 @nombre varchar(50),
 @cedula int,
 @telefono int,
 @direccion varchar(50),
 @monto float,
 @descuento float,
 @subtotal float,
 @total float,
 @iva float
as
	begin
	INSERT INTO INFOCLIENTE(NOMBRE,CEDULA,TELEFONO,DIRECCION,MONTOPAGO,DESCUENTO,SUBTOTAL,TOTAL,IVA) values (@nombre, @cedula, @telefono, @direccion, @monto, @descuento, @subtotal, @total, @iva)
	end
