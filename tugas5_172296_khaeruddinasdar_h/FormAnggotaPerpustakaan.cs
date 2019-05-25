using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
namespace tugas5_172296_khaeruddinasdar_h
{
	public partial class FormAnggotaPerpustakaan : Form
	{
		MySqlDataReader	dr;
		MySqlCommand query;
		Koneksi sambung;
		MySqlDataAdapter adapter;
		String sql;
		
		public FormAnggotaPerpustakaan()
		{
			InitializeComponent();
			TampilDalamTable();
		}
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{	
			sambung = new Koneksi();
			if(e.KeyChar == (char) Keys.Enter) {
				
				sql = 
					"select biodata_mahasiswa.nama from anggota_perpustakaan " +
					"inner join biodata_mahasiswa on biodata_mahasiswa.stb = anggota_perpustakaan.nomor " +
					"where anggota_perpustakaan.nomor ="+textBox1.Text;
				try{
					sambung.buka();
					query = new MySqlCommand(sql, sambung.koneksi);
					dr = query.ExecuteReader();
					
					if (dr.Read() == true ) {
						button1.Enabled = false;
							MessageBox.Show("Anda Telah Terdaftar sebagai Anggota");
							textBox2.Text = dr[0].ToString();
			            
					} else if (dr.Read() == false ) {
						sql = "select nama from biodata_mahasiswa where stb="+textBox1.Text;
						dr.Close();
						query = new MySqlCommand(sql, sambung.koneksi);
						dr = query.ExecuteReader();
						if(dr.Read() == true){
							button1.Enabled = true;
							MessageBox.Show("STB "+textBox1.Text+" Tidak Terdaftar sebagai Anggota");
							textBox2.Text = dr[0].ToString();
						} else {
							button1.Enabled = false;
							textBox2.Clear();
							MessageBox.Show("Anda Tidak Terdaftar sebagai Mahasiswa");
						}
						
					}
						
					sambung.tutup();
				} catch(Exception er) {
					MessageBox.Show(er.Message);
				}
			}
		}
		void FormAnggotaLoad(object sender, EventArgs e)
		{
			button1.Enabled = false;
		}
		void Button1Click(object sender, EventArgs e)
		{
			sambung = new Koneksi();
			sql = "insert into anggota_perpustakaan (nomor, tanggal_masuk,userid)" +
				"values ("+textBox1.Text+",'"+dateTimePicker1.Value.ToString("yyyyMMdd")+"',1)";
			try{
				sambung.buka();
				query = new MySqlCommand(sql, sambung.koneksi);
				adapter = new MySqlDataAdapter(query);
				query.ExecuteNonQuery();
				MessageBox.Show("Data Berhasil Disimpan !!","information");
				bersihkan();
				TampilDalamTable();
			} catch(Exception er) {
				MessageBox.Show(er.Message);
			}
			sambung.tutup();
		}
		
		public void bersihkan()
		{
			textBox1.Clear();
			textBox2.Clear();
			
		}
		
		public void TampilDalamTable()
		{
			ViewData tampilkan = new ViewData();
			DataTable tabel = new DataTable();
			
			tabel = tampilkan.anggota_perpustakaan();
			dataGridView1.DataSource =tabel;
		}
		void TextBox7TextChanged(object sender, EventArgs e)
		{
			string nama 	= textBox7.Text.ToString();
			ViewCari cari 	= new ViewCari();
			DataTable tabel = new DataTable();
			
			tabel = cari.tampilpencarian_anggota(nama);
			dataGridView1.DataSource = tabel;
		}
		void Button5Click(object sender, EventArgs e)
		{
			TampilDalamTable();
		}
		void Button4Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
