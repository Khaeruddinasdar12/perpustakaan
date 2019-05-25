
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace tugas5_no1_172296_khaeruddinasdar_h
{
	public partial class FormPeminjaman : Form
	{
		MySqlDataReader	dr;
		MySqlCommand query;
		Koneksi sambung;
		MySqlDataAdapter adapter;
		String sql, cek, updatestok;
		
		public FormPeminjaman()
		{
			InitializeComponent();
			TampilDalamTable();
		}
		
		public void nomor_anggota()
		{
			sambung = new Koneksi();
			sql = "SELECT nomor FROM anggota_perpustakaan";
			try{
					sambung.buka();
					query = new MySqlCommand(sql, sambung.koneksi);
					adapter = new MySqlDataAdapter(query);
					dr = query.ExecuteReader();
					 
					while (dr.Read()) {
						noAgt.Items.Add(dr[0].ToString()) ;
					 }
					sambung.tutup();
				} catch(Exception er) {
					MessageBox.Show(er.Message);
				}
		}
		
		public void kode_buku()
		{
			sambung = new Koneksi();
			sql = "SELECT kode_buku FROM buku where stock > 0";
			try{
					sambung.buka();
					query = new MySqlCommand(sql, sambung.koneksi);
					adapter = new MySqlDataAdapter(query);
					dr = query.ExecuteReader();
					 
					while (dr.Read()) {
						kodebuku.Items.Add(dr[0].ToString()) ;
					 }
					sambung.tutup();
				} catch(Exception er) {
					MessageBox.Show(er.Message);
				}
		}
		void FormPeminjamanLoad(object sender, EventArgs e)
		{
			nomor_anggota();
			kode_buku();
		}
		void NoAgtSelectedIndexChanged(object sender, EventArgs e)
		{
			sambung = new Koneksi();
			sql = "SELECT biodata_mahasiswa.nama FROM anggota_perpustakaan " +
				"inner join biodata_mahasiswa on anggota_perpustakaan.nomor = biodata_mahasiswa.stb " +
				"where anggota_perpustakaan.nomor ="+noAgt.SelectedItem;
			try{
					sambung.buka();
					query = new MySqlCommand(sql, sambung.koneksi);
					adapter = new MySqlDataAdapter(query);
					dr = query.ExecuteReader();
					 
					while (dr.Read()) {
						nomoragt.Text= dr[0].ToString() ;
					}
					sambung.tutup();
				} catch(Exception er) {
					MessageBox.Show(er.Message);
				}
		}
		
		void KodebukuSelectedIndexChanged(object sender, EventArgs e)
		{
			sambung = new Koneksi();
			sql = "SELECT judul, stock FROM buku where kode_buku ='"+kodebuku.SelectedItem+"' ";
			try{
					sambung.buka();
					query = new MySqlCommand(sql, sambung.koneksi);
					dr = query.ExecuteReader();
					 
					if (dr.Read()) {
						kdbuku.Text= dr[0].ToString() ;
						stok.Text= dr[1].ToString() ;
					 }
					sambung.tutup();
				} catch(Exception er) {
					MessageBox.Show(er.Message);
				}
		}
		void Button1Click(object sender, EventArgs e)
		{
			sambung = new Koneksi();
			cek = "SELECT COUNT(nomor_anggota) FROM `peminjaman_buku` WHERE nomor_anggota ="+noAgt.SelectedItem+ " " +
				"AND tanggal_pengembalian is NULL";
			try{
			sambung.buka();
			query = new MySqlCommand(cek, sambung.koneksi);
			dr = query.ExecuteReader();
			dr.Read();
			if (Convert.ToInt16(dr[0].ToString()) >= 3 ) {
				MessageBox.Show("Maksimum 3 peminjaman","information..!!");
			} else {
				dr.Close();
				cek = "SELECT COUNT(nomor_anggota) FROM `peminjaman_buku` WHERE nomor_anggota ="+noAgt.SelectedItem+ " " +
				"AND tanggal_pengembalian is NULL AND kode_buku = '"+kodebuku.SelectedItem+"'";
				query = new MySqlCommand(cek, sambung.koneksi);
				dr = query.ExecuteReader();
				dr.Read();
				if (Convert.ToInt16(dr[0].ToString()) >= 1) {
					MessageBox.Show("Buku Ini Telah Di pinjam Oleh Anggota Ini","information..!!");
				} else {
					dr.Close();
					sql = "insert into peminjaman_buku (nomor_anggota,kode_buku,tanggal_peminjaman,userid) " +
						"values("+noAgt.SelectedItem+", '"+kodebuku.SelectedItem+"', '"+dateTimePicker1.Value.ToString("yyyyMMdd")+"', 1)";
					query = new MySqlCommand(sql, sambung.koneksi);
					adapter = new MySqlDataAdapter(query);
					query.ExecuteNonQuery();
					
					updatestok = "update buku set stock = stock - 1";
					query = new MySqlCommand(updatestok, sambung.koneksi);
					adapter = new MySqlDataAdapter(query);
					query.ExecuteNonQuery();
					TampilDalamTable();
					bersihkan();
					
					MessageBox.Show("Data Berhasil Disimpan !!","information");
				}
			}
			
			} catch(Exception er) {
					MessageBox.Show(er.Message);
			}
			sambung.tutup();
		}
		
		public void TampilDalamTable()
		{
			ViewData tampilkan = new ViewData();
			DataTable tabel = new DataTable();
			
			tabel = tampilkan.peminjaman();
			dataGridView1.DataSource =tabel;
		}
		
		public void bersihkan()
		{
			noAgt.Text = "";
			kodebuku.Text= "";
			nomoragt.Clear();
			kdbuku.Clear();
			stok.Clear();
		}
		void Button5Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			TampilDalamTable();
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			string nomor 	= textBox1.Text.ToString();
			ViewCari cari 	= new ViewCari();
			DataTable tabel = new DataTable();
			
			tabel = cari.cari_peminjaman(nomor);
			dataGridView1.DataSource = tabel;
		}
		
	}
}
