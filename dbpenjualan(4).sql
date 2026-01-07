-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 07, 2026 at 12:49 PM
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
-- Database: `dbpenjualan`
--

-- --------------------------------------------------------

--
-- Table structure for table `buy`
--

CREATE TABLE `buy` (
  `idTrans` varchar(12) NOT NULL,
  `buyDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `buy`
--

INSERT INTO `buy` (`idTrans`, `buyDate`) VALUES
('TRB0012', '2026-01-03 20:56:21'),
('TRB0013', '2026-01-03 20:59:18'),
('TRB0014', '2026-01-03 20:59:48'),
('TRB0015', '2026-01-03 21:00:42'),
('TRB0016', '2026-01-05 17:50:29'),
('TRB0017', '2026-01-05 17:52:57'),
('TRB0018', '2026-01-05 17:54:27'),
('TRB0019', '2026-01-05 23:13:10');

-- --------------------------------------------------------

--
-- Table structure for table `buydetail`
--

CREATE TABLE `buydetail` (
  `id` int(11) NOT NULL,
  `idBuy` varchar(12) NOT NULL,
  `itemID` int(11) NOT NULL,
  `qtyBuy` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `subtotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `buydetail`
--

INSERT INTO `buydetail` (`id`, `idBuy`, `itemID`, `qtyBuy`, `price`, `subtotal`) VALUES
(15, 'TRB0012', 2, 5, 1500, 7500),
(16, 'TRB0013', 7, 1, 15000, 15000),
(17, 'TRB0013', 6, 5, 5500, 27500),
(18, 'TRB0014', 1, 2, 5000, 10000),
(19, 'TRB0014', 2, 1, 1500, 1500),
(20, 'TRB0014', 5, 4, 3000, 12000),
(21, 'TRB0015', 7, 3, 15000, 45000),
(22, 'TRB0016', 1, 10, 5000, 50000),
(23, 'TRB0016', 2, 15, 1500, 22500),
(24, 'TRB0016', 5, 15, 3000, 45000),
(25, 'TRB0016', 6, 10, 5500, 55000),
(26, 'TRB0016', 7, 10, 15000, 150000),
(27, 'TRB0016', 8, 5, 20000, 100000),
(28, 'TRB0016', 9, 10, 25000, 250000),
(29, 'TRB0016', 10, 1, 50000, 50000),
(30, 'TRB0017', 10, 10, 50000, 500000),
(31, 'TRB0018', 1, 1, 5000, 5000),
(32, 'TRB0018', 2, 1, 1500, 1500),
(33, 'TRB0019', 1, 10, 5000, 50000),
(34, 'TRB0019', 2, 5, 1500, 7500),
(35, 'TRB0019', 7, 2, 15000, 30000);

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `id` int(11) NOT NULL,
  `categoryDesc` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`id`, `categoryDesc`) VALUES
(1, 'ATK'),
(2, 'Sembako'),
(3, 'Snack'),
(4, 'Elektronik'),
(5, 'Barang'),
(6, 'Minuman');

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE `items` (
  `id` int(11) NOT NULL,
  `itemID` varchar(12) NOT NULL,
  `itemDesc` varchar(100) NOT NULL,
  `itemCate` int(11) NOT NULL,
  `unit` varchar(15) NOT NULL,
  `salesPrice` int(11) NOT NULL,
  `minStock` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `items`
--

INSERT INTO `items` (`id`, `itemID`, `itemDesc`, `itemCate`, `unit`, `salesPrice`, `minStock`) VALUES
(1, 'B0001', 'Buku Tulis', 1, 'Pcs', 5000, 10),
(2, 'B0002', 'Penghapus', 1, 'Pcs', 1500, 20),
(5, 'B0005', 'Pensil', 1, 'Pcs', 3000, 10),
(6, 'B0006', 'Spidol', 1, 'Pcs', 5500, 5),
(7, 'B0007', 'Crayon', 1, 'Pack', 15000, 5),
(8, 'B0008', 'Pensil Warna', 1, 'Pack', 20000, 10),
(9, 'B0009', 'Buku Gambar', 1, 'Lusin', 25000, 5),
(10, 'B0010', 'Kipas', 4, 'Pcs', 30000, 10);

-- --------------------------------------------------------

--
-- Table structure for table `mahasiswa`
--

CREATE TABLE `mahasiswa` (
  `id` int(11) NOT NULL,
  `nim` varchar(12) NOT NULL,
  `nama` varchar(60) NOT NULL,
  `jurusan` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `mahasiswa`
--

INSERT INTO `mahasiswa` (`id`, `nim`, `nama`, `jurusan`) VALUES
(1, '111', 'heri', 'dd'),
(2, '333', 'dede', 'dd'),
(3, '666', 'desi', 'dd');

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `id` int(11) NOT NULL,
  `kode` varchar(5) NOT NULL,
  `produk` varchar(100) NOT NULL,
  `harga` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `sale`
--

CREATE TABLE `sale` (
  `idTrans` varchar(12) NOT NULL,
  `saleDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sale`
--

INSERT INTO `sale` (`idTrans`, `saleDate`) VALUES
('TRX0001', '2025-12-10 13:18:27'),
('TRX0002', '2025-12-10 13:22:00'),
('TRX0003', '2025-12-17 19:28:32'),
('TRX0004', '2025-12-17 19:29:38'),
('TRX0005', '2025-12-17 19:32:26'),
('TRX0006', '2025-12-17 19:33:23'),
('TRX0007', '2026-01-02 18:39:44'),
('TRX0008', '2026-01-03 00:32:43'),
('TRX0009', '2026-01-03 19:12:07'),
('TRX0010', '2026-01-05 17:47:30'),
('TRX0011', '2026-01-05 17:53:43'),
('TRX0012', '2026-01-05 17:55:33'),
('TRX0013', '2026-01-05 23:12:19');

-- --------------------------------------------------------

--
-- Table structure for table `saledetail`
--

CREATE TABLE `saledetail` (
  `id` int(11) NOT NULL,
  `idSale` varchar(12) NOT NULL,
  `itemID` int(11) NOT NULL,
  `qtySale` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `subtotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `saledetail`
--

INSERT INTO `saledetail` (`id`, `idSale`, `itemID`, `qtySale`, `price`, `subtotal`) VALUES
(1, 'TRX0001', 1, 5, 5000, 25000),
(2, 'TRX0001', 2, 5, 1500, 7500),
(3, 'TRX0002', 2, 100, 1500, 150000),
(4, 'TRX0003', 1, 5, 5000, 25000),
(5, 'TRX0004', 1, 6, 5000, 30000),
(6, 'TRX0005', 5, 6, 2000, 12000),
(7, 'TRX0006', 5, 12, 2000, 24000),
(8, 'TRX0006', 1, 6, 5000, 30000),
(9, 'TRX0006', 2, 7, 1500, 10500),
(10, 'TRX0007', 1, 2, 5000, 10000),
(11, 'TRX0008', 1, 5, 5000, 25000),
(12, 'TRX0008', 2, 4, 1500, 6000),
(13, 'TRX0009', 1, 2, 5000, 10000),
(14, 'TRX0010', 9, 5, 25000, 125000),
(15, 'TRX0010', 8, 2, 20000, 40000),
(16, 'TRX0010', 10, 1, 50000, 50000),
(17, 'TRX0011', 10, 5, 50000, 250000),
(18, 'TRX0012', 7, 1, 15000, 15000),
(19, 'TRX0012', 8, 1, 20000, 20000),
(20, 'TRX0013', 6, 3, 5500, 16500),
(21, 'TRX0013', 9, 2, 25000, 50000),
(22, 'TRX0013', 5, 5, 3000, 15000);

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `id` int(11) NOT NULL,
  `supplierID` varchar(12) NOT NULL,
  `supplierName` varchar(100) NOT NULL,
  `supplierUser` varchar(15) NOT NULL,
  `supplierAlamat` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`id`, `supplierID`, `supplierName`, `supplierUser`, `supplierAlamat`) VALUES
(1, 'S0001', 'Toko akoh', 'Ahok', 'Pasar cikarang'),
(2, 'S0002', 'CV Maju Bersama', 'Abih', 'Jalan Merdeka'),
(7, 'S0003', 'PT Kreasi', 'Pak Wawan', 'Jalan Sebrang'),
(8, 'S0004', 'Toko Makmur', 'Haji Makmur', 'Jalan Panglima'),
(9, 'S0005', 'CV Sinar Jaya', 'Om Aceng', 'Jl Sudirman');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password_hash` varchar(255) NOT NULL,
  `password` varchar(15) NOT NULL,
  `fullname` varchar(150) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password_hash`, `password`, `fullname`, `created_at`) VALUES
(1, 'admin', '', '123', 'Super Admin', '2025-12-28 18:02:25');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `buy`
--
ALTER TABLE `buy`
  ADD PRIMARY KEY (`idTrans`);

--
-- Indexes for table `buydetail`
--
ALTER TABLE `buydetail`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `items`
--
ALTER TABLE `items`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `mahasiswa`
--
ALTER TABLE `mahasiswa`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `sale`
--
ALTER TABLE `sale`
  ADD PRIMARY KEY (`idTrans`);

--
-- Indexes for table `saledetail`
--
ALTER TABLE `saledetail`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `buydetail`
--
ALTER TABLE `buydetail`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `items`
--
ALTER TABLE `items`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `mahasiswa`
--
ALTER TABLE `mahasiswa`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `saledetail`
--
ALTER TABLE `saledetail`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
