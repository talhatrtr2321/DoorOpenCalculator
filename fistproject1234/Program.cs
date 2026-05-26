namespace fistproject1234
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("NOT:Bu program düzgün çalışmayabilir!!!");

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

            Console.ReadLine();
        }
    }
}
