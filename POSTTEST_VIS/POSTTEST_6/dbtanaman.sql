-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 20, 2026 at 04:32 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbtanaman`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbjenis`
--

CREATE TABLE `tbjenis` (
  `idJenis` int(11) NOT NULL,
  `namaJenis` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbjenis`
--

INSERT INTO `tbjenis` (`idJenis`, `namaJenis`) VALUES
(2, 'Tanaman Hias'),
(3, 'Tanaman Obat'),
(4, 'Tanaman Buah'),
(5, 'Tanaman Sayur'),
(6, 'Sukulen / Kaktus'),
(7, 'Tanaman Air'),
(8, 'Bonsai'),
(9, 'Tanaman Pangan');

-- --------------------------------------------------------

--
-- Table structure for table `tbtanaman`
--

CREATE TABLE `tbtanaman` (
  `idTanaman` int(11) NOT NULL,
  `namaTanaman` varchar(100) NOT NULL,
  `idJenis` int(11) NOT NULL,
  `lokasiLahan` varchar(150) NOT NULL,
  `hargaBeli` bigint(20) NOT NULL,
  `hargaJual` bigint(20) NOT NULL,
  `keterangan` text DEFAULT NULL,
  `fotoPath` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbtanaman`
--

INSERT INTO `tbtanaman` (`idTanaman`, `namaTanaman`, `idJenis`, `lokasiLahan`, `hargaBeli`, `hargaJual`, `keterangan`, `fotoPath`) VALUES
(11, 'Peashooter', 5, 'Crazy Dave\'s Garden', 100, 75, 'Peashooter menembakkan 1 biji polong kepada zombie', 'C:\\Users\\ASUS\\Downloads\\Peashooter.png'),
(12, 'Chomper', 2, 'Crazy Dave\'s Garden', 175, 150, 'Chomper dapat memakan 1 zombie normal dan membutuhkan waktu yang cukup lama untuk menelannya', 'C:\\Users\\ASUS\\Downloads\\Chomper.jpg'),
(13, 'Cactus', 6, 'Crazy Dave\'s Garden', 125, 100, 'Cactus dapat menembakkan duri kaktus ke zombia dan dapat mempertinggi dirinya untuk menembakkan duri ke zombi yang naik balon', 'C:\\Users\\ASUS\\Downloads\\Cactus.png');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbjenis`
--
ALTER TABLE `tbjenis`
  ADD PRIMARY KEY (`idJenis`);

--
-- Indexes for table `tbtanaman`
--
ALTER TABLE `tbtanaman`
  ADD PRIMARY KEY (`idTanaman`),
  ADD KEY `tbtanamanfk` (`idJenis`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbjenis`
--
ALTER TABLE `tbjenis`
  MODIFY `idJenis` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tbtanaman`
--
ALTER TABLE `tbtanaman`
  MODIFY `idTanaman` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbtanaman`
--
ALTER TABLE `tbtanaman`
  ADD CONSTRAINT `tbtanamanfk` FOREIGN KEY (`idJenis`) REFERENCES `tbjenis` (`idJenis`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
