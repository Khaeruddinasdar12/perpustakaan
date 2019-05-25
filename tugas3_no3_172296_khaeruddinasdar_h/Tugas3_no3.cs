using System;

namespace tugas3_no3_172296_khaeruddinasdar_h
{
	class Tugas3_no3
	{
		public static void Main(string[] args)
		{
			String color, merk;
			int speed;
			Kendaraan property_kendaraan = new Kendaraan() ;
			color = property_kendaraan.warna_kendaraan = "Merah";
			speed = property_kendaraan.kecepatan_kendaraan = 4;
			merk  = property_kendaraan.merk_kendaraan = "toyota";
			Console.WriteLine(color+ speed+merk);
			
			Terbang property_pesawat = new Terbang();
			property_pesawat.pesawat("Merah","Garuda",100);
			
			Terbang property_helikopter = new Terbang();
			property_helikopter.helikopter();
//			property_helikopter.bahan = "Aluminium";
			property_helikopter.warna("Berwarna Kuning ");  //method superclass
			
			Console.ReadKey(true);
		}
	}
}