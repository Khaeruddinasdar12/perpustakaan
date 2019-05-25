/*
 * Created by SharpDevelop.
 * User: Asdar
 * Date: 22/04/2019
 * Time: 21:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace latihan
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox nama;
		private System.Windows.Forms.ListView tampil;
		private System.Windows.Forms.Button proses;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.RadioButton P;
		private System.Windows.Forms.RadioButton L;
		
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
			this.nama = new System.Windows.Forms.TextBox();
			this.tampil = new System.Windows.Forms.ListView();
			this.proses = new System.Windows.Forms.Button();
			this.clear = new System.Windows.Forms.Button();
			this.P = new System.Windows.Forms.RadioButton();
			this.L = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(208, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(193, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Biodata";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(60, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Masukkan Nama";
			// 
			// nama
			// 
			this.nama.Location = new System.Drawing.Point(199, 60);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(244, 20);
			this.nama.TabIndex = 2;
			// 
			// tampil
			// 
			this.tampil.Location = new System.Drawing.Point(60, 197);
			this.tampil.Name = "tampil";
			this.tampil.Size = new System.Drawing.Size(383, 122);
			this.tampil.TabIndex = 6;
			this.tampil.UseCompatibleStateImageBehavior = false;
			this.tampil.View = System.Windows.Forms.View.List;
			// 
			// proses
			// 
			this.proses.Location = new System.Drawing.Point(199, 153);
			this.proses.Name = "proses";
			this.proses.Size = new System.Drawing.Size(70, 38);
			this.proses.TabIndex = 4;
			this.proses.Text = "Proses";
			this.proses.UseVisualStyleBackColor = true;
			this.proses.Click += new System.EventHandler(this.ProsesClick);
			// 
			// clear
			// 
			this.clear.Location = new System.Drawing.Point(275, 153);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(70, 38);
			this.clear.TabIndex = 5;
			this.clear.Text = "Clear";
			this.clear.UseVisualStyleBackColor = true;
			this.clear.Click += new System.EventHandler(this.ClearClick);
			// 
			// P
			// 
			this.P.Location = new System.Drawing.Point(199, 86);
			this.P.Name = "P";
			this.P.Size = new System.Drawing.Size(107, 18);
			this.P.TabIndex = 7;
			this.P.TabStop = true;
			this.P.Text = "Perempuan";
			this.P.UseVisualStyleBackColor = true;
			// 
			// L
			// 
			this.L.Location = new System.Drawing.Point(199, 110);
			this.L.Name = "L";
			this.L.Size = new System.Drawing.Size(107, 18);
			this.L.TabIndex = 8;
			this.L.TabStop = true;
			this.L.Text = "Laki-laki";
			this.L.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(630, 315);
			this.Controls.Add(this.L);
			this.Controls.Add(this.P);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.proses);
			this.Controls.Add(this.tampil);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "latihan";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
