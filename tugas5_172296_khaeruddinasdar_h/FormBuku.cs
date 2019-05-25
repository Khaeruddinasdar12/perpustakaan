
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;

namespace tugas5_172296_khaeruddinasdar_h
{
	public partial class FormBuku : Form
	{
		MySqlDataReader	dr;
		MySqlCommand query;
		Koneksi sambung;
		MySqlDataAdapter adapter;
		String sql;
		
		public FormBuku()
		{
			InitializeComponent();
			TampilDalamTable();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			 try {  
			        OpenFileDialog openFileDialog1 = new OpenFileDialog();  
			        openFileDialog1.Filter = "Image files | *.png";  
			        if (openFileDialog1.ShowDialog() == DialogResult.OK)  
			        { 
			            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);  
			        }  
			  } catch (Exception ex) {  
			        MessageBox.Show(ex.Message);  
			  } 
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
	
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			sambung = new Koneksi();
			MemoryStream ms = new MemoryStream();
			pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
			byte[] photo = new byte[ms.Length];
			ms.Position = 0;
			ms.Read(photo, 0, photo.Length);
			sql = "INSERT INTO buku (kode_buku, kode_kategori, judul, jumlah, stock, pengarang, penerbit, tahun_terbit, " +
				"tahun_pengadaan, sumber, rak, ISBN, foto, last_update, userid) " +
				"VALUES ('"+textBox1.Text+"', '"+comboBox1.SelectedItem+"', '"+textBox3.Text+"', "+numericUpDown1.Value+", "+textBox4.Text+", '"+textBox5.Text+"', '"+textBox6.Text+"', '"+comboBox2.SelectedItem+"', '"+comboBox3.SelectedItem+"', " +
				"'"+textBox7.Text+"', '"+textBox8.Text+"', '"+textBox9.Text+"', '"+photo+"', NOW(), 1)";
			
			try{
				sambung.buka();
				query 	= new MySqlCommand(sql, sambung.koneksi);
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
		void FormBukuLoad(object sender, EventArgs e)
		{
			tahun_pengadaan();
			tahun_terbit();
			kode_kategori();
			
		}
		
		public void TampilDalamTable()
		{
			ViewData tampilkan = new ViewData();
			DataTable tabel = new DataTable();
			
			tabel = tampilkan.databuku();
			dataGridView1.DataSource =tabel;
		}
		
		void tahun_pengadaan()
		{
			comboBox3.Items.Add("2010");
			comboBox3.Items.Add("2011");
			comboBox3.Items.Add("2012");
			comboBox3.Items.Add("2013");
			comboBox3.Items.Add("2014");
			comboBox3.Items.Add("2015");
			comboBox3.Items.Add("2016");
			comboBox3.Items.Add("2017");
			comboBox3.Items.Add("2018");
			comboBox3.Items.Add("2019");
			comboBox3.Items.Add("2020");
		}
		
		void tahun_terbit()
		{
			comboBox2.Items.Add("2010");
			comboBox2.Items.Add("2011");
			comboBox2.Items.Add("2012");
			comboBox2.Items.Add("2013");
			comboBox2.Items.Add("2014");
			comboBox2.Items.Add("2015");
			comboBox2.Items.Add("2016");
			comboBox2.Items.Add("2017");
			comboBox2.Items.Add("2018");
			comboBox2.Items.Add("2019");
			comboBox2.Items.Add("2020");
		}
		
		void kode_kategori()
		{
			sambung = new Koneksi();
			sql = "SELECT kode_kategori FROM kategori_buku";
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
		void TextBox10TextChanged(object sender, EventArgs e)
		{
			string nama 	= textBox10.Text.ToString();
			ViewCari cari 	= new ViewCari();
			DataTable tabel = new DataTable();
			
			tabel = cari.cari_databuku(nama);
			dataGridView1.DataSource = tabel;
		}
		void NumericUpDown1ValueChanged(object sender, EventArgs e)
		{
			textBox4.Text = numericUpDown1.Value.ToString();
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			sambung = new Koneksi();
			sql = "SELECT nama FROM kategori_buku where kode_kategori ='"+comboBox1.SelectedItem+"' ";
			try{
					sambung.buka();
					query = new MySqlCommand(sql, sambung.koneksi);
					adapter = new MySqlDataAdapter(query);
					dr = query.ExecuteReader();
					 
					dr.Read();
					textBox2.Text = dr[0].ToString();
					 
					sambung.tutup();
				} catch(Exception er) {
					MessageBox.Show(er.Message);
				}
		}
		void Button6Click(object sender, EventArgs e)
		{
			textBox10.Clear();
			TampilDalamTable();
		}
		
		void bersihkan()
		{
			textBox1.Clear();
			comboBox1.Text ="";
			textBox2.Clear();
			textBox3.Clear();
			numericUpDown1.Value = 0;
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();textBox7.Clear();textBox8.Clear();
			comboBox2.Text = "";
			comboBox3.Text = "";
		}
		void Button4Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
