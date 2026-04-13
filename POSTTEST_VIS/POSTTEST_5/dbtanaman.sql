-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 13, 2026 at 01:48 PM
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

-- --------------------------------------------------------

--
-- Table structure for table `tbtanaman`
--

CREATE TABLE `tbtanaman` (
  `idTanaman` int(11) NOT NULL,
  `namaTanaman` varchar(100) NOT NULL,
  `jenisTanaman` varchar(50) NOT NULL,
  `lokasiLahan` varchar(150) NOT NULL,
  `hargaBeli` bigint(20) NOT NULL,
  `hargaJual` bigint(20) NOT NULL,
  `keterangan` text DEFAULT NULL,
  `fotoPath` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbtanaman`
--

INSERT INTO `tbtanaman` (`idTanaman`, `namaTanaman`, `jenisTanaman`, `lokasiLahan`, `hargaBeli`, `hargaJual`, `keterangan`, `fotoPath`) VALUES
(5, 'Repeater', '- Tanaman Hias', 'Garden', 200, 150, 'Repeater menembakkan 2 biji polong ke zombie', 'C:\\Users\\ASUS\\OneDrive\\Pictures\\Screenshots\\akatsuki-pain-hat-deidara-konan-hat.jpg'),
(6, 'Snow Pea', '- Tanaman Hias', 'adawdawd', 175, 125, 'Snow pie menembakkan biji polong es dingin banget njir', 'C:\\Users\\ASUS\\OneDrive\\Pictures\\Screenshots\\akatsuki-pain-hat-deidara-konan-hat.jpg');

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
  ADD PRIMARY KEY (`idTanaman`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbjenis`
--
ALTER TABLE `tbjenis`
  MODIFY `idJenis` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbtanaman`
--
ALTER TABLE `tbtanaman`
  MODIFY `idTanaman` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
