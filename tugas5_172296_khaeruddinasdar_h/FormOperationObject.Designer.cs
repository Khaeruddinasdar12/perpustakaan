/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 5/8/2019
 * Time: 7:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tugas5_172296_khaeruddinasdar_h
{
	partial class FormOperationObject
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.na = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.nh = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.keterangan = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.nf = new System.Windows.Forms.NumericUpDown();
			this.nm = new System.Windows.Forms.NumericUpDown();
			this.nt = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.alamat = new System.Windows.Forms.TextBox();
			this.nama = new System.Windows.Forms.TextBox();
			this.stb = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.search = new System.Windows.Forms.TextBox();
			this.refresh = new System.Windows.Forms.Button();
			this.hapus = new System.Windows.Forms.Button();
			this.edit = new System.Windows.Forms.Button();
			this.simpan = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nf)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.na);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.nh);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.keterangan);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.nf);
			this.groupBox1.Controls.Add(this.nm);
			this.groupBox1.Controls.Add(this.nt);
			this.groupBox1.Location = new System.Drawing.Point(489, 68);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(248, 245);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Penilaian";
			// 
			// na
			// 
			this.na.Location = new System.Drawing.Point(108, 151);
			this.na.Name = "na";
			this.na.ReadOnly = true;
			this.na.Size = new System.Drawing.Size(116, 20);
			this.na.TabIndex = 0;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(18, 180);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(84, 17);
			this.label10.TabIndex = 22;
			this.label10.Text = "Nilai Huruf";
			// 
			// nh
			// 
			this.nh.Location = new System.Drawing.Point(108, 177);
			this.nh.Name = "nh";
			this.nh.ReadOnly = true;
			this.nh.Size = new System.Drawing.Size(116, 20);
			this.nh.TabIndex = 21;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(37, 107);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(175, 30);
			this.button1.TabIndex = 20;
			this.button1.Text = "Proses";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(18, 206);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(84, 17);
			this.label9.TabIndex = 19;
			this.label9.Text = "Keterangan";
			// 
			// keterangan
			// 
			this.keterangan.Location = new System.Drawing.Point(108, 203);
			this.keterangan.Name = "keterangan";
			this.keterangan.ReadOnly = true;
			this.keterangan.Size = new System.Drawing.Size(116, 20);
			this.keterangan.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(18, 153);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(84, 17);
			this.label8.TabIndex = 18;
			this.label8.Text = "Nilai Akhir";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(18, 77);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(84, 17);
			this.label7.TabIndex = 17;
			this.label7.Text = "Nilai Final";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(18, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 17);
			this.label6.TabIndex = 16;
			this.label6.Text = "Nilai Mid";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(18, 23);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 17);
			this.label5.TabIndex = 15;
			this.label5.Text = "Nilai Tugas";
			// 
			// nf
			// 
			this.nf.Location = new System.Drawing.Point(108, 75);
			this.nf.Name = "nf";
			this.nf.Size = new System.Drawing.Size(116, 20);
			this.nf.TabIndex = 2;
			// 
			// nm
			// 
			this.nm.Location = new System.Drawing.Point(108, 49);
			this.nm.Name = "nm";
			this.nm.Size = new System.Drawing.Size(116, 20);
			this.nm.TabIndex = 1;
			// 
			// nt
			// 
			this.nt.Location = new System.Drawing.Point(108, 21);
			this.nt.Name = "nt";
			this.nt.Size = new System.Drawing.Size(116, 20);
			this.nt.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(109, 181);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 17);
			this.label4.TabIndex = 27;
			this.label4.Text = "Alamat";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(109, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 17);
			this.label3.TabIndex = 26;
			this.label3.Text = "Nama";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(109, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 17);
			this.label2.TabIndex = 25;
			this.label2.Text = "Stb";
			// 
			// alamat
			// 
			this.alamat.Location = new System.Drawing.Point(199, 178);
			this.alamat.Multiline = true;
			this.alamat.Name = "alamat";
			this.alamat.Size = new System.Drawing.Size(244, 49);
			this.alamat.TabIndex = 24;
			this.alamat.TextChanged += new System.EventHandler(this.AlamatTextChanged);
			// 
			// nama
			// 
			this.nama.Location = new System.Drawing.Point(199, 152);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(244, 20);
			this.nama.TabIndex = 23;
			// 
			// stb
			// 
			this.stb.Location = new System.Drawing.Point(199, 126);
			this.stb.Name = "stb";
			this.stb.Size = new System.Drawing.Size(244, 20);
			this.stb.TabIndex = 22;
			this.stb.TextChanged += new System.EventHandler(this.StbTextChanged);
			this.stb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StbKeyPress);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(109, 340);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 30);
			this.label1.TabIndex = 21;
			this.label1.Text = "Cari nama";
			// 
			// search
			// 
			this.search.Location = new System.Drawing.Point(196, 340);
			this.search.Multiline = true;
			this.search.Name = "search";
			this.search.Size = new System.Drawing.Size(192, 27);
			this.search.TabIndex = 20;
			this.search.TextChanged += new System.EventHandler(this.SearchTextChanged);
			// 
			// refresh
			// 
			this.refresh.Location = new System.Drawing.Point(404, 340);
			this.refresh.Name = "refresh";
			this.refresh.Size = new System.Drawing.Size(102, 28);
			this.refresh.TabIndex = 19;
			this.refresh.Text = "Refresh";
			this.refresh.UseVisualStyleBackColor = true;
			this.refresh.Click += new System.EventHandler(this.RefreshClick);
			// 
			// hapus
			// 
			this.hapus.Location = new System.Drawing.Point(325, 68);
			this.hapus.Name = "hapus";
			this.hapus.Size = new System.Drawing.Size(102, 28);
			this.hapus.TabIndex = 18;
			this.hapus.Text = "Hapus";
			this.hapus.UseVisualStyleBackColor = true;
			this.hapus.Click += new System.EventHandler(this.HapusClick);
			// 
			// edit
			// 
			this.edit.Location = new System.Drawing.Point(217, 68);
			this.edit.Name = "edit";
			this.edit.Size = new System.Drawing.Size(102, 28);
			this.edit.TabIndex = 17;
			this.edit.Text = "Edit";
			this.edit.UseVisualStyleBackColor = true;
			this.edit.Click += new System.EventHandler(this.EditClick);
			// 
			// simpan
			// 
			this.simpan.Location = new System.Drawing.Point(109, 68);
			this.simpan.Name = "simpan";
			this.simpan.Size = new System.Drawing.Size(102, 28);
			this.simpan.TabIndex = 16;
			this.simpan.Text = "Simpan";
			this.simpan.UseVisualStyleBackColor = true;
			this.simpan.Click += new System.EventHandler(this.SimpanClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.Location = new System.Drawing.Point(46, 374);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(749, 240);
			this.dataGridView1.TabIndex = 29;
			// 
			// FormOperationDML
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(922, 749);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.alamat);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.stb);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.search);
			this.Controls.Add(this.refresh);
			this.Controls.Add(this.hapus);
			this.Controls.Add(this.edit);
			this.Controls.Add(this.simpan);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FormOperationDML";
			this.Text = "FormOperationDML";
			this.Load += new System.EventHandler(this.FormOperationDMLLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nf)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button simpan;
		private System.Windows.Forms.Button edit;
		private System.Windows.Forms.Button hapus;
		private System.Windows.Forms.Button refresh;
		private System.Windows.Forms.TextBox search;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox stb;
		private System.Windows.Forms.TextBox nama;
		private System.Windows.Forms.TextBox alamat;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown nt;
		private System.Windows.Forms.NumericUpDown nm;
		private System.Windows.Forms.NumericUpDown nf;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox keterangan;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox nh;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox na;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
