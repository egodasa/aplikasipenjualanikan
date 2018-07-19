DROP TABLE IF EXISTS `tbl_detail_pembelian`;
CREATE TABLE `tbl_detail_pembelian` (
  `id_detail` int(11) NOT NULL AUTO_INCREMENT,
  `id_pembelian` varchar(50) NOT NULL,
  `id_produk` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `harga` int(11) NOT NULL,
  `id_suplier` int(11) NOT NULL,
  PRIMARY KEY (`id_detail`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TRIGGER `tambah_stok_beli` AFTER INSERT ON `tbl_detail_pembelian` FOR EACH ROW update tbl_produk set stok = stok + NEW.jumlah where id_produk = NEW.id_produk;

CREATE TRIGGER `kurang_stok_beli` AFTER DELETE ON `tbl_detail_pembelian` FOR EACH ROW update tbl_produk set stok = stok - OLD.jumlah where id_produk = OLD.id_produk;

DROP TABLE IF EXISTS `tbl_detail_penjualan`;
CREATE TABLE `tbl_detail_penjualan` (
  `id_detail` int(11) NOT NULL AUTO_INCREMENT,
  `id_produk` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `id_penjualan` varchar(50) NOT NULL,
  PRIMARY KEY (`id_detail`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TRIGGER `kurangi_stok` AFTER INSERT ON `tbl_detail_penjualan` FOR EACH ROW update tbl_produk set stok = stok - new.jumlah where id_produk = new.id_produk;

CREATE TRIGGER `reset_stok` AFTER DELETE ON `tbl_detail_penjualan` FOR EACH ROW update tbl_produk set stok = stok + OLD.jumlah where id_produk = OLD.id_produk;

DROP TABLE IF EXISTS `tbl_jenis_produk`;
CREATE TABLE `tbl_jenis_produk` (
  `id_jproduk` int(11) NOT NULL AUTO_INCREMENT,
  `nm_jproduk` varchar(50) NOT NULL,
  PRIMARY KEY (`id_jproduk`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS `tbl_macam_satuan`;
CREATE TABLE `tbl_macam_satuan` (
  `id_jsat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_jsat` varchar(30) NOT NULL,
  PRIMARY KEY (`id_jsat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_macam_satuan` (`id_jsat`, `nm_jsat`) VALUES
(1,	'Berat'),
(2,	'Panjang'),
(3,	'Waktu'),
(4,	'Banyak'),
(5,	'Tekanan')
ON DUPLICATE KEY UPDATE `id_jsat` = VALUES(`id_jsat`), `nm_jsat` = VALUES(`nm_jsat`);

DROP TABLE IF EXISTS `tbl_produk`;
CREATE TABLE `tbl_produk` (
  `id_produk` int(11) NOT NULL AUTO_INCREMENT,
  `nm_produk` varchar(50) NOT NULL,
  `stok` int(11) NOT NULL,
  `status` enum('Aktif','Tidak Aktif') NOT NULL DEFAULT 'Aktif',
  `id_jproduk` int(11) NOT NULL,
  `hrg_jual` int(11) NOT NULL,
  `hrg_beli` int(11) NOT NULL,
  `id_sat_produk` int(11) NOT NULL DEFAULT '25',
  PRIMARY KEY (`id_produk`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS `tbl_suplier`;
CREATE TABLE `tbl_suplier` (
  `id_suplier` int(11) NOT NULL AUTO_INCREMENT,
  `nm_suplier` varchar(100) NOT NULL,
  `no_telpon` varchar(20) NOT NULL,
  `alamat` varchar(200) NOT NULL,
  PRIMARY KEY (`id_suplier`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS `tbl_pembelian`;
CREATE TABLE `tbl_pembelian` (
  `id_pembelian` varchar(50) NOT NULL,
  `waktu_pembelian` datetime NOT NULL,
  PRIMARY KEY (`id_pembelian`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS `tbl_pengguna`;
CREATE TABLE `tbl_pengguna` (
  `id_pengguna` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(15) NOT NULL,
  `password` text NOT NULL,
  `nm_lengkap` varchar(100) NOT NULL,
  `jenis` enum('Admin','Apoteker','Pimpinan') NOT NULL,
  PRIMARY KEY (`id_pengguna`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS `tbl_satuan`;
CREATE TABLE `tbl_satuan` (
  `id_sat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_sat` varchar(30) NOT NULL,
  `id_jsat` int(11) NOT NULL,
  PRIMARY KEY (`id_sat`),
  KEY `id_jsat` (`id_jsat`),
  CONSTRAINT `tbl_satuan_ibfk_1` FOREIGN KEY (`id_jsat`) REFERENCES `tbl_macam_satuan` (`id_jsat`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_satuan` (`id_sat`, `nm_sat`, `id_jsat`) VALUES
(1,	'Kg',	1),
(2,	'Hg',	1),
(3,	'Dag',	1),
(4,	'Gr',	1),
(5,	'Cg',	1),
(6,	'Mg',	1),
(7,	'Km',	2),
(8,	'Hm',	2),
(9,	'Dam',	2),
(10,	'M',	2),
(11,	'Dm',	2),
(12,	'Cm',	2),
(13,	'Mm',	2),
(14,	'Detik',	3),
(15,	'Menit',	3),
(16,	'Jam',	3),
(17,	'Hari',	3),
(18,	'Minggu',	3),
(19,	'Bulan',	3),
(20,	'Tahun',	3),
(21,	'Dg',	1),
(22,	'Pcs',	4),
(23,	'Lembar',	4),
(24,	'Tablet',	4),
(25,	'Buah',	4),
(26,	'MMHG',	5),
(27,	'Sachet',	4),
(28,	'Botol',	4)
ON DUPLICATE KEY UPDATE `id_sat` = VALUES(`id_sat`), `nm_sat` = VALUES(`nm_sat`), `id_jsat` = VALUES(`id_jsat`);

DROP TABLE IF EXISTS `tbl_penjualan`;
CREATE TABLE `tbl_penjualan` (
  `id_penjualan` varchar(50) NOT NULL,
  `waktu_penjualan` datetime NOT NULL,
  PRIMARY KEY (`id_penjualan`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ~ CREATE VIEW `daftar_satuan` AS select `a`.`id_sat` AS `Id_Sat`,`a`.`nm_sat` AS `Nama_Satuan`,`a`.`id_jsat` AS `Id_Jsat`,`b`.`nm_jsat` AS `Nama_Jenis_Satuan` from (`tbl_satuan` `a` join `tbl_macam_satuan` `b` on((`a`.`id_jsat` = `b`.`id_jsat`)));

-- ~ CREATE VIEW `daftar_produk` AS select `a`.`id_produk` AS `Id_produk`,`a`.`nm_produk` AS `Nama_produk`,`a`.`stok` AS `Stok`,`b`.`id_jproduk` AS `Id_Jproduk`,`b`.`nm_jproduk` AS `Jenis_produk`,`a`.`id_sat_produk` AS `Id_Sat_produk`,`c`.`Nama_Satuan` AS `Satuan`,`a`.`hrg_jual` AS `Harga_produk` from ((`tbl_produk` `a` join `tbl_jenis_produk` `b` on((`a`.`id_jproduk` = `b`.`id_jproduk`))) join `daftar_satuan` `c` on((`a`.`id_sat_produk` = `c`.`Id_Sat`)));

-- ~ CREATE VIEW `daftar_produk_beli` AS select `a`.`id_penjualan` AS `Id_penjualan`,`a`.`id_produk` AS `Id_produk`,`b`.`nm_produk` AS `Nama_produk`,sum(`a`.`jumlah`) AS `Jumlah`,`b`.`hrg_jual` AS `Harga_produk`,sum((`b`.`hrg_jual` * `a`.`jumlah`)) AS `Total_Harga` from (`tbl_detail_penjualan` `a` join `tbl_produk` `b` on((`a`.`id_produk` = `b`.`id_produk`))) group by `a`.`id_penjualan`,`a`.`id_produk`;

-- ~ CREATE VIEW `laporan_suplier` AS select `tbl_suplier`.`id_suplier` AS `id_suplier`,`tbl_suplier`.`nm_suplier` AS `Nama_suplier`,`tbl_suplier`.`alamat` AS `Alamat`,`tbl_suplier`.`no_telpon` AS `Nomor_Telepon` from `tbl_suplier`;

-- ~ CREATE VIEW `laporan_detail_pembelian` AS select `a`.`id_produk` AS `id_produk`,`a`.`id_detail` AS `id_detail`,`a`.`id_suplier` AS `id_suplier`,`a`.`id_pembelian` AS `id_pembelian`,`b`.`Nama_produk` AS `Nama_produk`,`a`.`jumlah` AS `jumlah`,`a`.`harga` AS `harga`,`b`.`Satuan` AS `Satuan`,`c`.`Nama_suplier` AS `Nama_suplier` from ((`tbl_detail_pembelian` `a` join `daftar_produk` `b` on((`a`.`id_produk` = `b`.`Id_produk`))) join `laporan_suplier` `c` on((`a`.`id_suplier` = `c`.`id_suplier`)));

-- ~ CREATE VIEW `laporan_detail_penjualan` AS select `a`.`id_penjualan` AS `Id_penjualan`,`a`.`id_produk` AS `Id_produk`,`b`.`Nama_produk` AS `Nama_produk`,`b`.`Harga_produk` AS `Harga_produk`,`a`.`jumlah` AS `Jumlah`,(`a`.`jumlah` * `b`.`Harga_produk`) AS `Total`,`b`.`Satuan` AS `Satuan` from (`tbl_detail_penjualan` `a` join `daftar_produk` `b` on((`a`.`id_produk` = `b`.`Id_produk`)));

-- ~ CREATE VIEW `daftar_pembelian` AS select `b`.`id_pembelian` AS `Id_Pembelian`,date_format(`a`.`waktu_pembelian`,'%d-%M-%Y') AS `Tanggal_Pembelian`,sum(`b`.`jumlah`) AS `Jumlah`,sum(`b`.`harga`) AS `Total_Harga` from (`tbl_pembelian` `a` join `laporan_detail_pembelian` `b` on((`a`.`id_pembelian` = `b`.`id_pembelian`))) group by `a`.`id_pembelian` order by `a`.`waktu_pembelian` desc;

-- ~ CREATE VIEW `daftar_penjualan` AS select `b`.`Id_penjualan` AS `Id_penjualan`,date_format(`a`.`waktu_penjualan`,'%d-%M-%Y') AS `Tanggal_penjualan`,sum(`b`.`Jumlah`) AS `Jumlah`,sum(`b`.`Total_Harga`) AS `Total_Harga` from (`tbl_penjualan` `a` join `daftar_produk_beli` `b` on((`a`.`id_penjualan` = `b`.`Id_penjualan`))) group by `a`.`id_penjualan` order by `a`.`waktu_penjualan` desc;

-- ~ CREATE VIEW `laporan_pemasukan` AS select `a`.`waktu_penjualan` AS `waktu_penjualan`,`b`.`Id_penjualan` AS `Id_penjualan`,`b`.`Nama_produk` AS `Nama_produk`,`b`.`Jumlah` AS `Jumlah`,`b`.`Total_Harga` AS `Total_Harga` from (`daftar_produk_beli` `b` join `tbl_penjualan` `a` on((`a`.`id_penjualan` = `b`.`Id_penjualan`)));

-- ~ CREATE VIEW `lap_harian` AS select `laporan_pemasukan`.`waktu_penjualan` AS `waktu_penjualan`,`laporan_pemasukan`.`Nama_produk` AS `Nama_produk`,sum(`laporan_pemasukan`.`Jumlah`) AS `Jumlah`,sum(`laporan_pemasukan`.`Total_Harga`) AS `Total_Harga` from `laporan_pemasukan` where date(`laporan_pemasukan`.`waktu_penjualan`) = date(now()) group by `laporan_pemasukan`.`Nama_produk`;

-- ~ CREATE VIEW `lap_bulanan` AS select dayofmonth(`laporan_pemasukan`.`waktu_penjualan`) AS `hari`,sum(`laporan_pemasukan`.`Jumlah`) AS `Jumlah`,sum(`laporan_pemasukan`.`Total_Harga`) AS `Total_Harga` from `laporan_pemasukan` where ((month(`laporan_pemasukan`.`waktu_penjualan`) = month(now())) and (year(`laporan_pemasukan`.`waktu_penjualan`) = year(now()))) group by dayofmonth(`laporan_pemasukan`.`waktu_penjualan`);

-- ~ CREATE VIEW `lap_tahunan` AS select month(`laporan_pemasukan`.`waktu_penjualan`) AS `bulan`,sum(`laporan_pemasukan`.`Jumlah`) AS `Jumlah`,sum(`laporan_pemasukan`.`Total_Harga`) AS `Total_Harga` from `laporan_pemasukan` where (year(`laporan_pemasukan`.`waktu_penjualan`) = year(now())) group by month(`laporan_pemasukan`.`waktu_penjualan`);
