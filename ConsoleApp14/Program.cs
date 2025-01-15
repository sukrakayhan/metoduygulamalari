

////Geriye Değer Döndürmeyen Bir void metot.Ekrana sevdiğiniz bir şarkı sözünü yazdırsın. 
    
using System;
using System.Reflection.Metadata;
using System.Security.Cryptography;

class Program

{
    static void Main()

    {
        Greeting();

        static void Greeting()
        {
            Console.WriteLine("Zor zamanlar olur nasıl çıkarsan içinden omurgan öyle şekillenir.");

        }
    }
}

////////////////////////////////////////////////////////////////////////////// Geriye Tamsayı Döndüren Bir metot Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.
using System;
class Program
{
    static void Main(string[] args)
    {
        int kalan = RastgeleSayiKalan();
        Console.WriteLine("rastgele sayının ikiye bölümünden kalan:" + kalan);
    }
    static int RastgeleSayiKalan()
    {
        Random rastgele = new Random();
        int sayi = rastgele.Next(1, 101);
        Console.WriteLine("üretilen sayı:" + sayi);
        return sayi % 2;

    }
}

//////////////////////////////////////////////////////////////////////////// Parametre Alan ve Geriye Değer Döndüren Bir Metot Parametre olarak aldığı iki sayının çarpımını geriye dönsün.

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("birinci sayıyı girin");
        int sayi1 = int.Parse(Console.ReadLine());
        Console.WriteLine("ikinci sayıyı girin");
        int sayi2 = int.Parse(Console.ReadLine());

        int carpim = CarpimHesapla(sayi1, sayi2);
        Console.WriteLine($"girilen sayıların carpımı: {carpim}");
    }
    static int CarpimHesapla(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;

    }
}

//////////////////////////////////////////////////////////////////////////////////// Parametre Alan ve Geriye Değer Döndürmeyen bir Metot Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.
///

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("isminizi giriniz");
        string isim = Console.ReadLine();
        Console.WriteLine("soyisim giriniz");
        string soyisim = Console.ReadLine();
        İsimSoyisimYazdir(isim, soyisim);
    }
    static  void İsimSoyisimYazdir(string isim,string soyisim)
    {
        Console.WriteLine ($"Merhaba {isim} {soyisim}");
    
    }
    }