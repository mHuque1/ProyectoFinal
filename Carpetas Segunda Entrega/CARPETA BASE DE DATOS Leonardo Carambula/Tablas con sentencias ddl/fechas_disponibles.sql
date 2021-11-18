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
-- Table structure for table `fechas_disponibles`
--

DROP TABLE IF EXISTS `fechas_disponibles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fechas_disponibles` (
  `Servicio` varchar(50) NOT NULL,
  `Fecha` date NOT NULL,
  `Hora` time NOT NULL,
  `Cupos` int(11) DEFAULT NULL,
  PRIMARY KEY (`Servicio`,`Fecha`,`Hora`),
  CONSTRAINT `nombre` FOREIGN KEY (`Servicio`) REFERENCES `servicio` (`Nombre`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fechas_disponibles`
--

LOCK TABLES `fechas_disponibles` WRITE;
/*!40000 ALTER TABLE `fechas_disponibles` DISABLE KEYS */;
INSERT INTO `fechas_disponibles` VALUES ('Botes','2021-09-25','10:00:00',-1),('Botes','2021-09-25','11:00:00',-1),('Botes','2021-09-25','12:00:00',-1),('Botes','2021-09-25','13:00:00',-1),('Botes','2021-09-25','14:00:00',-1),('Botes','2021-09-25','15:00:00',-1),('Botes','2021-09-25','16:00:00',-1),('Botes','2021-09-25','17:00:00',-1),('Botes','2021-09-25','18:00:00',-1),('Botes','2021-09-25','19:00:00',-1),('Masaje Tradicional','2021-09-25','10:00:00',2),('Masaje Tradicional','2021-09-25','10:20:00',2),('Masaje Tradicional','2021-09-25','10:40:00',2),('Masaje Tradicional','2021-09-25','11:00:00',2),('Masaje Tradicional','2021-09-25','11:20:00',2),('Masaje Tradicional','2021-09-25','11:40:00',2),('Masaje Tradicional','2021-09-25','12:00:00',2),('Masaje Tradicional','2021-09-25','12:20:00',2),('Masaje Tradicional','2021-09-25','12:40:00',2),('Masaje Tradicional','2021-09-25','13:00:00',2),('Masaje Tradicional','2021-09-25','13:20:00',2),('Masaje Tradicional','2021-09-25','13:40:00',2),('Masaje Tradicional','2021-09-25','14:00:00',2),('Masaje Tradicional','2021-09-25','14:20:00',2),('Masaje Tradicional','2021-09-25','14:40:00',2),('Masaje Tradicional','2021-09-25','15:00:00',2),('Masaje Tradicional','2021-09-25','15:20:00',2),('Masaje Tradicional','2021-09-25','15:40:00',2),('Masaje Tradicional','2021-09-25','16:00:00',1),('Masaje Tradicional','2021-09-25','16:20:00',2),('Masaje Tradicional','2021-09-25','16:40:00',2),('Masaje Tradicional','2021-09-25','17:00:00',2),('Masaje Tradicional','2021-09-25','17:20:00',2),('Masaje Tradicional','2021-09-25','17:40:00',2),('Masaje Tradicional','2021-09-25','18:00:00',2),('Masaje Tradicional','2021-09-25','18:20:00',2),('Masaje Tradicional','2021-09-25','18:40:00',2),('Masaje Tradicional','2021-09-25','19:00:00',2),('Masaje Tradicional','2021-09-25','19:20:00',2),('Masaje Tradicional','2021-09-25','19:40:00',2),('Meditación','2021-09-25','10:00:00',10),('Meditación','2021-09-25','10:30:00',10),('Meditación','2021-09-25','11:00:00',9),('Meditación','2021-09-25','11:30:00',10),('Meditación','2021-09-25','12:00:00',10),('Meditación','2021-09-25','12:30:00',10),('Meditación','2021-09-25','13:00:00',10),('Meditación','2021-09-25','13:30:00',10),('Meditación','2021-09-25','14:00:00',10),('Meditación','2021-09-25','14:30:00',10),('Meditación','2021-09-25','15:00:00',10),('Meditación','2021-09-25','15:30:00',10),('Meditación','2021-09-25','16:00:00',10),('Meditación','2021-09-25','16:30:00',10),('Meditación','2021-09-25','17:00:00',10),('Meditación','2021-09-25','17:30:00',10),('Meditación','2021-09-25','18:00:00',10),('Meditación','2021-09-25','18:30:00',10),('Meditación','2021-09-25','19:00:00',10),('Meditación','2021-09-25','19:30:00',10);
/*!40000 ALTER TABLE `fechas_disponibles` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-09-22 21:54:38
