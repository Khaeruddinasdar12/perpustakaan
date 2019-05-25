
using System;

namespace tugas2_no1_172296_khaeruddinadar_h
{
	class tugas2_no1_172296_khaeruddinasdar_h
	{
		public static void Main(string[] args)
		{
			double ntugas,nnmid,nfinal,nakhir;
			string stb,nama,alamat,jurusan;
			char nhuruf;
			int umur;
				
			Console.WriteLine("=======[ MENGINPUT BIODATA MAHASISWA DAN NILAI ]=======");
			Console.Write("STB	: ");stb = Console.ReadLine();
			Console.Write("Nama	: ");nama = Console.ReadLine();
			Console.Write("Alamat	: ");alamat = Console.ReadLine();
			Console.Write("Jurusan : ");jurusan = Console.ReadLine();
			Console.Write("Umur	: ");umur = Convert.ToInt16(Console.ReadLine());
			Console.Write("Nilai Tugas	: ");ntugas = Convert.ToDouble(Console.ReadLine());
			Console.Write("Nilai MID	: ");nnmid = Convert.ToDouble(Console.ReadLine());
			Console.Write("Nilai Final	: ");nfinal = Convert.ToDouble(Console.ReadLine());
			
			nakhir = 0.3 * ntugas + 0.3 * nnmid + 0.4 * nfinal;
			if(Convert.ToInt16(nakhir) >= 80){
				nhuruf='A';
			}else if(Convert.ToInt16(nakhir) >= 70){
				nhuruf='B';
			}else if(Convert.ToInt16(nakhir) >= 50){
				nhuruf='C';
			}else if(Convert.ToInt16(nakhir) >= 30){
				nhuruf='D';
			}else{
				nhuruf='E';
			}
			
			Console.WriteLine();
			Console.WriteLine("=======[ OUTPUT BIODATA MAHASISWA DAN NILAI AKHIR ]=======");
			Console.WriteLine("STB	: "+stb);
			Console.WriteLine("Nama	: "+nama);
			Console.WriteLine("Alamat	: "+alamat);
			Console.WriteLine("Jurusan : "+jurusan);
			Console.WriteLine("Umur	: "+umur);
			Console.WriteLine("Nilai Tugas : "+ntugas);
			Console.WriteLine("Nilai MID : "+nnmid);
			Console.WriteLine("Nilai Final : "+nfinal);
			Console.WriteLine("Nilai Akhir : "+nakhir);
			Console.Write("Nilai Huruf : "+nhuruf);
			Console.ReadKey(true);
		}
	}
}