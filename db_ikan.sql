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

INSERT INTO `tbl_detail_pembelian` (`id_detail`, `id_pembelian`, `id_produk`, `jumlah`, `harga`, `id_suplier`) VALUES
(1,	'2006181158043165',	10,	20,	100000,	1),
(3,	'2006181158043165',	14,	200,	100000,	1),
(6,	'2106181210346578',	9,	300,	1200000,	1)
ON DUPLICATE KEY UPDATE `id_detail` = VALUES(`id_detail`), `id_pembelian` = VALUES(`id_pembelian`), `id_produk` = VALUES(`id_produk`), `jumlah` = VALUES(`jumlah`), `harga` = VALUES(`harga`), `id_suplier` = VALUES(`id_suplier`);

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

INSERT INTO `tbl_detail_penjualan` (`id_detail`, `id_produk`, `jumlah`, `id_penjualan`) VALUES
(1,	1,	3,	'100620181115456348'),
(5,	10,	2,	'1006181122392383'),
(6,	1,	2,	'110620181206354178'),
(7,	8,	1,	'110620181214334910'),
(8,	10,	2,	'1806180902007400'),
(9,	10,	0,	'1806180902007400'),
(10,	12,	20,	'1806180902007400'),
(12,	11,	2,	'2106180317125498'),
(13,	12,	2,	'2106180317125498'),
(14,	11,	5,	'2206180933141041')
ON DUPLICATE KEY UPDATE `id_detail` = VALUES(`id_detail`), `id_produk` = VALUES(`id_produk`), `jumlah` = VALUES(`jumlah`), `id_penjualan` = VALUES(`id_penjualan`);

CREATE TRIGGER `kurangi_stok` AFTER INSERT ON `tbl_detail_penjualan` FOR EACH ROW update tbl_produk set stok = stok - new.jumlah where id_produk = new.id_produk;

CREATE TRIGGER `reset_stok` AFTER DELETE ON `tbl_detail_penjualan` FOR EACH ROW update tbl_produk set stok = stok + OLD.jumlah where id_produk = OLD.id_produk;

DROP TABLE IF EXISTS `tbl_jenis_produk`;
CREATE TABLE `tbl_jenis_produk` (
  `id_jproduk` int(11) NOT NULL AUTO_INCREMENT,
  `nm_jproduk` varchar(50) NOT NULL,
  PRIMARY KEY (`id_jproduk`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_jenis_produk` (`id_jproduk`, `nm_jproduk`) VALUES
(1,	'KB'),
(2,	'Ringan'),
(3,	'Keras'),
(4,	'Suplemen')
ON DUPLICATE KEY UPDATE `id_jproduk` = VALUES(`id_jproduk`), `nm_jproduk` = VALUES(`nm_jproduk`);

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

INSERT INTO `tbl_produk` (`id_produk`, `nm_produk`, `stok`, `status`, `id_jproduk`, `hrg_jual`, `id_sat_produk`) VALUES
(1,	'Kabe',	3,	'Aktif',	1,	10000,	25),
(2,	'Ringan',	2,	'Aktif',	2,	1800,	25),
(8,	'Suntik',	3,	'Aktif',	1,	9000,	25),
(9,	'Parasetamol',	307,	'Aktif',	2,	1100,	25),
(10,	'STM',	1,	'Aktif',	2,	1000,	25),
(11,	'Promag',	23,	'Aktif',	2,	2000,	25),
(12,	'Amoxilin',	18,	'Aktif',	2,	3000,	25),
(13,	'Vitamin C',	12,	'Aktif',	2,	12000,	25),
(14,	'sitrizin',	20,	'Aktif',	2,	12000,	23)
ON DUPLICATE KEY UPDATE `id_produk` = VALUES(`id_produk`), `nm_produk` = VALUES(`nm_produk`), `stok` = VALUES(`stok`), `status` = VALUES(`status`), `id_jproduk` = VALUES(`id_jproduk`), `hrg_jual` = VALUES(`hrg_jual`), `id_sat_produk` = VALUES(`id_sat_produk`);

DROP TABLE IF EXISTS `tbl_suplier`;
CREATE TABLE `tbl_suplier` (
  `id_suplier` int(11) NOT NULL AUTO_INCREMENT,
  `nm_suplier` varchar(100) NOT NULL,
  `no_telpon` varchar(20) NOT NULL,
  `alamat` varchar(200) NOT NULL,
  PRIMARY KEY (`id_suplier`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_suplier` (`id_suplier`, `nm_suplier`, `no_telpon`, `alamat`) VALUES
(1,	'suplier 2',	'22222',	'Alamat 2'),
(3,	'suplier 5',	'55555',	'Alamat 5')
ON DUPLICATE KEY UPDATE `id_suplier` = VALUES(`id_suplier`), `nm_suplier` = VALUES(`nm_suplier`), `no_telpon` = VALUES(`no_telpon`), `alamat` = VALUES(`alamat`);

DROP TABLE IF EXISTS `tbl_pembelian`;
CREATE TABLE `tbl_pembelian` (
  `id_pembelian` varchar(50) NOT NULL,
  `waktu_pembelian` datetime NOT NULL,
  PRIMARY KEY (`id_pembelian`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_pembelian` (`id_pembelian`, `waktu_pembelian`) VALUES
('2006181158043165',	'2018-06-20 11:59:15')
ON DUPLICATE KEY UPDATE `id_pembelian` = VALUES(`id_pembelian`), `waktu_pembelian` = VALUES(`waktu_pembelian`);

DROP TABLE IF EXISTS `tbl_pengguna`;
CREATE TABLE `tbl_pengguna` (
  `id_pengguna` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(15) NOT NULL,
  `password` text NOT NULL,
  `nm_lengkap` varchar(100) NOT NULL,
  `jenis` enum('Admin','Apoteker','Pimpinan') NOT NULL,
  PRIMARY KEY (`id_pengguna`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_pengguna` (`id_pengguna`, `username`, `password`, `nm_lengkap`, `jenis`) VALUES
(1,	'apoteker',	'326dd0e9d42a3da01b50028c51cf21fc',	'apoteker',	'Apoteker'),
(4,	'admin',	'21232f297a57a5a743894a0e4a801fc3',	'admin',	'Admin'),
(5,	'pimpinan',	'90973652b88fe07d05a4304f0a945de8',	'pimpinan',	'Pimpinan')
ON DUPLICATE KEY UPDATE `id_pengguna` = VALUES(`id_pengguna`), `username` = VALUES(`username`), `password` = VALUES(`password`), `nm_lengkap` = VALUES(`nm_lengkap`), `jenis` = VALUES(`jenis`);

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

INSERT INTO `tbl_penjualan` (`id_penjualan`, `waktu_penjualan`) VALUES
('2106180317125498',	'2018-06-21 03:17:54'),
('2206180933141041',	'2018-06-22 09:34:17')
ON DUPLICATE KEY UPDATE `id_penjualan` = VALUES(`id_penjualan`), `waktu_penjualan` = VALUES(`waktu_penjualan`);

CREATE VIEW `daftar_satuan` AS select `a`.`id_sat` AS `Id_Sat`,`a`.`nm_sat` AS `Nama_Satuan`,`a`.`id_jsat` AS `Id_Jsat`,`b`.`nm_jsat` AS `Nama_Jenis_Satuan` from (`tbl_satuan` `a` join `tbl_macam_satuan` `b` on((`a`.`id_jsat` = `b`.`id_jsat`)));

CREATE VIEW `daftar_produk` AS select `a`.`id_produk` AS `Id_produk`,`a`.`nm_produk` AS `Nama_produk`,`a`.`stok` AS `Stok`,`b`.`id_jproduk` AS `Id_Jproduk`,`b`.`nm_jproduk` AS `Jenis_produk`,`a`.`id_sat_produk` AS `Id_Sat_produk`,`c`.`Nama_Satuan` AS `Satuan`,`a`.`hrg_jual` AS `Harga_produk` from ((`tbl_produk` `a` join `tbl_jenis_produk` `b` on((`a`.`id_jproduk` = `b`.`id_jproduk`))) join `daftar_satuan` `c` on((`a`.`id_sat_produk` = `c`.`Id_Sat`)));

CREATE VIEW `daftar_produk_beli` AS select `a`.`id_penjualan` AS `Id_penjualan`,`a`.`id_produk` AS `Id_produk`,`b`.`nm_produk` AS `Nama_produk`,sum(`a`.`jumlah`) AS `Jumlah`,`b`.`hrg_jual` AS `Harga_produk`,sum((`b`.`hrg_jual` * `a`.`jumlah`)) AS `Total_Harga` from (`tbl_detail_penjualan` `a` join `tbl_produk` `b` on((`a`.`id_produk` = `b`.`id_produk`))) group by `a`.`id_penjualan`,`a`.`id_produk`;

CREATE VIEW `laporan_suplier` AS select `tbl_suplier`.`id_suplier` AS `id_suplier`,`tbl_suplier`.`nm_suplier` AS `Nama_suplier`,`tbl_suplier`.`alamat` AS `Alamat`,`tbl_suplier`.`no_telpon` AS `Nomor_Telepon` from `tbl_suplier`;

CREATE VIEW `laporan_detail_pembelian` AS select `a`.`id_produk` AS `id_produk`,`a`.`id_detail` AS `id_detail`,`a`.`id_suplier` AS `id_suplier`,`a`.`id_pembelian` AS `id_pembelian`,`b`.`Nama_produk` AS `Nama_produk`,`a`.`jumlah` AS `jumlah`,`a`.`harga` AS `harga`,`b`.`Satuan` AS `Satuan`,`c`.`Nama_suplier` AS `Nama_suplier` from ((`tbl_detail_pembelian` `a` join `daftar_produk` `b` on((`a`.`id_produk` = `b`.`Id_produk`))) join `laporan_suplier` `c` on((`a`.`id_suplier` = `c`.`id_suplier`)));

CREATE VIEW `laporan_detail_penjualan` AS select `a`.`id_penjualan` AS `Id_penjualan`,`a`.`id_produk` AS `Id_produk`,`b`.`Nama_produk` AS `Nama_produk`,`b`.`Harga_produk` AS `Harga_produk`,`a`.`jumlah` AS `Jumlah`,(`a`.`jumlah` * `b`.`Harga_produk`) AS `Total`,`b`.`Satuan` AS `Satuan` from (`tbl_detail_penjualan` `a` join `daftar_produk` `b` on((`a`.`id_produk` = `b`.`Id_produk`)));

CREATE VIEW `daftar_pembelian` AS select `b`.`id_pembelian` AS `Id_Pembelian`,date_format(`a`.`waktu_pembelian`,'%d-%M-%Y') AS `Tanggal_Pembelian`,sum(`b`.`jumlah`) AS `Jumlah`,sum(`b`.`harga`) AS `Total_Harga` from (`tbl_pembelian` `a` join `laporan_detail_pembelian` `b` on((`a`.`id_pembelian` = `b`.`id_pembelian`))) group by `a`.`id_pembelian` order by `a`.`waktu_pembelian` desc;

CREATE VIEW `daftar_penjualan` AS select `b`.`Id_penjualan` AS `Id_penjualan`,date_format(`a`.`waktu_penjualan`,'%d-%M-%Y') AS `Tanggal_penjualan`,sum(`b`.`Jumlah`) AS `Jumlah`,sum(`b`.`Total_Harga`) AS `Total_Harga` from (`tbl_penjualan` `a` join `daftar_produk_beli` `b` on((`a`.`id_penjualan` = `b`.`Id_penjualan`))) group by `a`.`id_penjualan` order by `a`.`waktu_penjualan` desc;

CREATE VIEW `laporan_pemasukan` AS select `a`.`waktu_penjualan` AS `waktu_penjualan`,`b`.`Id_penjualan` AS `Id_penjualan`,`b`.`Nama_produk` AS `Nama_produk`,`b`.`Jumlah` AS `Jumlah`,`b`.`Total_Harga` AS `Total_Harga` from (`daftar_produk_beli` `b` join `tbl_penjualan` `a` on((`a`.`id_penjualan` = `b`.`Id_penjualan`)));

CREATE VIEW `lap_harian` AS select `laporan_pemasukan`.`waktu_penjualan` AS `waktu_penjualan`,`laporan_pemasukan`.`Nama_produk` AS `Nama_produk`,sum(`laporan_pemasukan`.`Jumlah`) AS `Jumlah`,sum(`laporan_pemasukan`.`Total_Harga`) AS `Total_Harga` from `laporan_pemasukan` where date(`laporan_pemasukan`.`waktu_penjualan`) = date(now()) group by `laporan_pemasukan`.`Nama_produk`;

CREATE VIEW `lap_bulanan` AS select dayofmonth(`laporan_pemasukan`.`waktu_penjualan`) AS `hari`,sum(`laporan_pemasukan`.`Jumlah`) AS `Jumlah`,sum(`laporan_pemasukan`.`Total_Harga`) AS `Total_Harga` from `laporan_pemasukan` where ((month(`laporan_pemasukan`.`waktu_penjualan`) = month(now())) and (year(`laporan_pemasukan`.`waktu_penjualan`) = year(now()))) group by dayofmonth(`laporan_pemasukan`.`waktu_penjualan`);

CREATE VIEW `lap_tahunan` AS select month(`laporan_pemasukan`.`waktu_penjualan`) AS `bulan`,sum(`laporan_pemasukan`.`Jumlah`) AS `Jumlah`,sum(`laporan_pemasukan`.`Total_Harga`) AS `Total_Harga` from `laporan_pemasukan` where (year(`laporan_pemasukan`.`waktu_penjualan`) = year(now())) group by month(`laporan_pemasukan`.`waktu_penjualan`);
