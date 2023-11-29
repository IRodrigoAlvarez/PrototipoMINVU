-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 29-11-2023 a las 15:38:57
-- Versión del servidor: 10.4.18-MariaDB
-- Versión de PHP: 7.3.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `prototipominvu`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_ADDINTEGRACION` (IN `idinte` INT(11), IN `idso` INT(11), IN `idsd` INT(11), IN `idsd2` INT(11), IN `idmo` INT(11), IN `idmd` INT(11), IN `idmd2` INT(11), IN `idtint` INT(11), IN `identex` INT(11))  INSERT INTO

integraciones

VALUES(
	idinte,
    idso,
    idsd,
    idsd2,
    idmo,
    idmd,
    idmd2,
    idtint,
    identex
)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_AGREGAMODULO` (IN `idsistema` INT(11), IN `nombre_sistema` VARCHAR(1000), IN `descripcion_sistema` VARCHAR(100), IN `idambiente` INT(11), IN `idestado` INT(11))  INSERT INTO modulos (modulos.id_modulo, modulos.nombre_modulo, modulos.descripcion_modulo,modulos.id_ambiente,modulos.id_estado)VALUES (idsistema, nombre_sistema, descripcion_sistema, idambiente, idestado)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_AGREGARUSUARIO` (IN `idusuario` INT(11), IN `RUT` INT(50), IN `correo` VARCHAR(50), IN `strPass` VARCHAR(15), IN `nombre` VARCHAR(50), IN `idtipousuario` INT(11))  INSERT INTO

usuario

VALUES(
	idusuario,
    RUT,
    correo,
    strPass,
    nombre,
    idtipousuario
)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_AGREGASISTEMA` (IN `id_sistema` INT(11), IN `idambiente` INT(11), IN `nombresi` VARCHAR(1000), IN `urlinicio` VARCHAR(1000), IN `urldatos` VARCHAR(1000), IN `costosistema` INT(50), IN `descripcionsi` VARCHAR(1000), IN `decretoafecto` VARCHAR(1000), IN `idarea` INT(11), IN `iddata` INT(11), IN `idtecnologia` INT(11), IN `idtiposi` INT(11), IN `idregion` INT(11), IN `idestado` INT(11), IN `idjefeproyecto` INT(11), IN `idcontrol` INT(11), IN `idlegacy` INT(11), IN `idalcance` INT(11), IN `fechades` DATE)  INSERT INTO sistemas
VALUES(
    id_sistema,
    nombresi,
    descripcionsi,
    idambiente,
    idestado,
    fechades,
    urlinicio,
    urldatos,
    costosistema,    
    decretoafecto,
    idarea,
    iddata,
    idtecnologia,
    idtiposi,
    idregion,
    idjefeproyecto,
    idcontrol,
    idlegacy,
    idalcance)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_CARGAALCANCES` ()  SELECT * FROM alcance$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_CARGAAREAS` ()  SELECT * FROM area$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_CARGACONTROLACCESO` ()  SELECT * FROM control_acceso$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_CARGADO` ()  SELECT * FROM dueño_datos$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_CARGAESTADOS` ()  SELECT * FROM estados$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_CARGAJEFESPROY` ()  SELECT * FROM jefes_proyectos$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_CARGALEGACY` ()  SELECT * FROM tipo_legacy$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_CARGAMBIENTES` ()  SELECT * FROM ambiente$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_CARGAREGION` ()  SELECT * FROM region$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_CARGASISTEMASby` (IN `idsistema` INT(20))  SELECT
    sistemas.id_sistema,
    sistemas.nombre_sistema,
    sistemas.descripcion_sistema,
    jefes_proyectos.nombre_jefe,
    estados.descripcion_estado,
    ambiente.id_ambiente,
    ambiente.nombre_ambiente
FROM sistemas
LEFT JOIN estados ON sistemas.id_estado = estados.id_estado
LEFT JOIN jefes_proyectos ON sistemas.id_jefeproyecto = jefes_proyectos.id_jefe
LEFT JOIN ambiente ON sistemas.id_ambiente = ambiente.id_ambiente
WHERE sistemas.id_sistema = idsistema$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_CARGATECNOLOGIA` ()  SELECT * FROM tecnologia$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_CARGATIPOINTEGRACIONES` ()  SELECT

tipo_integracion.id_tipointeg,
tipo_integracion.tipo_integracion

FROM

tipo_integracion$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_CARGATIPOSISTEMA` ()  SELECT * FROM tipo_sistema$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_CARGATIPOUSUARIOS` ()  SELECT * FROM tipo_usuario$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_DELETEINTEGRACION` (IN `idinte` INT(11))  DELETE FROM integraciones WHERE integraciones.id_integracion=idinte$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_DELETEMODULO` (IN `idsistema` INT(11))  DELETE FROM modulos WHERE modulos.id_modulo=idsistema$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_DELETESISTEMA` (IN `idsistema` INT(11))  DELETE FROM sistemas WHERE sistemas.id_sistema=idsistema$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_EDITARINTEGRACION` (IN `idinte` INT(11), IN `idso` INT(11), IN `idsd` INT(11), IN `idsd2` INT(11), IN `idmo` INT(11), IN `idmd` INT(11), IN `idmd2` INT(11), IN `idtint` INT(11), IN `identex` INT(11))  UPDATE integraciones SET

integraciones.id_sistemaorigen = idso,
integraciones.id_sistemadestino=idsd,
integraciones.id_sistemadestino2=idsd2,
integraciones.id_moduloorigen=idmo,
integraciones.id_modulodestino=idmd,
integraciones.id_modulodestino2=idmd2,
integraciones.id_tipointegracion=idtint,
integraciones.id_entidad_ext=identex


WHERE 
integraciones.id_integracion=idinte$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_EDITARMODULO` (IN `idsistema` INT(11), IN `nombresistema` VARCHAR(100), IN `descripcionsistema` VARCHAR(1000), IN `idambiente` INT(11), IN `idestado` INT(11))  UPDATE modulos SET

modulos.nombre_modulo=nombresistema,
modulos.descripcion_modulo = descripcionsistema,
modulos.id_ambiente = idambiente,
modulos.id_estado = idestado
WHERE
modulos.id_modulo= idsistema$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_EDITARSISTEMA` (IN `nombresistema` VARCHAR(50), IN `descripcion` VARCHAR(1000), IN `URLinicio` VARCHAR(50), IN `URLdatos` VARCHAR(50), IN `costosistema` INT(50), IN `iddataow` INT(11), IN `idjefep` INT(11), IN `idcontrol` INT(11), IN `idalcance` INT(11), IN `idtiposistema` INT(11), IN `idtecnologia` INT(11), IN `idlegacy` INT(11), IN `idregion` INT(11), IN `idestado` INT(11), IN `idsistemanuevo` INT(11), IN `decretoafecto` VARCHAR(100))  UPDATE sistemas SET

sistemas.nombre_sistema = nombresistema,
sistemas.descripcion_sistema = descripcion,
sistemas.URLinicio = URLinicio,
sistemas.URLdatos = URLdatos,
sistemas.costo_sistema = costosistema,
sistemas.decreto_afecto = decretoafecto,
sistemas.id_data = iddataow,
sistemas.id_jefeproyecto =  idjefep,
sistemas.id_control = idcontrol,
sistemas.id_alcance = idalcance,
sistemas.id_tiposistema = idtiposistema,
sistemas.id_tecnologia = idtecnologia,
sistemas.id_legacy = idlegacy,
sistemas.id_region = idregion,
sistemas.id_estado = idestado


WHERE sistemas.id_sistema = idsistemanuevo$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_FRMEDITSISTEMA` (IN `idsistema` INT)  SELECT
 sistemas.id_sistema,
 sistemas.nombre_sistema,
 sistemas.URLinicio,
 sistemas.URLdatos,
 sistemas.costo_sistema,
 sistemas.descripcion_sistema,
 sistemas.decreto_afecto,
 sistemas.id_ambiente,
 ambiente.nombre_ambiente,
 
 sistemas.id_area,
 area.nombre_area,
 
 sistemas.id_data,
 dueño_datos.nombre_origen,
 
 sistemas.id_tecnologia,
 tecnologia.nombre_tecnologia,
 
 sistemas.id_tiposistema,
 tipo_sistema.descripcion_tipo,
 
 sistemas.id_region,
 region.nombre_region,
 
 sistemas.id_estado,
 estados.descripcion_estado,
 
 sistemas.id_control,
 control_acceso.tipo_control,
 
 sistemas.id_jefeproyecto,
 jefes_proyectos.nombre_jefe,
 
 sistemas.id_legacy,
 tipo_legacy.descripcion_legacy,
 
 sistemas.id_alcance,
 alcance.descripcion_alcance
 
FROM sistemas

LEFT JOIN ambiente ON ambiente.id_ambiente = sistemas.id_ambiente
LEFT JOIN area ON area.id_area=sistemas.id_area
LEFT JOIN dueño_datos ON dueño_datos.id_dataow = sistemas.id_data
LEFT JOIN tecnologia ON tecnologia.id_tecnologia = sistemas.id_tecnologia
LEFT JOIN tipo_sistema ON tipo_sistema.id_tiposistema = sistemas.id_tiposistema
LEFT JOIN region ON region.id_region = sistemas.id_region
LEFT JOIN estados ON estados.id_estado = sistemas.id_estado
LEFT JOIN control_acceso ON control_acceso.id_control = sistemas.id_control
LEFT JOIN jefes_proyectos ON jefes_proyectos.id_jefe = sistemas.id_jefeproyecto
LEFT JOIN tipo_legacy ON tipo_legacy.id_legacy = sistemas.id_legacy
LEFT JOIN alcance ON alcance.id_alcance = sistemas.id_alcance

WHERE sistemas.id_sistema=idsistema$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_GRAFICO_ALCANCE` ()  SELECT
  sistemas.id_sistema AS idX,
  alcance.descripcion_alcance AS etiquetaX,
  sistemas.id_alcance AS idY,
  sistemas.nombre_sistema AS etiquetaY
FROM sistemas
INNER JOIN alcance ON sistemas.id_alcance = alcance.id_alcance$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_GRAFICO_AMBIENTE` ()  SELECT
  sistemas.id_sistema AS idX,
  ambiente.nombre_ambiente AS etiquetaX,
  sistemas.id_ambiente AS idY,
  sistemas.nombre_sistema AS etiquetaY
FROM sistemas
INNER JOIN ambiente ON sistemas.id_ambiente = ambiente.id_ambiente$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_GRAFICO_AREAS` ()  SELECT
  sistemas.id_sistema AS idX,
  area.nombre_area AS etiquetaX,
  sistemas.id_area AS idY,
  sistemas.nombre_sistema AS etiquetaY
FROM sistemas
INNER JOIN area ON sistemas.id_area = area.id_area$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_GRAFICO_CONTROL` ()  SELECT
  sistemas.id_sistema AS idX,
  control_acceso.tipo_control AS etiquetaX,
  sistemas.id_control AS idY,
  sistemas.nombre_sistema AS etiquetaY
FROM sistemas
INNER JOIN control_acceso ON sistemas.id_control = control_acceso.id_control$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_GRAFICO_DATAOW` ()  SELECT
  sistemas.id_sistema AS idX,
  dueño_datos.nombre_origen AS etiquetaX,
  sistemas.id_data AS idY,
  sistemas.nombre_sistema AS etiquetaY
FROM sistemas
INNER JOIN dueño_datos ON sistemas.id_data = dueño_datos.id_dataow$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_GRAFICO_ESTADO` ()  SELECT
  sistemas.id_sistema AS idX,
  estados.descripcion_estado AS etiquetaX,
  sistemas.id_estado AS idY,
  sistemas.nombre_sistema AS etiquetaY
FROM sistemas
INNER JOIN estados ON sistemas.id_estado = estados.id_estado$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_GRAFICO_JEFE` ()  SELECT
  sistemas.id_sistema AS idX,
  jefes_proyectos.nombre_jefe AS etiquetaX,
  sistemas.id_jefeproyecto AS idY,
  sistemas.nombre_sistema AS etiquetaY
FROM sistemas
INNER JOIN jefes_proyectos ON sistemas.id_jefeproyecto = jefes_proyectos.id_jefe$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_GRAFICO_LEGACY` ()  SELECT
  sistemas.id_sistema AS idX,
  tipo_legacy.descripcion_legacy AS etiquetaX,
  sistemas.id_legacy AS idY,
  sistemas.nombre_sistema AS etiquetaY
FROM sistemas
INNER JOIN tipo_legacy ON sistemas.id_legacy = tipo_legacy.id_legacy$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_GRAFICO_REGION` ()  SELECT
  sistemas.id_sistema AS idX,
  region.id_region AS etiquetaX,
  sistemas.id_region AS idY,
  sistemas.nombre_sistema AS etiquetaY
FROM sistemas
INNER JOIN region ON sistemas.id_region = region.id_region$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_GRAFICO_TECNOLOGIA` ()  SELECT
  sistemas.id_sistema AS idX,
  tecnologia.nombre_tecnologia AS etiquetaX,
  sistemas.id_tecnologia AS idY,
  sistemas.nombre_sistema AS etiquetaY
FROM sistemas
INNER JOIN tecnologia ON sistemas.id_tecnologia = tecnologia.id_tecnologia$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_GRAFICO_TIPOSI` ()  SELECT
  sistemas.id_sistema AS idX,
  tipo_sistema.descripcion_tipo AS etiquetaX,
  sistemas.id_tiposistema AS idY,
  sistemas.nombre_sistema AS etiquetaY
FROM sistemas
INNER JOIN tipo_sistema ON sistemas.id_tiposistema = tipo_sistema.id_tiposistema$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_INTEGRACIONBY` (IN `idinte` INT(11))  SELECT

	integraciones.id_integracion,
    tipo_integracion.id_tipointeg,
    
    integraciones.id_sistemaorigen AS Sistema_Origen,
    integraciones.id_sistemadestino AS Sistema_Destino,
    integraciones.id_sistemadestino2 AS Sistema_Destino2,
    
    integraciones.id_moduloorigen AS Modulo_Origen,
    integraciones.id_modulodestino AS Modulo_Destino,
    integraciones.id_modulodestino2 AS Modulo_Destino2

FROM integraciones 

INNER JOIN tipo_integracion ON tipo_integracion.id_tipointeg = integraciones.id_tipointegracion 

WHERE integraciones.id_integracion=idinte$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_INTEGRACIONES` ()  SELECT
  integraciones.id_integracion,
  tipo_integracion.tipo_integracion,
  sistemas_origen.nombre_sistema AS Sistema_Origen,
  modulos_origen.nombre_modulo AS Modulo_Origen,
  sistemas_destino.nombre_sistema AS Sistema_Destino,
  sistemas_destino2.nombre_sistema AS Sistema_Destino2,
  modulos_destino.nombre_modulo AS Modulo_Destino,
  modulos_destino2.nombre_modulo AS Modulo_Destino2
FROM integraciones
INNER JOIN sistemas AS sistemas_origen ON sistemas_origen.id_sistema = integraciones.id_sistemaorigen
INNER JOIN sistemas AS sistemas_destino ON sistemas_destino.id_sistema = integraciones.id_sistemadestino
INNER JOIN sistemas AS sistemas_destino2 ON sistemas_destino2.id_sistema = integraciones.id_sistemadestino2
INNER JOIN modulos AS modulos_origen ON modulos_origen.id_modulo = integraciones.id_moduloorigen
INNER JOIN modulos AS modulos_destino ON modulos_destino.id_modulo = integraciones.id_modulodestino
INNER JOIN modulos AS modulos_destino2 ON modulos_destino2.id_modulo = integraciones.id_modulodestino2
INNER JOIN tipo_integracion ON tipo_integracion.id_tipointeg = integraciones.id_tipointegracion
WHERE integraciones.id_integracion <> 0
ORDER BY Sistema_Origen, tipo_integracion$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_INTEGRACIONES_MODULOS` ()  SELECT
  integraciones.id_integracion AS idX,
  tipo_integracion.tipo_integracion AS etiquetaX,
  integraciones.id_tipointegracion AS idY,
  modulos.nombre_modulo AS etiquetaY
FROM integraciones

INNER JOIN tipo_integracion ON tipo_integracion.id_tipointeg=integraciones.id_tipointegracion

INNER JOIN modulos ON modulos.id_modulo = integraciones.id_moduloorigen$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_INTEGRACION_SISTEMAS` ()  SELECT
  integraciones.id_integracion AS idX,    
  integraciones.id_tipointegracion AS idY,
  tipo_integracion.tipo_integracion AS etiquetaX,  
  integraciones.id_sistemaorigen AS etiquetaOrigen,
  integraciones.id_sistemadestino AS etiquetaDestino,
  integraciones.id_sistemadestino2 AS etiquetaDestino2
FROM integraciones

INNER JOIN tipo_integracion ON tipo_integracion.id_tipointeg=integraciones.id_tipointegracion

INNER JOIN sistemas ON sistemas.id_sistema = integraciones.id_sistemaorigen$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_INTEGRA_SISTEMASby` (IN `idsistema` INT(11))  SELECT
    integraciones.id_integracion,
    sistema_origen.nombre_sistema AS Sistema_Origen,
    tipo_integracion.tipo_integracion,
    sistema_destino.nombre_sistema AS Sistema_Destino,
    modulos_destino.nombre_modulo AS Modulo_Destino
FROM integraciones

INNER JOIN sistemas AS sistema_origen ON integraciones.id_sistemaorigen = sistema_origen.id_sistema
INNER JOIN sistemas AS sistema_destino ON integraciones.id_sistemadestino = sistema_destino.id_sistema
INNER JOIN modulos AS modulos_destino ON integraciones.id_modulodestino = modulos_destino.id_modulo
INNER JOIN tipo_integracion ON tipo_integracion.id_tipointeg = integraciones.id_tipointegracion
WHERE integraciones.id_sistemaorigen = idsistema OR integraciones.id_sistemadestino = idsistema


ORDER BY Sistema_Origen$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_MAXIDINTEGRA` ()  SELECT MAX(integraciones.id_integracion) FROM integraciones$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_MaxIDmodulos` ()  SELECT MAX(modulos.id_modulo) FROM modulos$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_MaxIDsistemas` ()  SELECT MAX(sistemas.id_sistema) FROM sistemas$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_MaxIDusuario` ()  SELECT MAX(usuario.idUsuario) FROM usuario$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_MODULObyambiente` (IN `ambiente` INT)  SELECT * FROM modulos WHERE modulos.id_ambiente = ambiente$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_MODULObyid` (IN `idsistema` INT(11))  SELECT

modulos.id_modulo,
modulos.nombre_modulo,
modulos.descripcion_modulo,
modulos.id_ambiente,
estados.descripcion_estado,
modulos.id_estado,
ambiente.nombre_ambiente

FROM modulos 
LEFT JOIN ambiente ON ambiente.id_ambiente=modulos.id_ambiente
LEFT JOIN estados ON estados.id_estado=modulos.id_estado
WHERE modulos.id_modulo=idsistema$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_MODULOS` ()  SELECT
	modulos.id_modulo,
    modulos.nombre_modulo,
    modulos.descripcion_modulo,
    modulos.id_estado,
    estados.descripcion_estado,
    ambiente.nombre_ambiente,
    modulos.id_ambiente

FROM modulos

INNER JOIN estados ON estados.id_estado=modulos.id_estado

INNER JOIN ambiente ON ambiente.id_ambiente=modulos.id_ambiente$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_MODULO_AMBIENTE` ()  SELECT
  modulos.id_modulo AS idX,
  ambiente.nombre_ambiente AS etiquetaX,
  modulos.id_ambiente AS idY,
  modulos.nombre_modulo AS etiquetaY
FROM modulos
INNER JOIN ambiente ON ambiente.id_ambiente=modulos.id_ambiente$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_MODULO_ESTADO` ()  SELECT
   modulos.id_modulo AS idX,
   estados.descripcion_estado AS etiquetaX,
   modulos.id_estado AS idY,
   modulos.nombre_modulo AS etiquetaY
FROM modulos
INNER JOIN estados ON estados.id_estado = modulos.id_estado$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_SISTEMAS` ()  SELECT 
  sistemas.id_sistema,
  sistemas.nombre_sistema,
  sistemas.id_estado,
  estados.descripcion_estado,
  sistemas.id_ambiente,
  ambiente.nombre_ambiente
FROM sistemas
INNER JOIN ambiente ON ambiente.id_ambiente = sistemas.id_ambiente
INNER JOIN estados ON estados.id_estado = sistemas.id_estado$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PSM_VALIDAUSUARIO` (IN `idrut` INT(10), IN `idpas` VARCHAR(15))  SELECT
	usuario.idUsuario,
	usuario.Nombre,
    usuario.RUT,
    usuario.Password,
    usuario.id_tipousuario,
    tipo_usuario.descripcion_usuario
FROM usuario 


INNER JOIN tipo_usuario ON tipo_usuario.id_tipousuario = usuario.id_tipousuario


WHERE usuario.RUT = idrut$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `alcance`
--

CREATE TABLE `alcance` (
  `id_alcance` int(11) NOT NULL,
  `descripcion_alcance` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `alcance`
--

INSERT INTO `alcance` (`id_alcance`, `descripcion_alcance`) VALUES
(0, 'Sin información'),
(1, 'REGIONAL'),
(2, 'COMUNAL'),
(3, 'INSTITUCIONAL'),
(4, 'EMPRESARIAL'),
(5, 'PARTICULAR');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ambiente`
--

CREATE TABLE `ambiente` (
  `id_ambiente` int(11) NOT NULL,
  `nombre_ambiente` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `ambiente`
--

INSERT INTO `ambiente` (`id_ambiente`, `nombre_ambiente`) VALUES
(0, 'Sin información'),
(1, 'DESARROLLO'),
(2, 'TESTING'),
(3, 'PRODUCCION');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `area`
--

CREATE TABLE `area` (
  `id_area` int(11) NOT NULL,
  `nombre_area` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `area`
--

INSERT INTO `area` (`id_area`, `nombre_area`) VALUES
(0, 'Sin información'),
(1, 'INFORMATICA'),
(2, 'RECURSOS HUMBANOS'),
(3, 'CONTRATOS'),
(4, 'SOPORTE');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `control_acceso`
--

CREATE TABLE `control_acceso` (
  `id_control` int(11) NOT NULL,
  `tipo_control` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `control_acceso`
--

INSERT INTO `control_acceso` (`id_control`, `tipo_control`) VALUES
(0, 'Sin información'),
(1, 'FACIAL'),
(2, 'HUELLA DACTILAR'),
(3, 'CREDENCIALES LABORALES'),
(4, 'NUMERO IDENTIFICACION (RUT)');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dueño_datos`
--

CREATE TABLE `dueño_datos` (
  `id_dataow` int(11) NOT NULL,
  `nombre_origen` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `dueño_datos`
--

INSERT INTO `dueño_datos` (`id_dataow`, `nombre_origen`) VALUES
(0, 'Sin información'),
(1, 'Ministerio de educación'),
(2, 'Ministerio de vivienda y urbanismo'),
(3, 'Ministerio de agronomia'),
(4, 'Ministerio de salud pública');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `entidad_externa`
--

CREATE TABLE `entidad_externa` (
  `id_codigo` int(11) NOT NULL,
  `nombre_institucion` varchar(100) NOT NULL,
  `descripcion_institucion` varchar(1000) NOT NULL,
  `URLentidad` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `entidad_externa`
--

INSERT INTO `entidad_externa` (`id_codigo`, `nombre_institucion`, `descripcion_institucion`, `URLentidad`) VALUES
(0, 'Sin información', '', ''),
(1, 'MINISTERIO DE DESARROLLO SOCIAL', 'El Ministerio de Desarrollo Social tiene por objetivo contribuir al diseño y aplicación de políticas, planes y programas, especialmente aquellos destinados a erradicar la pobreza y brindar protección social a las personas pertenecientes a grupos vulnerables, promoviendo la movilidad e integración social.', 'desarrollosocialyfamiliar.gob.cl'),
(2, 'SERVICIO IMPUESTOS INTERNOS', '¿Qué es Plataforma SII?\r\nLa herramienta permite al contribuyente personalizar la navegación y acceder directamente a los formularios que le corresponde enviar, de acuerdo a sus características, entre otras funcionalidades.', ' sii.cl'),
(3, 'REGISTRO CIVIL', 'registro civil de chile para las personas y familias', 'registrocivil.gob.cl'),
(4, 'MINISTERIO EDUCACION', 'ministerio de educacion para los y las estudiantes de todo chile', 'ministerioeducacion.cl');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estados`
--

CREATE TABLE `estados` (
  `id_estado` int(11) NOT NULL,
  `descripcion_estado` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `estados`
--

INSERT INTO `estados` (`id_estado`, `descripcion_estado`) VALUES
(0, 'Sin información'),
(1, 'Activo'),
(2, 'Rechazado'),
(3, 'Pendiente'),
(4, 'Negociando'),
(5, 'Iniciado'),
(6, 'Cancelado'),
(7, 'Dado de baja');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `integraciones`
--

CREATE TABLE `integraciones` (
  `id_integracion` int(11) NOT NULL,
  `id_sistemaorigen` int(11) NOT NULL,
  `id_sistemadestino` int(11) NOT NULL,
  `id_sistemadestino2` int(11) NOT NULL,
  `id_moduloorigen` int(11) NOT NULL,
  `id_modulodestino` int(11) NOT NULL,
  `id_modulodestino2` int(11) NOT NULL,
  `id_tipointegracion` int(11) NOT NULL,
  `id_entidad_ext` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `integraciones`
--

INSERT INTO `integraciones` (`id_integracion`, `id_sistemaorigen`, `id_sistemadestino`, `id_sistemadestino2`, `id_moduloorigen`, `id_modulodestino`, `id_modulodestino2`, `id_tipointegracion`, `id_entidad_ext`) VALUES
(0, 0, 0, 0, 0, 0, 0, 0, 0),
(1, 1, 0, 0, 0, 14, 0, 1, 0),
(2, 0, 1, 0, 0, 10, 0, 3, 0),
(3, 0, 3, 0, 14, 0, 0, 1, 0),
(4, 1, 0, 0, 0, 12, 0, 1, 0),
(5, 0, 0, 0, 0, 7, 8, 3, 0),
(6, 1, 3, 0, 0, 0, 0, 1, 0),
(7, 7, 10, 0, 0, 0, 0, 2, 0),
(8, 1, 6, 0, 0, 0, 0, 2, 0),
(9, 1, 4, 0, 0, 0, 0, 1, 0),
(10, 4, 5, 0, 0, 0, 0, 1, 0),
(11, 7, 5, 0, 0, 0, 0, 1, 0),
(12, 7, 4, 0, 0, 0, 0, 1, 0),
(13, 8, 1, 0, 0, 0, 0, 1, 0),
(14, 0, 3, 10, 0, 8, 0, 3, 0),
(15, 0, 10, 0, 9, 7, 0, 2, 0),
(16, 9, 0, 0, 0, 7, 0, 1, 0),
(17, 7, 11, 0, 0, 0, 0, 1, 0),
(18, 11, 5, 0, 0, 0, 0, 1, 0),
(19, 5, 2, 0, 0, 0, 0, 2, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `jefes_proyectos`
--

CREATE TABLE `jefes_proyectos` (
  `id_jefe` int(11) NOT NULL,
  `nombre_jefe` varchar(100) NOT NULL,
  `rut` varchar(20) NOT NULL,
  `correo` varchar(30) NOT NULL,
  `experiencia` varchar(50) NOT NULL,
  `titulo` varchar(100) NOT NULL,
  `descripcion` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `jefes_proyectos`
--

INSERT INTO `jefes_proyectos` (`id_jefe`, `nombre_jefe`, `rut`, `correo`, `experiencia`, `titulo`, `descripcion`) VALUES
(0, 'Sin información', '0', '', '', '', ''),
(1, 'Rodrigo Álvarez', '19551935', '', '1 años y  4 días como desarrollador. Un proyecto d', 'Ingeniero civil en Computación mención Informática', 'Texto de prueba para la visualización de información '),
(2, 'Yelka Ruiz', '15667843', '', 'Ingeniera del MINVU del gobierno de CHILE', 'Ingeniero civil en Computación mención Informática', 'Descripcion de pruebaa'),
(3, 'Paola Riquelme', '19123784', '', '4 años', 'Licenciada en literatura inglesa', 'prueba'),
(4, 'Jeniffer Riquelme', '123456789', '', '5 años y medio', 'Gastronomía y magister en asedora de uñas', 'prueba');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modulos`
--

CREATE TABLE `modulos` (
  `id_modulo` int(11) NOT NULL,
  `nombre_modulo` varchar(100) NOT NULL,
  `descripcion_modulo` varchar(1000) NOT NULL,
  `id_ambiente` int(11) NOT NULL,
  `id_estado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `modulos`
--

INSERT INTO `modulos` (`id_modulo`, `nombre_modulo`, `descripcion_modulo`, `id_ambiente`, `id_estado`) VALUES
(0, 'Sin información', '', 0, 0),
(1, 'Módulos Existencia/Activos Fijo', 'modulo de existencias y conteo de activos fijos', 2, 5),
(2, 'Gestor Documental', 'Modulo para la gestion de documentos', 3, 1),
(3, 'Global 3000 financiero/contable', 'Modulo para las finanzas', 1, 1),
(4, 'Intranet Comunicaciones', 'Modulo social para las telecomunicaciones internas', 3, 3),
(5, 'Consulta Cartera', 'Modulo especialidaso para consultar la cartera de sistemas', 1, 1),
(6, 'Calificacion Energética', 'Modulo para jerarquizar la energia', 3, 1),
(7, 'Portal Web MINVU', 'Modulo de difusion de información para los trabajadores del ministerio', 1, 2),
(8, 'Portal Ciudadano', 'Modulo de difusion de información para la ciudadania', 1, 1),
(9, 'Geo Portal MINVU', 'portal para los geos', 3, 4),
(10, 'Postulación en linea', 'Módulo para la postulacion en linea  alos beneficios', 3, 2),
(11, 'Portal Tu Vivienda', 'Portal o modulo para las postulantes a viviendas', 2, 5),
(12, 'Observatorio Habitacional (Sitio Web)', 'Modulo para el seguimiento de el estado de las postulaciones', 2, 3),
(13, 'Observatorio Urbano', 'Modulo para el observatorio de las sociedades', 2, 5),
(14, 'Cartolas DPH', ' Modulo para la consulta de las cartolas de vida de las personas', 1, 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `region`
--

CREATE TABLE `region` (
  `id_region` int(11) NOT NULL,
  `nombre_region` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `region`
--

INSERT INTO `region` (`id_region`, `nombre_region`) VALUES
(0, 'Sin información'),
(1, 'REGION METROPOLITANA'),
(2, 'REGION DEL BIO BIO '),
(3, 'REGION ATACAMA'),
(4, 'REGION ANTOFAGASTA');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reporte`
--

CREATE TABLE `reporte` (
  `id_reporte` int(11) NOT NULL,
  `id_sistema` int(11) NOT NULL,
  `fecha_solicitud` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sistemas`
--

CREATE TABLE `sistemas` (
  `id_sistema` int(11) NOT NULL,
  `nombre_sistema` varchar(100) NOT NULL,
  `descripcion_sistema` varchar(1000) NOT NULL,
  `id_ambiente` int(11) NOT NULL,
  `id_estado` int(11) NOT NULL,
  `fecha_desarrollo` date NOT NULL,
  `URLinicio` varchar(100) NOT NULL,
  `URLdatos` varchar(100) NOT NULL,
  `costo_sistema` int(11) NOT NULL,
  `decreto_afecto` varchar(100) NOT NULL,
  `id_area` int(11) NOT NULL,
  `id_data` int(11) NOT NULL,
  `id_tecnologia` int(11) NOT NULL,
  `id_tiposistema` int(11) NOT NULL,
  `id_region` int(11) NOT NULL,
  `id_jefeproyecto` int(11) NOT NULL,
  `id_control` int(11) NOT NULL,
  `id_legacy` int(11) NOT NULL,
  `id_alcance` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `sistemas`
--

INSERT INTO `sistemas` (`id_sistema`, `nombre_sistema`, `descripcion_sistema`, `id_ambiente`, `id_estado`, `fecha_desarrollo`, `URLinicio`, `URLdatos`, `costo_sistema`, `decreto_afecto`, `id_area`, `id_data`, `id_tecnologia`, `id_tiposistema`, `id_region`, `id_jefeproyecto`, `id_control`, `id_legacy`, `id_alcance`) VALUES
(0, 'Sin información', '', 0, 0, '2014-11-11', '', '', 0, '', 0, 0, 0, 0, 0, 0, 0, 0, 0),
(1, 'RUKAN', 'Es un sistema compuesto por diferentes desarrollos que componen el sistema Rukan por completo. Cada desarrollo tiene una funcionalidad marcada en Rukan, por lo que este tiene el objetivo de mantener integrados los sistemas y que estos entreguen información referente a los subsidios y que optimicen la gestión para el acceso a la vivienda de los postulantes. Este sistema a estudiar se compone de diferentes sistemas que entregan información vital al negocio del Ministerio de Vivienda y Urbanismo.', 1, 1, '1997-12-12', 'RUKAN.minvu.cl', '197.4.5.76', 15000, 'DS1', 1, 2, 1, 1, 1, 2, 4, 1, 3),
(2, 'UMBRAL', 'Es un módulo de consulta de personas que entrega información que es utilizada por las entidades para conformar los grupos. Es parte del sistema informático Rukan, como parte de unos de sus desarrollos. Cuenta con dos desarrollos más los cuales tienen como objetivo en general la entrega de la información de los postulantes, para habilitar los permisos de los usuarios, crear los llamados y habilitar procedimientos de inscripción de socios.', 3, 1, '1997-12-12', 'UMBRAL.MINVU.CL', 'umbral.minvu.cl', 500000, '176.5.7.123', 0, 3, 5, 2, 3, 1, 1, 1, 1),
(3, 'Sistema SIAC', 'Se consolida como plataforma de atención ciudadana y gestiona todas las solicitudes recibidas en los distintos canales de atención. Se complementa además con la implementación de firma electrónica avanzada, en las notificaciones de atención SIAC que son entregadas al ciudadano.', 1, 1, '1997-12-12', 'siac.minvu.cl', '123.4.76.13', 6000000, 'A1, A7, A4', 4, 2, 1, 3, 2, 4, 2, 1, 0),
(4, 'Sistema Asistencia Técnica', 'El objetivo de este sistema es hacer el seguimiento y control de pagos de asistencia técnica (AT). Existe un subsidio de AT y es el que acompaña a la construcción de los proyectos habitacionales, por tanto, sólo opera para postulaciones colectivas. Todo lo que ocurre antes de que se ejecute el pago de un subsidio, sucede en SNAT .\r\n\r\n', 1, 3, '1997-12-12', 'snat.minvu.cl', '197.4.5.76', 5678999, 'DS1', 3, 0, 3, 1, 4, 3, 1, 1, 5),
(5, 'Sistema Pago de Subsidios', 'Corresponde al sistema principal utilizado para el pago de subsidios y está compuesto por un conjunto de subsistemas que trabajan bajo una misma interfaz, asociados a los distintos programas de subsidios.', 3, 1, '1997-12-12', 'sps.minvu.cl', '123.4.76.13', 5666000, 'gf2', 2, 1, 6, 1, 2, 2, 3, 1, 3),
(6, 'Sistema Avance de Obras MUNIN', 'Es una herramienta web cuyo principal objetivo es el registro de información, desde la obra, en terreno, para ello se ha diseñado e implementado un sistema lo suficientemente flexible y adaptable a todos los dispositivos móviles, sin perder la facilidad de uso y accesibilidad.', 2, 5, '1997-12-12', 'munin.minvu.cl', '193.5.2.34', 100000, 'AS3', 3, 3, 4, 4, 3, 1, 3, 1, 1),
(7, 'ERP Doctos. Garantia.', 'Sistema ERP de documentos de garantias', 2, 2, '1997-12-12', 'erp.minvo1.cl', '197.4.5.76', 15000, '176.5.7.123', 3, 3, 1, 2, 4, 2, 4, 1, 4),
(8, 'Sistemas Índices del Sector', 'sistema que muestra los indicadores de los desempeños de las comunidades.', 1, 2, '1997-12-12', 'SIDEC.minvu.cl', '197.4.5.76', 15000, 'SDAA', 1, 2, 3, 2, 1, 3, 2, 2, 1),
(9, 'Sistema RRHH.', 'sistema para gestionar los recursos humanos del minissterio', 2, 6, '1997-12-12', 'RRHH.mincvul.cl', '123.4.76.13', 0, 'DS1', 3, 1, 1, 0, 1, 3, 1, 1, 2),
(10, 'Sistema Reserva de Horas', 'Sistema para el reserva de hora de los postulantes de los subsidios', 1, 1, '1997-12-12', 'resrvahoras.minvu.cl', '123.4.76.13', 15000, 'DS1', 1, 0, 3, 2, 2, 1, 2, 2, 4),
(11, 'Sistema Registros Técnicos', 'sistema del registro de las asistencias técnicas', 2, 1, '1997-12-12', 'srt.minvu.cl', '188.34.89.5', 456700000, 'AS3', 3, 1, 2, 2, 4, 2, 2, 0, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tecnologia`
--

CREATE TABLE `tecnologia` (
  `id_tecnologia` int(11) NOT NULL,
  `nombre_tecnologia` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tecnologia`
--

INSERT INTO `tecnologia` (`id_tecnologia`, `nombre_tecnologia`) VALUES
(0, 'Sin información'),
(1, 'ASP.NET 4.5'),
(2, 'ASP.NET 4.5.2'),
(3, 'ANGULAR'),
(4, 'Django'),
(5, 'Laravel'),
(6, 'ReactNative TypeS');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_integracion`
--

CREATE TABLE `tipo_integracion` (
  `id_tipointeg` int(11) NOT NULL,
  `tipo_integracion` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tipo_integracion`
--

INSERT INTO `tipo_integracion` (`id_tipointeg`, `tipo_integracion`) VALUES
(0, 'Sin información'),
(1, 'PUNTO FLECHA'),
(2, 'DE LINEA'),
(3, 'BASADA EN API');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_legacy`
--

CREATE TABLE `tipo_legacy` (
  `id_legacy` int(11) NOT NULL,
  `descripcion_legacy` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tipo_legacy`
--

INSERT INTO `tipo_legacy` (`id_legacy`, `descripcion_legacy`) VALUES
(0, 'Sin información'),
(1, 'SI'),
(2, 'NO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_sistema`
--

CREATE TABLE `tipo_sistema` (
  `id_tiposistema` int(11) NOT NULL,
  `descripcion_tipo` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tipo_sistema`
--

INSERT INTO `tipo_sistema` (`id_tiposistema`, `descripcion_tipo`) VALUES
(0, 'Sin información'),
(1, 'INFORMACIÓN'),
(2, 'GESTION Y CONTROL'),
(3, 'SEGUIMIENTO'),
(4, 'DE PROCESOS');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_usuario`
--

CREATE TABLE `tipo_usuario` (
  `id_tipousuario` int(11) NOT NULL,
  `descripcion_usuario` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tipo_usuario`
--

INSERT INTO `tipo_usuario` (`id_tipousuario`, `descripcion_usuario`) VALUES
(0, 'Sin información'),
(1, 'Admin'),
(2, 'Visualizador'),
(3, 'Informático');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `idUsuario` int(11) NOT NULL,
  `RUT` int(11) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `Password` varchar(15) NOT NULL,
  `Nombre` varchar(20) NOT NULL,
  `id_tipousuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`idUsuario`, `RUT`, `correo`, `Password`, `Nombre`, `id_tipousuario`) VALUES
(0, 19112754, '0', '1234', 'Paola Riquelme', 1),
(1, 19551935, '0', '123', 'Rodrigo Alvarez', 1),
(2, 19551359, '0', '123', 'Usuario Prueba', 2),
(3, 20001838, '0', '123', 'Belen Espinoza', 3),
(4, 20653748, '0', '123', 'Jeniffer Riquelme', 0),
(5, 20146458, '0', '123', 'Darling Garcia', 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `alcance`
--
ALTER TABLE `alcance`
  ADD PRIMARY KEY (`id_alcance`);

--
-- Indices de la tabla `ambiente`
--
ALTER TABLE `ambiente`
  ADD PRIMARY KEY (`id_ambiente`);

--
-- Indices de la tabla `area`
--
ALTER TABLE `area`
  ADD PRIMARY KEY (`id_area`);

--
-- Indices de la tabla `control_acceso`
--
ALTER TABLE `control_acceso`
  ADD PRIMARY KEY (`id_control`);

--
-- Indices de la tabla `dueño_datos`
--
ALTER TABLE `dueño_datos`
  ADD PRIMARY KEY (`id_dataow`);

--
-- Indices de la tabla `entidad_externa`
--
ALTER TABLE `entidad_externa`
  ADD PRIMARY KEY (`id_codigo`);

--
-- Indices de la tabla `estados`
--
ALTER TABLE `estados`
  ADD PRIMARY KEY (`id_estado`);

--
-- Indices de la tabla `integraciones`
--
ALTER TABLE `integraciones`
  ADD PRIMARY KEY (`id_integracion`),
  ADD KEY `id_sistema` (`id_sistemaorigen`,`id_sistemadestino`,`id_entidad_ext`,`id_tipointegracion`),
  ADD KEY `id_sistemaorigen` (`id_sistemaorigen`,`id_sistemadestino`),
  ADD KEY `id_sistemadestino` (`id_sistemadestino`),
  ADD KEY `id_entidad_ext` (`id_entidad_ext`),
  ADD KEY `id_tipointegracion` (`id_tipointegracion`),
  ADD KEY `id_modulo` (`id_moduloorigen`),
  ADD KEY `id_modulodestino` (`id_modulodestino`),
  ADD KEY `id_sistemadestino2` (`id_sistemadestino2`),
  ADD KEY `id_modulodestino2` (`id_modulodestino2`);

--
-- Indices de la tabla `jefes_proyectos`
--
ALTER TABLE `jefes_proyectos`
  ADD PRIMARY KEY (`id_jefe`);

--
-- Indices de la tabla `modulos`
--
ALTER TABLE `modulos`
  ADD PRIMARY KEY (`id_modulo`),
  ADD KEY `id_ambiente` (`id_ambiente`),
  ADD KEY `id_estado` (`id_estado`);

--
-- Indices de la tabla `region`
--
ALTER TABLE `region`
  ADD PRIMARY KEY (`id_region`);

--
-- Indices de la tabla `reporte`
--
ALTER TABLE `reporte`
  ADD PRIMARY KEY (`id_reporte`),
  ADD KEY `id_sistema` (`id_sistema`);

--
-- Indices de la tabla `sistemas`
--
ALTER TABLE `sistemas`
  ADD PRIMARY KEY (`id_sistema`),
  ADD KEY `id_ambiente` (`id_ambiente`),
  ADD KEY `id_estado` (`id_estado`),
  ADD KEY `id_area` (`id_area`),
  ADD KEY `id_data` (`id_data`),
  ADD KEY `id_tecnologia` (`id_tecnologia`),
  ADD KEY `id_tiposistema` (`id_tiposistema`),
  ADD KEY `id_alcance` (`id_alcance`),
  ADD KEY `id_region` (`id_region`),
  ADD KEY `id_jefeproyecto` (`id_jefeproyecto`),
  ADD KEY `id_control` (`id_control`),
  ADD KEY `id_legacy` (`id_legacy`);

--
-- Indices de la tabla `tecnologia`
--
ALTER TABLE `tecnologia`
  ADD PRIMARY KEY (`id_tecnologia`);

--
-- Indices de la tabla `tipo_integracion`
--
ALTER TABLE `tipo_integracion`
  ADD PRIMARY KEY (`id_tipointeg`);

--
-- Indices de la tabla `tipo_legacy`
--
ALTER TABLE `tipo_legacy`
  ADD PRIMARY KEY (`id_legacy`);

--
-- Indices de la tabla `tipo_sistema`
--
ALTER TABLE `tipo_sistema`
  ADD PRIMARY KEY (`id_tiposistema`);

--
-- Indices de la tabla `tipo_usuario`
--
ALTER TABLE `tipo_usuario`
  ADD PRIMARY KEY (`id_tipousuario`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`idUsuario`),
  ADD UNIQUE KEY `RUT` (`RUT`),
  ADD KEY `id_tipousuario` (`id_tipousuario`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `integraciones`
--
ALTER TABLE `integraciones`
  ADD CONSTRAINT `integraciones_ibfk_1` FOREIGN KEY (`id_sistemaorigen`) REFERENCES `sistemas` (`id_sistema`),
  ADD CONSTRAINT `integraciones_ibfk_2` FOREIGN KEY (`id_sistemadestino`) REFERENCES `sistemas` (`id_sistema`),
  ADD CONSTRAINT `integraciones_ibfk_3` FOREIGN KEY (`id_entidad_ext`) REFERENCES `entidad_externa` (`id_codigo`),
  ADD CONSTRAINT `integraciones_ibfk_4` FOREIGN KEY (`id_tipointegracion`) REFERENCES `tipo_integracion` (`id_tipointeg`),
  ADD CONSTRAINT `integraciones_ibfk_5` FOREIGN KEY (`id_moduloorigen`) REFERENCES `modulos` (`id_modulo`),
  ADD CONSTRAINT `integraciones_ibfk_6` FOREIGN KEY (`id_modulodestino`) REFERENCES `modulos` (`id_modulo`),
  ADD CONSTRAINT `integraciones_ibfk_7` FOREIGN KEY (`id_sistemadestino2`) REFERENCES `sistemas` (`id_sistema`);

--
-- Filtros para la tabla `modulos`
--
ALTER TABLE `modulos`
  ADD CONSTRAINT `modulos_ibfk_1` FOREIGN KEY (`id_ambiente`) REFERENCES `ambiente` (`id_ambiente`),
  ADD CONSTRAINT `modulos_ibfk_2` FOREIGN KEY (`id_estado`) REFERENCES `estados` (`id_estado`);

--
-- Filtros para la tabla `reporte`
--
ALTER TABLE `reporte`
  ADD CONSTRAINT `reporte_ibfk_1` FOREIGN KEY (`id_reporte`) REFERENCES `sistemas` (`id_sistema`);

--
-- Filtros para la tabla `sistemas`
--
ALTER TABLE `sistemas`
  ADD CONSTRAINT `sistemas_ibfk_1` FOREIGN KEY (`id_ambiente`) REFERENCES `ambiente` (`id_ambiente`),
  ADD CONSTRAINT `sistemas_ibfk_10` FOREIGN KEY (`id_jefeproyecto`) REFERENCES `jefes_proyectos` (`id_jefe`),
  ADD CONSTRAINT `sistemas_ibfk_11` FOREIGN KEY (`id_control`) REFERENCES `control_acceso` (`id_control`),
  ADD CONSTRAINT `sistemas_ibfk_12` FOREIGN KEY (`id_legacy`) REFERENCES `tipo_legacy` (`id_legacy`),
  ADD CONSTRAINT `sistemas_ibfk_2` FOREIGN KEY (`id_estado`) REFERENCES `estados` (`id_estado`),
  ADD CONSTRAINT `sistemas_ibfk_3` FOREIGN KEY (`id_area`) REFERENCES `area` (`id_area`),
  ADD CONSTRAINT `sistemas_ibfk_4` FOREIGN KEY (`id_data`) REFERENCES `dueño_datos` (`id_dataow`),
  ADD CONSTRAINT `sistemas_ibfk_5` FOREIGN KEY (`id_tecnologia`) REFERENCES `tecnologia` (`id_tecnologia`),
  ADD CONSTRAINT `sistemas_ibfk_6` FOREIGN KEY (`id_tiposistema`) REFERENCES `tipo_sistema` (`id_tiposistema`),
  ADD CONSTRAINT `sistemas_ibfk_7` FOREIGN KEY (`id_alcance`) REFERENCES `alcance` (`id_alcance`),
  ADD CONSTRAINT `sistemas_ibfk_9` FOREIGN KEY (`id_region`) REFERENCES `region` (`id_region`);

--
-- Filtros para la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`id_tipousuario`) REFERENCES `tipo_usuario` (`id_tipousuario`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
