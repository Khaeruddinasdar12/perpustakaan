/*
 * Created by SharpDevelop.
 * User: Asdar
 * Date: 12/05/2019
 * Time: 17:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tugas5_no1_172296_khaeruddinasdar_h
{
	partial class FormOperationDMLJoin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox stb;
		private System.Windows.Forms.TextBox nama;
		private System.Windows.Forms.TextBox tampilprodi;
		private System.Windows.Forms.TextBox tampilagama;
		private System.Windows.Forms.TextBox tempatlahir;
		private System.Windows.Forms.ComboBox jkel;
		private System.Windows.Forms.TextBox tampiljkel;
		private System.Windows.Forms.TextBox alamat;
		private System.Windows.Forms.TextBox kota;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tampilpropinsi;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox kodepos;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox telepon;
		private System.Windows.Forms.TextBox hp;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox hobi;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox wali;
		private System.Windows.Forms.TextBox alamatwali;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox telwali;
		private System.Windows.Forms.ComboBox tahunmasuk;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox prodi;
		private System.Windows.Forms.ComboBox agama;
		private System.Windows.Forms.ComboBox propinsi;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.stb = new System.Windows.Forms.TextBox();
			this.nama = new System.Windows.Forms.TextBox();
			this.tampilagama = new System.Windows.Forms.TextBox();
			this.agama = new System.Windows.Forms.ComboBox();
			this.tempatlahir = new System.Windows.Forms.TextBox();
			this.jkel = new System.Windows.Forms.ComboBox();
			this.tampiljkel = new System.Windows.Forms.TextBox();
			this.alamat = new System.Windows.Forms.TextBox();
			this.kota = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.propinsi = new System.Windows.Forms.ComboBox();
			this.tampilpropinsi = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.kodepos = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.telepon = new System.Windows.Forms.TextBox();
			this.hp = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.hobi = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.wali = new System.Windows.Forms.TextBox();
			this.alamatwali = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.telwali = new System.Windows.Forms.TextBox();
			this.tahunmasuk = new System.Windows.Forms.ComboBox();
			this.label18 = new System.Windows.Forms.Label();
			this.textBox17 = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.prodi = new System.Windows.Forms.ComboBox();
			this.tampilprodi = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(30, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 34);
			this.button1.TabIndex = 0;
			this.button1.Text = "Simpan";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(149, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(113, 34);
			this.button2.TabIndex = 1;
			this.button2.Text = "Edit";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(268, 12);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(113, 34);
			this.button3.TabIndex = 2;
			this.button3.Text = "Hapus";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(387, 12);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(113, 34);
			this.button4.TabIndex = 3;
			this.button4.Text = "Keluar";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// stb
			// 
			this.stb.Location = new System.Drawing.Point(115, 84);
			this.stb.Name = "stb";
			this.stb.Size = new System.Drawing.Size(178, 20);
			this.stb.TabIndex = 4;
			// 
			// nama
			// 
			this.nama.Location = new System.Drawing.Point(115, 110);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(308, 20);
			this.nama.TabIndex = 5;
			// 
			// tampilagama
			// 
			this.tampilagama.Location = new System.Drawing.Point(245, 163);
			this.tampilagama.Name = "tampilagama";
			this.tampilagama.ReadOnly = true;
			this.tampilagama.Size = new System.Drawing.Size(178, 20);
			this.tampilagama.TabIndex = 7;
			// 
			// agama
			// 
			this.agama.FormattingEnabled = true;
			this.agama.Location = new System.Drawing.Point(115, 162);
			this.agama.Name = "agama";
			this.agama.Size = new System.Drawing.Size(124, 21);
			this.agama.TabIndex = 8;
			this.agama.Text = "Pilih Agama";
			// 
			// tempatlahir
			// 
			this.tempatlahir.Location = new System.Drawing.Point(115, 189);
			this.tempatlahir.Name = "tempatlahir";
			this.tempatlahir.Size = new System.Drawing.Size(308, 20);
			this.tempatlahir.TabIndex = 10;
			// 
			// jkel
			// 
			this.jkel.FormattingEnabled = true;
			this.jkel.Location = new System.Drawing.Point(115, 243);
			this.jkel.Name = "jkel";
			this.jkel.Size = new System.Drawing.Size(124, 21);
			this.jkel.TabIndex = 12;
			this.jkel.Text = "Pilih jenis kelamin";
			// 
			// tampiljkel
			// 
			this.tampiljkel.Location = new System.Drawing.Point(245, 244);
			this.tampiljkel.Name = "tampiljkel";
			this.tampiljkel.ReadOnly = true;
			this.tampiljkel.Size = new System.Drawing.Size(178, 20);
			this.tampiljkel.TabIndex = 13;
			// 
			// alamat
			// 
			this.alamat.Location = new System.Drawing.Point(115, 270);
			this.alamat.Name = "alamat";
			this.alamat.Size = new System.Drawing.Size(308, 20);
			this.alamat.TabIndex = 14;
			// 
			// kota
			// 
			this.kota.Location = new System.Drawing.Point(115, 296);
			this.kota.Name = "kota";
			this.kota.Size = new System.Drawing.Size(308, 20);
			this.kota.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(30, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 17);
			this.label1.TabIndex = 16;
			this.label1.Text = "Stb";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(30, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 17);
			this.label2.TabIndex = 17;
			this.label2.Text = "Nama";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(30, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 17);
			this.label3.TabIndex = 18;
			this.label3.Text = "Kode Prodi";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(30, 165);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 18);
			this.label4.TabIndex = 19;
			this.label4.Text = "Kode Agama";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(30, 192);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 18);
			this.label5.TabIndex = 20;
			this.label5.Text = "T4 lahir";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(30, 217);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 18);
			this.label6.TabIndex = 21;
			this.label6.Text = "Tanggal lahir";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(30, 247);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(79, 18);
			this.label7.TabIndex = 22;
			this.label7.Text = "Jns Kelamin";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(30, 273);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(66, 17);
			this.label8.TabIndex = 23;
			this.label8.Text = "Alamat";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(30, 299);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(66, 17);
			this.label9.TabIndex = 24;
			this.label9.Text = "Kota";
			// 
			// propinsi
			// 
			this.propinsi.FormattingEnabled = true;
			this.propinsi.Location = new System.Drawing.Point(564, 83);
			this.propinsi.Name = "propinsi";
			this.propinsi.Size = new System.Drawing.Size(124, 21);
			this.propinsi.TabIndex = 25;
			// 
			// tampilpropinsi
			// 
			this.tampilpropinsi.Location = new System.Drawing.Point(694, 83);
			this.tampilpropinsi.Name = "tampilpropinsi";
			this.tampilpropinsi.Size = new System.Drawing.Size(178, 20);
			this.tampilpropinsi.TabIndex = 26;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(473, 87);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(85, 16);
			this.label10.TabIndex = 27;
			this.label10.Text = "Kode Provinsi";
			// 
			// kodepos
			// 
			this.kodepos.Location = new System.Drawing.Point(564, 110);
			this.kodepos.Name = "kodepos";
			this.kodepos.Size = new System.Drawing.Size(204, 20);
			this.kodepos.TabIndex = 28;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(473, 114);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(85, 16);
			this.label11.TabIndex = 29;
			this.label11.Text = "Kode Pos";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(473, 140);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(85, 16);
			this.label12.TabIndex = 30;
			this.label12.Text = "Telepon";
			// 
			// telepon
			// 
			this.telepon.Location = new System.Drawing.Point(564, 137);
			this.telepon.Name = "telepon";
			this.telepon.Size = new System.Drawing.Size(178, 20);
			this.telepon.TabIndex = 31;
			// 
			// hp
			// 
			this.hp.Location = new System.Drawing.Point(564, 165);
			this.hp.Name = "hp";
			this.hp.Size = new System.Drawing.Size(178, 20);
			this.hp.TabIndex = 32;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(473, 169);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(85, 16);
			this.label13.TabIndex = 33;
			this.label13.Text = "Handphone";
			// 
			// hobi
			// 
			this.hobi.Location = new System.Drawing.Point(564, 189);
			this.hobi.Name = "hobi";
			this.hobi.Size = new System.Drawing.Size(178, 20);
			this.hobi.TabIndex = 34;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(473, 189);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(85, 16);
			this.label14.TabIndex = 35;
			this.label14.Text = "Hobi";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(473, 217);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(85, 16);
			this.label15.TabIndex = 36;
			this.label15.Text = "Wali";
			// 
			// wali
			// 
			this.wali.Location = new System.Drawing.Point(564, 213);
			this.wali.Name = "wali";
			this.wali.Size = new System.Drawing.Size(178, 20);
			this.wali.TabIndex = 37;
			// 
			// alamatwali
			// 
			this.alamatwali.Location = new System.Drawing.Point(564, 245);
			this.alamatwali.Name = "alamatwali";
			this.alamatwali.Size = new System.Drawing.Size(178, 20);
			this.alamatwali.TabIndex = 38;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(473, 242);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(85, 16);
			this.label16.TabIndex = 39;
			this.label16.Text = "Alamat wali";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(473, 273);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(85, 16);
			this.label17.TabIndex = 40;
			this.label17.Text = "Telepon wali";
			// 
			// telwali
			// 
			this.telwali.Location = new System.Drawing.Point(564, 273);
			this.telwali.Name = "telwali";
			this.telwali.Size = new System.Drawing.Size(178, 20);
			this.telwali.TabIndex = 41;
			// 
			// tahunmasuk
			// 
			this.tahunmasuk.FormattingEnabled = true;
			this.tahunmasuk.Location = new System.Drawing.Point(564, 295);
			this.tahunmasuk.Name = "tahunmasuk";
			this.tahunmasuk.Size = new System.Drawing.Size(124, 21);
			this.tahunmasuk.TabIndex = 42;
			this.tahunmasuk.Text = "Pilih Tahun Masuk";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(473, 299);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(85, 16);
			this.label18.TabIndex = 43;
			this.label18.Text = "Tahun masuk";
			// 
			// textBox17
			// 
			this.textBox17.Location = new System.Drawing.Point(115, 347);
			this.textBox17.Name = "textBox17";
			this.textBox17.Size = new System.Drawing.Size(178, 20);
			this.textBox17.TabIndex = 44;
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(40, 350);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(56, 23);
			this.label19.TabIndex = 45;
			this.label19.Text = "Cari";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(34, 376);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(708, 147);
			this.dataGridView1.TabIndex = 46;
			// 
			// prodi
			// 
			this.prodi.FormattingEnabled = true;
			this.prodi.Location = new System.Drawing.Point(115, 136);
			this.prodi.Name = "prodi";
			this.prodi.Size = new System.Drawing.Size(124, 21);
			this.prodi.TabIndex = 47;
			this.prodi.Text = "Pilih Prodi";
			this.prodi.SelectedIndexChanged += new System.EventHandler(this.ProdiSelectedIndexChanged);
			// 
			// tampilprodi
			// 
			this.tampilprodi.Location = new System.Drawing.Point(245, 136);
			this.tampilprodi.Name = "tampilprodi";
			this.tampilprodi.ReadOnly = true;
			this.tampilprodi.Size = new System.Drawing.Size(178, 20);
			this.tampilprodi.TabIndex = 48;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(115, 215);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(147, 20);
			this.dateTimePicker1.TabIndex = 49;
			// 
			// FormOperationDMLJoin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 519);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.tampilprodi);
			this.Controls.Add(this.prodi);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.textBox17);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.tahunmasuk);
			this.Controls.Add(this.telwali);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.alamatwali);
			this.Controls.Add(this.wali);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.hobi);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.hp);
			this.Controls.Add(this.telepon);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.kodepos);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.tampilpropinsi);
			this.Controls.Add(this.propinsi);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.kota);
			this.Controls.Add(this.alamat);
			this.Controls.Add(this.tampiljkel);
			this.Controls.Add(this.jkel);
			this.Controls.Add(this.tempatlahir);
			this.Controls.Add(this.agama);
			this.Controls.Add(this.tampilagama);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.stb);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "FormOperationDMLJoin";
			this.Text = "FormOperationDMLJoin";
			this.Load += new System.EventHandler(this.FormOperationDMLJoinLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
