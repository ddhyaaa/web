-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 17 Bulan Mei 2024 pada 16.00
-- Versi server: 10.4.28-MariaDB
-- Versi PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `datakaryawan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `absen`
--

CREATE TABLE `absen` (
  `idK` varchar(150) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `tanggal` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `absen`
--

INSERT INTO `absen` (`idK`, `nama`, `tanggal`) VALUES
('1', 'Zachary Helios ', 'Friday, 17 May 2024 | 09:01 PM'),
('8', 'Smith Saparudin', 'Friday, 17 May 2024 | 09:16 PM'),
('8', 'Smith Saparudin', 'Friday, 17 May 2024 | 09:24 PM');

-- --------------------------------------------------------

--
-- Struktur dari tabel `akun`
--

CREATE TABLE `akun` (
  `username` varchar(255) NOT NULL,
  `password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `akun`
--

INSERT INTO `akun` (`username`, `password`) VALUES
('2', '12345'),
('1', '11111'),
('3', '12345'),
('8', '54321'),
('4', '12345');

-- --------------------------------------------------------

--
-- Struktur dari tabel `karyawan`
--

CREATE TABLE `karyawan` (
  `id` varchar(255) NOT NULL,
  `nama` varchar(150) NOT NULL,
  `tanggal_lahir` text NOT NULL,
  `jenis` text NOT NULL,
  `jabatan` text NOT NULL,
  `gaji` int(11) NOT NULL,
  `gambar` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `karyawan`
--

INSERT INTO `karyawan` (`id`, `nama`, `tanggal_lahir`, `jenis`, `jabatan`, `gaji`, `gambar`) VALUES
('1', 'Zachary Helios ', 'Thursday, 02 December 1999', 'Laki-laki', 'Manajer', 50000000, 'D:\\Semester 4\\PRAKTIKUM\\PEMVIS\\pegawai1.jpg'),
('2', 'Riz Janessa ', 'Friday, 20 August 1993', 'Perempuan', 'Sekretaris', 45000000, 'D:\\Semester 4\\PRAKTIKUM\\PEMVIS\\pegawai1cewe.jpg'),
('3', 'Varzae Amade ', 'Monday, 28 September 1998', 'Laki-laki', 'Bendahara', 25000000, 'D:\\Semester 4\\PRAKTIKUM\\PEMVIS\\pegawai2.jpg'),
('4', 'Smash Matahari', 'Tuesday, 15 June 1999', 'Laki-laki', 'Cleaning Service', 10000000, 'D:\\Semester 4\\PRAKTIKUM\\PEMVIS\\FOTO\\CS COWO.jpg'),
('8', 'Smith Saparudin', 'Tuesday, 07 October 1997', 'Laki-laki', 'Bendahara', 15000000, 'D:\\Semester 4\\PRAKTIKUM\\PEMVIS\\pegawai3.jpg');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `absen`
--
ALTER TABLE `absen`
  ADD KEY `idK` (`idK`);

--
-- Indeks untuk tabel `akun`
--
ALTER TABLE `akun`
  ADD KEY `nama` (`username`);

--
-- Indeks untuk tabel `karyawan`
--
ALTER TABLE `karyawan`
  ADD PRIMARY KEY (`id`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `absen`
--
ALTER TABLE `absen`
  ADD CONSTRAINT `absen_ibfk_1` FOREIGN KEY (`idK`) REFERENCES `karyawan` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `akun`
--
ALTER TABLE `akun`
  ADD CONSTRAINT `nama` FOREIGN KEY (`username`) REFERENCES `karyawan` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
