namespace tugas5_no1_172296_khaeruddinasdar_h
{
	partial class InputDataMhs
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label stb;
		private System.Windows.Forms.TextBox inputstb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox inputnama;
		private System.Windows.Forms.Label Jurusan;
		private System.Windows.Forms.ComboBox inputjurusan;
		private System.Windows.Forms.TextBox hasiljurusan;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox alamat;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox inputNT;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox inputMID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox inputFinal;
		private System.Windows.Forms.TextBox nilaihuruf;
		private System.Windows.Forms.TextBox nilaiakhir;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button Proses;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.Button tampilkan;
		private System.Windows.Forms.Button exit;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.TextBox ket;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown umur;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button savetodb;
		
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
		private void InitializeComponent()
		{
			this.stb = new System.Windows.Forms.Label();
			this.inputstb = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.inputnama = new System.Windows.Forms.TextBox();
			this.Jurusan = new System.Windows.Forms.Label();
			this.inputjurusan = new System.Windows.Forms.ComboBox();
			this.hasiljurusan = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.alamat = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.inputNT = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.inputMID = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.inputFinal = new System.Windows.Forms.TextBox();
			this.nilaihuruf = new System.Windows.Forms.TextBox();
			this.nilaiakhir = new System.Windows.Forms.TextBox();
			this.ket = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.Proses = new System.Windows.Forms.Button();
			this.clear = new System.Windows.Forms.Button();
			this.tampilkan = new System.Windows.Forms.Button();
			this.exit = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.label9 = new System.Windows.Forms.Label();
			this.umur = new System.Windows.Forms.NumericUpDown();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.savetodb = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.umur)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// stb
			// 
			this.stb.Location = new System.Drawing.Point(17, 23);
			this.stb.Name = "stb";
			this.stb.Size = new System.Drawing.Size(57, 27);
			this.stb.TabIndex = 0;
			this.stb.Text = "STB";
			// 
			// inputstb
			// 
			this.inputstb.Location = new System.Drawing.Point(109, 20);
			this.inputstb.Name = "inputstb";
			this.inputstb.Size = new System.Drawing.Size(424, 20);
			this.inputstb.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(17, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 27);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nama";
			// 
			// inputnama
			// 
			this.inputnama.Location = new System.Drawing.Point(109, 50);
			this.inputnama.Name = "inputnama";
			this.inputnama.Size = new System.Drawing.Size(424, 20);
			this.inputnama.TabIndex = 3;
			// 
			// Jurusan
			// 
			this.Jurusan.Location = new System.Drawing.Point(17, 83);
			this.Jurusan.Name = "Jurusan";
			this.Jurusan.Size = new System.Drawing.Size(100, 23);
			this.Jurusan.TabIndex = 4;
			this.Jurusan.Text = "Jurusan";
			// 
			// inputjurusan
			// 
			this.inputjurusan.FormattingEnabled = true;
			this.inputjurusan.Location = new System.Drawing.Point(109, 83);
			this.inputjurusan.Name = "inputjurusan";
			this.inputjurusan.Size = new System.Drawing.Size(101, 21);
			this.inputjurusan.TabIndex = 5;
			this.inputjurusan.Text = "--Pilih Jurusan--";
			this.inputjurusan.SelectedIndexChanged += new System.EventHandler(this.InputjurusanSelectedIndexChanged);
			// 
			// hasiljurusan
			// 
			this.hasiljurusan.Location = new System.Drawing.Point(230, 83);
			this.hasiljurusan.Name = "hasiljurusan";
			this.hasiljurusan.ReadOnly = true;
			this.hasiljurusan.Size = new System.Drawing.Size(303, 20);
			this.hasiljurusan.TabIndex = 6;
			this.hasiljurusan.TextChanged += new System.EventHandler(this.HasiljurusanTextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(17, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Alamat";
			// 
			// alamat
			// 
			this.alamat.Location = new System.Drawing.Point(109, 117);
			this.alamat.Multiline = true;
			this.alamat.Name = "alamat";
			this.alamat.Size = new System.Drawing.Size(288, 76);
			this.alamat.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(17, 246);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Nilai Tugas";
			// 
			// inputNT
			// 
			this.inputNT.Location = new System.Drawing.Point(109, 243);
			this.inputNT.Name = "inputNT";
			this.inputNT.Size = new System.Drawing.Size(202, 20);
			this.inputNT.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 283);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 11;
			this.label4.Text = "Nilai Mid";
			// 
			// inputMID
			// 
			this.inputMID.Location = new System.Drawing.Point(109, 278);
			this.inputMID.Name = "inputMID";
			this.inputMID.Size = new System.Drawing.Size(202, 20);
			this.inputMID.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 312);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 13;
			this.label5.Text = "Nilai Final";
			// 
			// inputFinal
			// 
			this.inputFinal.Location = new System.Drawing.Point(109, 309);
			this.inputFinal.Name = "inputFinal";
			this.inputFinal.Size = new System.Drawing.Size(202, 20);
			this.inputFinal.TabIndex = 14;
			// 
			// nilaihuruf
			// 
			this.nilaihuruf.Location = new System.Drawing.Point(416, 278);
			this.nilaihuruf.Name = "nilaihuruf";
			this.nilaihuruf.ReadOnly = true;
			this.nilaihuruf.Size = new System.Drawing.Size(117, 20);
			this.nilaihuruf.TabIndex = 15;
			this.nilaihuruf.TextChanged += new System.EventHandler(this.NilaihurufTextChanged);
			// 
			// nilaiakhir
			// 
			this.nilaiakhir.Location = new System.Drawing.Point(416, 243);
			this.nilaiakhir.Name = "nilaiakhir";
			this.nilaiakhir.ReadOnly = true;
			this.nilaiakhir.Size = new System.Drawing.Size(117, 20);
			this.nilaiakhir.TabIndex = 16;
			this.nilaiakhir.TextChanged += new System.EventHandler(this.NilaiakhirTextChanged);
			// 
			// ket
			// 
			this.ket.Location = new System.Drawing.Point(416, 309);
			this.ket.Name = "ket";
			this.ket.ReadOnly = true;
			this.ket.Size = new System.Drawing.Size(117, 20);
			this.ket.TabIndex = 17;
			this.ket.TextChanged += new System.EventHandler(this.KetTextChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(338, 246);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 23);
			this.label6.TabIndex = 18;
			this.label6.Text = "Nilai Akhir";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(338, 281);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 23);
			this.label7.TabIndex = 19;
			this.label7.Text = "Nilai Huruf";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(338, 312);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 23);
			this.label8.TabIndex = 20;
			this.label8.Text = "Keterangan";
			// 
			// Proses
			// 
			this.Proses.Location = new System.Drawing.Point(24, 351);
			this.Proses.Name = "Proses";
			this.Proses.Size = new System.Drawing.Size(86, 44);
			this.Proses.TabIndex = 21;
			this.Proses.Text = "Proses";
			this.Proses.UseVisualStyleBackColor = true;
			this.Proses.Click += new System.EventHandler(this.ProsesClick);
			// 
			// clear
			// 
			this.clear.Location = new System.Drawing.Point(158, 351);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(86, 44);
			this.clear.TabIndex = 22;
			this.clear.Text = "Clear";
			this.clear.UseVisualStyleBackColor = true;
			this.clear.Click += new System.EventHandler(this.ClearClick);
			// 
			// tampilkan
			// 
			this.tampilkan.Location = new System.Drawing.Point(305, 351);
			this.tampilkan.Name = "tampilkan";
			this.tampilkan.Size = new System.Drawing.Size(86, 44);
			this.tampilkan.TabIndex = 23;
			this.tampilkan.Text = "Tampilkan";
			this.tampilkan.UseVisualStyleBackColor = true;
			this.tampilkan.Click += new System.EventHandler(this.TampilkanClick);
			// 
			// exit
			// 
			this.exit.Location = new System.Drawing.Point(441, 351);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(86, 44);
			this.exit.TabIndex = 24;
			this.exit.Text = "Exit";
			this.exit.UseVisualStyleBackColor = true;
			this.exit.Click += new System.EventHandler(this.ExitClick);
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(24, 457);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(503, 208);
			this.listView1.TabIndex = 25;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.List;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1SelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(17, 211);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 26;
			this.label9.Text = "Umur";
			// 
			// umur
			// 
			this.umur.Location = new System.Drawing.Point(109, 211);
			this.umur.Name = "umur";
			this.umur.Size = new System.Drawing.Size(424, 20);
			this.umur.TabIndex = 27;
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(6, 19);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(105, 19);
			this.radioButton1.TabIndex = 28;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Laki-laki";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(6, 44);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(105, 19);
			this.radioButton2.TabIndex = 29;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Perempuan";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(416, 117);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(117, 76);
			this.groupBox1.TabIndex = 30;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Jenis kelamin";
			// 
			// savetodb
			// 
			this.savetodb.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.savetodb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.savetodb.Location = new System.Drawing.Point(24, 401);
			this.savetodb.Name = "savetodb";
			this.savetodb.Size = new System.Drawing.Size(503, 44);
			this.savetodb.TabIndex = 31;
			this.savetodb.Text = "Save";
			this.savetodb.UseVisualStyleBackColor = false;
			this.savetodb.Click += new System.EventHandler(this.SavetodbClick);
			// 
			// InputDataMhs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(552, 676);
			this.Controls.Add(this.savetodb);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.umur);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.tampilkan);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.Proses);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.ket);
			this.Controls.Add(this.nilaiakhir);
			this.Controls.Add(this.nilaihuruf);
			this.Controls.Add(this.inputFinal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.inputMID);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.inputNT);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.alamat);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.hasiljurusan);
			this.Controls.Add(this.inputjurusan);
			this.Controls.Add(this.Jurusan);
			this.Controls.Add(this.inputnama);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.inputstb);
			this.Controls.Add(this.stb);
			this.Name = "InputDataMhs";
			this.Text = "Input Data Mahasiswa";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.umur)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

