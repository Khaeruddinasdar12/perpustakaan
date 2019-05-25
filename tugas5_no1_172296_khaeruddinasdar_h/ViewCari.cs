using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace tugas5_no1_172296_khaeruddinasdar_h
{
	public class ViewCari
	{
		MySqlCommand query;
		Koneksi sambung;
		MySqlDataAdapter adapter;
		String sql;
		DataTable tabel;
		
		public DataTable tampilpencarian(string cari)
		{
			sambung = new Koneksi();
			sql 	= "SELECT * FROM mahasiswa where nama LIKE '%"+cari+"%'";
			tabel 	= new DataTable();
			
			try {
				sambung.buka();
				query	= new MySqlCommand(sql, sambung.koneksi);
				adapter = new MySqlDataAdapter(query);
				query.ExecuteNonQuery();
				adapter.Fill(tabel);
			} catch(Exception er) {
				MessageBox.Show(er.Message);
			}
			sambung.tutup();
			return tabel;
		}
		
		public DataTable tampilpencarian_anggota(string cari)
		{
			sambung = new Koneksi();
			sql 	= "Select anggota_perpustakaan.nomor, biodata_mahasiswa.nama, anggota_perpustakaan.tanggal_masuk " +
					"From anggota_perpustakaan inner join biodata_mahasiswa " +
					"on anggota_perpustakaan.nomor = biodata_mahasiswa.stb " +
					"where anggota_perpustakaan.nomor LIKE '%"+cari+"%' ";
			tabel 	= new DataTable();
			
			try {
				sambung.buka();
				query	= new MySqlCommand(sql, sambung.koneksi);
				adapter = new MySqlDataAdapter(query);
				query.ExecuteNonQuery();
				adapter.Fill(tabel);
			} catch(Exception er) {
				MessageBox.Show(er.Message);
			}
			sambung.tutup();
			return tabel;
		}
		
		public DataTable cari_peminjaman(string cari)
		{
			sambung = new Koneksi();
			sql 	= "Select peminjaman_buku.nomor_anggota, biodata_mahasiswa.nama,buku.kode_buku ,buku.judul, peminjaman_buku.tanggal_peminjaman " +
					"From peminjaman_buku " +
					"inner join biodata_mahasiswa on peminjaman_buku.nomor_anggota = biodata_mahasiswa.stb " +
					"inner join buku on peminjaman_buku.kode_buku= buku.kode_buku " +
					"where peminjaman_buku.nomor_anggota LIKE '%"+cari+"%' or biodata_mahasiswa.nama LIKE '%"+cari+"%' ";
			tabel 	= new DataTable();
			
			try {
				sambung.buka();
				query	= new MySqlCommand(sql, sambung.koneksi);
				adapter = new MySqlDataAdapter(query);
				query.ExecuteNonQuery();
				adapter.Fill(tabel);
			} catch(Exception er) {
				MessageBox.Show(er.Message);
			}
			sambung.tutup();
			return tabel;
		}
		
		public DataTable cari_databuku(string cari)
		{
			sambung = new Koneksi();
			sql		= "Select buku.kode_buku, kategori_buku.nama, buku.judul, buku.jumlah, " +
				"buku.stock, buku.pengarang, buku.penerbit, buku.tahun_terbit, buku.tahun_pengadaan, " +
				"buku.sumber, buku.rak, buku.ISBN, buku.foto from buku " +
				"inner join kategori_buku on kategori_buku.kode_kategori = buku.kode_kategori " +
				"where buku.kode_buku LIKE '%"+cari+"%'" +
				"or buku.judul LIKE '%"+cari+"%' ";
			tabel 	= new DataTable();
			
			try {
				sambung.buka();
				query	= new MySqlCommand(sql, sambung.koneksi);
				adapter = new MySqlDataAdapter(query);
				query.ExecuteNonQuery();
				adapter.Fill(tabel);
			} catch(Exception er) {
				MessageBox.Show(er.Message);
			}
			sambung.tutup();
			return tabel;
		}
		
		public DataTable cari_pengembalian(string cari)
		{
			sambung = new Koneksi();
			sql 	= "Select peminjaman_buku.nomor_anggota, biodata_mahasiswa.nama,buku.kode_buku ,buku.judul, peminjaman_buku.tanggal_peminjaman, " +
					"peminjaman_buku.tanggal_pengembalian, peminjaman_buku.denda " +
					"From peminjaman_buku " +
					"inner join biodata_mahasiswa on peminjaman_buku.nomor_anggota = biodata_mahasiswa.stb " +
					"inner join buku on peminjaman_buku.kode_buku= buku.kode_buku " +
					"where (peminjaman_buku.nomor_anggota LIKE '%"+cari+"%' or biodata_mahasiswa.nama LIKE '%"+cari+"%') " +
					"and peminjaman_buku.tanggal_pengembalian is not null ";
			tabel 	= new DataTable();
			
			try {
				sambung.buka();
				query	= new MySqlCommand(sql, sambung.koneksi);
				adapter = new MySqlDataAdapter(query);
				query.ExecuteNonQuery();
				adapter.Fill(tabel);
			} catch(Exception er) {
				MessageBox.Show(er.Message);
			}
			sambung.tutup();
			return tabel;
		}
		
	}
	
	
	
	
}
