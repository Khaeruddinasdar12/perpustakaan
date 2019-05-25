
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace tugas5_no1_172296_khaeruddinasdar_h
{
	public partial class Anggota_perpustakaan : Form
	{
		MySqlCommand query;
		Koneksi sambung;
		MySqlDataAdapter adapter;
		String sql;
		MySqlDataReader	dr;
		MySqlDataReader	cek;
		
		public Anggota_perpustakaan()
		{
			InitializeComponent();
			TampilDalamTable();
		}
		public void TampilDalamTable()
		{
			ViewData tampilkan = new ViewData();
			DataTable tabel = new DataTable();
			
			tabel = tampilkan.anggota_perpustakaan();
			dataGridView1.DataSource =tabel;
		}
		void PeminjamanLoad(object sender, EventArgs e)
		{
	
		}
		void Label4Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			sambung = new Koneksi();
			
			sql = "INSERT INTO anggota_perpustakaan (nomor, tanggal_masuk, last_updated, userid)" +
				"VALUES ('"+stb.Text+"', NOW(), 'NULL', 1)";
			
			try{
				sambung.buka();
				query = new MySqlCommand(sql, sambung.koneksi);
				adapter = new MySqlDataAdapter(query);
				query.ExecuteNonQuery();
				MessageBox.Show("Data Berhasil Disimpan !!","information");
				
			} catch(Exception er) {
				MessageBox.Show(er.Message);
			}
			sambung.tutup();
		}
		void StbKeyPress(object sender, KeyPressEventArgs e)
		{
			sambung = new Koneksi();
			if(e.KeyChar == (char) Keys.Enter) {
				sql = "SELECT * FROM anggota_perpustakaan where nomor='"+stb.Text+"' ";
				try{
					sambung.buka();
					query 	= new MySqlCommand(sql, sambung.koneksi);
					adapter = new MySqlDataAdapter(query);
					dr = query.ExecuteReader();
					 
					if (dr.Read()) {
						MessageBox.Show("Data Sudah Ada", "information");
			            nama.Text = dr[2].ToString();
					} else {
						dr.Close();
						sql = "SELECT * FROM biodata_mahasiswa where stb='"+stb.Text+"' ";
						query 	= new MySqlCommand(sql, sambung.koneksi);
						adapter = new MySqlDataAdapter(query);
						cek = query.ExecuteReader();
						if(cek.Read()) {
							MessageBox.Show("Anda Tidak ", "information");
						} else {
							MessageBox.Show("Anda Tidak Terdaftar Sebagai Mahasiswa", "information");
						}
					 }
					sambung.tutup();
				} catch(Exception er) {
					MessageBox.Show(er.Message);
				}
			}
		}
	
	}
}
