using System;

namespace tugas3_no2_172296_khaeruddinasdar_h
{
	class Tugas3_no2
	{
		public static void Main(string[] args)
		{
			char pilih;
			double celcius, hasil;
		start:
			Console.Clear();
			Suhu a = new Suhu();
			a.rafli();
			
			Console.Write("Pilih konversi : "); pilih = Convert.ToChar(Console.ReadLine());
			
			switch(pilih){
				case '1' : 
					Console.Write("Masukkan jumlah Celcius : "); celcius = Convert.ToDouble(Console.ReadLine());
					Suhu konversiC_R = new Suhu();
					hasil = konversiC_R.reamur(celcius);
					Console.WriteLine("Celcius "+celcius+" ke Reamur : "+hasil+" derajat Reamur");
					Console.ReadKey(true);
					break;
				
				case '2' : 
					Console.Write("Masukkan jumlah Celcius : "); celcius = Convert.ToDouble(Console.ReadLine());
					Suhu konversiC_F = new Suhu();
					hasil = konversiC_F.fahrenheit(celcius);
					Console.WriteLine("Celcius "+celcius+" ke Fahrenheit : "+hasil+" derajat Fahrenheit");
					Console.ReadKey(true);
					break;
					
				case '3' : 
					Console.Write("Masukkan jumlah Celcius : "); celcius = Convert.ToDouble(Console.ReadLine());
					Suhu konversiC_K = new Suhu();
					hasil = konversiC_K.kelvin(celcius);
					Console.WriteLine("Celcius "+celcius+" ke Kelvin : "+hasil+" derajat Kelvin");
					Console.ReadKey(true);
					break;
					
				default:
					goto start;
					
			}
			
			Console.Write("Press any key to continue . . . ");
			
		}
	}
}