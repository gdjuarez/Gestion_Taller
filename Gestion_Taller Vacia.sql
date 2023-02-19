-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.5.19


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema gestion_taller
--

CREATE DATABASE IF NOT EXISTS gestion_taller;
USE gestion_taller;

--
-- Temporary table structure for view `vista_factura`
--
DROP TABLE IF EXISTS `vista_factura`;
DROP VIEW IF EXISTS `vista_factura`;
CREATE TABLE `vista_factura` (
  `RazonSocial` varchar(45),
  `Apellido` varchar(45),
  `Nombre` varchar(45),
  `Domicilio` varchar(45),
  `idVentas` int(10) unsigned,
  `Fecha` date,
  `Total` decimal(10,2),
  `idVentaArticulo` int(10) unsigned,
  `idArticulo` varchar(13),
  `Descripcion` varchar(45),
  `Cantidad` int(10) unsigned,
  `PrecioUnitario` decimal(10,2),
  `Importe` decimal(10,2)
);

--
-- Temporary table structure for view `vistaarticulos`
--
DROP TABLE IF EXISTS `vistaarticulos`;
DROP VIEW IF EXISTS `vistaarticulos`;
CREATE TABLE `vistaarticulos` (
  `idArticulo` varchar(13),
  `Descripcion` varchar(45),
  `Marca` varchar(45),
  `Rubro` varchar(45)
);

--
-- Temporary table structure for view `vistaarticulosystock`
--
DROP TABLE IF EXISTS `vistaarticulosystock`;
DROP VIEW IF EXISTS `vistaarticulosystock`;
CREATE TABLE `vistaarticulosystock` (
  `idArticulo` varchar(13),
  `Descripcion` varchar(45),
  `Marca` varchar(45),
  `Rubro` varchar(45),
  `Stock` int(10) unsigned
);

--
-- Temporary table structure for view `vistaarticulosystockyprecio`
--
DROP TABLE IF EXISTS `vistaarticulosystockyprecio`;
DROP VIEW IF EXISTS `vistaarticulosystockyprecio`;
CREATE TABLE `vistaarticulosystockyprecio` (
  `idArticulo` varchar(13),
  `Descripcion` varchar(45),
  `Marca` varchar(45),
  `Rubro` varchar(45),
  `Stock` int(10) unsigned,
  `PrecioVenta` decimal(10,2)
);

--
-- Temporary table structure for view `vistacajamovimientos`
--
DROP TABLE IF EXISTS `vistacajamovimientos`;
DROP VIEW IF EXISTS `vistacajamovimientos`;
CREATE TABLE `vistacajamovimientos` (
  `Fecha` date,
  `TipoMovimiento` varchar(45),
  `Descripcion` varchar(120),
  `TipoComprobante` varchar(45),
  `SerieNumero` varchar(45),
  `ImporteIngreso` decimal(10,2),
  `ImporteSalida` decimal(10,2)
);

--
-- Temporary table structure for view `vistaconsultararticulostock`
--
DROP TABLE IF EXISTS `vistaconsultararticulostock`;
DROP VIEW IF EXISTS `vistaconsultararticulostock`;
CREATE TABLE `vistaconsultararticulostock` (
  `idArticulo` varchar(13),
  `Descripcion` varchar(45),
  `PrecioCompra` decimal(10,2),
  `PrecioVenta` decimal(10,2),
  `Marca` varchar(45),
  `Imagen` varchar(200),
  `Rubro` varchar(45),
  `Stock` int(10) unsigned,
  `StockMinimo` int(10) unsigned,
  `situado` varchar(45)
);

--
-- Temporary table structure for view `vistaordenreparacion`
--
DROP TABLE IF EXISTS `vistaordenreparacion`;
DROP VIEW IF EXISTS `vistaordenreparacion`;
CREATE TABLE `vistaordenreparacion` (
  `IdReparacion` int(10) unsigned,
  `Dominio` varchar(15),
  `IdCliente` varchar(11),
  `RazonSocial` varchar(45),
  `Apellido` varchar(45),
  `Nombre` varchar(45),
  `FechaEntrada` date,
  `DatosAveria` varchar(200),
  `FechaReparacion` date,
  `FechaSalida` date,
  `ESTADO` varchar(45)
);

--
-- Temporary table structure for view `vistaordenreparacioningresados`
--
DROP TABLE IF EXISTS `vistaordenreparacioningresados`;
DROP VIEW IF EXISTS `vistaordenreparacioningresados`;
CREATE TABLE `vistaordenreparacioningresados` (
  `IdReparacion` int(10) unsigned,
  `Dominio` varchar(15),
  `IdCliente` varchar(11),
  `RazonSocial` varchar(45),
  `Apellido` varchar(45),
  `Nombre` varchar(45),
  `FechaEntrada` date,
  `DatosAveria` varchar(200),
  `FechaReparacion` date,
  `FechaSalida` date,
  `ESTADO` varchar(45)
);

--
-- Temporary table structure for view `vistaordenreparacionreparados`
--
DROP TABLE IF EXISTS `vistaordenreparacionreparados`;
DROP VIEW IF EXISTS `vistaordenreparacionreparados`;
CREATE TABLE `vistaordenreparacionreparados` (
  `IdReparacion` int(10) unsigned,
  `Dominio` varchar(15),
  `IdCliente` varchar(11),
  `RazonSocial` varchar(45),
  `Apellido` varchar(45),
  `Nombre` varchar(45),
  `FechaEntrada` date,
  `DatosAveria` varchar(200),
  `FechaReparacion` date,
  `FechaSalida` date,
  `ESTADO` varchar(45)
);

--
-- Temporary table structure for view `vistapresupuesto`
--
DROP TABLE IF EXISTS `vistapresupuesto`;
DROP VIEW IF EXISTS `vistapresupuesto`;
CREATE TABLE `vistapresupuesto` (
  `RazonSocial` varchar(45),
  `Apellido` varchar(45),
  `Nombre` varchar(45),
  `idpresupuesto` int(10) unsigned,
  `Fecha` date,
  `Total` decimal(10,2),
  `idPresupuestoArticulos` int(10) unsigned,
  `idArticulo` varchar(13),
  `Descripcion` varchar(45),
  `Cantidad` int(10) unsigned,
  `PrecioUnitario` decimal(10,2),
  `Importe` decimal(10,2),
  `vencimiento` int(10) unsigned
);

--
-- Temporary table structure for view `vistapresupuestocliente`
--
DROP TABLE IF EXISTS `vistapresupuestocliente`;
DROP VIEW IF EXISTS `vistapresupuestocliente`;
CREATE TABLE `vistapresupuestocliente` (
  `idPresupuesto` int(10) unsigned,
  `Fecha` date,
  `Codigo` varchar(11),
  `RazonSocial` varchar(45),
  `Nombre` varchar(45),
  `Apellido` varchar(45),
  `Total` decimal(10,2)
);

--
-- Temporary table structure for view `vistavehiculos`
--
DROP TABLE IF EXISTS `vistavehiculos`;
DROP VIEW IF EXISTS `vistavehiculos`;
CREATE TABLE `vistavehiculos` (
  `Dominio` varchar(15),
  `Kilometros` varchar(15),
  `Color` varchar(15),
  `Marca` varchar(15),
  `Modelo` varchar(15),
  `Combustible` varchar(15),
  `TipoMotor` varchar(15),
  `Cilindrada` varchar(15),
  `Poliza` varchar(45),
  `Aseguradora` varchar(45),
  `Comentario` varchar(200),
  `Estado` varchar(45)
);

--
-- Temporary table structure for view `vistaventas`
--
DROP TABLE IF EXISTS `vistaventas`;
DROP VIEW IF EXISTS `vistaventas`;
CREATE TABLE `vistaventas` (
  `Codigo` int(10) unsigned,
  `IdReparacion` int(10) unsigned,
  `Fecha` date,
  `RazonSocial` varchar(45),
  `Apellido` varchar(45),
  `Nombre` varchar(45),
  `Domicilio` varchar(45),
  `Total` decimal(10,2),
  `Pagado` varchar(2)
);

--
-- Temporary table structure for view `vistaventassinpago`
--
DROP TABLE IF EXISTS `vistaventassinpago`;
DROP VIEW IF EXISTS `vistaventassinpago`;
CREATE TABLE `vistaventassinpago` (
  `Codigo` int(10) unsigned,
  `IdReparacion` int(10) unsigned,
  `Dominio` varchar(15),
  `Fecha` date,
  `RazonSocial` varchar(45),
  `Apellido` varchar(45),
  `Nombre` varchar(45),
  `Domicilio` varchar(45),
  `Total` decimal(10,2),
  `Pagado` varchar(2)
);

--
-- Definition of table `articulo`
--

DROP TABLE IF EXISTS `articulo`;
CREATE TABLE `articulo` (
  `idArticulo` varchar(13) NOT NULL,
  `Descripcion` varchar(45) NOT NULL,
  `PrecioCompra` decimal(10,2) NOT NULL,
  `PrecioVenta` decimal(10,2) NOT NULL,
  `Marca` varchar(45) DEFAULT NULL,
  `Imagen` varchar(200) DEFAULT NULL,
  `Rubro` varchar(45) DEFAULT NULL,
  `Situado` varchar(45) DEFAULT NULL,
  `Comentario` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`idArticulo`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `articulo`
--

/*!40000 ALTER TABLE `articulo` DISABLE KEYS */;
INSERT INTO `articulo` (`idArticulo`,`Descripcion`,`PrecioCompra`,`PrecioVenta`,`Marca`,`Imagen`,`Rubro`,`Situado`,`Comentario`) VALUES 
 ('0000000000001','Mano de obra','10.00','250.00','Taller','C:\\Users\\f_per\\Desktop\\Herramientas\\hora-de-mano-de-obra.jpg','Mano de obra','Taller',NULL);
/*!40000 ALTER TABLE `articulo` ENABLE KEYS */;


--
-- Definition of table `aseguradora`
--

DROP TABLE IF EXISTS `aseguradora`;
CREATE TABLE `aseguradora` (
  `Aseguradora` varchar(45) NOT NULL,
  PRIMARY KEY (`Aseguradora`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `aseguradora`
--

/*!40000 ALTER TABLE `aseguradora` DISABLE KEYS */;
/*!40000 ALTER TABLE `aseguradora` ENABLE KEYS */;


--
-- Definition of table `caja`
--

DROP TABLE IF EXISTS `caja`;
CREATE TABLE `caja` (
  `codCaja` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `codMovCaja` int(10) unsigned NOT NULL,
  `Fecha` date NOT NULL,
  `operador` varchar(45) NOT NULL,
  PRIMARY KEY (`codCaja`,`codMovCaja`) USING BTREE,
  KEY `FK_caja_1Mov` (`codMovCaja`),
  CONSTRAINT `FK_caja_1Mov` FOREIGN KEY (`codMovCaja`) REFERENCES `cajamov` (`idCajaMov`)
) ENGINE=InnoDB AUTO_INCREMENT=63 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `caja`
--

/*!40000 ALTER TABLE `caja` DISABLE KEYS */;
/*!40000 ALTER TABLE `caja` ENABLE KEYS */;


--
-- Definition of table `cajamov`
--

DROP TABLE IF EXISTS `cajamov`;
CREATE TABLE `cajamov` (
  `idCajaMov` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `tipoMovimiento` varchar(45) NOT NULL,
  `Descripcion` varchar(120) NOT NULL,
  `tipoComprobante` varchar(45) NOT NULL,
  `serienumero` varchar(45) DEFAULT NULL,
  `ingreso` decimal(10,2) NOT NULL,
  `egreso` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idCajaMov`)
) ENGINE=InnoDB AUTO_INCREMENT=63 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cajamov`
--

/*!40000 ALTER TABLE `cajamov` DISABLE KEYS */;
/*!40000 ALTER TABLE `cajamov` ENABLE KEYS */;


--
-- Definition of table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
CREATE TABLE `cliente` (
  `idCliente` varchar(11) NOT NULL,
  `Nombre` varchar(45) NOT NULL,
  `Apellido` varchar(45) NOT NULL,
  `RazonSocial` varchar(45) DEFAULT NULL,
  `Domicilio` varchar(45) NOT NULL,
  `Ciudad` varchar(45) NOT NULL,
  `Provincia` varchar(45) NOT NULL,
  `CodigoPostal` varchar(45) DEFAULT NULL,
  `TelFijo` varchar(45) DEFAULT NULL,
  `TelCelular` varchar(45) NOT NULL,
  `Email` varchar(45) NOT NULL,
  `Cuil` varchar(13) DEFAULT NULL,
  `Observaciones` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`idCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cliente`
--

/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;


--
-- Definition of table `clientepresupuesto`
--

DROP TABLE IF EXISTS `clientepresupuesto`;
CREATE TABLE `clientepresupuesto` (
  `IdPresupuesto` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idCliente` varchar(11) DEFAULT NULL,
  `Vencimiento` int(10) unsigned NOT NULL,
  PRIMARY KEY (`IdPresupuesto`),
  CONSTRAINT `FK_clientepresupuesto_1` FOREIGN KEY (`IdPresupuesto`) REFERENCES `presupuestos` (`idPresupuesto`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `clientepresupuesto`
--

/*!40000 ALTER TABLE `clientepresupuesto` DISABLE KEYS */;
/*!40000 ALTER TABLE `clientepresupuesto` ENABLE KEYS */;


--
-- Definition of table `clientevehiculo`
--

DROP TABLE IF EXISTS `clientevehiculo`;
CREATE TABLE `clientevehiculo` (
  `IdClienteVehiculo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `IdCliente` varchar(11) NOT NULL,
  `IdVehiculo` varchar(15) NOT NULL,
  PRIMARY KEY (`IdClienteVehiculo`),
  KEY `FK_clientevehiculo_1` (`IdCliente`),
  KEY `FK_clientevehiculo_2` (`IdVehiculo`),
  CONSTRAINT `FK_clientevehiculo_1` FOREIGN KEY (`IdCliente`) REFERENCES `cliente` (`idCliente`),
  CONSTRAINT `FK_clientevehiculo_2` FOREIGN KEY (`IdVehiculo`) REFERENCES `vehiculo` (`Dominio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `clientevehiculo`
--

/*!40000 ALTER TABLE `clientevehiculo` DISABLE KEYS */;
/*!40000 ALTER TABLE `clientevehiculo` ENABLE KEYS */;


--
-- Definition of table `clienteventa`
--

DROP TABLE IF EXISTS `clienteventa`;
CREATE TABLE `clienteventa` (
  `idVenta` int(10) unsigned NOT NULL,
  `idCliente` varchar(11) DEFAULT NULL,
  PRIMARY KEY (`idVenta`),
  CONSTRAINT `FK_clienteventa_1` FOREIGN KEY (`idVenta`) REFERENCES `ventas` (`idVentas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `clienteventa`
--

/*!40000 ALTER TABLE `clienteventa` DISABLE KEYS */;
/*!40000 ALTER TABLE `clienteventa` ENABLE KEYS */;


--
-- Definition of table `cobroreparacion`
--

DROP TABLE IF EXISTS `cobroreparacion`;
CREATE TABLE `cobroreparacion` (
  `IdReparacion` int(10) unsigned NOT NULL,
  `Fecha` date NOT NULL,
  `Total` decimal(10,2) NOT NULL,
  `FechaPago` date DEFAULT NULL,
  PRIMARY KEY (`IdReparacion`) USING BTREE,
  CONSTRAINT `FK_cobroreparacion_1` FOREIGN KEY (`IdReparacion`) REFERENCES `reparacion` (`IdReparacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cobroreparacion`
--

/*!40000 ALTER TABLE `cobroreparacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `cobroreparacion` ENABLE KEYS */;


--
-- Definition of table `compraarticulos`
--

DROP TABLE IF EXISTS `compraarticulos`;
CREATE TABLE `compraarticulos` (
  `idcompra_articulo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idArticulo` varchar(13) NOT NULL,
  `Cantidad` int(10) unsigned NOT NULL,
  `PrecioUnitario` decimal(10,2) NOT NULL,
  `Importe` decimal(10,2) NOT NULL,
  `idCompra` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idcompra_articulo`,`idCompra`) USING BTREE,
  KEY `FK_compra_articulo_1` (`idArticulo`),
  KEY `FK_compra_articulo_2` (`idCompra`),
  CONSTRAINT `FK_compra_articulo_1` FOREIGN KEY (`idArticulo`) REFERENCES `articulo` (`idArticulo`),
  CONSTRAINT `FK_compra_articulo_2` FOREIGN KEY (`idCompra`) REFERENCES `compras` (`idCompras`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `compraarticulos`
--

/*!40000 ALTER TABLE `compraarticulos` DISABLE KEYS */;
/*!40000 ALTER TABLE `compraarticulos` ENABLE KEYS */;


--
-- Definition of table `compras`
--

DROP TABLE IF EXISTS `compras`;
CREATE TABLE `compras` (
  `idCompras` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idProveedor` int(10) unsigned DEFAULT NULL,
  `Fecha` date NOT NULL,
  `Total` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idCompras`),
  KEY `FK_compras_2Provee` (`idProveedor`),
  KEY `FK_compras_1Articulo` (`Fecha`) USING BTREE,
  CONSTRAINT `FK_compras_2Provee` FOREIGN KEY (`idProveedor`) REFERENCES `proveedores` (`idProveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `compras`
--

/*!40000 ALTER TABLE `compras` DISABLE KEYS */;
/*!40000 ALTER TABLE `compras` ENABLE KEYS */;


--
-- Definition of table `detallereparacion`
--

DROP TABLE IF EXISTS `detallereparacion`;
CREATE TABLE `detallereparacion` (
  `idDetalleReparacion` int(10) unsigned NOT NULL,
  `idReparacion` int(10) unsigned NOT NULL,
  `IdArticulo` varchar(15) NOT NULL,
  `Cantidad` int(10) unsigned NOT NULL,
  `PrecioUnitario` decimal(10,2) NOT NULL,
  `Importe` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idDetalleReparacion`,`idReparacion`) USING BTREE,
  KEY `FK_detallereparacion_1` (`idReparacion`),
  KEY `FK_detallereparacion_2` (`IdArticulo`),
  CONSTRAINT `FK_detallereparacion_1` FOREIGN KEY (`idReparacion`) REFERENCES `cobroreparacion` (`IdReparacion`),
  CONSTRAINT `FK_detallereparacion_2` FOREIGN KEY (`IdArticulo`) REFERENCES `articulo` (`idArticulo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `detallereparacion`
--

/*!40000 ALTER TABLE `detallereparacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `detallereparacion` ENABLE KEYS */;


--
-- Definition of table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
CREATE TABLE `empleados` (
  `IdEmpleado` varchar(11) NOT NULL,
  `Apellido` varchar(45) NOT NULL,
  `Nombre` varchar(45) NOT NULL,
  `Domicilio` varchar(45) DEFAULT NULL,
  `Ciudad` varchar(45) DEFAULT NULL,
  `Provincia` varchar(45) DEFAULT NULL,
  `CodigoPostal` varchar(45) DEFAULT NULL,
  `TelFijo` varchar(45) DEFAULT NULL,
  `TelCelular` varchar(45) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `Cargo` varchar(45) DEFAULT NULL,
  `Horario` varchar(45) DEFAULT NULL,
  `Salario` varchar(45) DEFAULT NULL,
  `FechaAlta` date DEFAULT NULL,
  `FechaVencContrato` date DEFAULT NULL,
  `Foto` varchar(200) DEFAULT NULL,
  `Comentario` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`IdEmpleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `empleados`
--

/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
/*!40000 ALTER TABLE `empleados` ENABLE KEYS */;


--
-- Definition of table `herramientas`
--

DROP TABLE IF EXISTS `herramientas`;
CREATE TABLE `herramientas` (
  `idHerramientas` varchar(15) NOT NULL,
  `Descripcion` varchar(45) NOT NULL,
  `Tipo` varchar(45) DEFAULT NULL,
  `Cantidad` varchar(45) NOT NULL,
  `Imagen` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`idHerramientas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `herramientas`
--

/*!40000 ALTER TABLE `herramientas` DISABLE KEYS */;
/*!40000 ALTER TABLE `herramientas` ENABLE KEYS */;


--
-- Definition of table `marcavehiculo`
--

DROP TABLE IF EXISTS `marcavehiculo`;
CREATE TABLE `marcavehiculo` (
  `Marca` varchar(15) NOT NULL,
  PRIMARY KEY (`Marca`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `marcavehiculo`
--

/*!40000 ALTER TABLE `marcavehiculo` DISABLE KEYS */;
INSERT INTO `marcavehiculo` (`Marca`) VALUES 
 ('Chery'),
 ('Chevrolet'),
 ('Citroen'),
 ('Ferrari'),
 ('Ford'),
 ('Renault'),
 ('Toyota');
/*!40000 ALTER TABLE `marcavehiculo` ENABLE KEYS */;


--
-- Definition of table `misdatos`
--

DROP TABLE IF EXISTS `misdatos`;
CREATE TABLE `misdatos` (
  `RazonSocial` varchar(45) NOT NULL,
  `Direccion` varchar(45) DEFAULT NULL,
  `Ciudad` varchar(45) DEFAULT NULL,
  `Telefono` varchar(45) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `Cuit` varchar(13) DEFAULT NULL,
  PRIMARY KEY (`RazonSocial`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `misdatos`
--

/*!40000 ALTER TABLE `misdatos` DISABLE KEYS */;
INSERT INTO `misdatos` (`RazonSocial`,`Direccion`,`Ciudad`,`Telefono`,`Email`,`Cuit`) VALUES 
 ('Taller de reparación','Direccion','Ciudad','tel','mail','00-00000000-0');
/*!40000 ALTER TABLE `misdatos` ENABLE KEYS */;


--
-- Definition of table `modelovehiculo`
--

DROP TABLE IF EXISTS `modelovehiculo`;
CREATE TABLE `modelovehiculo` (
  `Modelo` varchar(15) NOT NULL,
  `Marca` varchar(45) NOT NULL,
  PRIMARY KEY (`Modelo`) USING BTREE,
  KEY `FK_modelovehiculo_1` (`Marca`),
  CONSTRAINT `FK_modelovehiculo_1` FOREIGN KEY (`Marca`) REFERENCES `marcavehiculo` (`Marca`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `modelovehiculo`
--

/*!40000 ALTER TABLE `modelovehiculo` DISABLE KEYS */;
INSERT INTO `modelovehiculo` (`Modelo`,`Marca`) VALUES 
 ('Thigo','Chery'),
 ('Corsa','Chevrolet'),
 ('Zafira','Chevrolet'),
 ('C3','Citroen'),
 ('C4','Citroen'),
 ('Testarrosa','Ferrari'),
 ('Focus','Ford'),
 ('Ranger','Ford'),
 ('Clio','Renault'),
 ('Megane','Renault'),
 ('Corolla','Toyota'),
 ('Etios','Toyota');
/*!40000 ALTER TABLE `modelovehiculo` ENABLE KEYS */;


--
-- Definition of table `presupuestoarticulos`
--

DROP TABLE IF EXISTS `presupuestoarticulos`;
CREATE TABLE `presupuestoarticulos` (
  `idpresupuestoarticulos` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idpresupuesto` int(10) unsigned NOT NULL,
  `idArticulo` varchar(13) NOT NULL,
  `Cantidad` int(10) unsigned NOT NULL,
  `PrecioUnitario` decimal(10,2) NOT NULL,
  `Importe` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idpresupuestoarticulos`,`idpresupuesto`) USING BTREE,
  KEY `FK_presupuestoarticulos_1` (`idArticulo`),
  KEY `FK_presupuestoarticulos_2` (`idpresupuesto`),
  CONSTRAINT `FK_presupuestoarticulos_1` FOREIGN KEY (`idArticulo`) REFERENCES `articulo` (`idArticulo`),
  CONSTRAINT `FK_presupuestoarticulos_2` FOREIGN KEY (`idpresupuesto`) REFERENCES `presupuestos` (`idPresupuesto`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `presupuestoarticulos`
--

/*!40000 ALTER TABLE `presupuestoarticulos` DISABLE KEYS */;
/*!40000 ALTER TABLE `presupuestoarticulos` ENABLE KEYS */;


--
-- Definition of table `presupuestos`
--

DROP TABLE IF EXISTS `presupuestos`;
CREATE TABLE `presupuestos` (
  `idPresupuesto` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Fecha` date NOT NULL,
  `Total` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idPresupuesto`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `presupuestos`
--

/*!40000 ALTER TABLE `presupuestos` DISABLE KEYS */;
/*!40000 ALTER TABLE `presupuestos` ENABLE KEYS */;


--
-- Definition of table `proveedores`
--

DROP TABLE IF EXISTS `proveedores`;
CREATE TABLE `proveedores` (
  `idProveedor` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `RazonSocial` varchar(45) NOT NULL,
  `Domicilio` varchar(45) DEFAULT NULL,
  `Localidad` varchar(45) DEFAULT NULL,
  `TelFijo` varchar(45) DEFAULT NULL,
  `TelCelular` varchar(45) DEFAULT NULL,
  `CUIT` varchar(13) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `Comentarios` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`idProveedor`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `proveedores`
--

/*!40000 ALTER TABLE `proveedores` DISABLE KEYS */;
INSERT INTO `proveedores` (`idProveedor`,`RazonSocial`,`Domicilio`,`Localidad`,`TelFijo`,`TelCelular`,`CUIT`,`email`,`Comentarios`) VALUES 
 (1,'unProveedor','','Mercedes','','','00-00000000-0','@','');
/*!40000 ALTER TABLE `proveedores` ENABLE KEYS */;


--
-- Definition of table `reparacion`
--

DROP TABLE IF EXISTS `reparacion`;
CREATE TABLE `reparacion` (
  `IdReparacion` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Dominio` varchar(15) NOT NULL,
  `IdCliente` varchar(11) NOT NULL,
  `FechaEntrada` date NOT NULL,
  `DatosAveria` varchar(200) DEFAULT NULL,
  `FechaReparacion` date DEFAULT NULL,
  `FechaSalida` date DEFAULT NULL,
  `idVenta` int(10) unsigned DEFAULT NULL,
  `Estado` varchar(45) NOT NULL,
  PRIMARY KEY (`IdReparacion`),
  KEY `FK_reparacion_1Dominio` (`Dominio`),
  CONSTRAINT `FK_reparacion_1Dominio` FOREIGN KEY (`Dominio`) REFERENCES `vehiculo` (`Dominio`)
) ENGINE=InnoDB AUTO_INCREMENT=69 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `reparacion`
--

/*!40000 ALTER TABLE `reparacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `reparacion` ENABLE KEYS */;


--
-- Definition of table `stockarticulos`
--

DROP TABLE IF EXISTS `stockarticulos`;
CREATE TABLE `stockarticulos` (
  `idArticulo` varchar(13) NOT NULL,
  `Stock` int(10) unsigned NOT NULL,
  `StockMinimo` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idArticulo`) USING BTREE,
  CONSTRAINT `FK_stockarticulos_1` FOREIGN KEY (`idArticulo`) REFERENCES `articulo` (`idArticulo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `stockarticulos`
--

/*!40000 ALTER TABLE `stockarticulos` DISABLE KEYS */;
INSERT INTO `stockarticulos` (`idArticulo`,`Stock`,`StockMinimo`) VALUES 
 ('0000000000001',999999999,0);
/*!40000 ALTER TABLE `stockarticulos` ENABLE KEYS */;


--
-- Definition of table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE `usuario` (
  `usuario` varchar(45) NOT NULL,
  `clave` varchar(45) NOT NULL,
  PRIMARY KEY (`usuario`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `usuario`
--

/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` (`usuario`,`clave`) VALUES 
 ('1','1'),
 ('Admin','1234');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;


--
-- Definition of table `vehiculo`
--

DROP TABLE IF EXISTS `vehiculo`;
CREATE TABLE `vehiculo` (
  `Dominio` varchar(15) NOT NULL,
  `Marca` varchar(15) DEFAULT NULL,
  `Modelo` varchar(15) DEFAULT NULL,
  `Color` varchar(15) DEFAULT NULL,
  `Combustible` varchar(15) DEFAULT NULL,
  `Kilometros` varchar(15) DEFAULT NULL,
  `TipoMotor` varchar(15) DEFAULT NULL,
  `Cilindrada` varchar(15) DEFAULT NULL,
  `IdAseguradora` varchar(45) DEFAULT NULL,
  `Poliza` varchar(45) DEFAULT NULL,
  `Comentario` varchar(200) DEFAULT NULL,
  `Foto` varchar(200) DEFAULT NULL,
  `Vtv` date DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Dominio`) USING BTREE,
  KEY `FK_vehiculo_1Marca` (`Marca`),
  CONSTRAINT `FK_vehiculo_1Marca` FOREIGN KEY (`Marca`) REFERENCES `marcavehiculo` (`Marca`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `vehiculo`
--

/*!40000 ALTER TABLE `vehiculo` DISABLE KEYS */;
/*!40000 ALTER TABLE `vehiculo` ENABLE KEYS */;


--
-- Definition of table `ventaarticulos`
--

DROP TABLE IF EXISTS `ventaarticulos`;
CREATE TABLE `ventaarticulos` (
  `idVentaArticulo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idVenta` int(10) unsigned NOT NULL,
  `idArticulo` varchar(13) NOT NULL,
  `Cantidad` int(10) unsigned NOT NULL,
  `PrecioUnitario` decimal(10,2) NOT NULL,
  `Importe` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idVentaArticulo`,`idVenta`) USING BTREE,
  KEY `FK_venta_articulo_1` (`idVenta`),
  KEY `FK_ventaarticulos_2` (`idArticulo`),
  CONSTRAINT `FK_ventaarticulos_2` FOREIGN KEY (`idArticulo`) REFERENCES `articulo` (`idArticulo`),
  CONSTRAINT `FK_venta_articulo_1` FOREIGN KEY (`idVenta`) REFERENCES `ventas` (`idVentas`)
) ENGINE=InnoDB AUTO_INCREMENT=89 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `ventaarticulos`
--

/*!40000 ALTER TABLE `ventaarticulos` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventaarticulos` ENABLE KEYS */;


--
-- Definition of table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
CREATE TABLE `ventas` (
  `idVentas` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Fecha` date NOT NULL,
  `Total` decimal(10,2) NOT NULL,
  `Pagado` varchar(2) DEFAULT NULL,
  PRIMARY KEY (`idVentas`),
  KEY `FK_ventas_2Articulos` (`Fecha`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=74 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `ventas`
--

/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;


--
-- Definition of procedure `Factura`
--

DROP PROCEDURE IF EXISTS `Factura`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`GiFSys`@`localhost` PROCEDURE `Factura`(codigoVenta int)
BEGIN

SELECT
v.idVentas, v.Fecha, v.Total,
va.idVentaArticulo,va.idArticulo,a.Descripcion, va.Cantidad, va.PrecioUnitario, va.Importe
FROM ventas v
inner join ventaarticulos va on va.idventa= v.idventas
inner join Articulo a on a.idArticulo=va.idArticulo
where idVenta = codigoVenta;

END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `Get_buscar_articulo`
--

DROP PROCEDURE IF EXISTS `Get_buscar_articulo`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `Get_buscar_articulo`(ida int)
BEGIN

SELECT * FROM articulo a
where a.idArticulo = ida;


END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `get_Factura`
--

DROP PROCEDURE IF EXISTS `get_Factura`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`GiFSys`@`localhost` PROCEDURE `get_Factura`(codigoVenta int)
BEGIN
SELECT
cl.RazonSocial, cl.Apellido, Cl.Nombre,cl.Domicilio,v.idVentas, v.Fecha, v.Total,
va.idVentaArticulo,va.idArticulo,a.Descripcion, va.Cantidad, va.PrecioUnitario, va.Importe
FROM ventas v
left join ventaarticulos va on va.idventa= v.idventas
left join Articulo a on a.idArticulo=va.idArticulo
left join clienteventa cv on cv.idventa = v.idventas
left join cliente cl on cl.idcliente = cv.idcliente
where v.idVentas = codigoVenta;
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `get_inf_ArticulosXrubro`
--

DROP PROCEDURE IF EXISTS `get_inf_ArticulosXrubro`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_inf_ArticulosXrubro`(art varchar(45))
BEGIN

SELECT idArticulo, Descripcion, Marca, Rubro
FROM articulo
where Rubro = art
order by Descripcion;


END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `get_inf_ArticulosXrubroYstock`
--

DROP PROCEDURE IF EXISTS `get_inf_ArticulosXrubroYstock`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_inf_ArticulosXrubroYstock`(art varchar(45))
BEGIN

SELECT a.idArticulo, a.Descripcion, a.Marca, a.Rubro , s.Stock
FROM articulo a
inner join stockarticulos s
on a.idArticulo = s.Idarticulo
where Rubro = art
order by rubro;


END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `get_inf_CajaEgreso`
--

DROP PROCEDURE IF EXISTS `get_inf_CajaEgreso`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_inf_CajaEgreso`(desde date, hasta date)
BEGIN

SELECT c.Fecha, CM.Descripcion, CM.tipoComprobante as Comprobante, cm.egreso as Monto
FROM Taller.caja c
inner join cajamov CM
on c.codMovCaja = CM.idCajaMov
where cm.ingreso=0 and cm.egreso>0 and c.Fecha >= desde and c.Fecha <= hasta;



END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `get_inf_CajaIngreso`
--

DROP PROCEDURE IF EXISTS `get_inf_CajaIngreso`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_inf_CajaIngreso`(desde date, hasta date)
BEGIN

SELECT c.Fecha, CM.Descripcion, CM.tipoComprobante as Comprobante, cm.ingreso as Monto
FROM Taller.caja c
inner join cajamov CM
on c.codMovCaja = CM.idCajaMov
where cm.egreso=0 and cm.ingreso>0 and c.Fecha >= desde and c.Fecha <= hasta;


END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `get_inf_CajaxDia`
--

DROP PROCEDURE IF EXISTS `get_inf_CajaxDia`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`GiFSys`@`localhost` PROCEDURE `get_inf_CajaxDia`(desde date,hasta date)
BEGIN

SELECT c.Fecha, m.TipoMovimiento, m.Descripcion, m.TipoComprobante, m.SerieNumero,
m.ingreso as ImporteIngreso, m.egreso as ImporteSalida
FROM caja c
inner join cajamov m
on m.idCajaMov = c.codMovCaja
where c.fecha >= desde and c.fecha <= hasta;

END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `get_inf_Compra1`
--

DROP PROCEDURE IF EXISTS `get_inf_Compra1`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_inf_Compra1`(desde date,hasta date)
BEGIN

SELECT c.IdCompras, p.RazonSocial, c.Fecha , c.Total
FROM compras c
inner join proveedores p on  c.idProveedor = p.idProveedor
where c.fecha >= desde and c.fecha <= hasta;

END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `get_inf_Venta_4`
--

DROP PROCEDURE IF EXISTS `get_inf_Venta_4`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_inf_Venta_4`(desde date,hasta date)
BEGIN

SELECT idVentas,Fecha, Total FROM ventas v
where Fecha >= desde and Fecha <= hasta;

END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `Get_OrdenReparacion`
--

DROP PROCEDURE IF EXISTS `Get_OrdenReparacion`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`GiFSys`@`localhost` PROCEDURE `Get_OrdenReparacion`(repa int)
BEGIN

SELECT r.IdReparacion, r.Dominio, r.IdCliente, r.FechaEntrada, r.DatosAveria,
v.Marca, V.modelo, v.Kilometros,
c.RazonSocial, c.Apellido, c.nombre, c.telfijo, c.telcelular, c.email
 FROM reparacion r
 inner join vehiculo v on v.dominio = r.dominio
 inner join cliente c on c.idcliente = r.idcliente
 where r.idreparacion = repa;

END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `get_saldo`
--

DROP PROCEDURE IF EXISTS `get_saldo`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_saldo`(fechasaldo date)
BEGIN

SELECT sum(ingreso)- sum(egreso) as Saldo
FROM Taller.cajamov cm
inner join caja c on c.codMovCaja = cm.idCajaMov
where c.fecha <= fechasaldo;


END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `Get_VehiculosEstado`
--

DROP PROCEDURE IF EXISTS `Get_VehiculosEstado`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`GiFSys`@`localhost` PROCEDURE `Get_VehiculosEstado`(Pestado VARCHAR(45))
BEGIN

 SELECT v.Dominio, v.Kilometros, v.Color, v.Marca, v.Modelo, v.Combustible, v.TipoMotor, v.Cilindrada, v.Poliza,
A.Aseguradora, v.Comentario, v.Estado, v.Foto, v.Vtv
FROM gestion_taller.vehiculo v
left join aseguradora a on a.Aseguradora = v.idaseguradora
where v.estado = Pestado;


END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `mipresu`
--

DROP PROCEDURE IF EXISTS `mipresu`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`GiFSys`@`localhost` PROCEDURE `mipresu`(numero int)
BEGIN
select c.RazonSocial AS RazonSocial,c.Apellido AS Apellido,c.Nombre AS Nombre,
v.idPresupuesto AS idpresupuesto,v.Fecha AS Fecha,v.Total AS Total,
va.idpresupuestoarticulos AS idPresupuestoArticulos,va.idArticulo AS idArticulo,
a.Descripcion AS Descripcion,va.Cantidad AS Cantidad,va.PrecioUnitario AS PrecioUnitario,
va.Importe AS Importe,cp.Vencimiento AS vencimiento from ((((presupuestos v
join presupuestoarticulos va on((va.idpresupuesto = v.idPresupuesto)))
join articulo a on((a.idArticulo = va.idArticulo)))
left join clientepresupuesto cp on((cp.IdPresupuesto = v.idPresupuesto)))
left join cliente c on((c.idCliente = cp.idCliente)))
where v.idpresupuesto= numero;

END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `Presupuesto`
--

DROP PROCEDURE IF EXISTS `Presupuesto`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `Presupuesto`(codigoPresupuesto integer)
BEGIN
SELECT
c.RazonSocial, c.Apellido, C.Nombre,
v.idpresupuesto, v.Fecha, v.Total,
va.idPresupuestoArticulos,va.idArticulo,a.Descripcion, va.Cantidad, va.PrecioUnitario, va.Importe,
cp.vencimiento
FROM presupuestos v
left join presupuestoarticulos va on va.idPresupuesto= v.idpresupuesto
left join Articulo a on a.idArticulo=va.idArticulo
left join clientepresupuesto cp on cp.idpresupuesto = v.idpresupuesto
left join cliente c on c.idcliente = cp.idcliente
where va.idPresupuesto = codigoPresupuesto;

END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of view `vista_factura`
--

DROP TABLE IF EXISTS `vista_factura`;
DROP VIEW IF EXISTS `vista_factura`;
CREATE ALGORITHM=UNDEFINED DEFINER=`GiFSys`@`localhost` SQL SECURITY DEFINER VIEW `vista_factura` AS select `cl`.`RazonSocial` AS `RazonSocial`,`cl`.`Apellido` AS `Apellido`,`cl`.`Nombre` AS `Nombre`,`cl`.`Domicilio` AS `Domicilio`,`v`.`idVentas` AS `idVentas`,`v`.`Fecha` AS `Fecha`,`v`.`Total` AS `Total`,`va`.`idVentaArticulo` AS `idVentaArticulo`,`va`.`idArticulo` AS `idArticulo`,`a`.`Descripcion` AS `Descripcion`,`va`.`Cantidad` AS `Cantidad`,`va`.`PrecioUnitario` AS `PrecioUnitario`,`va`.`Importe` AS `Importe` from ((((`ventas` `v` left join `ventaarticulos` `va` on((`va`.`idVenta` = `v`.`idVentas`))) left join `articulo` `a` on((`a`.`idArticulo` = `va`.`idArticulo`))) left join `clienteventa` `cv` on((`cv`.`idVenta` = `v`.`idVentas`))) left join `cliente` `cl` on((`cl`.`idCliente` = `cv`.`idCliente`)));

--
-- Definition of view `vistaarticulos`
--

DROP TABLE IF EXISTS `vistaarticulos`;
DROP VIEW IF EXISTS `vistaarticulos`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistaarticulos` AS select `a`.`idArticulo` AS `idArticulo`,`a`.`Descripcion` AS `Descripcion`,`a`.`Marca` AS `Marca`,`a`.`Rubro` AS `Rubro` from `articulo` `a` order by `a`.`Rubro`;

--
-- Definition of view `vistaarticulosystock`
--

DROP TABLE IF EXISTS `vistaarticulosystock`;
DROP VIEW IF EXISTS `vistaarticulosystock`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistaarticulosystock` AS select `a`.`idArticulo` AS `idArticulo`,`a`.`Descripcion` AS `Descripcion`,`a`.`Marca` AS `Marca`,`a`.`Rubro` AS `Rubro`,`s`.`Stock` AS `Stock` from (`articulo` `a` join `stockarticulos` `s` on((`a`.`idArticulo` = `s`.`idArticulo`))) order by `a`.`Rubro`;

--
-- Definition of view `vistaarticulosystockyprecio`
--

DROP TABLE IF EXISTS `vistaarticulosystockyprecio`;
DROP VIEW IF EXISTS `vistaarticulosystockyprecio`;
CREATE ALGORITHM=UNDEFINED DEFINER=`GiFSys`@`localhost` SQL SECURITY DEFINER VIEW `vistaarticulosystockyprecio` AS select `a`.`idArticulo` AS `idArticulo`,`a`.`Descripcion` AS `Descripcion`,`a`.`Marca` AS `Marca`,`a`.`Rubro` AS `Rubro`,`s`.`Stock` AS `Stock`,`a`.`PrecioVenta` AS `PrecioVenta` from (`articulo` `a` join `stockarticulos` `s` on((`a`.`idArticulo` = `s`.`idArticulo`))) order by `a`.`Rubro`;

--
-- Definition of view `vistacajamovimientos`
--

DROP TABLE IF EXISTS `vistacajamovimientos`;
DROP VIEW IF EXISTS `vistacajamovimientos`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistacajamovimientos` AS select `c`.`Fecha` AS `Fecha`,`m`.`tipoMovimiento` AS `TipoMovimiento`,`m`.`Descripcion` AS `Descripcion`,`m`.`tipoComprobante` AS `TipoComprobante`,`m`.`serienumero` AS `SerieNumero`,`m`.`ingreso` AS `ImporteIngreso`,`m`.`egreso` AS `ImporteSalida` from (`caja` `c` join `cajamov` `m` on((`m`.`idCajaMov` = `c`.`codMovCaja`)));

--
-- Definition of view `vistaconsultararticulostock`
--

DROP TABLE IF EXISTS `vistaconsultararticulostock`;
DROP VIEW IF EXISTS `vistaconsultararticulostock`;
CREATE ALGORITHM=UNDEFINED DEFINER=`GiFSys`@`localhost` SQL SECURITY DEFINER VIEW `vistaconsultararticulostock` AS select `v`.`idArticulo` AS `idArticulo`,`v`.`Descripcion` AS `Descripcion`,`v`.`PrecioCompra` AS `PrecioCompra`,`v`.`PrecioVenta` AS `PrecioVenta`,`v`.`Marca` AS `Marca`,`v`.`Imagen` AS `Imagen`,`v`.`Rubro` AS `Rubro`,`s`.`Stock` AS `Stock`,`s`.`StockMinimo` AS `StockMinimo`,`v`.`Situado` AS `situado` from (`articulo` `v` join `stockarticulos` `s` on((`v`.`idArticulo` = `s`.`idArticulo`)));

--
-- Definition of view `vistaordenreparacion`
--

DROP TABLE IF EXISTS `vistaordenreparacion`;
DROP VIEW IF EXISTS `vistaordenreparacion`;
CREATE ALGORITHM=UNDEFINED DEFINER=`GiFSys`@`localhost` SQL SECURITY DEFINER VIEW `vistaordenreparacion` AS select `r`.`IdReparacion` AS `IdReparacion`,`r`.`Dominio` AS `Dominio`,`r`.`IdCliente` AS `IdCliente`,`c`.`RazonSocial` AS `RazonSocial`,`c`.`Apellido` AS `Apellido`,`c`.`Nombre` AS `Nombre`,`r`.`FechaEntrada` AS `FechaEntrada`,`r`.`DatosAveria` AS `DatosAveria`,`r`.`FechaReparacion` AS `FechaReparacion`,`r`.`FechaSalida` AS `FechaSalida`,`r`.`Estado` AS `ESTADO` from ((`reparacion` `r` join `cliente` `c` on((`c`.`idCliente` = `r`.`IdCliente`))) join `vehiculo` `v` on((`v`.`Dominio` = `r`.`Dominio`))) order by `r`.`IdReparacion`;

--
-- Definition of view `vistaordenreparacioningresados`
--

DROP TABLE IF EXISTS `vistaordenreparacioningresados`;
DROP VIEW IF EXISTS `vistaordenreparacioningresados`;
CREATE ALGORITHM=UNDEFINED DEFINER=`GiFSys`@`localhost` SQL SECURITY DEFINER VIEW `vistaordenreparacioningresados` AS select `r`.`IdReparacion` AS `IdReparacion`,`r`.`Dominio` AS `Dominio`,`r`.`IdCliente` AS `IdCliente`,`c`.`RazonSocial` AS `RazonSocial`,`c`.`Apellido` AS `Apellido`,`c`.`Nombre` AS `Nombre`,`r`.`FechaEntrada` AS `FechaEntrada`,`r`.`DatosAveria` AS `DatosAveria`,`r`.`FechaReparacion` AS `FechaReparacion`,`r`.`FechaSalida` AS `FechaSalida`,`r`.`Estado` AS `ESTADO` from ((`reparacion` `r` join `cliente` `c` on((`c`.`idCliente` = `r`.`IdCliente`))) join `vehiculo` `v` on((`v`.`Dominio` = `r`.`Dominio`))) where (`r`.`Estado` = 'INGRESADO') order by `r`.`IdReparacion`;

--
-- Definition of view `vistaordenreparacionreparados`
--

DROP TABLE IF EXISTS `vistaordenreparacionreparados`;
DROP VIEW IF EXISTS `vistaordenreparacionreparados`;
CREATE ALGORITHM=UNDEFINED DEFINER=`GiFSys`@`localhost` SQL SECURITY DEFINER VIEW `vistaordenreparacionreparados` AS select `r`.`IdReparacion` AS `IdReparacion`,`r`.`Dominio` AS `Dominio`,`r`.`IdCliente` AS `IdCliente`,`c`.`RazonSocial` AS `RazonSocial`,`c`.`Apellido` AS `Apellido`,`c`.`Nombre` AS `Nombre`,`r`.`FechaEntrada` AS `FechaEntrada`,`r`.`DatosAveria` AS `DatosAveria`,`r`.`FechaReparacion` AS `FechaReparacion`,`r`.`FechaSalida` AS `FechaSalida`,`r`.`Estado` AS `ESTADO` from ((`reparacion` `r` join `cliente` `c` on((`c`.`idCliente` = `r`.`IdCliente`))) join `vehiculo` `v` on((`v`.`Dominio` = `r`.`Dominio`))) where (`r`.`Estado` = 'REPARADO') order by `r`.`IdReparacion`;

--
-- Definition of view `vistapresupuesto`
--

DROP TABLE IF EXISTS `vistapresupuesto`;
DROP VIEW IF EXISTS `vistapresupuesto`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistapresupuesto` AS select `c`.`RazonSocial` AS `RazonSocial`,`c`.`Apellido` AS `Apellido`,`c`.`Nombre` AS `Nombre`,`v`.`idPresupuesto` AS `idpresupuesto`,`v`.`Fecha` AS `Fecha`,`v`.`Total` AS `Total`,`va`.`idpresupuestoarticulos` AS `idPresupuestoArticulos`,`va`.`idArticulo` AS `idArticulo`,`a`.`Descripcion` AS `Descripcion`,`va`.`Cantidad` AS `Cantidad`,`va`.`PrecioUnitario` AS `PrecioUnitario`,`va`.`Importe` AS `Importe`,`cp`.`Vencimiento` AS `vencimiento` from ((((`presupuestos` `v` join `presupuestoarticulos` `va` on((`va`.`idpresupuesto` = `v`.`idPresupuesto`))) join `articulo` `a` on((`a`.`idArticulo` = `va`.`idArticulo`))) left join `clientepresupuesto` `cp` on((`cp`.`IdPresupuesto` = `v`.`idPresupuesto`))) left join `cliente` `c` on((`c`.`idCliente` = `cp`.`idCliente`)));

--
-- Definition of view `vistapresupuestocliente`
--

DROP TABLE IF EXISTS `vistapresupuestocliente`;
DROP VIEW IF EXISTS `vistapresupuestocliente`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistapresupuestocliente` AS select `p`.`idPresupuesto` AS `idPresupuesto`,`p`.`Fecha` AS `Fecha`,`c`.`idCliente` AS `Codigo`,`c`.`RazonSocial` AS `RazonSocial`,`c`.`Nombre` AS `Nombre`,`c`.`Apellido` AS `Apellido`,`p`.`Total` AS `Total` from ((`presupuestos` `p` left join `clientepresupuesto` `cp` on((`p`.`idPresupuesto` = `cp`.`IdPresupuesto`))) left join `cliente` `c` on((`c`.`idCliente` = `cp`.`idCliente`)));

--
-- Definition of view `vistavehiculos`
--

DROP TABLE IF EXISTS `vistavehiculos`;
DROP VIEW IF EXISTS `vistavehiculos`;
CREATE ALGORITHM=UNDEFINED DEFINER=`GiFSys`@`localhost` SQL SECURITY DEFINER VIEW `vistavehiculos` AS select `v`.`Dominio` AS `Dominio`,`v`.`Kilometros` AS `Kilometros`,`v`.`Color` AS `Color`,`v`.`Marca` AS `Marca`,`v`.`Modelo` AS `Modelo`,`v`.`Combustible` AS `Combustible`,`v`.`TipoMotor` AS `TipoMotor`,`v`.`Cilindrada` AS `Cilindrada`,`v`.`Poliza` AS `Poliza`,`a`.`Aseguradora` AS `Aseguradora`,`v`.`Comentario` AS `Comentario`,`v`.`estado` AS `Estado` from (`vehiculo` `v` left join `aseguradora` `a` on((`a`.`Aseguradora` = `v`.`IdAseguradora`)));

--
-- Definition of view `vistaventas`
--

DROP TABLE IF EXISTS `vistaventas`;
DROP VIEW IF EXISTS `vistaventas`;
CREATE ALGORITHM=UNDEFINED DEFINER=`GiFSys`@`localhost` SQL SECURITY DEFINER VIEW `vistaventas` AS select `v`.`idVentas` AS `Codigo`,`r`.`IdReparacion` AS `IdReparacion`,`v`.`Fecha` AS `Fecha`,`cl`.`RazonSocial` AS `RazonSocial`,`cl`.`Apellido` AS `Apellido`,`cl`.`Nombre` AS `Nombre`,`cl`.`Domicilio` AS `Domicilio`,`v`.`Total` AS `Total`,`v`.`Pagado` AS `Pagado` from (((`ventas` `v` left join `clienteventa` `cv` on((`cv`.`idVenta` = `v`.`idVentas`))) left join `cliente` `cl` on((`cl`.`idCliente` = `cv`.`idCliente`))) join `reparacion` `r` on((`r`.`idVenta` = `v`.`idVentas`)));

--
-- Definition of view `vistaventassinpago`
--

DROP TABLE IF EXISTS `vistaventassinpago`;
DROP VIEW IF EXISTS `vistaventassinpago`;
CREATE ALGORITHM=UNDEFINED DEFINER=`GiFSys`@`localhost` SQL SECURITY DEFINER VIEW `vistaventassinpago` AS select `v`.`idVentas` AS `Codigo`,`r`.`IdReparacion` AS `IdReparacion`,`r`.`Dominio` AS `Dominio`,`v`.`Fecha` AS `Fecha`,`cl`.`RazonSocial` AS `RazonSocial`,`cl`.`Apellido` AS `Apellido`,`cl`.`Nombre` AS `Nombre`,`cl`.`Domicilio` AS `Domicilio`,`v`.`Total` AS `Total`,`v`.`Pagado` AS `Pagado` from (((`ventas` `v` left join `clienteventa` `cv` on((`cv`.`idVenta` = `v`.`idVentas`))) left join `cliente` `cl` on((`cl`.`idCliente` = `cv`.`idCliente`))) join `reparacion` `r` on((`r`.`idVenta` = `v`.`idVentas`))) where (`v`.`Pagado` = 'NO');



/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
