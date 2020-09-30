CREATE DATABASE  IF NOT EXISTS `mercadolider` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `mercadolider`;
-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: mercadolider
-- ------------------------------------------------------
-- Server version	8.0.21

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `administradores`
--

DROP TABLE IF EXISTS `administradores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `administradores` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `id_usuario` int NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `id_usuario_UNIQUE` (`id_usuario`),
  CONSTRAINT `FK_USUARIO_ADMINISTRADOR` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `administradores`
--

LOCK TABLES `administradores` WRITE;
/*!40000 ALTER TABLE `administradores` DISABLE KEYS */;
INSERT INTO `administradores` VALUES (1,1);
/*!40000 ALTER TABLE `administradores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compradores`
--

DROP TABLE IF EXISTS `compradores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `compradores` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `id_usuario` int NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `id_usuario_UNIQUE` (`id_usuario`),
  CONSTRAINT `FK_USUARIO_COMPRADOR` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compradores`
--

LOCK TABLES `compradores` WRITE;
/*!40000 ALTER TABLE `compradores` DISABLE KEYS */;
INSERT INTO `compradores` VALUES (1,1),(2,2),(3,5),(4,7),(5,8),(6,9),(7,10);
/*!40000 ALTER TABLE `compradores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `direccion_usuario`
--

DROP TABLE IF EXISTS `direccion_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `direccion_usuario` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `id_usuario` int DEFAULT NULL,
  `direccion` varchar(140) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_DIRECCION_USUARIO_idx` (`id_usuario`),
  CONSTRAINT `FK_DIRECCION_USUARIO` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `direccion_usuario`
--

LOCK TABLES `direccion_usuario` WRITE;
/*!40000 ALTER TABLE `direccion_usuario` DISABLE KEYS */;
INSERT INTO `direccion_usuario` VALUES (1,1,'San Jose'),(2,1,'Capurro'),(3,2,'No se sabe '),(5,10,'La callesita consitutsion'),(6,10,'pepemujica'),(7,2,''),(8,8,'Atenas'),(9,8,'');
/*!40000 ALTER TABLE `direccion_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `galeria_producto`
--

DROP TABLE IF EXISTS `galeria_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `galeria_producto` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `id_producto` int NOT NULL,
  `imagen` varchar(100) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_PRODUCTO_IMAGEN_idx` (`id_producto`),
  CONSTRAINT `FK_PRODUCTO_IMAGEN` FOREIGN KEY (`id_producto`) REFERENCES `productos` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `galeria_producto`
--

LOCK TABLES `galeria_producto` WRITE;
/*!40000 ALTER TABLE `galeria_producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `galeria_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productos` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `id_vendedor` int NOT NULL,
  `nombre` varchar(150) NOT NULL,
  `descripcion` varchar(500) DEFAULT NULL,
  `foto` varchar(100) DEFAULT NULL,
  `fec_publicacion` datetime NOT NULL,
  `precio` int NOT NULL,
  `stock` int NOT NULL DEFAULT '1',
  PRIMARY KEY (`ID`),
  KEY `FK_PRODUCTO_VENDEDOR_idx` (`id_vendedor`),
  CONSTRAINT `FK_PRODUCTO_VENDEDOR` FOREIGN KEY (`id_vendedor`) REFERENCES `vendedores` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES (1,2,'Collar','Collar para hombre','Collar.jpg','2020-09-18 00:00:00',2000,12),(2,1,'Katana','Katana, Cinese handmade katana ','Espada.png','2020-09-18 00:00:00',20000,13),(3,3,'Anillo','Anillo en tono azul','Anillo.jpg','2020-09-18 00:00:00',1000,15),(4,4,'Libro Andrew Loomis','Dibujo De Cabeza y Manos Andrew Loomis, Libro Completo','Libro.jpg','2020-09-18 00:00:00',1200,12),(5,5,'Libro Perspective Made Easy','Libro Perspective made easy Ernest R.Norling','Libro2.jpg','2020-09-18 00:00:00',1200,3),(6,2,'Tableta Wacom Intuos','Tableta Wacom Intuos, Color Negro, con lápiz sensible a la presión, inalámbrico y sin pilas','Tableta.jpg','2020-09-18 00:00:00',40000,4),(7,3,'Kawasaki Ninja 300','Kawasaki Ninja 300.','Moto.jpg','2020-09-18 00:00:00',600000,56),(8,5,'SketchBooks','Cuaderno de bocetos para dibujar y pintar, 3 unidades, tamaño A5, 5.5 x 8.3 in, 100% algodón, impresión en frío, texturizado, vegano, 44 páginas por libro','SketchBooks.jpg','2020-09-18 00:00:00',2000,7),(9,6,'iPad Pro','Nuevo iPad Pro, Hace lo mismo que los otros :v Pero oye es nuevo!!! ','IpadPro.jpg','2020-09-18 00:00:00',60000,8),(10,2,'CristalCuarzo','Cristales de cuarzo bonito y barato','CristalCuarzo.jpeg','2020-09-18 00:00:00',200000,9),(11,1,'Casas','Contate para acorda presio','Default.jpg','2020-09-28 00:00:00',111,11);
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `mail` varchar(320) NOT NULL,
  `clave` varchar(100) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellido` varchar(50) NOT NULL,
  `imagen` varchar(130) NOT NULL,
  `telefono` varchar(22) NOT NULL,
  `activo` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `mail_UNIQUE` (`mail`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'pamelarblu@gmail.com','123','Pamela','Rodriguez','Kadaj.jpeg','092712484',1),(2,'sephiroth@gmail.com','123','Sephiroth','S','Sephiroth.jpeg','092456674',1),(5,'dohkodelibra@gmail.com','123','Dohokito','De Libra','Dohko.png','345345345',1),(6,'zackzito@gmail.com','123','Zack','Fire','Zack.jpg','345345543',1),(7,'anchan@gmail.com','123','AnChan','KinSabe','AnChan.jpg','345654456',1),(8,'shiondearies@gmail.com','123','Shion','De Aries','Shion.jpg','098 765 345',1),(9,'tenmma@gmail.coml.com','123','Tenmma','Kenzo','tenmma.jpg','23456783',1),(10,'kaladin@gmail.com','123','Kaladin','Andeasaber','Kaladin.jpg','43567233',1);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vendedores`
--

DROP TABLE IF EXISTS `vendedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vendedores` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `id_usuario` int NOT NULL,
  `RUT` varchar(12) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `id_usuario_UNIQUE` (`id_usuario`),
  CONSTRAINT `FK_USUARIO_VENDEDOR` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vendedores`
--

LOCK TABLES `vendedores` WRITE;
/*!40000 ALTER TABLE `vendedores` DISABLE KEYS */;
INSERT INTO `vendedores` VALUES (1,1,'123456654323'),(2,2,'123476543454'),(3,3,'235345324524'),(4,4,'534634634543'),(5,5,'645456745634'),(6,6,'547645766345'),(7,7,'546685875676');
/*!40000 ALTER TABLE `vendedores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ventas` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `id_comprador` int NOT NULL,
  `id_producto` int NOT NULL,
  `precio` int NOT NULL,
  `cantidad` int NOT NULL DEFAULT '1',
  `fec_venta` datetime NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_VENTA_COMPRADOR_idx` (`id_comprador`),
  KEY `FK_VENTA_PRODUCTO_idx` (`id_producto`),
  CONSTRAINT `FK_VENTA_COMPRADOR` FOREIGN KEY (`id_comprador`) REFERENCES `compradores` (`ID`),
  CONSTRAINT `FK_VENTA_PRODUCTO` FOREIGN KEY (`id_producto`) REFERENCES `productos` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas`
--

LOCK TABLES `ventas` WRITE;
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-09-30 19:40:06
