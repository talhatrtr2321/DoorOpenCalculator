namespace fistproject1234
{
    internal class Program
    {
        static void Main()
        {
            //1.SAYIYI GİR
            Console.Write("Birinci sayıyı gir:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            //2.SAYIYI GİR
            Console.Write("ikinci sayıyı gir:");
            Double sayi2 = Convert.ToDouble(Console.ReadLine());

            //TOPLAMA 
            double sonuc = sayi1 + sayi2;
             


            //SONUCU YAZDIR
            Console.WriteLine("Sonuç:" + sonuc);

            Console.Write("Çıkarma");

            //1.SAYIYI GİR
            Console.Write("Birinci sayıyı gir:");
            double sayi3 = Convert.ToDouble(Console.ReadLine());

            //2.SAYIYI GİR
            Console.Write("İkinci sayıyı gir");
            double sayi4 = Convert.ToDouble(Console.ReadLine());

            //ÇIKARMA
            double sonuc2 = sayi3 - sayi4;

            //SONUCU YAZDIR
            Console.WriteLine("Sonuç:" + sonuc2);






            Console.ReadLine();
        }
    }
}
