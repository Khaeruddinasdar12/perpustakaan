using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tugas4_no1_172296_khaeruddinasdar_h
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
		}
		
		void NamaTextChanged(object sender, EventArgs e)
		{
			hasilnama.Text = nama.Text;
		}
		void StbTextChanged(object sender, EventArgs e)
		{
			hasilstb.Text = stb.Text;
		}
		void Laki_lakiCheckedChanged(object sender, EventArgs e)
		{
			jkel.Text = laki_laki.Text;
		}
		void PerempuanCheckedChanged(object sender, EventArgs e)
		{
			jkel.Text = perempuan.Text;
		}
		void EmailTextChanged(object sender, EventArgs e)
		{
			 hasilemail.Text = email.Text ;
		}
		void NohpTextChanged(object sender, EventArgs e)
		{
			hasilnohp.Text = nohp.Text;
		}
		void HasilnohpClick(object sender, EventArgs e)
		{
	
		}
		
		
	}
}
