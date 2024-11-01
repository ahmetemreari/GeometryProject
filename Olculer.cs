//ölçüler ile alan hesapla
using System;
public class Olculer
{
    public double Genislik { get; set; }
    public double Yukseklik { get; set; }
    public double AlanHesapla()
    {
        return Genislik * Yukseklik;
    }
}