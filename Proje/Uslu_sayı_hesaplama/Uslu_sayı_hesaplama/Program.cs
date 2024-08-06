using System;

class Program
{
    static void Main()
    {
        // Burada double veri türümüz ile değişken adlarını belirliyoruz. 
        double a, b, c, d, sonuc, auzerib, cuzerid;

        // Birinci Sayımızın Verilerini Buradan alıyoruz.
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Birinci Sayının Tabanını ve Üstünü Giriniz.");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine();

        Console.Write("Birinci Sayının Tabanını Giriniz (A): ");
        a = Convert.ToDouble(Console.ReadLine()); // Kullanıcıdan Girilen a veri sayısının değerini alıyoruz.

        Console.Write("Birinci Sayının Üstünü Giriniz (B): ");
        b = Convert.ToDouble(Console.ReadLine()); // Kullanıcıdan Girilen b veri sayısının değerini alıyoruz.
        Console.WriteLine();

        // İkinci Sayımızın verilerini Buradan alıyoruz.
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("İkinci Sayının Tabanını ve Üstünü Giriniz.");
        Console.WriteLine("-------------------------------------------");

        Console.Write("İkinci Sayının Tabanını Giriniz (C): ");
        c = Convert.ToDouble(Console.ReadLine()); // Kullanıcıdan Girilen c veri sayısının değerini alıyoruz.
        Console.Write("İkinci Sayının Üstünü Giriniz (D): ");
        d = Convert.ToDouble(Console.ReadLine()); // Kullanıcıdan Girilen d veri sayısının değerini alıyoruz.

        Console.Clear(); // Sayılar Girildikten sonra ConsoleClear kodu ile Konsolu Siliyoruz.

        // Burada Üslü ifadelerimizi hesaplıyoruz.
        auzerib = Math.Pow(a, b); // a ve b üslü hesaplamayı gerçekleştiren formülümüz.
        cuzerid = Math.Pow(c, d); // c ve d üslü hesaplamayı gerçekleştiren formülümüz.

        // Burada (b * d) - (a * c) İşlemini Gerçekleştiriyoruz.
        sonuc = (b * d) - (a * c);

        // Burada Sonuçlarımızı ekrana yazdıyoruz.
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine($"Birinci Sayı: {a} üzeri {b} sonucu: {auzerib}"); // Kullanıcıdan Girilen Birinci Üslü sayının sonucunu ekrana yazdıyoruz.
        Console.WriteLine($"İkinci Sayı: {c} üzeri {d} sonucu: {cuzerid}"); // Kullanıcıdan Girilen İkinci Üslü sayının sonucunu ekrana yazdıyoruz.
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("(b * d) - (a * c) İşleminin Sonucu: " + sonuc);  // Kullanıcıdan Girilen Sayıların İstenilen İşlemini Gerçekleştiriyoruz.

    }
}
