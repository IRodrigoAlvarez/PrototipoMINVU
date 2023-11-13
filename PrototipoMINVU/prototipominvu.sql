-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 13-11-2023 a las 23:49:03
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

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `idUsuario` int(11) NOT NULL,
  `RUT` int(11) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `Password` varchar(15) NOT NULL,
  `Nombre` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`idUsuario`, `RUT`, `correo`, `Password`, `Nombre`) VALUES
(0, 19112754, '0', '1234', 'Paola Riquelme'),
(1, 19551935, '0', '123', 'Rodrigo Alvarez'),
(2, 19551359, '0', '123', 'Usuario Prueba'),
(3, 20001838, '0', '12345', 'Belen Espinoza'),
(4, 20653748, '0', '123', 'Jeniffer Riquelme'),
(5, 20146458, '0', '123', 'Darling Garcia'),
(6, 11111111, 'correo@equisde.cl', '123', 'alejo y valentina');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`idUsuario`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
