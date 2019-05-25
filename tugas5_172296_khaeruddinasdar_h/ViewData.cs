﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace tugas5_172296_khaeruddinasdar_h
{	
	public class ViewData
	{
		MySqlCommand query;
		Koneksi sambung;
		MySqlDataAdapter adapter;
		String sql;
		DataTable tabel;
		
		public DataTable bacasemua()
		{
			sambung = new Koneksi();
			sql		= "Select * From Mahasiswa";
			tabel 	= new DataTable();
			
			try {
				sambung.buka();
				query 	= new MySqlCommand(sql, sambung.koneksi);
				adapter = new MySqlDataAdapter(query);
				query.ExecuteNonQuery();
				adapter.Fill(tabel);
			} catch(Exception er) {
				MessageBox.Show(er.Message);
			}
			sambung.tutup();
			return tabel;
		}
		
		public DataTable biodata()
		{
			sambung = new Koneksi();
			sql		= "SELECT biodata_mahasiswa.stb, biodata_mahasiswa.nama, program_studi.nama as prodi, " +
				"agama.nama as agama, biodata_mahasiswa.tempat_lahir, biodata_mahasiswa.tanggal_lahir, " +
				"biodata_mahasiswa.jenis_kelamin, biodata_mahasiswa.alamat, biodata_mahasiswa.kota, " +
				"propinsi.nama as provinsi, biodata_mahasiswa.kode_pos, biodata_mahasiswa.telpon, " +
				"biodata_mahasiswa.handphone, biodata_mahasiswa.hobi, biodata_mahasiswa.wali, " +
				"biodata_mahasiswa.alamat_wali, biodata_mahasiswa.telpon_wali, biodata_mahasiswa.tahun_masuk " +
				"from biodata_mahasiswa inner join program_studi on biodata_mahasiswa.kode_program_studi = program_studi.kode_prodi " +
				"INNER join agama on agama.kode_agama = biodata_mahasiswa.kode_agama " +
				"INNER JOIN propinsi on propinsi.kode_propinsi = biodata_mahasiswa.kode_propinsi";
			tabel 	= new DataTable();
			
			try {
				sambung.buka();
				query 	= new MySqlCommand(sql, sambung.koneksi);
				adapter = new MySqlDataAdapter(query);
				query.ExecuteNonQuery();
				adapter.Fill(tabel);
			} catch(Exception er) {
				MessageBox.Show(er.Message);
			}
			sambung.tutup();
			return tabel;
		}
		
		public DataTable anggota_perpustakaan()
		{
			sambung = new Koneksi();
			sql		= "Select anggota_perpustakaan.nomor, biodata_mahasiswa.nama, anggota_perpustakaan.tanggal_masuk " +
					"From anggota_perpustakaan inner join biodata_mahasiswa " +
					"on anggota_perpustakaan.nomor = biodata_mahasiswa.stb";
			tabel 	= new DataTable();
			
			try {
				sambung.buka();
				query 	= new MySqlCommand(sql, sambung.koneksi);
				adapter = new MySqlDataAdapter(query);
				query.ExecuteNonQuery();
				adapter.Fill(tabel);
			} catch(Exception er) {
				MessageBox.Show(er.Message);
			}
			sambung.tutup();
			return tabel;
		}
		
		public DataTable peminjaman()
		{
			sambung = new Koneksi();
			sql		= "Select peminjaman_buku.nomor_anggota, biodata_mahasiswa.nama,buku.kode_buku ,buku.judul, peminjaman_buku.tanggal_peminjaman " +
					"From peminjaman_buku " +
					"inner join biodata_mahasiswa on peminjaman_buku.nomor_anggota = biodata_mahasiswa.stb " +
					"inner join buku on peminjaman_buku.kode_buku= buku.kode_buku " +
					"where peminjaman_buku.tanggal_pengembalian is null";
			tabel 	= new DataTable();
			
			try {
				sambung.buka();
				query 	= new MySqlCommand(sql, sambung.koneksi);
				adapter = new MySqlDataAdapter(query);
				query.ExecuteNonQuery();
				adapter.Fill(tabel);
			} catch(Exception er) {
				MessageBox.Show(er.Message);
			}
			sambung.tutup();
			return tabel;
		}
		
		public DataTable pengembalian()
		{
			sambung = new Koneksi();
			sql		= "Select peminjaman_buku.nomor_anggota, biodata_mahasiswa.nama,buku.kode_buku , " +
					"buku.judul, peminjaman_buku.tanggal_peminjaman, peminjaman_buku.tanggal_pengembalian," +
					"peminjaman_buku.denda " +
					"From peminjaman_buku " +
					"inner join biodata_mahasiswa on peminjaman_buku.nomor_anggota = biodata_mahasiswa.stb " +
					"inner join buku on peminjaman_buku.kode_buku= buku.kode_buku " +
					"where peminjaman_buku.tanggal_pengembalian is not null";
			tabel 	= new DataTable();
			
			try {
				sambung.buka();
				query 	= new MySqlCommand(sql, sambung.koneksi);
				adapter = new MySqlDataAdapter(query);
				query.ExecuteNonQuery();
				adapter.Fill(tabel);
			} catch(Exception er) {
				MessageBox.Show(er.Message);
			}
			sambung.tutup();
			return tabel;
		}
		
		public DataTable databuku()
		{
			sambung = new Koneksi();
			sql		= "Select buku.kode_buku, kategori_buku.nama, buku.judul, buku.jumlah, " +
				"buku.stock, buku.pengarang, buku.penerbit, buku.tahun_terbit, buku.tahun_pengadaan, " +
				"buku.sumber, buku.rak, buku.ISBN, buku.foto from buku " +
				"inner join kategori_buku on kategori_buku.kode_kategori = buku.kode_kategori ";
			tabel 	= new DataTable();
			
			try {
				sambung.buka();
				query 	= new MySqlCommand(sql, sambung.koneksi);
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
