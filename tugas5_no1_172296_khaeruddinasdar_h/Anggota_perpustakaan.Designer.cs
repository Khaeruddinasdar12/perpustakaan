/*
 * Created by SharpDevelop.
 * User: Asdar
 * Date: 13/05/2019
 * Time: 1:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tugas5_no1_172296_khaeruddinasdar_h
{
	partial class Anggota_perpustakaan
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox stb;
		private System.Windows.Forms.TextBox nama;
		private System.Windows.Forms.TextBox cari;
		private System.Windows.Forms.Label label4;
		
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.stb = new System.Windows.Forms.TextBox();
			this.nama = new System.Windows.Forms.TextBox();
			this.cari = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(65, 178);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(551, 186);
			this.dataGridView1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(316, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "Daftar Anggota Perpustakaan";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(64, 27);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 41);
			this.button1.TabIndex = 2;
			this.button1.Text = "Simpan";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(206, 27);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 41);
			this.button2.TabIndex = 3;
			this.button2.Text = "Edit";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(358, 27);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 41);
			this.button3.TabIndex = 4;
			this.button3.Text = "Hapus";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(496, 27);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(120, 41);
			this.button4.TabIndex = 5;
			this.button4.Text = "Keluar";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(65, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 21);
			this.label2.TabIndex = 6;
			this.label2.Text = "Stb";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(65, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 21);
			this.label3.TabIndex = 7;
			this.label3.Text = "Nama";
			// 
			// stb
			// 
			this.stb.Location = new System.Drawing.Point(162, 73);
			this.stb.Name = "stb";
			this.stb.Size = new System.Drawing.Size(164, 20);
			this.stb.TabIndex = 8;
			this.stb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StbKeyPress);
			// 
			// nama
			// 
			this.nama.Location = new System.Drawing.Point(162, 105);
			this.nama.Name = "nama";
			this.nama.ReadOnly = true;
			this.nama.Size = new System.Drawing.Size(164, 20);
			this.nama.TabIndex = 9;
			// 
			// cari
			// 
			this.cari.Location = new System.Drawing.Point(422, 152);
			this.cari.Name = "cari";
			this.cari.Size = new System.Drawing.Size(164, 20);
			this.cari.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(345, 155);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 21);
			this.label4.TabIndex = 11;
			this.label4.Text = "Cari nama";
			// 
			// Anggota_perpustakaan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(783, 386);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cari);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.stb);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Anggota_perpustakaan";
			this.Text = "Anggota_perpustakaan";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
