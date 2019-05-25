using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace latihan
{
	public partial class MainForm : Form
	{
		String jkel;
		public MainForm()
		{
			InitializeComponent();
		}
		
		void ProsesClick(object sender, EventArgs e)
		{
			if(L.Checked)
				jkel = L.Text;
			else if(P.Checked)
				jkel = P.Text;
			
			tampil.Items.Add("Nama Anda : " + nama.Text);
			tampil.Items.Add("Jenis Kelamin : " + jkel);
		}
		void ClearClick(object sender, EventArgs e)
		{
			tampil.Clear();
			nama.Clear();
			L.Checked = false;
			P.Checked = false;
			
		}
		
	}
}
