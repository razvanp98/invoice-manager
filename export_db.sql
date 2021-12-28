-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gazdă: 127.0.0.1
-- Timp de generare: dec. 28, 2021 la 07:59 PM
-- Versiune server: 10.4.22-MariaDB
-- Versiune PHP: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Bază de date: `invoice_sys`
--

CREATE DATABASE IF NOT EXISTS `invoice_sys`;

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `invoice`
--

CREATE TABLE `invoice` (
  `id` int(11) NOT NULL,
  `invoice_number` varchar(64) NOT NULL,
  `vat_percentage` float NOT NULL,
  `invoice_customer_name` varchar(64) NOT NULL,
  `gross_price` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Eliminarea datelor din tabel `invoice`
--

INSERT INTO `invoice` (`id`, `invoice_number`, `vat_percentage`, `invoice_customer_name`, `gross_price`) VALUES
(13, '777/2021', 19, 'eMAG', 678.91),
(14, '778/2021', 25, 'Ross Sarl AG', 100901),
(15, '1045/2022', 50, 'Fashion Days', 780),
(16, '890/2022', 19, 'B2B Enterprise', 9450);

--
-- Indexuri pentru tabele eliminate
--

--
-- Indexuri pentru tabele `invoice`
--
ALTER TABLE `invoice`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT pentru tabele eliminate
--

--
-- AUTO_INCREMENT pentru tabele `invoice`
--
ALTER TABLE `invoice`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
