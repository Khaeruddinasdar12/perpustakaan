/*
 * Created by SharpDevelop.
 * User: Asdar
 * Date: 04/04/2019
 * Time: 21:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace tugas3_no3_172296_khaeruddinasdar_h
{
	/// <summary>
	/// Description of Kendaraan.
	/// </summary>
	public class Kendaraan
	{
		public String merk_kendaraan;
        public int kecepatan_kendaraan;
        public String warna_kendaraan;
        protected String bahan;
       
		public void merk()
		{
			Console.Write(merk_kendaraan);
		}
		
		public void warna(String color)
		{
			Console.Write(color);
		}
		
		public void kecepatan()
		{
			Console.Write(kecepatan_kendaraan + " mph");
		}
	}
}
