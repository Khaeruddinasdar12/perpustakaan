using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tugas4_no4_172296_khaeruddinasdar_h
{
	public partial class MainForm : Form
	{
		String nama_barang;
		Double diskon_bayar, total_bayar, jml_bayar, jml_barang;
		
		public MainForm()
		{
			InitializeComponent();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			jenisbarang.Items.Add("A") ;
			jenisbarang.Items.Add("B") ;
			jenisbarang.Items.Add("C") ;
			jenisbarang.Items.Add("D") ;
		}
		void JenisbarangSelectedIndexChanged(object sender, EventArgs e)
		{
			nama_barang = jenisbarang.SelectedItem.ToString();
			switch(nama_barang){
				case "A" :
            		namabarang.Text = "Baju Kemeja"; 
            		hargabrg.Text = "50000";
            		break;
            	
            	case "B" :
            		namabarang.Text = "Celana Panjang";
            		hargabrg.Text = "70000";
            		break;
            		
            	case "C" :
            		namabarang.Text = "Topi";
            		hargabrg.Text = "80000";
            		break;
            		
            	case "D" :
            		namabarang.Text = "Sepatu";
            		hargabrg.Text = "100000";
            		break;
            	default :
            		namabarang.Text = "Jenis Barang Tidak Ditemukan";
            		hargabrg.Text= "0";	
            		break;
			}
		}
		void NamabarangTextChanged(object sender, EventArgs e)
		{
			namabarang.Enabled = false;
		}
		
		void HargabrgTextChanged(object sender, EventArgs e)
		{
			hargabrg.Enabled = false;
		}
		
		void JumlahbarangValueChanged(object sender, EventArgs e)
		{
			
		}
		
		void JumlahbayarTextChanged(object sender, EventArgs e)
		{
			jumlahbayar.Enabled = false;
		}
		void DiskonTextChanged(object sender, EventArgs e)
		{
			diskon.Enabled = false;
		}
		void TotalTextChanged(object sender, EventArgs e)
		{
			total.Enabled = false;
		}
		void ProsesClick(object sender, EventArgs e)
		{
			jml_barang = Convert.ToDouble(jumlahbarang.Value);
			jml_bayar  = (Convert.ToDouble(hargabrg.Text) * jml_barang);
			jumlahbayar.Text = jml_bayar.ToString();
			if(jml_barang >= 0 && jml_barang <= 5){
				diskon_bayar	= 0;
				total_bayar		= jml_bayar;
			}else if(jml_barang > 5){
				diskon_bayar 	= (0.1 * jml_bayar);
				total_bayar 	= jml_bayar - diskon_bayar;
			}
				diskon.Text = "Rp. "+diskon_bayar;
				total.Text  = "Rp. "+total_bayar;
		}
		void ListView1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void TampilkanClick(object sender, EventArgs e)
		{
			listView1.Clear();
			listView1.Items.Add("Kode Barang : " + kodebarang.Text);
			listView1.Items.Add("Jenis Barang : " + jenisbarang.SelectedItem);
			listView1.Items.Add("Nama Barang : " + namabarang.Text);
			listView1.Items.Add("Harga Barang : " + hargabrg.Text);
			listView1.Items.Add("Jumlah Barang : " + jumlahbarang.Value +" buah");
			listView1.Items.Add("Jumlah Bayar: " + jumlahbayar.Text);
			listView1.Items.Add("Diskon: " + diskon.Text);
			listView1.Items.Add("TOTAL : " + total.Text);
		}
		void ExitClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void ClearClick(object sender, EventArgs e)
		{
			listView1.Clear();
			namabarang.Clear();
			this.ActiveControl = kodebarang;
		}
		
	}
	
}
