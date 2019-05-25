using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tugas4_no3_172296_khaeruddinasdar_h
{
	
	
	public partial class MainForm : Form
	{
		Double hasil;
		String jur,jkel;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void ProsesClick(object sender, EventArgs e)
		{
			hasil = ((0.3 * Double.Parse(inputNT.Text)) + 
			                   (0.3 * Double.Parse(inputMID.Text)) + 
			                   (0.4 * Double.Parse(inputFinal.Text)));
			nilaiakhir.Text = hasil.ToString();
			
			if(hasil >= 80){
				nilaihuruf.Text = "A";
				ket.Text = "Sangat Baik";
			}else if(Convert.ToInt16(hasil) >= 70){
				nilaihuruf.Text = "B";
				ket.Text = "Baik";
			}else if(Convert.ToInt16(hasil) >= 50){
				nilaihuruf.Text = "C";
				ket.Text = "Cukup";
			}else if(Convert.ToInt16(hasil) >= 30){
				nilaihuruf.Text = "D";
				ket.Text = "Cukup";
			}else{
				nilaihuruf.Text ="E";
				ket.Text = "Error";
			}
						
		}
		
		void NilaiakhirTextChanged(object sender, EventArgs e)
		{
			nilaiakhir.Enabled = false;
		}
		void NilaihurufTextChanged(object sender, EventArgs e)
		{
			nilaihuruf.Enabled = false;
		}
		void KetTextChanged(object sender, EventArgs e)
		{
			ket.Enabled = false;
		}
		void ClearClick(object sender, EventArgs e)
		{
			nilaihuruf.Clear();
			inputFinal.Clear();
			inputMID.Clear();
			ket.Clear();
			inputNT.Clear();
			inputstb.Clear();
			inputMID.Clear();
			alamat.Clear();
			inputnama.Clear();
			nilaiakhir.Clear();
			listView1.Clear();
			umur.Value = 0;
			radioButton2.Checked = false;
			radioButton1.Checked = false;
			this.ActiveControl = inputstb;
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			inputjurusan.Items.Add("SI") ;
			inputjurusan.Items.Add("TI") ;
			inputjurusan.Items.Add("MI") ;
			inputjurusan.Items.Add("RPL");
		}
		void InputjurusanSelectedIndexChanged(object sender, EventArgs e)
		{
			jur = inputjurusan.SelectedItem.ToString();
			switch(jur){
					case "MI": hasiljurusan.Text = "Manajemen Informatika";
								break;
					case "TI": hasiljurusan.Text = "Teknik Informatika";
								break;
					case "SI": hasiljurusan.Text = "Sistem Informasi";
								break;
					case "RPL": hasiljurusan.Text = "Rekayasa Perangkat Lunak";
								break;
			}
			 
		}
		void ListView1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		void TampilkanClick(object sender, EventArgs e)
		{
			listView1.Clear();
			if(radioButton1.Checked)
				jkel = radioButton1.Text;
			else if(radioButton2.Checked)
				jkel = radioButton2.Text;
			
			listView1.Items.Add("STB : " + inputstb.Text);
			listView1.Items.Add("Nama : " + inputnama.Text);
			listView1.Items.Add("Jurusan : " + hasiljurusan.Text);
			listView1.Items.Add("Alamat : " + alamat.Text);
			listView1.Items.Add("Umur : " + umur.Text +" tahun");
			listView1.Items.Add("Jenis Kelamin : " + jkel);
			listView1.Items.Add("Nilai Tugas : " + inputNT.Text);
			listView1.Items.Add("Nilai MID : " + inputMID.Text);
			listView1.Items.Add("Nilai Final : " + inputFinal.Text);
			listView1.Items.Add("Nilai Akhir : " + nilaiakhir.Text);
			listView1.Items.Add("Nilai Huruf : " + nilaihuruf.Text);
			listView1.Items.Add("Keterangan : " + ket.Text);
		}
		void HasiljurusanTextChanged(object sender, EventArgs e)
		{
			hasiljurusan.Enabled = false;
		}
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			
		}
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void ExitClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
	}
}
