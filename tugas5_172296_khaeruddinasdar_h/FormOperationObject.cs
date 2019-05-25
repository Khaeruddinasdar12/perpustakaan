using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace tugas5_172296_khaeruddinasdar_h
{
	public partial class FormOperationObject : Form
	{
		MySqlDataReader	dr;
		MySqlCommand query;
		Koneksi sambung;
		MySqlDataAdapter adapter;
		String sql;
		double ntugas, nmid, nfinal, nakhir;
		
		public FormOperationObject()
		{
			InitializeComponent();
			TampilDalamTable();
		}
		
		public void bersihkan()
		{
			stb.Clear();
			nama.Clear();
			alamat.Clear();
			nt.Value = 0;
			nm.Value = 0;
			nf.Value = 0;
			na.Clear();
			nh.Clear();
			keterangan.Clear();
			search.Clear();
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
			sambung = new Koneksi();
			
			sql = "INSERT INTO mahasiswa (stb, nama, alamat, nilai_tugas, nilai_mid, nilai_final, nilai_akhir, " +
				"nilai_huruf, keterangan) " +
				"VALUES ('"+stb.Text+"', '"+nama.Text+"', '"+alamat.Text+"', "+nt.Value+", "+nm.Value+", "+nf.Value+", '"+na.Text+"', '"+nh.Text+"', " +
				"'"+keterangan.Text+"')";
			
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
		
		
		void EditClick(object sender, EventArgs e)
		{
			sambung = new Koneksi();
			sql = "UPDATE mahasiswa SET nama ='"+nama.Text+"', alamat ='"+alamat.Text+"', " +
				"nilai_tugas="+nt.Value+", nilai_mid="+nm.Value+", " +
				"nilai_final="+nf.Value+", nilai_akhir='"+na.Text+"', nilai_huruf='"+nh.Text+"', " +
				"keterangan='"+keterangan.Text+"' where stb='"+stb.Text+"' ";
			try {
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
			sql = "DELETE FROM mahasiswa where stb='"+stb.Text+"' ";
			
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
		
		void Button1Click(object sender, EventArgs e)
		{
			ntugas  = Convert.ToDouble(nt.Value);
			nmid	= Convert.ToDouble(nm.Value);
			nfinal  = Convert.ToDouble(nf.Value);
			
			nakhir	= (ntugas + nmid + nfinal)/3;
			na.Text = nakhir.ToString();;
			if(nakhir >= 81) {
				keterangan.Text = "Sangat Baik";
				nh.Text= "A";
			} else if(nakhir >= 66) {
				keterangan.Text = "Baik";
				nh.Text= "B";
			} else if(nakhir >= 46) {
				keterangan.Text = "Cukup";
				nh.Text= "C";
			} else if(nakhir >= 36) {
				keterangan.Text = "Kurang";
				nh.Text= "D";
			} else {
				keterangan.Text = "Error";
				nh.Text= "E";				
			}
		}
		
		void SearchTextChanged(object sender, EventArgs e)
		{
			string nama 	= search.Text.ToString();
			ViewCari cari 	= new ViewCari();
			DataTable tabel = new DataTable();
			
			tabel = cari.tampilpencarian(nama);
			dataGridView1.DataSource = tabel;
		}
		
		void RefreshClick(object sender, EventArgs e)
		{
			bersihkan();
			TampilDalamTable();
		}
		
		void StbKeyPress(object sender, KeyPressEventArgs e)
		{
			sambung = new Koneksi();
			if(e.KeyChar == (char) Keys.Enter) {
				sql = "SELECT * FROM mahasiswa where stb='"+stb.Text+"' ";
				try{
					sambung.buka();
					query = new MySqlCommand(sql, sambung.koneksi);
					adapter = new MySqlDataAdapter(query);
	//				dr = new MySqlDataReader();
					dr = query.ExecuteReader();
					 
					
					if (dr.Read() ) {
						MessageBox.Show("Data Sudah Ada", "information");
						simpan.Enabled = false;
						edit.Enabled = true;
						hapus.Enabled= true;
			            nama.Text = dr[1].ToString();
			            alamat.Text= dr[2].ToString();
			            nt.Value = Convert.ToInt32(dr[3]);
			            nm.Value = Convert.ToInt32(dr[4]);
			            nf.Value = Convert.ToInt32(dr[5]);
			            na.Text = dr[6].ToString();
			            nh.Text = dr[7].ToString();
			            keterangan.Text = dr[8].ToString();
					 } else {
						simpan.Enabled= true;
					 	nama.Select();
					 }
					sambung.tutup();
				} catch(Exception er) {
					MessageBox.Show(er.Message);
				}
			}
		}
		
		void FormOperationDMLLoad(object sender, EventArgs e)
		{
			edit.Enabled = false;
			hapus.Enabled= false;
		}
		
		void StbTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void AlamatTextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
