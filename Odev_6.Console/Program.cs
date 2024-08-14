// See https://aka.ms/new-console-template for more information
using Odev_6.Models;

Console.WriteLine("Hello, World!");

Ogrenci ogr = new Ogrenci();

Console.WriteLine("Öğrencinin adı nedir?");
ogr.adi = Console.ReadLine();
Console.WriteLine("Öğrencinin soyadı nedir?");
ogr.soyadi = Console.ReadLine();
Console.WriteLine("Öğrencinin bölümü nedir?");
ogr.bolum = Console.ReadLine();

if (!ZorunlulukKontrolu<Ogrenci>.Dogrula(ogr))
{
    Console.WriteLine("Öğrenci bilgileri girilmesi zorunludur");
}
else
{
    Console.WriteLine("Öğrenci Formu Başarılı");
}

Araba araba = new Araba();
Console.WriteLine("Arabanın markası nedir?");
araba.marka = Console.ReadLine();
Console.WriteLine("Arabanın modeli nedir?");
araba.model = Console.ReadLine();

if (!ZorunlulukKontrolu<Araba>.Dogrula(araba))
{
    Console.WriteLine("Araba bilgileri girilmesi zorunludur");
}
else
{
    Console.WriteLine("Araba Formu Başarılı");
}