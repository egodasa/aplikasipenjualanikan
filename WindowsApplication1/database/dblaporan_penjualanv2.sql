DROP TABLE IF EXISTS `tbl_detail_pembelian`;
CREATE TABLE `tbl_detail_pembelian` (
  `id_dpembelian` int(11) NOT NULL AUTO_INCREMENT,
  `id_pembelian` varchar(50) NOT NULL,
  `id_produk` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `harga_satuan` decimal(10,2) NOT NULL,
  `total_harga` decimal(10,2) NOT NULL,
  `id_pemasok` int(11) NOT NULL,
  PRIMARY KEY (`id_dpembelian`),
  KEY `id_pembelian` (`id_pembelian`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TRIGGER `tambah_stok_beli` AFTER INSERT ON `tbl_detail_pembelian` FOR EACH ROW update tbl_produk set stok = stok + NEW.jumlah where id_produk = NEW.id_produk;

CREATE TRIGGER `kurang_stok_beli` AFTER DELETE ON `tbl_detail_pembelian` FOR EACH ROW update tbl_produk set stok = stok - OLD.jumlah where id_produk = OLD.id_produk;

DROP TABLE IF EXISTS `tbl_detail_transaksi`;
CREATE TABLE `tbl_detail_transaksi` (
  `id_dtransaksi` int(11) NOT NULL AUTO_INCREMENT,
  `id_dpembelian` int(11) NOT NULL,
  `id_produk` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `harga_jual` decimal(10,2) NOT NULL,
  `id_transaksi` varchar(50) NOT NULL,
  PRIMARY KEY (`id_dtransaksi`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TRIGGER `kurangi_stok` AFTER INSERT ON `tbl_detail_transaksi` FOR EACH ROW update tbl_produk set stok = stok - new.jumlah where id_produk = new.id_produk;

CREATE TRIGGER `reset_stok` AFTER DELETE ON `tbl_detail_transaksi` FOR EACH ROW update tbl_produk set stok = stok + OLD.jumlah where id_produk = OLD.id_produk;

DROP TABLE IF EXISTS `tbl_pemasok`;
CREATE TABLE `tbl_pemasok` (
  `id_pemasok` int(11) NOT NULL AUTO_INCREMENT,
  `nm_pemasok` varchar(100) NOT NULL,
  `no_telpon` varchar(20) NOT NULL,
  `alamat` varchar(200) NOT NULL,
  PRIMARY KEY (`id_pemasok`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `tbl_pembelian`;
CREATE TABLE `tbl_pembelian` (
  `id_pembelian` varchar(50) NOT NULL,
  `tgl_pembelian` date NOT NULL,
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


DROP TABLE IF EXISTS `tbl_produk`;
CREATE TABLE `tbl_produk` (
  `id_produk` int(11) NOT NULL AUTO_INCREMENT,
  `nm_produk` varchar(50) NOT NULL,
  `stok` int(11) NOT NULL,
  `status` enum('Aktif','Tidak Aktif') NOT NULL DEFAULT 'Aktif',
  `harga_produk` decimal(10,2) NOT NULL,
  `id_sat_produk` int(11) NOT NULL DEFAULT '25',
  PRIMARY KEY (`id_produk`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `tbl_satuan`;
CREATE TABLE `tbl_satuan` (
  `id_sat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_sat` varchar(30) NOT NULL,
  PRIMARY KEY (`id_sat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `tbl_transaksi`;
CREATE TABLE `tbl_transaksi` (
  `id_transaksi` varchar(50) NOT NULL,
  `tgl_transaksi` date NOT NULL,
  PRIMARY KEY (`id_transaksi`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS `tbl_pengguna`;
CREATE TABLE `tbl_pengguna` (
  `id_pengguna` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(15) NOT NULL,
  `password` text NOT NULL,
  `nm_lengkap` varchar(100) NOT NULL,
  `jenis` enum('Admin','Karyawan','Pemilik') NOT NULL,
  PRIMARY KEY (`id_pengguna`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_pengguna` (`username`,`password`,`nm_lengkap`,`jenis`) VALUES ('admin',md5('admin'),'admin','Admin');
INSERT INTO `tbl_pengguna` (`username`,`password`,`nm_lengkap`,`jenis`) VALUES ('pemilik',md5('pemilik'),'pemilik','Pemilik');
INSERT INTO `tbl_pengguna` (`username`,`password`,`nm_lengkap`,`jenis`) VALUES ('karyawan',md5('karyawan'),'karyawan','Karyawan');

DROP VIEW IF EXISTS `daftar_satuan`;
CREATE VIEW `daftar_satuan` AS select `a`.`id_sat` AS `Id_Sat`,`a`.`nm_sat` AS `Nama_Satuan` from `tbl_satuan` `a`;

DROP VIEW IF EXISTS `laporan_pemasok`;
CREATE VIEW `laporan_pemasok` AS select `tbl_pemasok`.`id_pemasok` AS `id_pemasok`,`tbl_pemasok`.`nm_pemasok` AS `Nama_Pemasok`,`tbl_pemasok`.`alamat` AS `Alamat`,`tbl_pemasok`.`no_telpon` AS `Nomor_Telepon` from `tbl_pemasok`;

DROP VIEW IF EXISTS `daftar_produk`;
CREATE VIEW `daftar_produk` AS select `a`.`id_produk` AS `Id_Produk`,`a`.`nm_produk` AS `Nama_Produk`,`a`.`harga_produk` AS `Harga_Produk`,`a`.`stok` AS `Stok`,`a`.`id_sat_produk` AS `Id_Sat_Produk`,`c`.`Nama_Satuan` AS `Satuan` from (`tbl_produk` `a` join `daftar_satuan` `c` on((`a`.`id_sat_produk` = `c`.`Id_Sat`)));

DROP VIEW IF EXISTS `daftar_produk_beli`;
CREATE VIEW `daftar_produk_beli` AS select `a`.`id_transaksi` AS `Id_Transaksi`,`a`.`id_produk` AS `Id_Produk`,`b`.`nm_produk` AS `Nama_Produk`,sum(`a`.`jumlah`) AS `Jumlah` from (`tbl_detail_transaksi` `a` join `tbl_produk` `b` on((`a`.`id_produk` = `b`.`id_produk`))) group by `a`.`id_transaksi`,`a`.`id_produk`;

DROP VIEW IF EXISTS `laporan_detail_pembelian`;
CREATE VIEW `laporan_detail_pembelian` AS select `a`.`id_produk` AS `id_produk`,`a`.`id_dpembelian` AS `id_dpembelian`,`d`.`tgl_pembelian` AS `tgl_pembelian`,`a`.`id_pemasok` AS `id_pemasok`,`a`.`id_pembelian` AS `id_pembelian`,`b`.`Nama_Produk` AS `Nama_Produk`,`a`.`jumlah` AS `jumlah`,`a`.`harga_satuan` AS `harga_satuan`,`a`.`total_harga` AS `total_harga`,`b`.`Satuan` AS `Satuan`,`c`.`Nama_Pemasok` AS `Nama_Pemasok` from (((`tbl_detail_pembelian` `a` join `daftar_produk` `b` on((`a`.`id_produk` = `b`.`Id_Produk`))) join `laporan_pemasok` `c` on((`a`.`id_pemasok` = `c`.`id_pemasok`))) left join `tbl_pembelian` `d` on((`a`.`id_pembelian` = `d`.`id_pembelian`)));

DROP VIEW IF EXISTS `laporan_detail_transaksi`;
CREATE VIEW `laporan_detail_transaksi` AS select `a`.`id_dtransaksi` AS `id_dtransaksi`,`a`.`id_dpembelian` AS `id_dpembelian`,`a`.`id_transaksi` AS `Id_Transaksi`,`a`.`id_produk` AS `Id_Produk`,`b`.`Nama_Produk` AS `Nama_Produk`,`a`.`harga_jual` AS `Harga_Jual`,`a`.`jumlah` AS `Jumlah`,(`a`.`harga_jual` * `a`.`jumlah`) AS `Total_Harga`,`b`.`Satuan` AS `Satuan` from (`tbl_detail_transaksi` `a` join `daftar_produk` `b` on((`a`.`id_produk` = `b`.`Id_Produk`)));

DROP VIEW IF EXISTS `daftar_pembelian`;
CREATE VIEW `daftar_pembelian` AS select `b`.`id_pembelian` AS `Id_Pembelian`,date_format(`a`.`tgl_pembelian`,'%d-%M-%Y') AS `Tanggal_Pembelian`,sum(`b`.`total_harga`) AS `total_harga` from (`tbl_pembelian` `a` join `laporan_detail_pembelian` `b` on((`a`.`id_pembelian` = `b`.`id_pembelian`))) group by `a`.`id_pembelian` order by `a`.`tgl_pembelian` desc;

DROP VIEW IF EXISTS `daftar_transaksi`;
CREATE VIEW `daftar_transaksi` AS select `b`.`Id_Transaksi` AS `Id_Transaksi`,date_format(`a`.`tgl_transaksi`,'%d-%M-%Y') AS `Tanggal_Transaksi`,sum(`b`.`Total_Harga`) AS `Total_Harga` from (`tbl_transaksi` `a` join `laporan_detail_transaksi` `b` on((`a`.`id_transaksi` = `b`.`Id_Transaksi`))) group by `a`.`id_transaksi` order by `a`.`tgl_transaksi` desc;

DROP VIEW IF EXISTS `detail_pembelian`;
CREATE VIEW `detail_pembelian` AS select concat('Rp ',`b`.`harga_satuan`,'/satuan, Tanggal ',date_format(`a`.`tgl_pembelian`,'%d %M %Y'),' sebanyak ',`b`.`jumlah`,' ',`b`.`Satuan`) AS `keterangan`,`b`.`id_dpembelian` AS `id_dpembelian`,`b`.`id_produk` AS `id_produk` from (`tbl_pembelian` `a` join `laporan_detail_pembelian` `b` on((`a`.`id_pembelian` = `b`.`id_pembelian`)));

DROP VIEW IF EXISTS `laporan_laba_rugi`;
CREATE VIEW `laporan_laba_rugi` AS select `a`.`Id_Transaksi` AS `id_transaksi`,`b`.`id_pembelian` AS `id_pembelian`,`a`.`Id_Produk` AS `id_produk`,`a`.`Nama_Produk` AS `Nama_Produk`,`a`.`Jumlah` AS `jumlah`,`a`.`Harga_Jual` AS `harga_jual`,`b`.`harga_satuan` AS `harga_beli`,`c`.`tgl_transaksi` AS `tgl_jual`,`b`.`tgl_pembelian` AS `tgl_pembelian`,((`a`.`Harga_Jual` - `b`.`harga_satuan`) * `a`.`Jumlah`) AS `laba/rugi` from (`tbl_transaksi` `c` left join (`laporan_detail_transaksi` `a` join `laporan_detail_pembelian` `b` on((`a`.`id_dpembelian` = `b`.`id_dpembelian`))) on((`a`.`Id_Transaksi` = `c`.`id_transaksi`)));
