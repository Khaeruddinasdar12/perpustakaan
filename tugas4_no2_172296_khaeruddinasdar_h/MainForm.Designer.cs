/*
 * Created by SharpDevelop.
 * User: Asdar
 * Date: 11/04/2019
 * Time: 15:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tugas4_no2_172296_khaeruddinasdar_h
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.TextBox hasil;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button;
		private System.Windows.Forms.Button buttonequal;
		private System.Windows.Forms.Button buttonbagi;
		private System.Windows.Forms.Button operate;
		private System.Windows.Forms.Button buttonkurang;
		private System.Windows.Forms.Button buttonclear;
		private System.Windows.Forms.Button buttonkali;
		private System.Windows.Forms.Button buttontitik;
		private System.Windows.Forms.Label label1;
		
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
			this.button7 = new System.Windows.Forms.Button();
			this.hasil = new System.Windows.Forms.TextBox();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button = new System.Windows.Forms.Button();
			this.buttonequal = new System.Windows.Forms.Button();
			this.buttonbagi = new System.Windows.Forms.Button();
			this.operate = new System.Windows.Forms.Button();
			this.buttonkurang = new System.Windows.Forms.Button();
			this.buttonclear = new System.Windows.Forms.Button();
			this.buttonkali = new System.Windows.Forms.Button();
			this.buttontitik = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(46, 146);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(64, 45);
			this.button7.TabIndex = 0;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.ButtonClick);
			// 
			// hasil
			// 
			this.hasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hasil.Location = new System.Drawing.Point(45, 25);
			this.hasil.Multiline = true;
			this.hasil.Name = "hasil";
			this.hasil.Size = new System.Drawing.Size(277, 49);
			this.hasil.TabIndex = 1;
			this.hasil.Text = "0";
			this.hasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(116, 146);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(65, 45);
			this.button8.TabIndex = 2;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(187, 146);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(65, 45);
			this.button9.TabIndex = 3;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(46, 197);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(65, 45);
			this.button4.TabIndex = 4;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(116, 197);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(65, 45);
			this.button5.TabIndex = 5;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(187, 197);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(65, 45);
			this.button6.TabIndex = 6;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(46, 248);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(65, 45);
			this.button1.TabIndex = 7;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(116, 248);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(65, 45);
			this.button2.TabIndex = 8;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(187, 248);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(65, 45);
			this.button3.TabIndex = 9;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button
			// 
			this.button.Location = new System.Drawing.Point(46, 299);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(65, 45);
			this.button.TabIndex = 10;
			this.button.Text = "0";
			this.button.UseVisualStyleBackColor = true;
			this.button.Click += new System.EventHandler(this.ButtonClick);
			// 
			// buttonequal
			// 
			this.buttonequal.Location = new System.Drawing.Point(187, 299);
			this.buttonequal.Name = "buttonequal";
			this.buttonequal.Size = new System.Drawing.Size(136, 44);
			this.buttonequal.TabIndex = 11;
			this.buttonequal.Text = "=";
			this.buttonequal.UseVisualStyleBackColor = true;
			this.buttonequal.Click += new System.EventHandler(this.ButtonequalClick);
			// 
			// buttonbagi
			// 
			this.buttonbagi.Location = new System.Drawing.Point(258, 96);
			this.buttonbagi.Name = "buttonbagi";
			this.buttonbagi.Size = new System.Drawing.Size(65, 45);
			this.buttonbagi.TabIndex = 12;
			this.buttonbagi.Text = "/";
			this.buttonbagi.UseVisualStyleBackColor = true;
			this.buttonbagi.Click += new System.EventHandler(this.OperateClick);
			// 
			// operate
			// 
			this.operate.Location = new System.Drawing.Point(257, 248);
			this.operate.Name = "operate";
			this.operate.Size = new System.Drawing.Size(65, 45);
			this.operate.TabIndex = 13;
			this.operate.Text = "+";
			this.operate.UseVisualStyleBackColor = true;
			this.operate.Click += new System.EventHandler(this.OperateClick);
			// 
			// buttonkurang
			// 
			this.buttonkurang.Location = new System.Drawing.Point(257, 197);
			this.buttonkurang.Name = "buttonkurang";
			this.buttonkurang.Size = new System.Drawing.Size(65, 45);
			this.buttonkurang.TabIndex = 14;
			this.buttonkurang.Text = "-";
			this.buttonkurang.UseVisualStyleBackColor = true;
			this.buttonkurang.Click += new System.EventHandler(this.OperateClick);
			// 
			// buttonclear
			// 
			this.buttonclear.Location = new System.Drawing.Point(46, 96);
			this.buttonclear.Name = "buttonclear";
			this.buttonclear.Size = new System.Drawing.Size(206, 44);
			this.buttonclear.TabIndex = 15;
			this.buttonclear.Text = "C";
			this.buttonclear.UseVisualStyleBackColor = true;
			this.buttonclear.Click += new System.EventHandler(this.ButtonclearClick);
			// 
			// buttonkali
			// 
			this.buttonkali.Location = new System.Drawing.Point(257, 147);
			this.buttonkali.Name = "buttonkali";
			this.buttonkali.Size = new System.Drawing.Size(65, 45);
			this.buttonkali.TabIndex = 16;
			this.buttonkali.Text = "x";
			this.buttonkali.UseVisualStyleBackColor = true;
			this.buttonkali.Click += new System.EventHandler(this.OperateClick);
			// 
			// buttontitik
			// 
			this.buttontitik.Location = new System.Drawing.Point(117, 298);
			this.buttontitik.Name = "buttontitik";
			this.buttontitik.Size = new System.Drawing.Size(65, 45);
			this.buttontitik.TabIndex = 17;
			this.buttontitik.Text = ",";
			this.buttontitik.UseVisualStyleBackColor = true;
			this.buttontitik.Click += new System.EventHandler(this.ButtonClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(46, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 23);
			this.label1.TabIndex = 18;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(357, 371);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttontitik);
			this.Controls.Add(this.buttonkali);
			this.Controls.Add(this.buttonclear);
			this.Controls.Add(this.buttonkurang);
			this.Controls.Add(this.operate);
			this.Controls.Add(this.buttonbagi);
			this.Controls.Add(this.buttonequal);
			this.Controls.Add(this.button);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.hasil);
			this.Controls.Add(this.button7);
			this.Name = "MainForm";
			this.Text = "Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
