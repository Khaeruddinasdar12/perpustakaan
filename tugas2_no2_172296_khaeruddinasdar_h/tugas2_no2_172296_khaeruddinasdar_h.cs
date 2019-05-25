/*
 * Created by SharpDevelop.
 * User: Asdar
 * Date: 28/03/2019
 * Time: 4:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace tugas2_no2_172296_khaeruddinasdar_h
{
	class tugas2_no2_172296_khaeruddinasdar_h
	{
		public static void Main(string[] args)
		{
			  String kodebarang,ulang,namabarang="";
			  int jumlah,hargabarang=0;
			  double bayar=0,diskon,totbayar=0;
			  char jenisbarang, akhir;
			
			  akhir = 'y';
			  for(int i=1; akhir!='n'; i++){
			Console.Clear();
            Console.WriteLine(" 	MENGINPUT DATA "+i);
            Console.WriteLine("=================================");
            Console.Write("Input Kode Barang        : "); kodebarang = Console.ReadLine();
            Console.Write("Input Jenis Barang       : "); jenisbarang = Convert.ToChar(Console.ReadLine());
            Console.Write("Input Jumlah Beli        : "); jumlah = Convert.ToInt16(Console.ReadLine());

            switch(jenisbarang){
            	case 'A' :
            		namabarang = "Baju Kemeja"; 
            		hargabarang = 50000;
            		break;
            	
            	case 'B' :
            		namabarang = "Celana Panjang";
            		hargabarang = 70000;
            		break;
            		
            	case 'C' :
            		namabarang = "Topi";
            		hargabarang = 80000;
            		break;
            		
            	case 'D' :
            		namabarang = "Sepatu";
            		hargabarang = 100000;
            		break;
            	default :
            		namabarang = "Jenis Barang Tidak Ditemukan";
            		hargabarang=0;	
            		break;
            }
            
           	bayar = hargabarang * jumlah;
           	
           	switch(jumlah){
           		case 1 : case 2 : case 3 : case 4 : case 5 :
	           		diskon=0;
	           		totbayar = bayar;
	           		break;
           		default :
	           		diskon = 0.1*bayar;
            		totbayar = bayar - diskon;
            		break;
           	}
           	
            Console.WriteLine();  
            Console.WriteLine("           OUTPUT            ");
            Console.WriteLine("=============================");
            Console.WriteLine("Kode Barang    	: "+kodebarang);
	 		Console.WriteLine("Nama Barang 	: "+namabarang);
            Console.WriteLine("Harga Barang   	: "+hargabarang);
            Console.WriteLine("Jumlah Beli    	: "+jumlah);
            Console.WriteLine("Jumlah Bayar   	: Rp. "+bayar);
            Console.WriteLine("Diskon        	: Rp. "+diskon);
            Console.WriteLine("Total Bayar    	: Rp. "+totbayar);
            Console.WriteLine();
            // Console.Write("Lagi ?   y/n     : "); akhir = Convert.ToChar(Console.ReadLine());
            //Console.ReadKey();
            Console.Write("Transaksi Lagi ?   y/n    	: "); akhir = Convert.ToChar(Console.ReadLine());
           
		  }
			 
		}
	}
}