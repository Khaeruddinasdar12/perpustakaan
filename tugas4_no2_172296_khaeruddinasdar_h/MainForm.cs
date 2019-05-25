using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tugas4_no2_172296_khaeruddinasdar_h
{
	public partial class MainForm : Form
	{
		Double nilai = 0;
		String operation = "";
//		bool processed = false;
		public MainForm()
		{
			InitializeComponent();
		}
		void ButtonClick(object sender, EventArgs e)
		{
			if(hasil.Text == "0") 
				hasil.Clear();
			Button b 	= (Button)sender;
			
			if(b.Text == ",") {
				if(hasil.Text == ",")
					hasil.Text = " ";
				else if(!hasil.Text.Contains(","))
					hasil.Text = hasil.Text + b.Text;
			} else
				hasil.Text 	= hasil.Text + b.Text;	
		}
		void OperateClick(object sender, EventArgs e)
		{
			
			Button proses 	= (Button)sender;
			operation 		= proses.Text;
			nilai 			= Double.Parse(hasil.Text);
//			processed 		= true;
			hasil.Text		= " ";
			label1.Text 	= nilai + " " + operation;
		}
		
		void ButtonequalClick(object sender, EventArgs e)
		{
//			processed 	= true;
			label1.Text = "";
			switch(operation)
			{
				case "+": 
					hasil.Text = (nilai + Double.Parse(hasil.Text)).ToString();
					break;
				case "-": 
					hasil.Text = (nilai - Double.Parse(hasil.Text)).ToString();
					break;
				case "x": 
					hasil.Text = (nilai * Double.Parse(hasil.Text)).ToString();
					break;	
				case "/": 
					hasil.Text = (nilai / Double.Parse(hasil.Text)).ToString();
					break;
				default:
					break;
			}
			
		}
		void ButtonclearClick(object sender, EventArgs e)
		{
			hasil.Clear();
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
//		void ButtontitikClick(object sender, EventArgs e)
//		{
//			hasil.Text = hasil.Text + ".";
//		}
	
	}
		
}
