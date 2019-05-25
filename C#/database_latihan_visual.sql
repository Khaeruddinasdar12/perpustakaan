-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 06 Bulan Mei 2019 pada 06.20
-- Versi server: 10.1.34-MariaDB
-- Versi PHP: 7.2.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `database_latihan_visual`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `mahasiswa`
--

CREATE TABLE `mahasiswa` (
  `id` int(11) NOT NULL,
  `stb` varchar(6) NOT NULL,
  `nama` varchar(191) NOT NULL,
  `alamat` varchar(191) NOT NULL,
  `nilai_tugas` int(11) NOT NULL,
  `nilai_mid` int(11) NOT NULL,
  `nilai_final` int(11) NOT NULL,
  `nilai_akhir` double NOT NULL,
  `nilai_huruf` char(5) NOT NULL,
  `keterangan` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `mahasiswa`
--

INSERT INTO `mahasiswa` (`id`, `stb`, `nama`, `alamat`, `nilai_tugas`, `nilai_mid`, `nilai_final`, `nilai_akhir`, `nilai_huruf`, `keterangan`) VALUES
(1, '172296', 'Khaeruddin Asdar', 'Jln. Paccerakkang', 80, 78, 88, 90, 'A', 'Sangat Baik'),
(4, '172297', 'Mimi Amelia', 'Citra Sudiang Indah', 67, 87, 77, 87, 'A', 'Sangat Baik'),
(5, '172298', 'Brian', 'Citra Sudiang Indah', 67, 87, 77, 87, 'A', 'Sangat Baik'),
(6, '172288', 'JuliastriYunus', 'Sulawesi Selatan', 78, 98, 71, 71, 'A', 'Sangat Baik'),
(8, '192168', 'Mimi Sudi', 'Makassar', 89, 45, 12, 12, 'D', 'Cukup'),
(9, '192167', 'Johnson', 'Jeneponto', 19, 19, 89, 89, 'D', 'Cukup'),
(10, '127001', 'Muhaimin', 'Bawakaraeng', 75, 67, 65, 65, 'C', 'Cukup'),
(11, '172344', 'Lisa', 'Maros', 55, 44, 78, 78, 'C', 'Cukup'),
(12, '192192', 'Mawar', 'Jeddah', 89, 78, 67, 67, 'B', 'Baik'),
(13, '1', '1', '1', 1, 1, 1, 1, 'E', 'Error'),
(14, '12', '12', '12', 12, 12, 12, 12, 'E', 'Error'),
(15, '122', '12', '122', 13, 13, 13, 13, 'E', 'Error'),
(16, '198168', 'Mirna', 'Maros', 67, 56, 78, 78, 'C', 'Cukup');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `mahasiswa`
--
ALTER TABLE `mahasiswa`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `stb` (`stb`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `mahasiswa`
--
ALTER TABLE `mahasiswa`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
