using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace tugas5_no1_172296_khaeruddinasdar_h
{
	public class ViewCari
	{
		MySqlCommand query;
		Koneksi sambung;
		MySqlDataAdapter adapter;
		String sql;
		DataTable tabel;
		
		public DataTable tampilpencarian(string cari)
		{
			sambung = new Koneksi();
			sql 	= "SELECT * FROM mahasiswa where nama LIKE '%"+cari+"%'";
			tabel 	= new DataTable();
			
			try {
				sambung.buka();
				query	= new MySqlCommand(sql, sambung.koneksi);
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
