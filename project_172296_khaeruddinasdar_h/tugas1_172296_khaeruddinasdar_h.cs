/*
 * Created by SharpDevelop.
 * User: Asdar
 * Date: 28/03/2019
 * Time: 4:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace project_172296_khaeruddinasdar_h
{
	class tugas1_172296_khaeruddinasdar_h
	{
		public static void Main(string[] args)
		{
			double n_tugas,n_mid,n_final,n_akhir;
			  String stb,nama,alamat;
			  int umur;

            Console.WriteLine("          MENGINPUT DATA PRIBADI - MAHASISWA        ");
            Console.WriteLine("======================================================");
            Console.Write("Stambuk        : "); stb = Console.ReadLine();
            Console.Write("Nama           : "); nama = Console.ReadLine();
            Console.Write("Alamat         : "); alamat = Console.ReadLine();
            Console.Write("Umur           : "); umur = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("           MENGINPUT	NILAI  MAHASISWA                   ");
            Console.WriteLine("======================================================");
            Console.Write("Nilai Tugas    : "); n_tugas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nilai MID      : "); n_mid = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nilai Final    : "); n_final = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("           OUTPUT BIODATA DAN NILAI AKHIR                 ");
            Console.WriteLine("======================================================");
            Console.WriteLine("Stambuk        : "+stb);
            Console.WriteLine("Nama  lengkap  : "+nama);
            Console.WriteLine("Alamat         : "+alamat);
            Console.WriteLine("Umur           : "+umur);
            Console.WriteLine("Nilai Tugas    : "+n_tugas);
            Console.WriteLine("Nilai MID      : "+n_mid);
            Console.WriteLine("Nilai Final    : "+n_final);
            n_akhir = 0.3 * n_tugas + 0.3 * n_mid + 0.4 * n_final;
            Console.WriteLine("Nilai Akhir anda adalah    " +n_akhir);
            Console.ReadKey();
		}
	}
}