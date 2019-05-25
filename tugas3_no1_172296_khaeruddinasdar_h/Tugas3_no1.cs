using System;

namespace tugas3_no1_172296_khaeruddinasdar_h
{
	class Tugas3_no1
	{
		public static void Main(string[] args)
		{
			double ntugas,nmid,nfinal,nakhir;
			string stb,nama,alamat,jurusan;
			char nhuruf, ulang;
			int umur, i;
				
			i=1 ;
			do {
			Console.Clear();
			Console.WriteLine("=======[ Data "+ i +" ]=======");
			Console.WriteLine("=======[ MENGINPUT BIODATA MAHASISWA DAN NILAI ]=======");
			Console.Write("STB	: ");stb = Console.ReadLine();
			Console.Write("Nama	: ");nama = Console.ReadLine();
			Console.Write("Alamat	: ");alamat = Console.ReadLine();
			Console.Write("Jurusan : ");jurusan = Console.ReadLine();
			Console.Write("Umur	: ");umur = Convert.ToInt16(Console.ReadLine());
			Console.Write("Nilai Tugas	: ");ntugas = Convert.ToDouble(Console.ReadLine());
			Console.Write("Nilai MID	: ");nmid = Convert.ToDouble(Console.ReadLine());
			Console.Write("Nilai Final	: ");nfinal = Convert.ToDouble(Console.ReadLine());
			
			Hitung perhitungan = new Hitung();
			nakhir = perhitungan.nilai_akhir(ntugas, nmid, nfinal);
			
			Console.WriteLine("Nilai Akhir : "+ nakhir) ;
			
			Console.WriteLine();
			Console.WriteLine("=======[ OUTPUT BIODATA MAHASISWA DAN NILAI AKHIR ]=======");
			Console.WriteLine("STB	: "+stb);
			Console.WriteLine("Nama	: "+nama);
			Console.WriteLine("Alamat	: "+alamat);
			Console.WriteLine("Jurusan : "+jurusan);
			Console.WriteLine("Umur	: "+umur);
			Console.WriteLine("Nilai Tugas : "+ntugas);
			Console.WriteLine("Nilai MID : "+nmid);
			Console.WriteLine("Nilai Final : "+nfinal);
			Console.WriteLine("Nilai Akhir : "+nakhir);
			perhitungan.nilai_huruf(nakhir);
			 Console.Write("Input data mahasiswa lagi ?   y/n    	: "); ulang = Convert.ToChar(Console.ReadLine());
			 i++;
			}
			while(ulang == 'y' || ulang =='Y');
		}
	}
}
