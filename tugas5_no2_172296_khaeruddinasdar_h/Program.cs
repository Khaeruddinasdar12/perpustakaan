﻿/*
 * Created by SharpDevelop.
 * User: Asdar
 * Date: 10/05/2019
 * Time: 5:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace tugas5_no2_172296_khaeruddinasdar_h
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormOperationDML());
		}
		
	}
}
