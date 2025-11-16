-- phpMyAdmin SQL Dump
-- version 4.0.4.2
-- http://www.phpmyadmin.net
--
-- Máquina: localhost
-- Data de Criação: 16-Nov-2025 às 22:56
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
  `diaCremacao` date NOT NULL,
  `idSala` int(11) DEFAULT NULL,
  `idFalecido` int(11) DEFAULT NULL,
  PRIMARY KEY (`idCremacao`),
  KEY `idSala` (`idSala`),
  KEY `idFalecido` (`idFalecido`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

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
  `fileiraJazigo` int(11) NOT NULL,
  `colunaJazigo` char(1) COLLATE utf8_unicode_ci NOT NULL,
  `idFalecido` int(11) DEFAULT NULL,
  PRIMARY KEY (`idJazigo`),
  KEY `idFalecido` (`idFalecido`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_orcamentos`
--

CREATE TABLE IF NOT EXISTS `tb_orcamentos` (
  `idOrcamento` int(11) NOT NULL AUTO_INCREMENT,
  `descricaoOrcamento` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `valorOrcamento` decimal(10,2) NOT NULL,
  `idFalecido` int(11) DEFAULT NULL,
  `idStatus` int(11) DEFAULT NULL,
  PRIMARY KEY (`idOrcamento`),
  KEY `idFalecido` (`idFalecido`),
  KEY `idStatus` (`idStatus`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=43 ;

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
(42, 'Decoração', '180.00');

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
(3, 'Recepção'),
(4, 'TI');

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
  `diaVelorio` date NOT NULL,
  `idSala` int(11) DEFAULT NULL,
  `idFalecido` int(11) DEFAULT NULL,
  PRIMARY KEY (`idVelorio`),
  KEY `idSala` (`idSala`),
  KEY `idFalecido` (`idFalecido`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

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
