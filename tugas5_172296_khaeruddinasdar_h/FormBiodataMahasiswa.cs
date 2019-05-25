using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace tugas5_172296_khaeruddinasdar_h
{
	public partial class FormBiodataMahasiswa : Form
	{
		MySqlDataReader	dr;
		MySqlCommand query;
		Koneksi sambung;
		MySqlDataAdapter adapter;
		String sql;
		
		public FormBiodataMahasiswa()
		{
			InitializeComponent();
			TampilDalamTable();
		}
		
		public void kodeprodi()
		{
			sambung = new Koneksi();
			sql = "SELECT kode_prodi FROM program_studi";
			try{
					sambung.buka();
					query = new MySqlCommand(sql, sambung.koneksi);
					adapter = new MySqlDataAdapter(query);
					dr = query.ExecuteReader();
					 
					while (dr.Read()) {
						prodi.Items.Add(dr[0].ToString()) ;
					 }
					sambung.tutup();
				} catch(Exception er) {
					MessageBox.Show(er.Message);
				}
		}
		
		public void kodeagama()
		{
			sambung = new Koneksi();
			sql = "SELECT kode_agama FROM agama";
			try{
					sambung.buka();
					query = new MySqlCommand(sql, sambung.koneksi);
					adapter = new MySqlDataAdapter(query);
					dr = query.ExecuteReader();
					 
					while (dr.Read()) {
						agama.Items.Add(dr[0].ToString()) ;
					 }
					sambung.tutup();
				} catch(Exception er) {
					MessageBox.Show(er.Message);
				}
		}
		
		public void kodepropinsi()
		{
			sambung = new Koneksi();
			sql = "SELECT kode_propinsi FROM propinsi";
			try{
					sambung.buka();
					query = new MySqlCommand(sql, sambung.koneksi);
					adapter = new MySqlDataAdapter(query);
					dr = query.ExecuteReader();
					 
					while (dr.Read()) {
						propinsi.Items.Add(dr[0].ToString()) ;
					 }
					sambung.tutup();
				} catch(Exception er) {
					MessageBox.Show(er.Message);
				}
		}
		
		void FormOperationDMLJoinLoad(object sender, EventArgs e)
		{
			button1.Enabled =true;
			button2.Enabled = false;
			button3.Enabled = false;
			kodeprodi();
			kodeagama();
			kodepropinsi();
			tahunmasuk.Items.Add("2015") ;
			tahunmasuk.Items.Add("2016") ;
			tahunmasuk.Items.Add("2017") ;
			tahunmasuk.Items.Add("2018") ;
			tahunmasuk.Items.Add("2019") ;
			jkel.Items.Add("L") ;
			jkel.Items.Add("P") ;
		}
		
		void ProdiSelectedIndexChanged(object sender, EventArgs e)
		{
			sambung = new Koneksi();
			sql = "SELECT nama FROM program_studi where kode_prodi= '"+prodi.SelectedItem+"' ";
			try{
					sambung.buka();
					query = new MySqlCommand(sql, sambung.koneksi);
					adapter = new MySqlDataAdapter(query);
					dr = query.ExecuteReader();
					 
					while(dr.Read()) {
						tampilprodi.Text = dr[0].ToString() ;
					}
					
				} catch(Exception er) {
					MessageBox.Show(er.Message);
				}
			sambung.tutup();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			sambung = new Koneksi();
			
			sql = 	"INSERT INTO biodata_mahasiswa (stb, nama, kode_program_studi, kode_agama, tempat_lahir," +
					"tanggal_lahir, jenis_kelamin, alamat, kota, kode_propinsi, kode_pos, telpon," +
					"handphone, hobi, wali, alamat_wali, telpon_wali, tahun_masuk, userid) " +
				"VALUES ("+stb.Text+", " +
				"'"+nama.Text+"', " +
				"'"+prodi.SelectedItem+"', " +
				"'"+agama.SelectedItem+"', " +
				"'"+tempatlahir.Text+"', " +
				"'"+dateTimePicker1.Value.ToString("yyyyMMdd")+"', " +
				"'"+jkel.SelectedItem+"'," +
				"'"+alamat.Text+"', " +
				"'"+kota.Text+"', " +
				"'"+propinsi.SelectedItem+"' , " +
				"'"+kodepos.Text+"', " +
				"'"+telepon.Text+"', " +
				"'"+hp.Text+"', " +
				"'"+hobi.Text+"', " +
				"'"+wali.Text+"', " +
				"'"+alamatwali.Text+"', " +
				"'"+telwali.Text+"', " +
				" "+tahunmasuk.SelectedItem+", " +
				"  1 ) ";
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
		
		void bersihkan()
		{
			stb.ReadOnly = false;
			button1.Enabled=true;
			button2.Enabled=false;
			button3.Enabled=false;
			stb.Clear();
			nama.Clear();
			prodi.Text = "";
			agama.Text = "";
			jkel.Text = "";
			propinsi.Text = "";
			tampilagama.Clear();
			tampilprodi.Clear();
			tampiljkel.Clear();
			tampilpropinsi.Clear();
			tempatlahir.Clear();
			alamat.Clear();
			kota.Clear();
			kodepos.Clear();
			telepon.Clear();
			hp.Clear(); hobi.Clear();wali.Clear();alamatwali.Clear();
			telwali.Clear();tahunmasuk.Text="";
		}
		void Button5Click(object sender, EventArgs e)
		{
			textBox17.Clear();
			TampilDalamTable();
		}
		
		public void TampilDalamTable()
		{
			ViewData tampilkan = new ViewData();
			DataTable tabel = new DataTable();
			
			tabel = tampilkan.biodata();
			dataGridView1.DataSource =tabel;
		}
		void AgamaSelectedIndexChanged(object sender, EventArgs e)
		{
			sambung = new Koneksi();
			sql = "SELECT nama FROM agama where kode_agama='"+agama.SelectedItem+"' ";
			try{
					sambung.buka();
					query = new MySqlCommand(sql, sambung.koneksi);
					adapter = new MySqlDataAdapter(query);
					dr = query.ExecuteReader();
					 
					while(dr.Read()) {
						tampilagama.Text = dr[0].ToString() ;
					}
						
					sambung.tutup();
				} catch(Exception er) {
					MessageBox.Show(er.Message);
				}
		}
		
		void PropinsiSelectedIndexChanged(object sender, EventArgs e)
		{
			sambung = new Koneksi();
			sql = "SELECT nama FROM propinsi where kode_propinsi='"+propinsi.SelectedItem+"' ";
			try{
					sambung.buka();
					query = new MySqlCommand(sql, sambung.koneksi);
					adapter = new MySqlDataAdapter(query);
					dr = query.ExecuteReader();
					 
					while(dr.Read()) {
						tampilpropinsi.Text = dr[0].ToString() ;
					}
					sambung.tutup();
				} catch(Exception er) {
					MessageBox.Show(er.Message);
				}
		}
		void JkelSelectedIndexChanged(object sender, EventArgs e)
		{
			if(jkel.SelectedItem.ToString() == "L"){
				tampiljkel.Text = "Laki-laki";
			} else if(jkel.SelectedItem.ToString() == "P"){
				tampiljkel.Text = "Perempuan";
			}
		}
		void Button4Click(object sender, EventArgs e)
		{	
			this.Close();
		}
		
		void StbKeyPress(object sender, KeyPressEventArgs e)
		{
			sambung = new Koneksi();
			if(e.KeyChar == (char) Keys.Enter) {
				sql = "SELECT * FROM biodata_mahasiswa where stb="+stb.Text ;
				try{
					sambung.buka();
					query = new MySqlCommand(sql, sambung.koneksi);
					adapter = new MySqlDataAdapter(query);
					dr = query.ExecuteReader();
					if (dr.Read() ) {
						MessageBox.Show("Data Sudah Ada", "information");
						stb.Text = dr["stb"].ToString();
						nama.Text = dr["nama"].ToString();
						prodi.Text = dr["kode_program_studi"].ToString();
						agama.Text= dr["kode_agama"].ToString();
						tempatlahir.Text = dr["tempat_lahir"].ToString();
						dateTimePicker1.Text = dr["tanggal_lahir"].ToString();
						jkel.Text = dr["jenis_kelamin"].ToString();
						alamat.Text = dr["alamat"].ToString();
						kota.Text = dr["kota"].ToString();
						propinsi.Text = dr["kode_propinsi"].ToString();
						kodepos.Text = dr["kode_pos"].ToString();
						telepon.Text = dr["telpon"].ToString();
						hp.Text = dr["handphone"].ToString();
						hobi.Text = dr["hobi"].ToString();
						wali.Text = dr["wali"].ToString();
						alamatwali.Text = dr["alamat_wali"].ToString();
						telwali.Text = dr["telpon_wali"].ToString();
						tahunmasuk.Text = dr["tahun_masuk"].ToString();
						button2.Enabled = true;
						button3.Enabled = true;
						button1.Enabled = false;
						stb.ReadOnly = true;
					 } else {
						nama.Select();
						button1.Enabled = true;
						
					 }
					sambung.tutup();
				} catch(Exception er) {
					MessageBox.Show(er.Message);
				}
			}
		}
		void TextBox17TextChanged(object sender, EventArgs e)
		{
			string nama 	= textBox17.Text.ToString();
			ViewCari cari 	= new ViewCari();
			DataTable tabel = new DataTable();
			
			tabel = cari.carimahasiswa(nama);
			dataGridView1.DataSource = tabel;
		}
		void Button6Click(object sender, EventArgs e)
		{
			bersihkan();
		}
		void Button3Click(object sender, EventArgs e)
		{
			sambung = new Koneksi();
			sql = "DELETE FROM biodata_mahasiswa where stb='"+stb.Text+"' ";
			
			try{
				sambung.buka();
				query = new MySqlCommand(sql, sambung.koneksi);
				adapter = new MySqlDataAdapter(query);
				query.ExecuteNonQuery();
				MessageBox.Show("Data Berhasil Dihapus !!","information");
				bersihkan();
				TampilDalamTable();
			} catch(Exception er) {
				MessageBox.Show(er.Message);
			}
			sambung.tutup();
		}
	}
}
