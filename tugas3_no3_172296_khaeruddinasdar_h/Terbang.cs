using System;

namespace tugas3_no3_172296_khaeruddinasdar_h
{
	/// <summary>
	/// Description of Terbang.
	/// </summary>
	public class Terbang:Kendaraan
	{
		
		public void pesawat(String color, String merk, int kecepatan)
		{
			Console.WriteLine("Pesawat dengan merk "+merk+" memiliki kecepatan "+kecepatan+" mp/s dan warna "+ color );
		}
		
		public void helikopter()
		{
			
			Console.WriteLine("Helikopter memiliki baling-baling");
		}
	}
}
