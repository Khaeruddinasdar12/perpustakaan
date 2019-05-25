
using System;
using MySql.Data.MySqlClient;

namespace tugas5_no1_172296_khaeruddinasdar_h
{
	public class Koneksi
	{
		string alamat = "server=localhost; database=database_latihan_visual; uid=root; pwd= ";
		public MySqlConnection koneksi;
		
		public void buka()
		{
			koneksi = new MySqlConnection(alamat);
			koneksi.Open();
		}
		
		public void tutup()
		{
			koneksi = new MySqlConnection(alamat);
			koneksi.Close();
		}
	}
}
