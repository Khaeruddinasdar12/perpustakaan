using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace tugas5_172296_khaeruddinasdar_h
{
	public partial class FormOperationDML : Form
	{
		MySqlCommand query;
		Koneksi sambung;
		MySqlDataAdapter adapter;
		String sql;
		
		public FormOperationDML()
		{
			InitializeComponent();
			TampilDalamTable();
		}
		
		public void TampilDalamTable()
		{
			ViewData tampilkan = new ViewData();
			DataTable tabel = new DataTable();
			
			tabel = tampilkan.bacasemua();
			dataGridView1.DataSource =tabel;
		}
		
		void SimpanClick(object sender, EventArgs e)
		{
//			InputDataMhs inputdatamhs = new InputDataMhs();
//			inputdatamhs.ShowDialog();
			sambung = new Koneksi();
			sql = "INSERT INTO mahasiswa (stb, nama, alamat, nilai_tugas, nilai_mid, nilai_final, nilai_akhir, " +
				"nilai_huruf, keterangan) VALUES ('172298', 'Brian', 'Citra Sudiang Indah', 67, 87, 77, 87, 'A', " +
				"'Sangat Baik')";
			
			try{
				sambung.buka();
				query = new MySqlCommand(sql, sambung.koneksi);
				adapter = new MySqlDataAdapter(query);
				query.ExecuteNonQuery();
				MessageBox.Show("Data Berhasil Disimpan !!","information");
				TampilDalamTable();
				
			} catch(Exception er) {
				MessageBox.Show(er.Message);
			}
			sambung.tutup();
		}
		
		void EditClick(object sender, EventArgs e)
		{
			sambung = new Koneksi();
			sql = "UPDATE mahasiswa SET nama ='Mimi Amelia' where id=4 ";
			
			try{
				sambung.buka();
				query = new MySqlCommand(sql, sambung.koneksi);
				adapter = new MySqlDataAdapter(query);
				query.ExecuteNonQuery();
				MessageBox.Show("Data Berhasil Diubah !!","information");
				TampilDalamTable();
				
			} catch(Exception er) {
				MessageBox.Show(er.Message);
			}
			sambung.tutup();
		}
		
		void HapusClick(object sender, EventArgs e)
		{
			sambung = new Koneksi();
			sql = "DELETE FROM mahasiswa where id=7 ";
			
			try{
				sambung.buka();
				query = new MySqlCommand(sql, sambung.koneksi);
				adapter = new MySqlDataAdapter(query);
				query.ExecuteNonQuery();
				MessageBox.Show("Data Berhasil Dihapus !!","information");
//				dataGridView1.Refresh();
				TampilDalamTable();
				
			} catch(Exception er) {
				MessageBox.Show(er.Message);
			}
			sambung.tutup();
		}
		
		void CariClick(object sender, EventArgs e)
		{
			string nama 	= search.Text.ToString();
			ViewCari cari 	= new ViewCari();
			DataTable tabel = new DataTable();
			
			tabel = cari.tampilpencarian(nama);
			dataGridView1.DataSource = tabel;
		}
		
		void RefreshClick(object sender, EventArgs e)
		{
			TampilDalamTable();
		}
		
		void SearchTextChanged(object sender, EventArgs e)
		{
			string nama 	= search.Text.ToString();
			ViewCari cari 	= new ViewCari();
			DataTable tabel = new DataTable();
			
			tabel = cari.tampilpencarian(nama);
			dataGridView1.DataSource = tabel;
		}
	}
}
