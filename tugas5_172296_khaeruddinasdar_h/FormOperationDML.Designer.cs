/*
 * Created by SharpDevelop.
 * User: Asdar
 * Date: 05/05/2019
 * Time: 11:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tugas5_172296_khaeruddinasdar_h
{
	partial class FormOperationDML
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button simpan;
		private System.Windows.Forms.Button edit;
		private System.Windows.Forms.Button hapus;
		private System.Windows.Forms.Button cari;
		private System.Windows.Forms.Button refresh;
		private System.Windows.Forms.TextBox search;
		
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
			this.simpan = new System.Windows.Forms.Button();
			this.edit = new System.Windows.Forms.Button();
			this.hapus = new System.Windows.Forms.Button();
			this.cari = new System.Windows.Forms.Button();
			this.refresh = new System.Windows.Forms.Button();
			this.search = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(13, 64);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(704, 275);
			this.dataGridView1.TabIndex = 0;
			// 
			// simpan
			// 
			this.simpan.Location = new System.Drawing.Point(18, 355);
			this.simpan.Name = "simpan";
			this.simpan.Size = new System.Drawing.Size(102, 28);
			this.simpan.TabIndex = 1;
			this.simpan.Text = "Tambah Data+";
			this.simpan.UseVisualStyleBackColor = true;
			this.simpan.Click += new System.EventHandler(this.SimpanClick);
			// 
			// edit
			// 
			this.edit.Location = new System.Drawing.Point(126, 355);
			this.edit.Name = "edit";
			this.edit.Size = new System.Drawing.Size(102, 28);
			this.edit.TabIndex = 2;
			this.edit.Text = "Edit";
			this.edit.UseVisualStyleBackColor = true;
			this.edit.Click += new System.EventHandler(this.EditClick);
			// 
			// hapus
			// 
			this.hapus.Location = new System.Drawing.Point(234, 355);
			this.hapus.Name = "hapus";
			this.hapus.Size = new System.Drawing.Size(102, 28);
			this.hapus.TabIndex = 3;
			this.hapus.Text = "Hapus";
			this.hapus.UseVisualStyleBackColor = true;
			this.hapus.Click += new System.EventHandler(this.HapusClick);
			// 
			// cari
			// 
			this.cari.Location = new System.Drawing.Point(653, 30);
			this.cari.Name = "cari";
			this.cari.Size = new System.Drawing.Size(64, 28);
			this.cari.TabIndex = 4;
			this.cari.Text = "Cari nama";
			this.cari.UseVisualStyleBackColor = true;
			this.cari.Click += new System.EventHandler(this.CariClick);
			// 
			// refresh
			// 
			this.refresh.Location = new System.Drawing.Point(342, 355);
			this.refresh.Name = "refresh";
			this.refresh.Size = new System.Drawing.Size(102, 28);
			this.refresh.TabIndex = 5;
			this.refresh.Text = "Refresh";
			this.refresh.UseVisualStyleBackColor = true;
			this.refresh.Click += new System.EventHandler(this.RefreshClick);
			// 
			// search
			// 
			this.search.Location = new System.Drawing.Point(455, 30);
			this.search.Multiline = true;
			this.search.Name = "search";
			this.search.Size = new System.Drawing.Size(192, 27);
			this.search.TabIndex = 6;
			this.search.TextChanged += new System.EventHandler(this.SearchTextChanged);
			// 
			// FormOperationDML
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(760, 395);
			this.Controls.Add(this.search);
			this.Controls.Add(this.refresh);
			this.Controls.Add(this.cari);
			this.Controls.Add(this.hapus);
			this.Controls.Add(this.edit);
			this.Controls.Add(this.simpan);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FormOperationDML";
			this.Text = "FormOperationDML";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
