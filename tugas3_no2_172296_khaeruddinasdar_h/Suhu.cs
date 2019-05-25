/*
 * Created by SharpDevelop.
 * User: Asdar
 * Date: 04/04/2019
 * Time: 20:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace tugas3_no2_172296_khaeruddinasdar_h
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Suhu
	{
		public double hasil;
		public double celcius;
		
		public double reamur(double celcius)
		{
			hasil = 0.8 * celcius;
			return hasil;
		}
		
		public double fahrenheit(double celcius)
		{
			hasil = celcius * 1.8 + 32;
			return hasil;
		}
		
		public double kelvin(double celcius)
		{
			hasil =celcius + 273.15;
			return hasil;
		}
		
		public void rafli()
		{
			Console.WriteLine("Konversi Suhu !");
			Console.WriteLine("1. Celcius ke Fahrenheit!");
			Console.WriteLine("2. Celcius ke Reamur!");
			Console.WriteLine("3. Celcius ke Kelvin!");
		}
	}
}
