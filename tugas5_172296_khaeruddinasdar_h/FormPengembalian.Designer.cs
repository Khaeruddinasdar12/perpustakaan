/*
 * Created by SharpDevelop.
 * User: Asdar
 * Date: 24/05/2019
 * Time: 13:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tugas5_172296_khaeruddinasdar_h
{
	partial class FormPengembalian
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox5;
		
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(292, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "FORM PENGEMBALIAN";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(172, 106);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(164, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(342, 106);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(229, 20);
			this.textBox1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(41, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nomor Anggota";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(41, 41);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 41);
			this.button1.TabIndex = 4;
			this.button1.Text = "Simpan";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(147, 41);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 41);
			this.button2.TabIndex = 5;
			this.button2.Text = "Hapus";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(253, 41);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 41);
			this.button3.TabIndex = 6;
			this.button3.Text = "Edit";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(359, 41);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(100, 41);
			this.button4.TabIndex = 7;
			this.button4.Text = "Keluar";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(172, 133);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(164, 21);
			this.comboBox2.TabIndex = 8;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(41, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 25);
			this.label3.TabIndex = 9;
			this.label3.Text = "Kode Buku";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(342, 134);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(229, 20);
			this.textBox2.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(41, 161);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 25);
			this.label4.TabIndex = 11;
			this.label4.Text = "Tanggal peminjaman";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Enabled = false;
			this.dateTimePicker1.Location = new System.Drawing.Point(172, 161);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(164, 20);
			this.dateTimePicker1.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(41, 242);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(110, 25);
			this.label5.TabIndex = 13;
			this.label5.Text = "Denda";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(172, 239);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(164, 20);
			this.textBox3.TabIndex = 14;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(172, 187);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(164, 20);
			this.dateTimePicker2.TabIndex = 15;
			this.dateTimePicker2.Value = new System.DateTime(2019, 5, 24, 16, 19, 6, 0);
			this.dateTimePicker2.ValueChanged += new System.EventHandler(this.DateTimePicker2ValueChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(41, 187);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(122, 25);
			this.label6.TabIndex = 16;
			this.label6.Text = "Tanggal pengembalian";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(172, 213);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(64, 20);
			this.textBox4.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(41, 216);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(110, 25);
			this.label7.TabIndex = 18;
			this.label7.Text = "Keterlambatan";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(242, 216);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(94, 20);
			this.label8.TabIndex = 19;
			this.label8.Text = "Hari";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(41, 347);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(552, 146);
			this.dataGridView1.TabIndex = 20;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(41, 319);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(55, 25);
			this.label9.TabIndex = 21;
			this.label9.Text = "Cari";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(102, 316);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(209, 20);
			this.textBox5.TabIndex = 22;
			this.textBox5.TextChanged += new System.EventHandler(this.TextBox5TextChanged);
			// 
			// FormPengembalian
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(722, 505);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.Name = "FormPengembalian";
			this.Text = "FormPengembalian";
			this.Load += new System.EventHandler(this.FormPengembalianLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
