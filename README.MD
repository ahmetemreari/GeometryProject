
# Geometrik Alan Hesaplama Programı

Bu program, temel geometrik şekillerin alanlarını hesaplamak için C# dilinde yazılmıştır. Program, kare, dikdörtgen ve dik üçgen gibi şekillerin alanlarını hesaplamak için nesne yönelimli programlama (OOP) prensiplerini kullanmaktadır.

## Özellikler

- **Kare**: Kullanıcıdan alınan kenar uzunluğuna göre alanı hesaplar.
- **Dikdörtgen**: Kullanıcıdan alınan genişlik ve yükseklik değerlerine göre alanı hesaplar.
- **Dik Üçgen**: Kullanıcıdan alınan taban ve yükseklik değerlerine göre alanı hesaplar.

## Kullanım

### Gereksinimler

- .NET 6.0 veya üzeri
- C# 8.0 veya üzeri

### Çalıştırma Adımları

1. Projeyi klonlayın veya indirin.
2. Terminal veya komut istemcisinde proje dizinine gidin.
3. Aşağıdaki komutla projeyi çalıştırın:

   ```bash
   dotnet run
   ```

### Örnek Çıktı

```
Kare Alanı: 25
Dikdörtgen Alanı: 50
Dik Üçgen Alanı: 25
```

## Kod Yapısı

### `Program.cs`

- **Olculer Sınıfı**: Tüm şekillerin temel sınıfı.
- **Kare, Dikdortgen, DikUcgen Sınıfları**: Olculer sınıfından türeyen ve spesifik alan hesaplama yöntemlerini içeren sınıflar.

### Örnek Kod

```csharp
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

        Olculer dikUcgen = new DikUcgen();
        dikUcgen.Genislik = 5;
        dikUcgen.Yukseklik = 10;
        Console.WriteLine("Dik Üçgen Alanı: " + dikUcgen.AlanHesapla());
    }
}
```

## Katkıda Bulunma

Herhangi bir öneri veya hata bildirimi için lütfen bir [sorun](https://github.com/ahmetemreari/GeometryProject/issues) oluşturun.

## Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Daha fazla bilgi için lütfen [LICENSE](LICENSE) dosyasını kontrol edin.

