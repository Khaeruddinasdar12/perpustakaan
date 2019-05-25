using System;

namespace tugas3_no1_172296_khaeruddinasdar_h
{
	public class Hitung{
		Char nhuruf;
		String keterangan;
		
		public double nilai_akhir(double ntugas, double nmid, double nfinal) 
		{
			return 0.3 * ntugas + 0.3 * nmid + 0.4 * nfinal;
		}
		
		public void nilai_huruf(double nakhir)
		{
			if(Convert.ToDouble(nakhir) >= 80){
				nhuruf='A';
				Console.WriteLine("Nilai Huruf : "+nhuruf);
				Console.WriteLine("Keterangan : Sangat baik");
			}else if(Convert.ToDouble(nakhir) >= 70){
				nhuruf='B';
				Console.WriteLine("Nilai Huruf : "+nhuruf);
				Console.WriteLine("Keterangan : Baik");
			}else if(Convert.ToDouble(nakhir) >= 50){
				nhuruf='C';
				Console.WriteLine("Nilai Huruf : "+nhuruf);
				Console.WriteLine("Keterangan : Cukup");
			}else if(Convert.ToDouble(nakhir) >= 30){
				nhuruf='D';
				Console.WriteLine("Nilai Huruf : "+nhuruf);
				Console.WriteLine("Keterangan : Buruk");
			}else{
				nhuruf='E';
				Console.WriteLine("Nilai Huruf : "+nhuruf);
				Console.WriteLine("Keterangan : Error");
			}
				
		}
		
	}
}
