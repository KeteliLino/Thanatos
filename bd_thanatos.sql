-- phpMyAdmin SQL Dump
-- version 4.0.4.2
-- http://www.phpmyadmin.net
--
-- Máquina: localhost
-- Data de Criação: 26-Nov-2025 às 02:00
-- Versão do servidor: 5.6.13
-- versão do PHP: 5.4.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de Dados: `bd_thanatos`
--
CREATE DATABASE IF NOT EXISTS `bd_thanatos` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE `bd_thanatos`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_cremacoes`
--

CREATE TABLE IF NOT EXISTS `tb_cremacoes` (
  `idCremacao` int(11) NOT NULL AUTO_INCREMENT,
  `horaCremacao` time NOT NULL,
  `dataCremacao` date NOT NULL,
  `idSala` int(11) DEFAULT NULL,
  `idFalecido` int(11) DEFAULT NULL,
  PRIMARY KEY (`idCremacao`),
  KEY `idSala` (`idSala`),
  KEY `idFalecido` (`idFalecido`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=16 ;

--
-- Extraindo dados da tabela `tb_cremacoes`
--

INSERT INTO `tb_cremacoes` (`idCremacao`, `horaCremacao`, `dataCremacao`, `idSala`, `idFalecido`) VALUES
(1, '10:00:00', '2025-11-18', 1, 2),
(2, '10:00:00', '2025-11-19', 2, 4),
(3, '10:00:00', '2025-11-20', 3, 6),
(4, '10:00:00', '2025-11-21', 1, 8),
(5, '10:00:00', '2025-11-22', 2, 10),
(6, '10:00:00', '2025-11-23', 3, 11),
(7, '10:00:00', '2025-11-24', 1, 12),
(8, '10:00:00', '2025-11-25', 2, 13),
(9, '10:00:00', '2025-11-26', 3, 14),
(10, '10:00:00', '2025-11-27', 1, 15),
(11, '10:00:00', '2025-11-28', 2, 16),
(12, '10:00:00', '2025-11-29', 3, 17),
(13, '10:00:00', '2025-11-30', 1, 18),
(14, '10:00:00', '2025-12-01', 2, 19),
(15, '10:00:00', '2025-12-02', 3, 20);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_falecidos`
--

CREATE TABLE IF NOT EXISTS `tb_falecidos` (
  `idFalecido` int(11) NOT NULL AUTO_INCREMENT,
  `nomeFalecido` varchar(150) COLLATE utf8_unicode_ci NOT NULL,
  `idStatus` int(11) NOT NULL,
  PRIMARY KEY (`idFalecido`),
  KEY `idStatus` (`idStatus`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=36 ;

--
-- Extraindo dados da tabela `tb_falecidos`
--

INSERT INTO `tb_falecidos` (`idFalecido`, `nomeFalecido`, `idStatus`) VALUES
(1, 'Antônio Ribeiro da Silva', 6),
(2, 'Maria Aparecida dos Santos', 7),
(3, 'José Carlos Mendonça', 6),
(4, 'Francisca Lima Barros', 7),
(5, 'Ricardo Alves Monteiro', 6),
(6, 'Claudete Ferreira Moura', 7),
(7, 'Luiz Fernando Pereira', 6),
(8, 'Sueli Tavares Gonçalves', 7),
(9, 'Paulo Henrique Bastos', 6),
(10, 'Joana Matilde de Souza', 7),
(11, 'Helena Duarte Moreira', 7),
(12, 'Marcos Vinícius Cardoso', 7),
(13, 'Ângela Cristina Falcão', 7),
(14, 'Roberto Nogueira Campos', 7),
(15, 'Beatriz Martins Oliveira', 7),
(16, 'Sandro Luiz Peixoto', 7),
(17, 'Daniela Moura Peçanha', 7),
(18, 'Henrique Batista da Paz', 7),
(19, 'Célia Regina Barbosa', 7),
(20, 'Fábio Augusto Trindade', 7),
(21, 'João Marcos Ferreira', 6),
(22, 'Patrícia Gomes Teles', 6),
(23, 'Eduardo Ramos Montezano', 6),
(24, 'Luciana Ribeiro Braga', 6),
(25, 'Alberto Silva Miranda', 6),
(26, 'Gabriela Santos Pacheco', 6),
(27, 'Miguel Freitas Alvarenga', 6),
(28, 'Elisângela Torres Mourão', 6),
(29, 'Ronaldo César Azevedo', 6),
(30, 'Juliana Oliveira Rocha', 6),
(31, 'Bruno Almeida Correia', 6),
(32, 'Tatiane Moura Ribeiro', 6),
(33, 'Maurício Ferreira Lopes', 6),
(34, 'Denise Cardoso Prates', 6),
(35, 'Rogério Matias Silveira', 6);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_funcionarios`
--

CREATE TABLE IF NOT EXISTS `tb_funcionarios` (
  `cpfFuncionario` char(11) COLLATE utf8_unicode_ci NOT NULL,
  `loginFuncionario` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `senhaFuncionario` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `nomeFuncionario` varchar(150) COLLATE utf8_unicode_ci NOT NULL,
  `cepFuncionario` char(8) COLLATE utf8_unicode_ci NOT NULL,
  `idStatus` int(11) DEFAULT NULL,
  `idSetor` int(11) DEFAULT NULL,
  PRIMARY KEY (`cpfFuncionario`),
  KEY `idStatus` (`idStatus`),
  KEY `idSetor` (`idSetor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Extraindo dados da tabela `tb_funcionarios`
--

INSERT INTO `tb_funcionarios` (`cpfFuncionario`, `loginFuncionario`, `senhaFuncionario`, `nomeFuncionario`, `cepFuncionario`, `idStatus`, `idSetor`) VALUES
('12345678901', 'marcos.almeida', '123', 'Marcos Almeida', '09810000', 1, 1),
('23456789012', 'carla.rodrigues', '123', 'Carla Rodrigues', '09790000', 1, 2),
('34567890123', 'joao.pereira', '123', 'João Pereira', '04476240', 1, 3),
('45678901234', 'clarice.cobain', '123', 'Clarice Cobain', '04246002', 1, 4);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_jazigos`
--

CREATE TABLE IF NOT EXISTS `tb_jazigos` (
  `idJazigo` int(11) NOT NULL AUTO_INCREMENT,
  `quadranteJazigo` int(11) NOT NULL,
  `linhaJazigo` int(11) NOT NULL,
  `colunaJazigo` char(1) COLLATE utf8_unicode_ci NOT NULL,
  `idFalecido` int(11) DEFAULT NULL,
  PRIMARY KEY (`idJazigo`),
  KEY `idFalecido` (`idFalecido`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=101 ;

--
-- Extraindo dados da tabela `tb_jazigos`
--

INSERT INTO `tb_jazigos` (`idJazigo`, `quadranteJazigo`, `linhaJazigo`, `colunaJazigo`, `idFalecido`) VALUES
(1, 1, 1, 'A', 1),
(2, 1, 1, 'B', 3),
(3, 1, 1, 'C', 5),
(4, 1, 1, 'D', 7),
(5, 1, 1, 'E', 9),
(6, 1, 2, 'A', 21),
(7, 1, 2, 'B', 22),
(8, 1, 2, 'C', 23),
(9, 1, 2, 'D', 24),
(10, 1, 2, 'E', 25),
(11, 1, 3, 'A', 26),
(12, 1, 3, 'B', 27),
(13, 1, 3, 'C', 28),
(14, 1, 3, 'D', 29),
(15, 1, 3, 'E', 30),
(16, 1, 4, 'A', 31),
(17, 1, 4, 'B', 32),
(18, 1, 4, 'C', 33),
(19, 1, 4, 'D', 34),
(20, 1, 4, 'E', 35),
(21, 1, 5, 'A', NULL),
(22, 1, 5, 'B', NULL),
(23, 1, 5, 'C', NULL),
(24, 1, 5, 'D', NULL),
(25, 1, 5, 'E', NULL),
(26, 2, 6, 'A', NULL),
(27, 2, 6, 'B', NULL),
(28, 2, 6, 'C', NULL),
(29, 2, 6, 'D', NULL),
(30, 2, 6, 'E', NULL),
(31, 2, 7, 'A', NULL),
(32, 2, 7, 'B', NULL),
(33, 2, 7, 'C', NULL),
(34, 2, 7, 'D', NULL),
(35, 2, 7, 'E', NULL),
(36, 2, 8, 'A', NULL),
(37, 2, 8, 'B', NULL),
(38, 2, 8, 'C', NULL),
(39, 2, 8, 'D', NULL),
(40, 2, 8, 'E', NULL),
(41, 2, 9, 'A', NULL),
(42, 2, 9, 'B', NULL),
(43, 2, 9, 'C', NULL),
(44, 2, 9, 'D', NULL),
(45, 2, 9, 'E', NULL),
(46, 2, 10, 'A', NULL),
(47, 2, 10, 'B', NULL),
(48, 2, 10, 'C', NULL),
(49, 2, 10, 'D', NULL),
(50, 2, 10, 'E', NULL),
(51, 3, 11, 'A', NULL),
(52, 3, 11, 'B', NULL),
(53, 3, 11, 'C', NULL),
(54, 3, 11, 'D', NULL),
(55, 3, 11, 'E', NULL),
(56, 3, 12, 'A', NULL),
(57, 3, 12, 'B', NULL),
(58, 3, 12, 'C', NULL),
(59, 3, 12, 'D', NULL),
(60, 3, 12, 'E', NULL),
(61, 3, 13, 'A', NULL),
(62, 3, 13, 'B', NULL),
(63, 3, 13, 'C', NULL),
(64, 3, 13, 'D', NULL),
(65, 3, 13, 'E', NULL),
(66, 3, 14, 'A', NULL),
(67, 3, 14, 'B', NULL),
(68, 3, 14, 'C', NULL),
(69, 3, 14, 'D', NULL),
(70, 3, 14, 'E', NULL),
(71, 3, 15, 'A', NULL),
(72, 3, 15, 'B', NULL),
(73, 3, 15, 'C', NULL),
(74, 3, 15, 'D', NULL),
(75, 3, 15, 'E', NULL),
(76, 4, 16, 'A', NULL),
(77, 4, 16, 'B', NULL),
(78, 4, 16, 'C', NULL),
(79, 4, 16, 'D', NULL),
(80, 4, 16, 'E', NULL),
(81, 4, 17, 'A', NULL),
(82, 4, 17, 'B', NULL),
(83, 4, 17, 'C', NULL),
(84, 4, 17, 'D', NULL),
(85, 4, 17, 'E', NULL),
(86, 4, 18, 'A', NULL),
(87, 4, 18, 'B', NULL),
(88, 4, 18, 'C', NULL),
(89, 4, 18, 'D', NULL),
(90, 4, 18, 'E', NULL),
(91, 4, 19, 'A', NULL),
(92, 4, 19, 'B', NULL),
(93, 4, 19, 'C', NULL),
(94, 4, 19, 'D', NULL),
(95, 4, 19, 'E', NULL),
(96, 4, 20, 'A', NULL),
(97, 4, 20, 'B', NULL),
(98, 4, 20, 'C', NULL),
(99, 4, 20, 'D', NULL),
(100, 4, 20, 'E', NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_orcamentos`
--

CREATE TABLE IF NOT EXISTS `tb_orcamentos` (
  `idOrcamento` int(11) NOT NULL AUTO_INCREMENT,
  `descricaoOrcamento` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `valorOrcamento` decimal(10,2) NOT NULL,
  `dataOrcamento` date DEFAULT NULL,
  `idFalecido` int(11) DEFAULT NULL,
  `idStatus` int(11) DEFAULT NULL,
  PRIMARY KEY (`idOrcamento`),
  KEY `idFalecido` (`idFalecido`),
  KEY `idStatus` (`idStatus`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=21 ;

--
-- Extraindo dados da tabela `tb_orcamentos`
--

INSERT INTO `tb_orcamentos` (`idOrcamento`, `descricaoOrcamento`, `valorOrcamento`, `dataOrcamento`, `idFalecido`, `idStatus`) VALUES
(1, 'Caixão M em Cedro; Higienização; Maquiagem; Ornamentação simples; Taxa de cemitério; Serviço de sepultamento', '2600.00', '2025-11-18', 1, 5),
(2, 'Caixão G em Mogno; Higienização; Ornamentação com flores naturais; Taxa de cemitério; Serviço de sepultamento', '3400.00', '2025-11-19', 3, 5),
(3, 'Caixão P em Pinus; Higienização; Ornamentação básica; Taxa de cemitério', '1800.00', '2025-11-20', 5, 5),
(4, 'Caixão GG em Imbuia; Preparação completa; Ornamentação premium; Taxa de cemitério; Sepultamento completo', '4800.00', '2025-11-21', 7, 5),
(5, 'Caixão M em Carvalho; Higienização; Maquiagem; Flores simples; Taxa de cemitério; Sepultamento', '2900.00', '2025-11-22', 9, 5),
(6, 'Caixão P em Cedro; Higienização; Taxa de cemitério; Sepultamento básico', '1650.00', '2025-11-23', 21, 5),
(7, 'Caixão G em Mogno; Preparação completa; Ornamentação premium; Taxa de cemitério; Sepultamento', '3600.00', '2025-11-24', 22, 5),
(8, 'Caixão M em Pinus; Higienização; Ornamentação leve; Taxa de cemitério; Sepultamento', '2100.00', '2025-11-25', 23, 5),
(9, 'Caixão GG em Cedro; Preparação completa; Maquiagem; Véu; Taxa de cemitério; Sepultamento completo', '4200.00', '2025-11-26', 24, 5),
(10, 'Caixão M em Carvalho; Higienização; Ornamentação simples; Taxa de cemitério', '2000.00', '2025-11-27', 25, 5),
(11, 'Caixão G em Imbuia; Maquiagem; Preparação especial; Flores naturais; Taxa de cemitério; Sepultamento', '4600.00', '2025-11-28', 26, 5),
(12, 'Caixão XL em Mogno; Maquiagem; Preparação avançada; Ornamentação premium; Taxa de cemitério; Sepultamento de alto padrão', '5400.00', '2025-11-29', 27, 5),
(13, 'Caixão P em Pinus; Higienização; Taxa de cemitério; Sepultamento básico', '1700.00', '2025-11-30', 28, 4),
(14, 'Caixão M em Cedro; Maquiagem; Ornamentação simples; Taxa de cemitério', '2300.00', '2025-12-01', 29, 3),
(15, 'Caixão G em Carvalho; Preparação completa; Ornamentação floral; Taxa de cemitério; Sepultamento', '3500.00', '2025-12-02', 30, 3),
(16, 'Caixão P em Pinus; Higienização; Flores simples; Taxa de cemitério', '1750.00', '2025-12-03', 31, 3),
(17, 'Caixão GG em Imbuia; Preparação especial; Ornamentação premium; Taxa de cemitério; Sepultamento completo', '4400.00', '2025-12-04', 32, 3),
(18, 'Caixão M em Cedro; Higienização; Ornamentação com flores naturais; Taxa de cemitério', '2400.00', '2025-12-05', 33, 3),
(19, 'Caixão G em Mogno; Preparação completa; Maquiagem; Véu; Taxa de cemitério; Sepultamento', '3700.00', '2025-12-06', 34, 5),
(20, 'Caixão M em Carvalho; Higienização; Ornamentação simples; Taxa de cemitério; Sepultamento', '2250.00', '2025-12-07', 35, 4);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_salas`
--

CREATE TABLE IF NOT EXISTS `tb_salas` (
  `idSala` int(11) NOT NULL AUTO_INCREMENT,
  `descricaoSala` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `idTipoSala` int(11) NOT NULL,
  PRIMARY KEY (`idSala`),
  UNIQUE KEY `descricaoSala` (`descricaoSala`),
  KEY `idTipoSala` (`idTipoSala`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=7 ;

--
-- Extraindo dados da tabela `tb_salas`
--

INSERT INTO `tb_salas` (`idSala`, `descricaoSala`, `idTipoSala`) VALUES
(1, 'Sala 01', 1),
(2, 'Sala 02', 1),
(3, 'Sala 03', 1),
(4, 'Sala 04', 2),
(5, 'Sala 05', 2),
(6, 'Sala 06', 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_servicos`
--

CREATE TABLE IF NOT EXISTS `tb_servicos` (
  `idServico` int(11) NOT NULL AUTO_INCREMENT,
  `descricaoServico` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `valorServico` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idServico`),
  UNIQUE KEY `descricaoServico` (`descricaoServico`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=47 ;

--
-- Extraindo dados da tabela `tb_servicos`
--

INSERT INTO `tb_servicos` (`idServico`, `descricaoServico`, `valorServico`) VALUES
(1, 'Caixão Pinus - Tamanho P', '500.00'),
(2, 'Caixão Pinus - Tamanho M', '650.00'),
(3, 'Caixão Pinus - Tamanho G', '800.00'),
(4, 'Caixão Pinus - Tamanho GG', '950.00'),
(5, 'Caixão Pinus - Tamanho X', '1100.00'),
(6, 'Caixão Pinus - Tamanho XL', '1300.00'),
(7, 'Caixão Pinus - Tamanho XXL', '1500.00'),
(8, 'Caixão Carvalho - Tamanho P', '900.00'),
(9, 'Caixão Carvalho - Tamanho M', '1100.00'),
(10, 'Caixão Carvalho - Tamanho G', '1300.00'),
(11, 'Caixão Carvalho - Tamanho GG', '1500.00'),
(12, 'Caixão Carvalho - Tamanho X', '1700.00'),
(13, 'Caixão Carvalho - Tamanho XL', '1900.00'),
(14, 'Caixão Carvalho - Tamanho XXL', '2200.00'),
(15, 'Caixão Mogno - Tamanho P', '1200.00'),
(16, 'Caixão Mogno - Tamanho M', '1450.00'),
(17, 'Caixão Mogno - Tamanho G', '1700.00'),
(18, 'Caixão Mogno - Tamanho GG', '2000.00'),
(19, 'Caixão Mogno - Tamanho X', '2300.00'),
(20, 'Caixão Mogno - Tamanho XL', '2600.00'),
(21, 'Caixão Mogno - Tamanho XXL', '3000.00'),
(22, 'Caixão Cedro - Tamanho P', '1400.00'),
(23, 'Caixão Cedro - Tamanho M', '1650.00'),
(24, 'Caixão Cedro - Tamanho G', '1900.00'),
(25, 'Caixão Cedro - Tamanho GG', '2200.00'),
(26, 'Caixão Cedro - Tamanho X', '2500.00'),
(27, 'Caixão Cedro - Tamanho XL', '2800.00'),
(28, 'Caixão Cedro - Tamanho XXL', '3200.00'),
(29, 'Caixão Imbuia - Tamanho P', '1800.00'),
(30, 'Caixão Imbuia - Tamanho M', '2100.00'),
(31, 'Caixão Imbuia - Tamanho G', '2400.00'),
(32, 'Caixão Imbuia - Tamanho GG', '2800.00'),
(33, 'Caixão Imbuia - Tamanho X', '3200.00'),
(34, 'Caixão Imbuia - Tamanho XL', '3600.00'),
(35, 'Caixão Imbuia - Tamanho XXL', '4000.00'),
(36, 'Tanatopraxia Completa', '1200.00'),
(37, 'Maquiagem Facial', '250.00'),
(38, 'Higienização Corporal', '300.00'),
(39, 'Vestuário e Preparação do Corpo', '180.00'),
(40, 'Restauração Facial', '900.00'),
(41, 'Aluguel de sala de velório', '300.00'),
(42, 'Decoração', '180.00'),
(43, 'Aluguel da sala de cremação', '450.00'),
(44, 'Cremação', '1800.00'),
(45, 'Jarro para Cinzas', '250.00'),
(46, 'Velório', '2000.00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_setores`
--

CREATE TABLE IF NOT EXISTS `tb_setores` (
  `idSetor` int(11) NOT NULL AUTO_INCREMENT,
  `descricaoSetor` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`idSetor`),
  UNIQUE KEY `descricaoSetor` (`descricaoSetor`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=5 ;

--
-- Extraindo dados da tabela `tb_setores`
--

INSERT INTO `tb_setores` (`idSetor`, `descricaoSetor`) VALUES
(1, 'Administração'),
(2, 'Financeiro'),
(4, 'Gerente'),
(3, 'Recepção');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_status`
--

CREATE TABLE IF NOT EXISTS `tb_status` (
  `idStatus` int(11) NOT NULL AUTO_INCREMENT,
  `descricaoStatus` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`idStatus`),
  UNIQUE KEY `descricaoStatus` (`descricaoStatus`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=8 ;

--
-- Extraindo dados da tabela `tb_status`
--

INSERT INTO `tb_status` (`idStatus`, `descricaoStatus`) VALUES
(3, 'Aberto'),
(1, 'Ativo'),
(4, 'Cancelado'),
(7, 'Cremado'),
(5, 'Finalizado'),
(2, 'Inativo'),
(6, 'Sepultado');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_tipos_sala`
--

CREATE TABLE IF NOT EXISTS `tb_tipos_sala` (
  `idTipoSala` int(11) NOT NULL AUTO_INCREMENT,
  `descricaoTipoSala` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`idTipoSala`),
  UNIQUE KEY `descricaoTipoSala` (`descricaoTipoSala`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=3 ;

--
-- Extraindo dados da tabela `tb_tipos_sala`
--

INSERT INTO `tb_tipos_sala` (`idTipoSala`, `descricaoTipoSala`) VALUES
(1, 'Cremação'),
(2, 'Velório');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_velorios`
--

CREATE TABLE IF NOT EXISTS `tb_velorios` (
  `idVelorio` int(11) NOT NULL AUTO_INCREMENT,
  `horaVelorio` time NOT NULL,
  `dataVelorio` date NOT NULL,
  `idSala` int(11) DEFAULT NULL,
  `idFalecido` int(11) DEFAULT NULL,
  PRIMARY KEY (`idVelorio`),
  KEY `idSala` (`idSala`),
  KEY `idFalecido` (`idFalecido`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=16 ;

--
-- Extraindo dados da tabela `tb_velorios`
--

INSERT INTO `tb_velorios` (`idVelorio`, `horaVelorio`, `dataVelorio`, `idSala`, `idFalecido`) VALUES
(1, '08:00:00', '2025-11-18', 4, 1),
(2, '08:00:00', '2025-11-19', 5, 3),
(3, '08:00:00', '2025-11-20', 6, 5),
(4, '08:00:00', '2025-11-21', 4, 7),
(5, '08:00:00', '2025-11-22', 5, 9),
(6, '08:00:00', '2025-11-23', 6, 21),
(7, '08:00:00', '2025-11-24', 4, 22),
(8, '08:00:00', '2025-11-25', 5, 23),
(9, '08:00:00', '2025-11-26', 6, 24),
(10, '08:00:00', '2025-11-27', 4, 25),
(11, '08:00:00', '2025-11-28', 5, 26),
(12, '08:00:00', '2025-11-29', 6, 27),
(13, '08:00:00', '2025-11-30', 4, 28),
(14, '08:00:00', '2025-12-01', 5, 29),
(15, '08:00:00', '2025-12-02', 6, 30);

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `tb_cremacoes`
--
ALTER TABLE `tb_cremacoes`
  ADD CONSTRAINT `tb_cremacoes_ibfk_1` FOREIGN KEY (`idSala`) REFERENCES `tb_salas` (`idSala`),
  ADD CONSTRAINT `tb_cremacoes_ibfk_2` FOREIGN KEY (`idFalecido`) REFERENCES `tb_falecidos` (`idFalecido`);

--
-- Limitadores para a tabela `tb_falecidos`
--
ALTER TABLE `tb_falecidos`
  ADD CONSTRAINT `tb_falecidos_ibfk_1` FOREIGN KEY (`idStatus`) REFERENCES `tb_status` (`idStatus`);

--
-- Limitadores para a tabela `tb_funcionarios`
--
ALTER TABLE `tb_funcionarios`
  ADD CONSTRAINT `tb_funcionarios_ibfk_1` FOREIGN KEY (`idStatus`) REFERENCES `tb_status` (`idStatus`),
  ADD CONSTRAINT `tb_funcionarios_ibfk_2` FOREIGN KEY (`idSetor`) REFERENCES `tb_setores` (`idSetor`);

--
-- Limitadores para a tabela `tb_jazigos`
--
ALTER TABLE `tb_jazigos`
  ADD CONSTRAINT `tb_jazigos_ibfk_1` FOREIGN KEY (`idFalecido`) REFERENCES `tb_falecidos` (`idFalecido`);

--
-- Limitadores para a tabela `tb_orcamentos`
--
ALTER TABLE `tb_orcamentos`
  ADD CONSTRAINT `tb_orcamentos_ibfk_1` FOREIGN KEY (`idFalecido`) REFERENCES `tb_falecidos` (`idFalecido`),
  ADD CONSTRAINT `tb_orcamentos_ibfk_2` FOREIGN KEY (`idStatus`) REFERENCES `tb_status` (`idStatus`);

--
-- Limitadores para a tabela `tb_salas`
--
ALTER TABLE `tb_salas`
  ADD CONSTRAINT `tb_salas_ibfk_1` FOREIGN KEY (`idTipoSala`) REFERENCES `tb_tipos_sala` (`idTipoSala`);

--
-- Limitadores para a tabela `tb_velorios`
--
ALTER TABLE `tb_velorios`
  ADD CONSTRAINT `tb_velorios_ibfk_1` FOREIGN KEY (`idSala`) REFERENCES `tb_salas` (`idSala`),
  ADD CONSTRAINT `tb_velorios_ibfk_2` FOREIGN KEY (`idFalecido`) REFERENCES `tb_falecidos` (`idFalecido`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
