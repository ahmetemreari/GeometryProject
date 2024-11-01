using System;

class Program
{
    static void Main()
    {
        Olculer kare = new Kare();
        kare.Genislik = 5;
        kare.Yukseklik = 5;
        Console.WriteLine("Kare Alanı: " + kare.AlanHesapla());
        
        Olculer dikdortgen = new Dikdortgen();
        dikdortgen.Genislik = 5;
        dikdortgen.Yukseklik = 10;
        Console.WriteLine("Dikdörtgen Alanı: " + dikdortgen.AlanHesapla());
        Olculer dikUcgen = new DikUcgec();
        Olculer dikUcgec = new DikUcgec();
        dikUcgen.Genislik = 5;
        dikUcgen.Yukseklik = 10;
        Console.WriteLine("Dik Üçgen Alanı: " + dikUcgen.AlanHesapla());
    }
        
}