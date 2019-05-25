
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace tugas5_172296_khaeruddinasdar_h
{
	public partial class FormPengembalian : Form
	{
		MySqlDataReader	dr;
		MySqlCommand query;
		Koneksi sambung;
		MySqlDataAdapter adapter;
		String sql;
		
		public FormPengembalian()
		{
			InitializeComponent();
			TampilDalamTable();
		}
		void FormPengembalianLoad(object sender, EventArgs e)
		{
			nomor_anggota();
			
		}
		
		public void nomor_anggota()
		{
			sambung = new Koneksi();
			sql = "SELECT distinct nomor_anggota FROM peminjaman_buku where tanggal_pengembalian is Null ";
			try{
					sambung.buka();
					query = new MySqlCommand(sql, sambung.koneksi);
					adapter = new MySqlDataAdapter(query);
					dr = query.ExecuteReader();
					 
					while (dr.Read()) {
						comboBox1.Items.Add(dr[0].ToString()) ;
					}
					sambung.tutup();
			} catch(Exception er) {
					MessageBox.Show(er.Message);
			}
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			sambung = new Koneksi();
			comboBox2.Items.Clear();
			comboBox2.Text = "";
			textBox2.Clear();
			kode_buku();
			sql = "SELECT nama from biodata_mahasiswa where stb = '"+comboBox1.SelectedItem+"' ";
			try{
					sambung.buka();
					query = new MySqlCommand(sql, sambung.koneksi);
					dr = query.ExecuteReader();
					 
					if (dr.Read()) {
						textBox1.Text= dr[0].ToString() ;
						
					 }
					sambung.tutup();
				} catch(Exception er) {
					MessageBox.Show(er.Message);
				}
		}
		
		public void kode_buku()
		{
			sambung = new Koneksi();
			sql = "SELECT kode_buku from peminjaman_buku where nomor_anggota = "+comboBox1.SelectedItem+" AND tanggal_pengembalian is NULL" ;
			try{
					sambung.buka();
					query = new MySqlCommand(sql, sambung.koneksi);
					adapter = new MySqlDataAdapter(query);
					dr = query.ExecuteReader();
					 
					while (dr.Read()) {
						comboBox2.Items.Add(dr[0].ToString()) ;
					 }
					sambung.tutup();
				} catch(Exception er) {
					MessageBox.Show(er.Message);
				}
		}
		
		void ComboBox2SelectedIndexChanged(object sender, EventArgs e)
		{
			sambung = new Koneksi();
			sql = "SELECT buku.judul, peminjaman_buku.tanggal_peminjaman FROM peminjaman_buku " +
				"inner join buku on buku.kode_buku = peminjaman_buku.kode_buku " +
				"where nomor_anggota ="+comboBox1.SelectedItem+" and peminjaman_buku.kode_buku = '"+comboBox2.SelectedItem+"' " +
				"and peminjaman_buku.tanggal_pengembalian is null";
			try{
					sambung.buka();
					query = new MySqlCommand(sql, sambung.koneksi);
					dr = query.ExecuteReader();
					 
					if (dr.Read()) {
						textBox2.Text= dr[0].ToString() ;
						dateTimePicker1.Text= dr[1].ToString();
					 }
					sambung.tutup();
				} catch(Exception er) {
					MessageBox.Show(er.Message);
				}
		}
		void DateTimePicker2ValueChanged(object sender, EventArgs e)
		{
			
			Double hasil, keterlambatan, denda;
			DateTime tanggal1 = Convert.ToDateTime(dateTimePicker1.Text);
			DateTime tanggal2 = Convert.ToDateTime(dateTimePicker2.Text);
			TimeSpan ts = new TimeSpan();
			ts = tanggal2.Subtract(tanggal1);
			hasil = ts.TotalDays;
			
			if (hasil > 7) {
				keterlambatan = hasil - 7 ;
				textBox4.Text = keterlambatan.ToString();
				denda = keterlambatan * 1000;
				textBox3.Text = denda.ToString();
			} else {
				keterlambatan = 0 ;
				textBox4.Text = keterlambatan.ToString();
				denda = 0;
				textBox3.Text = denda.ToString();
			}
		}
		
		public void TampilDalamTable()
		{
			ViewData tampilkan = new ViewData();
			DataTable tabel = new DataTable();
			
			tabel = tampilkan.pengembalian();
			dataGridView1.DataSource =tabel;
		}
		void TextBox5TextChanged(object sender, EventArgs e)
		{
			string nomor 	= textBox5.Text.ToString();
			ViewCari cari 	= new ViewCari();
			DataTable tabel = new DataTable();
			
			tabel = cari.cari_pengembalian(nomor);
			dataGridView1.DataSource = tabel;
		}
		void Button1Click(object sender, EventArgs e)
		{
	
		}
		void Button4Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
