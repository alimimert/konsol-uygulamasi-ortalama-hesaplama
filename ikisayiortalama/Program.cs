using System;

class Program
{
    static void Main()
    {
        do
        {
            Console.WriteLine("İki sayı giriniz:");

            // Kullanıcıdan ilk sayıyı girmesini iste
            Console.Write("Birinci sayı: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            // Kullanıcıdan ikinci sayıyı girmesini iste
            Console.Write("İkinci sayı: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            // İki sayının ortalamasını hesapla
            double ortalama = (sayi1 + sayi2) / 2;

            // Ortalamayı ekrana yazdır
            Console.WriteLine("Girilen sayıların ortalaması: " + ortalama);

            Console.WriteLine("Başka bir işlem yapmak ister misiniz? (Evet/Hayır): ");
        } while (Console.ReadLine().Equals("Evet", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("Program sonlandı. İyi günler!");
    }
}
