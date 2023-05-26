using System;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayı giriniz");
            int a = Int32.Parse(Console.ReadLine());
            //ekrandan girilen sayıya kadar olan tek sayıları yazdırma
           for (int i = 0; i < a; i++)
           {
            if (i%2==1)
            {
                Console.WriteLine(i);
            }
           }
          //1 ile 1000 arasındaki  tek ve çift sayıların toplamı
           int tektoplam = 0;
           int cifttoplam= 0;

           for (int i = 1; i <= 1000; i++)
           {
            if (i%2 ==1 )
            {
                tektoplam += i;
            }
            else
            {
                cifttoplam += i;
            }
           }
           Console.WriteLine(tektoplam);
           Console.WriteLine(cifttoplam);
           // break, contune
           for (int i = 1; i < 10; i++)
           {
            if (i==4)
                break;
                Console.WriteLine(i);
            
            if (i==4)
                continue;
                Console.WriteLine(i);
           }
        }

    }
}