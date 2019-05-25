/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 5/8/2019
 * Time: 7:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace tugas5_no2_172296_khaeruddinasdar_h
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
