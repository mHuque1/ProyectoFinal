-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 192.168.2.53    Database: Pollux
-- ------------------------------------------------------
-- Server version	5.7.18-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `servicio`
--

DROP TABLE IF EXISTS `servicio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `servicio` (
  `Nombre` varchar(50) NOT NULL,
  `CapacidadMax` int(11) DEFAULT NULL,
  `PermanenciaMinutos` int(11) NOT NULL,
  `CuposMax` int(11) DEFAULT NULL,
  `Costo` int(11) NOT NULL,
  `Habilitado` tinyint(4) NOT NULL DEFAULT '1',
  `FechaDeDeshabilitacion` datetime NOT NULL DEFAULT '0001-01-01 01:00:00',
  `FechaDeHabilitacion` datetime NOT NULL DEFAULT '0001-01-01 01:00:00',
  PRIMARY KEY (`Nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `servicio`
--

LOCK TABLES `servicio` WRITE;
/*!40000 ALTER TABLE `servicio` DISABLE KEYS */;
INSERT INTO `servicio` VALUES ('Bicicletas',-1,30,-1,100,1,'0001-01-01 01:00:00','0001-01-01 01:00:00'),('Botes',-1,60,-1,400,1,'0001-01-01 01:00:00','0001-01-01 01:00:00'),('Cabalgatas',-1,60,-1,500,1,'0001-01-01 01:00:00','0001-01-01 01:00:00'),('Hidromasaje',90,20,4,0,1,'0001-01-01 01:00:00','0001-01-01 01:00:00'),('Masaje Oriental',50,20,2,700,1,'0001-01-01 01:00:00','0001-01-01 01:00:00'),('Masaje Tradicional',50,20,2,600,1,'0001-01-01 01:00:00','0001-01-01 01:00:00'),('Meditación',-1,30,10,500,1,'0001-01-01 01:00:00','0001-01-01 01:00:00'),('Piscina Abierta',200,120,50,0,1,'0001-01-01 01:00:00','0001-01-01 01:00:00'),('Piscina barro',80,20,40,0,1,'0001-01-01 01:00:00','0001-01-01 01:00:00'),('Piscina Cerrada',200,120,50,0,1,'0001-01-01 01:00:00','0001-01-01 01:00:00'),('Sauna',75,10,6,0,1,'0001-01-01 01:00:00','0001-01-01 01:00:00'),('Traslado Ida',-1,15,6,350,1,'0001-01-01 01:00:00','0001-01-01 01:00:00'),('Traslado Vuelta',-1,15,6,350,1,'0001-01-01 01:00:00','0001-01-01 01:00:00'),('Yoga / Pilates',-1,30,10,800,1,'0001-01-01 01:00:00','0001-01-01 01:00:00');
/*!40000 ALTER TABLE `servicio` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-09-22 21:54:37
