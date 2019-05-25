/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 5/8/2019
 * Time: 6:49 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tugas5_no2_172296_khaeruddinasdar_h
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			Koneksi sambung = new Koneksi();
			try{
				sambung.buka();
				MessageBox.Show("Berhasil Koneksi Database", "Konfirmasi");
				this.Hide();
				FormOperationDML tampil = new FormOperationDML();
				tampil.ShowDialog();
			}
			catch(MySqlException ex)
			{
				switch(ex.Number) {
					case 0 : 
						{ MessageBox.Show("Koneksi Gagal", "Konfirmasi");}
						break;
						
					case 1045:
						{ MessageBox.Show("Username atau Password Salah", "Konfirmasi");}
						break;			
				}
			}
		}
		
		
	}
}
