/*
 * Created by SharpDevelop.
 * User: Asdar
 * Date: 11/04/2019
 * Time: 15:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tugas4_no1_172296_khaeruddinasdar_h
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nama;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox stb;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton perempuan;
		private System.Windows.Forms.RadioButton laki_laki;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label hasilnama;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label hasilstb;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label jkel;
		private System.Windows.Forms.TextBox email;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label hasilemail;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label hasilnohp;
		private System.Windows.Forms.TextBox nohp;
		
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
			this.nama = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.stb = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.perempuan = new System.Windows.Forms.RadioButton();
			this.laki_laki = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.hasilnama = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.hasilstb = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.jkel = new System.Windows.Forms.Label();
			this.email = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.hasilemail = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.hasilnohp = new System.Windows.Forms.Label();
			this.nohp = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(39, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Masukkan Nama";
			// 
			// nama
			// 
			this.nama.Location = new System.Drawing.Point(139, 53);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(173, 20);
			this.nama.TabIndex = 1;
			this.nama.TextChanged += new System.EventHandler(this.NamaTextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(39, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Masukkan STB";
			// 
			// stb
			// 
			this.stb.Location = new System.Drawing.Point(139, 88);
			this.stb.Name = "stb";
			this.stb.Size = new System.Drawing.Size(173, 20);
			this.stb.TabIndex = 3;
			this.stb.TextChanged += new System.EventHandler(this.StbTextChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(39, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Jenis Kelamin";
			// 
			// perempuan
			// 
			this.perempuan.Location = new System.Drawing.Point(215, 119);
			this.perempuan.Name = "perempuan";
			this.perempuan.Size = new System.Drawing.Size(104, 24);
			this.perempuan.TabIndex = 5;
			this.perempuan.TabStop = true;
			this.perempuan.Text = "Perempuan";
			this.perempuan.UseVisualStyleBackColor = true;
			this.perempuan.CheckedChanged += new System.EventHandler(this.PerempuanCheckedChanged);
			// 
			// laki_laki
			// 
			this.laki_laki.Location = new System.Drawing.Point(139, 119);
			this.laki_laki.Name = "laki_laki";
			this.laki_laki.Size = new System.Drawing.Size(70, 24);
			this.laki_laki.TabIndex = 6;
			this.laki_laki.TabStop = true;
			this.laki_laki.Text = "Laki-laki";
			this.laki_laki.UseVisualStyleBackColor = true;
			this.laki_laki.CheckedChanged += new System.EventHandler(this.Laki_lakiCheckedChanged);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(41, 11);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(270, 30);
			this.label6.TabIndex = 14;
			this.label6.Text = "BIODATA";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(41, 190);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 20);
			this.label7.TabIndex = 16;
			this.label7.Text = "No. Hp";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(25, 235);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(294, 189);
			this.textBox3.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(45, 238);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 22);
			this.label4.TabIndex = 19;
			this.label4.Text = "Nama";
			// 
			// hasilnama
			// 
			this.hasilnama.Location = new System.Drawing.Point(125, 238);
			this.hasilnama.Name = "hasilnama";
			this.hasilnama.Size = new System.Drawing.Size(170, 22);
			this.hasilnama.TabIndex = 20;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(45, 269);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 22);
			this.label8.TabIndex = 21;
			this.label8.Text = "STB";
			// 
			// hasilstb
			// 
			this.hasilstb.Location = new System.Drawing.Point(125, 269);
			this.hasilstb.Name = "hasilstb";
			this.hasilstb.Size = new System.Drawing.Size(170, 22);
			this.hasilstb.TabIndex = 22;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(45, 301);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(74, 22);
			this.label9.TabIndex = 23;
			this.label9.Text = "Jkel";
			// 
			// jkel
			// 
			this.jkel.Location = new System.Drawing.Point(125, 301);
			this.jkel.Name = "jkel";
			this.jkel.Size = new System.Drawing.Size(170, 22);
			this.jkel.TabIndex = 24;
			// 
			// email
			// 
			this.email.Location = new System.Drawing.Point(138, 152);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(173, 20);
			this.email.TabIndex = 25;
			this.email.TextChanged += new System.EventHandler(this.EmailTextChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(41, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 20);
			this.label5.TabIndex = 13;
			this.label5.Text = "Email";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(45, 334);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(74, 22);
			this.label10.TabIndex = 26;
			this.label10.Text = "Email";
			// 
			// hasilemail
			// 
			this.hasilemail.Location = new System.Drawing.Point(125, 334);
			this.hasilemail.Name = "hasilemail";
			this.hasilemail.Size = new System.Drawing.Size(170, 22);
			this.hasilemail.TabIndex = 27;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(45, 367);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(74, 22);
			this.label11.TabIndex = 28;
			this.label11.Text = "No. Hp";
			// 
			// hasilnohp
			// 
			this.hasilnohp.Location = new System.Drawing.Point(125, 367);
			this.hasilnohp.Name = "hasilnohp";
			this.hasilnohp.Size = new System.Drawing.Size(170, 22);
			this.hasilnohp.TabIndex = 29;
			this.hasilnohp.Click += new System.EventHandler(this.HasilnohpClick);
			// 
			// nohp
			// 
			this.nohp.Location = new System.Drawing.Point(138, 190);
			this.nohp.Name = "nohp";
			this.nohp.Size = new System.Drawing.Size(173, 20);
			this.nohp.TabIndex = 30;
			this.nohp.TextChanged += new System.EventHandler(this.NohpTextChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(375, 436);
			this.Controls.Add(this.nohp);
			this.Controls.Add(this.hasilnohp);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.hasilemail);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.email);
			this.Controls.Add(this.jkel);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.hasilstb);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.hasilnama);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.laki_laki);
			this.Controls.Add(this.perempuan);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.stb);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Penginputan";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
