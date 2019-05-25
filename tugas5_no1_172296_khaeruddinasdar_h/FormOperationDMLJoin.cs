
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tugas5_no1_172296_khaeruddinasdar_h
{
	public partial class FormOperationDMLJoin : Form
	{
		MySqlDataReader	dr;
		MySqlCommand query;
		Koneksi sambung;
		MySqlDataAdapter adapter;
		String sql;
		
		public FormOperationDMLJoin()
		{
			InitializeComponent();
		}
		
		public void kodeprodi()
		{
			sambung = new Koneksi();
			sql = "SELECT id FROM program_studi";
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
			sql = "SELECT id FROM agama";
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
			sql = "SELECT id FROM propinsi";
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
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			sambung = new Koneksi();
			
			sql = 	"INSERT INTO biodata_mahasiswa (stb, nama, kode_program_studi, kode_agama, tempat_lahir," +
					"tanggal_lahir, jenis_kelamin, alamat, kota, kode_propinsi, kode_pos, telpon," +
					"handphone, hobi, wali, alamat_wali, telpon_wali, tahun_masuk, userid) " +
				"VALUES ("+stb.Text+", " +
				"'"+nama.Text+"', " +
				" "+prodi.SelectedItem+", " +
				" "+agama.SelectedItem+", " +
				"'"+tempatlahir.Text+"', " +
				"'"+dateTimePicker1.Value.ToString("yyyyMMdd")+"', " +
				"'"+jkel.SelectedItem+"'," +
				"'"+alamat.Text+"', " +
				"'"+kota.Text+"', " +
				" "+propinsi.SelectedItem+" , " +
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
//				bersihkan();
//				TampilDalamTable();
				
			} catch(Exception er) {
				MessageBox.Show(er.Message);
			}
			sambung.tutup();
		}
	}
}
