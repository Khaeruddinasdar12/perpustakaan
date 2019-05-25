/*
 * Created by SharpDevelop.
 * User: Asdar
 * Date: 14/04/2019
 * Time: 22:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tugas4_no4_172296_khaeruddinasdar_h
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox kodebarang;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox jenisbarang;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown jumlahbarang;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox jumlahbayar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox diskon;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox total;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox namabarang;
		private System.Windows.Forms.TextBox hargabrg;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button proses;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.Button tampilkan;
		private System.Windows.Forms.Button exit;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.kodebarang = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.jenisbarang = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.jumlahbarang = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.jumlahbayar = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.diskon = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.total = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.namabarang = new System.Windows.Forms.TextBox();
			this.hargabrg = new System.Windows.Forms.TextBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.proses = new System.Windows.Forms.Button();
			this.clear = new System.Windows.Forms.Button();
			this.tampilkan = new System.Windows.Forms.Button();
			this.exit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.jumlahbarang)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(39, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kode Barang";
			// 
			// kodebarang
			// 
			this.kodebarang.Location = new System.Drawing.Point(157, 21);
			this.kodebarang.Name = "kodebarang";
			this.kodebarang.Size = new System.Drawing.Size(141, 20);
			this.kodebarang.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(39, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "Jenis Barang";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(39, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 21);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nama Barang";
			// 
			// jenisbarang
			// 
			this.jenisbarang.FormattingEnabled = true;
			this.jenisbarang.Location = new System.Drawing.Point(157, 51);
			this.jenisbarang.Name = "jenisbarang";
			this.jenisbarang.Size = new System.Drawing.Size(142, 21);
			this.jenisbarang.TabIndex = 5;
			this.jenisbarang.Text = "--Pilih Jenis Barang--";
			this.jenisbarang.SelectedIndexChanged += new System.EventHandler(this.JenisbarangSelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(39, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 21);
			this.label4.TabIndex = 6;
			this.label4.Text = "Jumlah Barang";
			// 
			// jumlahbarang
			// 
			this.jumlahbarang.Location = new System.Drawing.Point(157, 148);
			this.jumlahbarang.Name = "jumlahbarang";
			this.jumlahbarang.Size = new System.Drawing.Size(141, 20);
			this.jumlahbarang.TabIndex = 8;
			this.jumlahbarang.ValueChanged += new System.EventHandler(this.JumlahbarangValueChanged);
			this.jumlahbarang.StyleChanged += new System.EventHandler(this.JumlahbarangValueChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(39, 184);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 21);
			this.label5.TabIndex = 9;
			this.label5.Text = "Jumlah Bayar";
			// 
			// jumlahbayar
			// 
			this.jumlahbayar.Location = new System.Drawing.Point(157, 181);
			this.jumlahbayar.Name = "jumlahbayar";
			this.jumlahbayar.ReadOnly = true;
			this.jumlahbayar.Size = new System.Drawing.Size(141, 20);
			this.jumlahbayar.TabIndex = 10;
			this.jumlahbayar.TextChanged += new System.EventHandler(this.JumlahbayarTextChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(39, 215);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 21);
			this.label6.TabIndex = 11;
			this.label6.Text = "Diskon";
			// 
			// diskon
			// 
			this.diskon.Location = new System.Drawing.Point(157, 212);
			this.diskon.Name = "diskon";
			this.diskon.ReadOnly = true;
			this.diskon.Size = new System.Drawing.Size(141, 20);
			this.diskon.TabIndex = 12;
			this.diskon.TextChanged += new System.EventHandler(this.DiskonTextChanged);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(39, 248);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 21);
			this.label7.TabIndex = 13;
			this.label7.Text = "TOTAL";
			// 
			// total
			// 
			this.total.Location = new System.Drawing.Point(157, 245);
			this.total.Name = "total";
			this.total.ReadOnly = true;
			this.total.Size = new System.Drawing.Size(141, 20);
			this.total.TabIndex = 14;
			this.total.TextChanged += new System.EventHandler(this.TotalTextChanged);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(39, 119);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(90, 21);
			this.label8.TabIndex = 16;
			this.label8.Text = "Harga Barang";
			// 
			// namabarang
			// 
			this.namabarang.Location = new System.Drawing.Point(157, 84);
			this.namabarang.Name = "namabarang";
			this.namabarang.ReadOnly = true;
			this.namabarang.Size = new System.Drawing.Size(141, 20);
			this.namabarang.TabIndex = 17;
			this.namabarang.TextChanged += new System.EventHandler(this.NamabarangTextChanged);
			// 
			// hargabrg
			// 
			this.hargabrg.Location = new System.Drawing.Point(157, 116);
			this.hargabrg.Name = "hargabrg";
			this.hargabrg.ReadOnly = true;
			this.hargabrg.Size = new System.Drawing.Size(141, 20);
			this.hargabrg.TabIndex = 18;
			this.hargabrg.TextChanged += new System.EventHandler(this.HargabrgTextChanged);
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(39, 322);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(403, 157);
			this.listView1.TabIndex = 19;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.List;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1SelectedIndexChanged);
			// 
			// proses
			// 
			this.proses.Location = new System.Drawing.Point(41, 281);
			this.proses.Name = "proses";
			this.proses.Size = new System.Drawing.Size(87, 31);
			this.proses.TabIndex = 20;
			this.proses.Text = "Proses";
			this.proses.UseVisualStyleBackColor = true;
			this.proses.Click += new System.EventHandler(this.ProsesClick);
			// 
			// clear
			// 
			this.clear.Location = new System.Drawing.Point(145, 281);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(87, 31);
			this.clear.TabIndex = 21;
			this.clear.Text = "Clear";
			this.clear.UseVisualStyleBackColor = true;
			this.clear.Click += new System.EventHandler(this.ClearClick);
			// 
			// tampilkan
			// 
			this.tampilkan.Location = new System.Drawing.Point(250, 281);
			this.tampilkan.Name = "tampilkan";
			this.tampilkan.Size = new System.Drawing.Size(87, 31);
			this.tampilkan.TabIndex = 22;
			this.tampilkan.Text = "Tampilkan";
			this.tampilkan.UseVisualStyleBackColor = true;
			this.tampilkan.Click += new System.EventHandler(this.TampilkanClick);
			// 
			// exit
			// 
			this.exit.Location = new System.Drawing.Point(355, 281);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(87, 31);
			this.exit.TabIndex = 23;
			this.exit.Text = "Exit";
			this.exit.UseVisualStyleBackColor = true;
			this.exit.Click += new System.EventHandler(this.ExitClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(506, 513);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.tampilkan);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.proses);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.hargabrg);
			this.Controls.Add(this.namabarang);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.total);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.diskon);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.jumlahbayar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.jumlahbarang);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.jenisbarang);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.kodebarang);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Program manage barang";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.jumlahbarang)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
