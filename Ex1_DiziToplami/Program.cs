using System;

namespace Ex1_DiziToplami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir dizi boyutu giriniz=");
            int [] sayiDizisi=new int[Convert.ToInt32(Console.ReadLine())];
            int Toplam=0;

            for (int i = 0; i <sayiDizisi.Length; i++)
            {
                Console.WriteLine(i+1 +". SAYIYI GİRİNİZ=");
                int [] sayi = new int[sayiDizisi.Length];
                sayi[i]=int.Parse(Console.ReadLine());
                Toplam+=sayi[i];
            

            }
           Console.WriteLine("Dizi Toplam= "+Toplam);
            
        }  
          
    }
}
