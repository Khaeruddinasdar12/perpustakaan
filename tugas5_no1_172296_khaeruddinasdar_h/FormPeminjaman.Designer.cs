/*
 * Created by SharpDevelop.
 * User: Asdar
 * Date: 21/05/2019
 * Time: 23:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tugas5_no1_172296_khaeruddinasdar_h
{
	partial class FormPeminjaman
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox noAgt;
		private System.Windows.Forms.ComboBox kodebuku;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox kdbuku;
		private System.Windows.Forms.TextBox nomoragt;
		private System.Windows.Forms.TextBox stok;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.noAgt = new System.Windows.Forms.ComboBox();
			this.kodebuku = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.kdbuku = new System.Windows.Forms.TextBox();
			this.nomoragt = new System.Windows.Forms.TextBox();
			this.stok = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(49, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nomor Anggota";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(271, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(215, 34);
			this.label2.TabIndex = 1;
			this.label2.Text = "FORM PEMINJAMAN ";
			// 
			// noAgt
			// 
			this.noAgt.FormattingEnabled = true;
			this.noAgt.Location = new System.Drawing.Point(166, 93);
			this.noAgt.Name = "noAgt";
			this.noAgt.Size = new System.Drawing.Size(163, 21);
			this.noAgt.TabIndex = 2;
			this.noAgt.SelectedIndexChanged += new System.EventHandler(this.NoAgtSelectedIndexChanged);
			// 
			// kodebuku
			// 
			this.kodebuku.FormattingEnabled = true;
			this.kodebuku.Location = new System.Drawing.Point(166, 129);
			this.kodebuku.Name = "kodebuku";
			this.kodebuku.Size = new System.Drawing.Size(163, 21);
			this.kodebuku.TabIndex = 3;
			this.kodebuku.SelectedIndexChanged += new System.EventHandler(this.KodebukuSelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(49, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 21);
			this.label3.TabIndex = 4;
			this.label3.Text = "Kode Buku";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(49, 169);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 21);
			this.label4.TabIndex = 5;
			this.label4.Text = "Tanggal peminjaman";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(166, 170);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(163, 20);
			this.dateTimePicker1.TabIndex = 6;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(49, 252);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(605, 153);
			this.dataGridView1.TabIndex = 7;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(165, 219);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(163, 20);
			this.textBox1.TabIndex = 8;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(100, 222);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 21);
			this.label5.TabIndex = 9;
			this.label5.Text = "Cari";
			// 
			// kdbuku
			// 
			this.kdbuku.Location = new System.Drawing.Point(347, 129);
			this.kdbuku.Name = "kdbuku";
			this.kdbuku.ReadOnly = true;
			this.kdbuku.Size = new System.Drawing.Size(206, 20);
			this.kdbuku.TabIndex = 10;
			// 
			// nomoragt
			// 
			this.nomoragt.Location = new System.Drawing.Point(347, 96);
			this.nomoragt.Name = "nomoragt";
			this.nomoragt.ReadOnly = true;
			this.nomoragt.Size = new System.Drawing.Size(206, 20);
			this.nomoragt.TabIndex = 11;
			// 
			// stok
			// 
			this.stok.Location = new System.Drawing.Point(617, 129);
			this.stok.Name = "stok";
			this.stok.ReadOnly = true;
			this.stok.Size = new System.Drawing.Size(54, 20);
			this.stok.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(580, 132);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 21);
			this.label6.TabIndex = 13;
			this.label6.Text = "Stok";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(49, 32);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(102, 33);
			this.button1.TabIndex = 14;
			this.button1.Text = "Simpan";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(166, 32);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(102, 33);
			this.button2.TabIndex = 15;
			this.button2.Text = "Edit";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(283, 32);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(102, 33);
			this.button3.TabIndex = 16;
			this.button3.Text = "Hapus";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(408, 32);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(102, 33);
			this.button4.TabIndex = 17;
			this.button4.Text = "Keluar";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(334, 219);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(82, 24);
			this.button5.TabIndex = 18;
			this.button5.Text = "Refresh";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// FormPeminjaman
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 415);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.stok);
			this.Controls.Add(this.nomoragt);
			this.Controls.Add(this.kdbuku);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.kodebuku);
			this.Controls.Add(this.noAgt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormPeminjaman";
			this.Text = "FormPeminjaman";
			this.Load += new System.EventHandler(this.FormPeminjamanLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
