using System.ComponentModel.Design;

namespace DoorOpenCalculator
{
    internal class Program
    {
        static void Main()
        {


            //TOPLAMA


            //1.SAYIYI GİR
            Console.Write("Birinci sayıyı gir:");
            double sayi1 = Convert.ToInt32(Console.ReadLine());

            //2.SAYIYI GİR
            Console.Write("ikinci sayıyı gir:");
            Double sayi2 = Convert.ToInt32(Console.ReadLine());

            //TOPLAMA 
            double sonuc = sayi1 + sayi2;

            //SONUCU YAZDIR
            Console.WriteLine("Sonuç:" + sonuc);


            //ÇIKARTMA


            //1.SAYIYI GİR
            Console.Write("Birinci sayıyı gir:");
            double sayi3 = Convert.ToInt32(Console.ReadLine());

            //2.SAYIYI GİR
            Console.Write("ikinci sayıyı gir:");
            double sayi4 = Convert.ToInt32(Console.ReadLine());

            //ÇIKARMA
            double sonuc2 = sayi3 - sayi4;

            //SONUCU YAZDIR
            Console.WriteLine("sonuç:" + sonuc2);

            Console.ReadLine();
        }
    }
}
