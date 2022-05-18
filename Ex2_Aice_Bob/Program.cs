using System;

namespace Ex2_Aice_Bob
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Alice ve Bob, HackerRank için birer problem yarattı. Bir gözden geçiren, iki zorluğu değerlendirir ve üç kategori için 1'den 100'e kadar bir ölçekte puan verir : problemin netliği , orijinalliği ve zorluğu .

            Alice'in meydan okumasının derecesi a = (a[0], a[1], a[2]) üçlüsüdür ve Bob'un meydan okumasının derecesi b = (b[0], b[1], b üçlüsüdür. [2]) .

            Görev, a[0] ile b[0] , a[1] ile b[1] ve a[2] ile b[2 ] ile karşılaştırarak karşılaştırma noktalarını bulmaktır .

            a[i] > b[i] ise , Alice 1 puan alır.
            a[i] < b[i] ise , Bob'a 1 puan verilir.
            a[i] = b[i] ise , o zaman hiç kimse bir puan almaz.
            Karşılaştırma puanları, bir kişinin kazandığı toplam puandır.

            a ve b verildiğinde , ilgili karşılaştırma noktalarını belirleyin.

            Misal

            a = [1, 2, 3]
            b = [3, 2, 1]*/
            Console.WriteLine("Hello Baby! Alice ve Bob karşılaşmasına hazır mısın?");
            Console.WriteLine("Haydi Alice için 1 ile 100 arasında bir puan ver ");
            int [] a=new int[3];
            int [] b=new int[3];
            // problemin netliği
            //************Alice***************
            Console.Write("Problem Netliği=");
            int deger1=int.Parse(Console.ReadLine());
            while (deger1>100)
            {
                Console.WriteLine("Lütfen 0 dan büyük ve 100 den küçük bir değer giriniz!!!");
                Console.Write("Problem Netliği=");
                deger1=int.Parse(Console.ReadLine()); 
               
            }
               if (deger1<100)
               {
                   a[0]=deger1;
                   
               }
               deger1=0;
            Console.Write("Problem Zorluğu=");
            deger1=int.Parse(Console.ReadLine());
            while (deger1>100)
            {
                Console.WriteLine("Lütfen 0 dan büyük ve 100 den küçük bir değer giriniz!!!");
                Console.Write("Problem Zorluğu=");
                deger1=int.Parse(Console.ReadLine()); 
               
            }
               if (deger1<100)
               {
                   a[1]=deger1;
                   
               }
               deger1=0;
            
            Console.Write("Problem Orjinalliği=");
            deger1=int.Parse(Console.ReadLine());
            while (deger1>100)
            {
                Console.WriteLine("Lütfen 0 dan büyük ve 100 den küçük bir değer giriniz!!!");
                Console.Write("Problem Orjinalliği=");
                deger1=int.Parse(Console.ReadLine()); 
               
            }
               if (deger1<100)
               {
                   a[2]=deger1;
                   
               }
               deger1=0;
          

            Console.WriteLine("Alice değerleri =["+a[0]+","+a[1]+","+a[2]+"]");

            Console.WriteLine("Çok iyi!!! Bob için 1 ile 100 arasında bir puan ver bakalım bebek!!");
            // problemin netliği
            //************Bob***************
            Console.Write("Problem Netliği=");
            deger1=int.Parse(Console.ReadLine());
            while (deger1>100)
            {
                Console.WriteLine("Lütfen 0 dan büyük ve 100 den küçük bir değer giriniz!!!");
                Console.Write("Problem Netliği=");
                deger1=int.Parse(Console.ReadLine()); 
               
            }
               if (deger1<100)
               {
                   b[0]=deger1;
                   
               }
               deger1=0;
            Console.Write("Problem Zorluğu=");
            deger1=int.Parse(Console.ReadLine());
            while (deger1>100)
            {
                Console.WriteLine("Lütfen 0 dan büyük ve 100 den küçük bir değer giriniz!!!");
                Console.Write("Problem Zorluğu=");
                deger1=int.Parse(Console.ReadLine()); 
               
            }
               if (deger1<100)
               {
                   b[1]=deger1;
                   
               }
               deger1=0;
            
            Console.Write("Problem Orjinalliği=");
            deger1=int.Parse(Console.ReadLine());
            while (deger1>100)
            {
                Console.WriteLine("Lütfen 0 dan büyük ve 100 den küçük bir değer giriniz!!!");
                Console.Write("Problem Orjinalliği=");
                deger1=int.Parse(Console.ReadLine()); 
               
            }
               if (deger1<100)
               {
                   b[2]=deger1;
                   
               }
               deger1=0;

            Console.WriteLine("Bob Değerleri =["+b[0]+","+b[1]+","+b[2]+"]");

            int sayaca=0;
            int sayacb=0;
            for (int i = 0; i < 3; i++)
            {
                if(a[i]>b[i])
                {

                sayaca+=1;
                }
               else if(a[i]==b[i])
                {
                sayaca+=0;
                sayacb+=0;
                }
                else
                {
                sayacb+=1;
                }
              
            }

            Console.WriteLine("SKOR= ["+sayaca+","+sayacb+"]");
    
        }
    }
}
